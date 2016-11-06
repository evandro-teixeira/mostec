/*
 * serial.h
 *
 *  Created on: 05/11/2016
 *      Author: Evandro
 */

#ifndef SOURCES_SERIAL_H_
#define SOURCES_SERIAL_H_


#include "extern.h"

void InicializaSerial(uint32_t baud_rate);
void EnviaCh(char ch);
char RecebeCh(void);
void EnviaString(char* msg);

#if UART_MODE == INTERRUPT
void IRQ_Serial(void);
#endif


#endif /* SOURCES_SERIAL_H_ */