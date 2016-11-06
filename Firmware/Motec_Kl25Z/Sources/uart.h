/*
 * uart.h
 *
 *  Created on: 05/11/2016
 *      Author: Evandro
 */

#ifndef SOURCES_UART_H_
#define SOURCES_UART_H_

#include "extern.h"

#define POLLING_MODE 	1
#define UART_MODE 		POLLING_MODE
#define UART_BAUD       115200
#define CORE_CLK_KHZ    48000

#define UART_MODE 		INTERRUPT
#define POLLING			0
#define INTERRUPT		1

void uart_init (UART_MemMapPtr uartch, int sysclk, int baud);
void uart_putchar (UART_MemMapPtr channel, char ch);
char uart_getchar (UART_MemMapPtr channel);


#endif /* SOURCES_UART_H_ */
