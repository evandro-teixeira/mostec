/*
 * gpio.h
 *
 *  Created on: Dec 10, 2012
 *      Author: B34443
 */

#include "derivative.h"
//#include "main.h"

#ifndef GPIO_H_
#define GPIO_H_

#define PIN(x)			1 << x

#define RED				(18)
#define RED_SHIFT		(1 << 18)
#define GREEN			(19)
#define GREEN_SHIFT		(1 << 19)
#define BLUE			(1)
#define BLUE_SHIFT		(1 << 1)

#define RED_OFF			(GPIOB_PSOR = RED_SHIFT)
#define RED_ON			(GPIOB_PCOR = RED_SHIFT)
#define RED_TOGGLE		(GPIOB_PTOR = RED_SHIFT)

#define GREEN_OFF		(GPIOB_PSOR = GREEN_SHIFT)
#define GREEN_ON		(GPIOB_PCOR = GREEN_SHIFT)
#define GREEN_TOGGLE	(GPIOB_PTOR = GREEN_SHIFT)

#define BLUE_OFF		(GPIOD_PSOR = BLUE_SHIFT)
#define BLUE_ON			(GPIOD_PCOR = BLUE_SHIFT)
#define BLUE_TOGGLE		(GPIOD_PTOR = BLUE_SHIFT)

// utilizar com o CodeWarrior
#ifndef PORT_PCR_PE(x)
#define PORT_PCR_PE(x) (((uint32_t)(((uint32_t)(x))<<PORT_PCR_PE_SHIFT))&PORT_PCR_PE_MASK)
#endif

#ifndef bool
typedef unsigned char bool;
#endif

#define PORT_A 	0
#define PORT_B 	1
#define PORT_C 	2
#define PORT_D 	3
#define PORT_E 	4
#define OUTPUT 	1
#define INPUT 	0
#define HIGH 	1
#define LOW 	0
#define ON		1
#define OFF     0

#define PULL_RESISTOR 1		// habilita pull resistor
#define NO_PULL_RESISTOR 0

void gpio_direction(uint8_t port, uint8_t pin, uint8_t mode, bool pull_resistor);

void gpio_set(uint8_t port, uint8_t pin, uint8_t value);

void gpio_toggle(uint8_t port, uint8_t pin);

uint16_t gpio_read(uint8_t port, uint8_t pin);

void rgb_init(void);

#endif /* GPIO_H_ */
