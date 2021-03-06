/*
 * main.h
 *
 *  Created on: May 16, 2013
 *      Author: B34443
 */

#ifndef MAIN_H_
#define MAIN_H_

#include "derivative.h" /* include peripheral declarations */
#include "mcg.h"
#include "gpio.h"
#include "uart.h"
#include "io.h"
#include "nvic.h"
#include "libs.h"
#include "Drivers/pit/pit.h"
#include "Application/application.h"
#include "Drivers/flags/flags.h"

/* Uses UART0 for both Open SDA and TWR-SER Tower card */
#define TERM_PORT_NUM       0

#define TERMINAL_BAUD       9600
#undef  HW_FLOW_CONTROL

#define UART_MODE 			INTERRUPT
#define POLLING				0
#define INTERRUPT			1

#ifndef bool
typedef unsigned char bool;
#endif

/*
 * PLL Configuration Info
 */
//#define NO_PLL_INIT  // define this to skip PLL initialization and stay in default FEI mode

#define DLY 100000

/*
 * Misc. Defines
 */
#ifdef	FALSE
#undef	FALSE
#endif
#define FALSE	(0)

#ifdef	TRUE
#undef	TRUE
#endif
#define	TRUE	(1)

#ifdef	NULL
#undef	NULL
#endif
#define NULL	(0)

#ifdef  ON
#undef  ON
#endif
#define ON      (1)

#ifdef  OFF
#undef  OFF
#endif
#define OFF     (0)

extern uint64_t Tick;

#endif /* MAIN_H_ */
