FILENAME		= program_b
PORT				=	COM3
DEVICE			=	atmega328p
PROGRAMMER 	=	arduino
BAUD				= 115200
COMPILE			=	avr-gcc

default: build upload clean

build:
	${COMPILE} -g -mmcu=${DEVICE} -o ${FILENAME}.elf ${FILENAME}.S
	avr-objcopy -O ihex -R .eeprom ${FILENAME}.elf ${FILENAME}.hex


upload:
	avrdude -c ${PROGRAMMER} -P ${PORT} -b ${BAUD} -p ${DEVICE} -D -U flash:w:${FILENAME}.hex:i

clean:
	rm ${FILENAME}.elf
	rm ${FILENAME}.hex
