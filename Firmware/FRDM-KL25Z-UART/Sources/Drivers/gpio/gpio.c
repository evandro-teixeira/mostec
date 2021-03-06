/*
 * gpio.c
 *
 *  Created on: Dec 10, 2012
 *      Author: B34443
 */

#include "gpio.h"
#
/********************************************************************/
// 
/********************************************************************/
void rgb_init(void)
{
	/* Turn on clock to PortB and PortD module */
	SIM_SCGC5 |= SIM_SCGC5_PORTB_MASK|SIM_SCGC5_PORTD_MASK;
	
	/* Set the PTB18 pin multiplexer to GPIO mode */
	PORTB_PCR18 = PORT_PCR_MUX(1);
	
	/* Set the initial output state to high */
	GPIOB_PSOR |= RED_SHIFT;
	
	/* Set the pins direction to output */
	GPIOB_PDDR |= RED_SHIFT;
	
	/* Set the PTB19 pin multiplexer to GPIO mode */
	PORTB_PCR19 = PORT_PCR_MUX(1);
	
	/* Set the initial output state to high */
	GPIOB_PSOR |= GREEN_SHIFT;
	
	/* Set the pins direction to output */
	GPIOB_PDDR |= GREEN_SHIFT;
	
	/* Set the PTD1 pin multiplexer to GPIO mode */
	PORTD_PCR1 = PORT_PCR_MUX(1);
	
	/* Set the initial output state to high */
	GPIOD_PSOR = BLUE_SHIFT;
	
	/* Set the pins direction to output */
	GPIOD_PDDR |= BLUE_SHIFT;
}


