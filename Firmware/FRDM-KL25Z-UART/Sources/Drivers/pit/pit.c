/*
 * pit.c
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */
#include "pit.h"



void PIT_Init(void)
{
	
	//PIT initialization 
	SIM_SCGC6 |= SIM_SCGC6_PIT_MASK;		// Turn on clock to to the PIT module
	PIT_LDVAL0 = (1048000/1000);     		// Timeout period = 1 ms
	PIT_MCR = PIT_MCR_FRZ_MASK;     		// Enable clock for PIT, freeze PIT in debug mode
	PIT_TCTRL0 = PIT_TCTRL_TIE_MASK | 		// Enable PIT interrupt
				 PIT_TCTRL_TEN_MASK;     	// and PIT 
		
	//Enable PIT interrupt on NVIC	 
	NVIC_ICPR |= 1 << ((INT_PIT - 16) % 32);
	NVIC_ISER |= 1 << ((INT_PIT - 16) % 32);	
}

void PIT_IRQHandler()
{
	static uint32_t contador = 0;
	static uint32_t counter = 0;
	static uint8_t i = 0;
	
	PIT_TFLG0 |= PIT_TFLG_TIF_MASK;		// Clear the PIT interrupt flag	
   	//Toggle Green LED
   	//GPIOB_PTOR = (1 << 19);
	
	Le_Entradas();
	
	counter++;
	if(counter >= 12000)
	{
		//gpio_toggle(PORT_C,1);
		counter = 0;
		Tick++;
	}
   	//ToggleLedBLUE();
	/*
   	contador++;
   	if(contador >= 6000)
   	{
   		contador = 0;
   		entrada[i] = (uint8_t)Le_Entradas(i);
   		i++;
   		if(i >= 8)
   		{
   			i = 0;
   		}
   	}*/
}

