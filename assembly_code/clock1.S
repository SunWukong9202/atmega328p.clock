#include<avr/io.h>
#include "m328p_io.inc";redefine the lowest 63 io address
#include "macros.mac"

.equ TEMP, 0x10
.equ HOURS, 0x11
.equ MINUTES, 0x12
.equ SECONDS, 0x13
.equ MILISEC, 0x14
.equ SC_BUFFER, 0x100 ; ram address after io extended memory
.equ SEND, 0x15;
.equ SREG_CLOCK, 0x16;
.equ SREG_SW_STOP_PLAY,0
.equ SREG_SW_RESET,1
.equ SREG_SC_STOP_PLAY,2
.equ SREG_SC_RESET,3
.equ CLOCKS_1S, 62500;for a preescaler 256
.equ ClOCK_100ms, 6250;
.equ sc_edit, 0; 000_0001
.equ sc_reset, 1;000_0010
.equ sc_play, 2; 000_0100
.equ sc_pause, 3;000_1000
.equ sw_reset, 4;001_0000 
.equ sw_play, 5; 010_0000
.equ sw_pause, 6;100_0000
.equ tx_signal, 0xff
.global main
main:
INIT_STACK
LOAD_IO DDRB, 0x01;
;active tx and rx, so as its interrupts
LOAD_ARAM UCSR0B, (1 << TXEN0) | (1 << RXEN0) | (1 << RXCIE0)
;async mode, 9600 bauds, 8 bits, 1 stop bit, without parity
LOAD_ARAM UCSR0C, (1 << USBS0) | (1 << UCSZ01) | (1 << UCSZ00)
LOAD_ARAM UBRR0L, 103; 76.8k ;51;19.2k baud rate ;103; 9600
;;TIMER1 configutation
LOAD_ARAM TCCR1A, 0x00;
LOAD_ARAM TCCR1B, (1 << CS12) | (1 << WGM12); preescaler 256 ;CTC mode enable
LOAD_ARAM TIMSK1, (1 << OCIE1A); enable compare match int
LOAD_ARAM OCR1AH, hi8(ClOCK_100ms);0x02;load first to high to save in its temp reg
LOAD_ARAM OCR1AL, lo8(ClOCK_100ms);lo8;0x71;(CLOCKS_1S - 1);load to low to send temp to high
;load buffer - to use reg indirect addressing
LDI ZL, lo8(SC_BUFFER);
LDI ZH, hi8(SC_BUFFER);
;load reference to show the actual time
RCALL receive;milisec
ST Z, TEMP;
RCALL receive;seconds
STD Z+1, TEMP
RCALL receive;minutes
STD Z+2, TEMP
RCALL receive;hours
STD Z+3, TEMP 
RCALL reset_buffer;
EOR SREG_CLOCK, SREG_CLOCK;
SEI; enable global interrupts
start:
RJMP start;

;assembly encode timestamp
encode_timestamp:
  LD MILISEC, Z;
  LDD SECONDS, Z+1  
  LDD MINUTES, Z+2  
  LDD HOURS, Z+3  
  INC MILISEC
  CPI MILISEC, 10
  BRNE skip_milisec
  LDI MILISEC, 0
  INC SECONDS
  skip_milisec:
  CPI SECONDS, 60
  BRNE skip_minutes
  LDI SECONDS, 0;
  INC MINUTES
  skip_minutes:
  CPI MINUTES, 60
  BRNE skip_hours
  LDI MINUTES, 0;
  INC HOURS
  skip_hours:
  CPI HOURS, 24
  BRNE skip_reset
  RCALL reset_timestamp
  skip_reset:
  ;store to keep state
  ST Z, MILISEC
  STD Z+1, SECONDS
  STD Z+2, MINUTES
  STD Z+3, HOURS
  ;load next values for sw_timestamp
  LDD MILISEC, Z+4
  LDD SECONDS, Z+5
  LDD MINUTES, Z+6
  SBRS SREG_CLOCK, SREG_SW_STOP_PLAY;skip if set(play = set, stop = clear)
  RJMP skip_sw_timestamp; if stop jmp 
  INC MILISEC
  CPI MILISEC, 10
  BRNE skip_sw_milisec
  LDI MILISEC, 0
  INC SECONDS
  skip_sw_milisec:
  CPI SECONDS, 60
  BRNE skip_sw_seconds
  LDI SECONDS, 0
  INC MINUTES
  skip_sw_seconds:
  CPI MINUTES, 60
  BRNE skip_sw_timestamp
  resetSW: RCALL reset_timestamp;
  CBR SREG_CLOCK, (1 << SREG_SW_RESET);to execute only one time
  skip_sw_timestamp:
  SBRC SREG_CLOCK, SREG_SW_RESET; if clear skip to continue
  RJMP resetSW; else goback to reset
  ;store sw clock timestamp
  STD Z+4, MILISEC
  STD Z+5, SECONDS
  STD Z+6, MINUTES
  ;load next values
  LDD MILISEC, Z+7
  LDD SECONDS, Z+8
  LDD MINUTES, Z+9
  LDD HOURS, Z+10
  SBRC SREG_CLOCK, SREG_SC_RESET;skip if clear(reset=set, !reset=clear)
  RCALL reset_timer_sc
  ;sand clock or timer clock
  SBRS SREG_CLOCK, SREG_SC_STOP_PLAY
  RJMP skip_sc_timestamp
  CPI MILISEC, 0
  BRNE dec_mili
  ;code for mili == 0
  CPI SECONDS, 0
  BRNE dec_sec
  ;code for sec == 0
  CPI MINUTES, 0
  BRNE dec_min
  ;code for min == 0
  CPI HOURS, 0
  BRNE dec_hour
  ;code for all of them == 0
  RJMP skip_sc_timestamp
  dec_hour:
  LDI MINUTES, 60
  DEC HOURS
  dec_min:
  LDI SECONDS, 60
  DEC MINUTES
  dec_sec:
  LDI MILISEC, 10
  DEC SECONDS
  dec_mili:
  DEC MILISEC
  skip_sc_timestamp:
  ;store timer/sc timestamp
  STD Z+7, MILISEC
  STD Z+8, SECONDS
  STD Z+9, MINUTES
  STD Z+10, HOURS