/********************************************************************/
// fun��o que define a dire��o do pino
/********************************************************************/
void gpio_direction(uint8_t port, uint8_t pin, uint8_t mode,bool pull_resistor)
{
	switch(port)
	{
		case PORT_A:
			SIM_SCGC5 |= SIM_SCGC5_PORTA_MASK;
			PORT_PCR_REG(PORTA_BASE_PTR,pin) = PORT_PCR_MUX(1);
			if(pull_resistor == PULL_RESISTOR)
			{
				PORT_PCR_REG(PORTA_BASE_PTR,pin) |= PORT_PCR_PE(1);
			}
			if(mode == OUTPUT)
			{
				GPIOA_PDDR |= (1 << pin);
			}
			else if(mode == INPUT)
			{
				GPIOA_PDDR &=~ (1 << pin);
			}
		break;

		case PORT_B:
			//switch(pin)
			//{
			SIM_SCGC5 |= SIM_SCGC5_PORTB_MASK;
			PORT_PCR_REG(PORTB_BASE_PTR,pin) = PORT_PCR_MUX(1);
			if(pull_resistor == PULL_RESISTOR)
			{
				PORT_PCR_REG(PORTA_BASE_PTR,pin) |= PORT_PCR_PE(1);
			}
			if(mode == OUTPUT)
			{
				GPIOB_PDDR |= (1 << pin);
			}
			else if(mode == INPUT)
			{
				GPIOB_PDDR &=~ (1 << pin);
			}
			//}
		break;

		case PORT_C:
			SIM_SCGC5 |= SIM_SCGC5_PORTC_MASK;
			PORT_PCR_REG(PORTC_BASE_PTR,pin) = PORT_PCR_MUX(1);
			if(pull_resistor == PULL_RESISTOR)
			{
				PORT_PCR_REG(PORTA_BASE_PTR,pin) |= PORT_PCR_PE(1);
			}
			if(mode == OUTPUT)
			{
				GPIOC_PDDR |= (1 << pin);
			}
			else if(mode == INPUT)
			{
				GPIOC_PDDR &= (1 << pin);
			}
		break;

		case PORT_D:
			SIM_SCGC5 |= SIM_SCGC5_PORTD_MASK;
			PORT_PCR_REG(PORTD_BASE_PTR,pin) = PORT_PCR_MUX(1);
			if(pull_resistor == PULL_RESISTOR)
			{
				PORT_PCR_REG(PORTA_BASE_PTR,pin) |= PORT_PCR_PE(1);
			}
			if(mode == OUTPUT)
			{
				GPIOD_PDDR |= (1 << pin);
			}
			else if(mode == INPUT)
			{
				GPIOD_PDDR &=~ (1 << pin);
			}
		break;

		case PORT_E:
			SIM_SCGC5 |= SIM_SCGC5_PORTE_MASK;
			PORT_PCR_REG(PORTE_BASE_PTR,pin) = PORT_PCR_MUX(1);
			if(pull_resistor == PULL_RESISTOR)
			{
				PORT_PCR_REG(PORTA_BASE_PTR,pin) |= PORT_PCR_PE(1);
			}
			if(mode == OUTPUT)
			{
				GPIOE_PDDR |= (1 << pin);
			}
			else if(mode == INPUT)
			{
				GPIOE_PDDR &=~ (1 << pin);
			}
		break;
	}
}
/********************************************************************/
// Fun��o que set o pino 0 ou 1
/********************************************************************/
void gpio_set(uint8_t port, uint8_t pin, uint8_t value)
{
	switch(port)
	{
		case PORT_A:
			if(value == HIGH)
			{
				GPIOA_PSOR |= (1 << pin);
			}
			else if(value == LOW)
			{
				GPIOA_PDOR &=~ (1 << pin);
			}
		break;

		case PORT_B:
			if(value == HIGH)
			{
				GPIOB_PSOR |= (1 << pin);
			}
			else if(value == LOW)
			{
				GPIOB_PDOR &=~ (1 << pin);
			}
		break;

		case PORT_C:
			if(value == HIGH)
			{
				GPIOC_PSOR |= (1 << pin);
			}
			else if(value == LOW)
			{
				GPIOC_PDOR &=~ (1 << pin);
			}
		break;

		case PORT_D:
			if(value == HIGH)
			{
				GPIOD_PSOR |= (1 << pin);
			}
			else if(value == LOW)
			{
				GPIOD_PDOR &=~ (1 << pin);
			}
		break;

		case PORT_E:
			if(value == HIGH)
			{
				GPIOE_PSOR |= (1 << pin);
			}
			else if(value == LOW)
			{
				GPIOE_PDOR &=~ (1 << pin);
			}
		break;
	}
}
/********************************************************************/
// fun��o que inverte o valor do pino
/********************************************************************/
void gpio_toggle(uint8_t port, uint8_t pin)
{
	switch(port)
	{
		case PORT_A:
			GPIOA_PTOR = (1 << pin);
		break;

		case PORT_B:
			GPIOB_PTOR = (1 << pin);
		break;

		case PORT_C:
			GPIOC_PTOR = (1 << pin);
		break;

		case PORT_D:
			GPIOD_PTOR = (1 << pin);
		break;

		case PORT_E:
			GPIOE_PTOR = (1 << pin);
		break;
	}
}
/********************************************************************/
// fun��o que le o valor do pino
/********************************************************************/
uint16_t gpio_read(uint8_t port, uint8_t pin)
{
	switch(port)
	{
		case PORT_A:
			/*if ( GPIOA_PDIR & (1 << pin))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}*/
			return (GPIOA_PDIR & (1 << pin));
		break;

		case PORT_B:
			/*if ( GPIOB_PDIR & (1 << pin))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}*/
			return (GPIOB_PDIR & (1 << pin));
		break;

		case PORT_C:
			/*if ( GPIOC_PDIR &= (1 << pin))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
			*/
			return (GPIOC_PDIR & (1 << pin));
		break;

		case PORT_D:
			/*if ( GPIOD_PDIR & (1 << pin))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}*/
			return (GPIOD_PDIR & (1 << pin));
		break;

		case PORT_E:
			/*if ( GPIOE_PDIR & (1 << pin))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}*/
			return ( GPIOE_PDIR & (1 << pin));
		break;
	}
}
/********************************************************************/




