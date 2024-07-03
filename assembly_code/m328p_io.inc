#pragma GCC diagnostic push
#pragma GCC diagnostic ignored "-Wmacro-redefined"

#ifndef m328p_io_h
#define m328p_io_h

#define	_SFR_IO8(io_addr) io_addr

#define	SREG  _SFR_IO8(0x3f)
#define	SPL  _SFR_IO8(0x3d)
#define	SPH  _SFR_IO8(0x3e)

#define	OCR0B  _SFR_IO8(0x28)
#define	OCR0A  _SFR_IO8(0x27)
#define	TCNT0  _SFR_IO8(0x26)
#define	TCCR0B  _SFR_IO8(0x25)
#define	TCCR0A  _SFR_IO8(0x24)

;eeprom i/o registers
#define	EEARH  _SFR_IO8(0x22)
#define	EEARL  _SFR_IO8(0x21)
#define	EEDR  _SFR_IO8(0x20)
#define	EECR  _SFR_IO8(0x1f)

#define	EIMSK  _SFR_IO8(0x1d)
#define	PORTD  _SFR_IO8(0x0b)
#define	DDRD  _SFR_IO8(0x0a)
#define	PIND  _SFR_IO8(0x09)
#define	PORTC  _SFR_IO8(0x08)
#define	DDRC  _SFR_IO8(0x07)
#define	PINC  _SFR_IO8(0x06)
#define	PORTB  _SFR_IO8(0x05)
#define	DDRB  _SFR_IO8(0x04)
#define	PINB  _SFR_IO8(0x03)

#endif
#pragma GCC diagnostic pop