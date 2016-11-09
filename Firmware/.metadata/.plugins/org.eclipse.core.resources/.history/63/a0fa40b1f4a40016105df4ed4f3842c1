/*
 * application.c
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */
#include "application.h"
/********************************************************************/
// o projeto contem oito entrada digitais
// as entrada estão atraves de um multiplexador 74HC4051
// o sinal entraDA no IN0 do Kit de Automação
// X  - IN0  - PTD5  ~ FRDM-KL25
// Os pinos de controle do 74HC4051
// A  - OUT0 - PTA5  ~ FRDM-KL25
// B  - OUT1 - PTA4  ~ FRDM-KL25
// C  - OUT2 - PTA12 ~ FRDM-KL25
// EN - OUT3 - PTD4  ~ FRDM-KL25
/********************************************************************/
void Inicializa_Entrada(void)
{
	// Pinos de controle do 74HC4051
	gpio_direction(PORT_A,5, OUTPUT,NO_PULL_RESISTOR); // A
	gpio_direction(PORT_A,4, OUTPUT,NO_PULL_RESISTOR); // B			
	gpio_direction(PORT_A,12,OUTPUT,NO_PULL_RESISTOR); // C
	gpio_direction(PORT_D,4, OUTPUT,NO_PULL_RESISTOR); // EN
	// entrada
	gpio_direction(PORT_D,5,INPUT,PULL_RESISTOR);      // X
}
/********************************************************************/
//
/********************************************************************/
bool Le_Entradas(uint8_t ch)
{
	uint16_t i =0;
	
	switch(ch)
	{
		case 0:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,5,OFF); // B
			gpio_set(PORT_A,5,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		case 1:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,5,OFF); // B
			gpio_set(PORT_A,5,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		case 2:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,5,ON);  // B
			gpio_set(PORT_A,5,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;		
		
		case 3:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,5,ON);  // B
			gpio_set(PORT_A,5,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		case 4:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,5,OFF); // B
			gpio_set(PORT_A,5,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		case 5:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,5,OFF); // B
			gpio_set(PORT_A,5,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		case 6:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,5,ON);  // B
			gpio_set(PORT_A,5,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		case 7:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,5,ON);  // B
			gpio_set(PORT_A,5,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<100;i++);
			
			return (bool)(gpio_read(PORT_D,5));
		break;
		
		default:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,5,OFF); // B
			gpio_set(PORT_A,5,OFF); // C
			gpio_set(PORT_D,4,ON);  // EN
		break;	
	}
}
/********************************************************************/
//
/********************************************************************/
void Inicializa_Reles(void)
{
	gpio_direction(PORT_E,1,OUTPUT,NO_PULL_RESISTOR);  // Bomba de Mel
	gpio_direction(PORT_E,0,OUTPUT,NO_PULL_RESISTOR);  // Bomba Energetico 
	gpio_direction(PORT_D,1,OUTPUT,NO_PULL_RESISTOR);  // Bomba Vodka
	gpio_direction(PORT_D,3,OUTPUT,NO_PULL_RESISTOR);  // Bomba Corante
	gpio_direction(PORT_D,2,OUTPUT,NO_PULL_RESISTOR);  // Motor Esteira - Rele 5
	gpio_direction(PORT_D,0,OUTPUT,NO_PULL_RESISTOR);  // Motor Esteira - Rele 6
}
/********************************************************************/
//
/********************************************************************/
void Bomba_Mel(bool x)
{
	if(x == ON) // Bomba MEL Ligada ~ ON
	{
		gpio_set(PORT_E,1,ON);
	}
	else // Bomba MEL Desligado ~ OFF
	{
		gpio_set(PORT_E,1,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Bomba_Energetico(bool x)
{
	if(x == ON) // Bomba MEL Ligada ~ ON
	{
		gpio_set(PORT_E,0,ON);
	}
	else // Bomba MEL Desligado ~ OFF
	{
		gpio_set(PORT_E,0,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Bomba_Vodka(bool x)
{
	if(x == ON) // Bomba MEL Ligada ~ ON
	{
		gpio_set(PORT_D,1,ON);
	}
	else // Bomba MEL Desligado ~ OFF
	{
		gpio_set(PORT_D,1,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Bomba_Corante(bool x)
{
	if(x == ON) // Bomba MEL Ligada ~ ON
	{
		gpio_set(PORT_D,3,ON);
	}
	else // Bomba MEL Desligado ~ OFF
	{
		gpio_set(PORT_D,3,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Controle_Esteira(bool x, bool dir)
{
	if(x == ON) // Bomba MEL Ligada ~ ON
	{
		if(dir == LEFT)
		{
			gpio_set(PORT_D,2,OFF);  // - Rele 5
			gpio_set(PORT_D,0,OFF);  // - Rele 6
		}
		else
		{
			gpio_set(PORT_D,2,ON);  // - Rele 5
			gpio_set(PORT_D,0,ON);  // - Rele 6
		}

	}
	else // Bomba MEL Desligado ~ OFF
	{
		gpio_set(PORT_D,2,ON);   // - Rele 5
		gpio_set(PORT_D,0,OFF);  // - Rele 6
	}
}
/********************************************************************/
