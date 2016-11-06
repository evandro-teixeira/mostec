/*
 * serial.c
 *
 *  Created on: 05/11/2016
 *      Author: Evandro
 */
#include "serial.h"
//=========================================================
//
//
//=========================================================
void InicializaSerial(uint32_t baud_rate)
{
	/* Habilita uart0 - pinos PTA1-RX, PTA2-TX */
	//uart_init(UART0_BASE_PTR,(21000000/1000),baud_rate);
	//uart_init(UART0_BASE_PTR,(8000000),baud_rate);
	uart_init(UART0_BASE_PTR,(iClock/2),baud_rate);
	//uart_init(UART0_BASE_PTR,iClock,baud_rate);

#if UART_MODE == INTERRUPT
	//EnableInterrupts;
	//enable_irq(INT_UART0 -16);
	//set_irq_priority((INT_UART0 -16), 2);
	NVIC_EnableIRQ(UART0_IRQn);
	NVIC_SetPriority(UART0_IRQn,2);

	//NVIC_ICPR |= 1 << ((INT_PIT - 16) % 32);
	//NVIC_ISER |= 1 << ((INT_PIT - 16) % 32);
#endif

}
//=========================================================
//
//
//=========================================================
void EnviaCh(char ch)
{
	/* enviar uart0 */
	uart_putchar(UART0_BASE_PTR,ch) ;
}
//=========================================================
//
//
//=========================================================
char RecebeCh(void)
{
	/* uart0 */
	return uart_getchar(UART0_BASE_PTR);
}
//=========================================================
//
//
//=========================================================
void EnviaString(char* msg)
{
	/* envia string uart0  */
	while(*msg)
	{
		uart_putchar(UART0_BASE_PTR,*msg) ;
		msg++;
	}
}
//=========================================================
//
//
//=========================================================
#if UART_MODE == INTERRUPT
void IRQ_Serial(void)
{
	char c = 0;
	if (UART0_S1&UART_S1_RDRF_MASK)
	{
		c = UART0_D;

		if ((UART0_S1&UART_S1_TDRE_MASK)||(UART0_S1&UART_S1_TC_MASK))
		{
			UART0_D  = c;
		}
	}
}
#endif
//=========================================================