RET

reset_timer_sc:
  LDD MILISEC, Z+11 ;load from buffer
  LDD SECONDS, Z+12
  LDD MINUTES, Z+13
  LDD HOURS, Z+14
  CBR SREG_CLOCK, (1 << SREG_SC_RESET); disable sc reset
RET

set_sc:
  STD Z+11, MILISEC ;load from buffer
  STD Z+12, SECONDS 
  STD Z+13, MINUTES 
  STD Z+14, HOURS 
RET

reset_timestamp:
  LDI HOURS, 0
  LDI MINUTES, 0
  LDI SECONDS, 0
  LDI MILISEC, 0
RET

reset_buffer:
  LDI TEMP, 0
  ; ST Z, TEMP
  ; STD Z+1, TEMP
  ; STD Z+2, TEMP
  ; STD Z+3, TEMP
  STD Z+4, TEMP
  STD Z+5, TEMP
  STD Z+6, TEMP
  STD Z+7, TEMP
  STD Z+8, TEMP
  STD Z+10, TEMP
  STD Z+11, TEMP
  STD Z+12, TEMP
  STD Z+14, TEMP 
  LDI TEMP, 1
  STD Z+9, TEMP
  STD Z+13, TEMP 
RET

.global TIMER1_COMPA_vect
TIMER1_COMPA_vect:
  RCALL encode_timestamp;
  LDI SEND, tx_signal
  RCALL transmit
  LD SEND, Z
  RCALL transmit
  LDD SEND, Z+1
  RCALL transmit
  LDD SEND, Z+2
  RCALL transmit
  LDD SEND, Z+3
  RCALL transmit
  ;send sw timestamp
  LDD SEND, Z+4
  RCALL transmit
  LDD SEND, Z+5
  RCALL transmit
  LDD SEND, Z+6
  RCALL transmit
  ;send sc timestamp
  LDD SEND, Z+7
  RCALL transmit
  LDD SEND, Z+8
  RCALL transmit
  LDD SEND, Z+9
  RCALL transmit
  LDD SEND, Z+10
  RCALL transmit
RETI

transmit:
  LDS TEMP, UCSR0A;
  SBRS TEMP, UDRE0;0xc6	
  RJMP transmit;
  STS UDR0, SEND;
RET

receive:
  LDS TEMP, UCSR0A
  SBRS TEMP, RXC0
  RJMP receive 
  LDS TEMP, UDR0
RET

.global USART_RX_vect 
USART_RX_vect:
  LDS TEMP, UDR0;
  SBRC TEMP, sc_reset
  ;code for reset timer/sc
  SBR SREG_CLOCK, (1 << SREG_SC_RESET);

  SBRC TEMP, sc_play;
  ;code for play timer
  SBR SREG_CLOCK, (1 << SREG_SC_STOP_PLAY);

  SBRC TEMP, sc_pause;if clear skip
  ;code for stop sc/timer
  CBR SREG_CLOCK, (1 << SREG_SC_STOP_PLAY);

  SBRC TEMP, sw_reset
  ;code for reset sw
  SBR SREG_CLOCK, (1 << SREG_SW_RESET);

  SBRC TEMP, sw_play
  ;code for active play sw
  SBR SREG_CLOCK, (1 << SREG_SW_STOP_PLAY);

  SBRC TEMP, sw_pause
  ;code for stop sw (stop watch)
  CBR SREG_CLOCK, (1 << SREG_SW_STOP_PLAY);

  SBRS TEMP, sc_edit;
  RJMP return_from_rx
  ;code for edit
  RCALL receive
  MOV HOURS, TEMP
  RCALL receive
  MOV MINUTES, TEMP
  RCALL receive
  MOV SECONDS, TEMP
  LDI MILISEC, 0;
  RCALL set_sc; refresh buffer
  return_from_rx:
RETI
