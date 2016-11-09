/*
 * application.c
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */
#include "application.h"
/********************************************************************/
// Variavel Global
/********************************************************************/
static uint8_t estado_maquina = 0;
/********************************************************************/
// o projeto contem oito entrada digitais
// as entrada est�o atraves de um multiplexador 74HC4051
// o sinal entraDA no IN0 do Kit de Automa��o
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
	if(x == ON) // Bomba Energetico Ligada ~ ON
	{
		gpio_set(PORT_E,0,ON);
	}
	else // Bomba Energetico Desligado ~ OFF
	{
		gpio_set(PORT_E,0,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Bomba_Vodka(bool x)
{
	if(x == ON) // Bomba Vodka Ligada ~ ON
	{
		gpio_set(PORT_D,1,ON);
	}
	else // Bomba Vodka Desligado ~ OFF
	{
		gpio_set(PORT_D,1,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Bomba_Corante(bool x)
{
	if(x == ON) // Bomba Corante Ligada ~ ON
	{
		gpio_set(PORT_D,3,ON);
	}
	else // Bomba Corante Desligado ~ OFF
	{
		gpio_set(PORT_D,3,OFF);
	}
}
/********************************************************************/
//
/********************************************************************/
void Controle_Esteira(bool x, bool dir)
{
	if(x == ON) // Esteira Ligada ~ ON
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
	else // Esteira Desligado ~ OFF
	{
		gpio_set(PORT_D,2,ON);   // - Rele 5
		gpio_set(PORT_D,0,OFF);  // - Rele 6
	}
}
/********************************************************************/
//
/********************************************************************/
void Interpreter(void)
{
	uint8_t i = 0;
	
	if( Flag_Check(NEW_DATA) == TRUE )
	{
		Flags_Action(NEW_DATA,RESET);
		
		switch( Machine_Status() )
		{
			case PARADO:
				/*out_char('[');
				out_char( Machine_Status() );
				out_char(']');*/
				data_tx[0] = '[';
				data_tx[1] = (Machine_Status() + 48) ;
				data_tx[2] = ']';
				
				for(i=0;i<3;i++)
				{
					out_char( data_tx[i] );
				}
				// inicia opera��o
				//Change_Machine_Status( EXECUTANDO );
				// SET flag para iniciar 
				Flags_Action(INICIA_PROCESSO,SET);
			break;
			
			case EXECUTANDO:
				/*out_char('[');
				out_char( Machine_Status() );
				out_char(']');*/
				data_tx[0] = '[';
				data_tx[1] = (Machine_Status() + 48) ;
				data_tx[2] = ']';
				
				for(i=0;i<3;i++)
				{
					out_char( data_tx[i] );
				}
			break;
			
			case OK:
				/*out_char('[');
				out_char( Machine_Status() );
				out_char(']');*/
				data_tx[0] = '[';
				data_tx[1] = (Machine_Status() + 48) ;
				data_tx[2] = ']';
				
				for(i=0;i<3;i++)
				{
					out_char( data_tx[i] );
				}
			break;
			
			default:
				/*out_char('[');
				out_char( ERRO );
				out_char(']');*/
				data_tx[0] = '[';
				data_tx[1] = (ERRO + 48) ;
				data_tx[2] = ']';
				
				for(i=0;i<3;i++)
				{
					out_char( data_tx[i] );
				}
			break;	
		}
	}
}
/********************************************************************/
//
/********************************************************************/
uint8_t Machine_Status(void)
{
	return estado_maquina;
}
/********************************************************************/
//
/********************************************************************/
void Change_Machine_Status(uint8_t st)
{
	switch( st )
	{
		case PARADO:
			estado_maquina = PARADO;
		break;
		
		case EXECUTANDO:
			estado_maquina = EXECUTANDO;
		break;
		
		case OK:
			estado_maquina = OK;
		break;
		
		default:
			estado_maquina = PARADO;
		break;
	}
}
/********************************************************************/
//
/********************************************************************/
void Controle_Aplicacao(void)
{
	static uint8_t estado_aplicacao = 0;
	
	switch(estado_aplicacao)
	{
		case STOP:
			if((Flag_Check(POSITION) == TRUE) && // Checa se o copo esta posi��o inicial
			   (Flag_Check(ERRO_INT) == FALSE))  // e checa se n�o ha erro
			{
				if( Flag_Check( INICIA_PROCESSO ) == TRUE )
				{
					// Reset flag
					Flags_Action( INICIA_PROCESSO,RESET );
					Change_Machine_Status( EXECUTANDO );
					estado_maquina = EXECUTANDO;
				}
			}
			else // se o copo n�o estiver na posi��o inicial, deve posicionar o mesmo
			{
				// muda para estado 
				estado_aplicacao = POSITIONING;
			}
		break;
		
		case RUNNING:
			// Checa se as chaves fim de curso
			if((entrada[FIM_CURSO_1] == 1) &&
			   (entrada[FIM_CURSO_2] == 1) )
			{
				
			}
			else
			{
				// desliga Esteira
				Controle_Esteira(OFF,OFF);
				// Set flag que sinaliza erro
				Flags_Action(ERRO_INT,SET);
			}
		break;	
		
		case POSITIONING:
			// liga Esteira  
			Controle_Esteira( ON , LEFT);
			// Checa se o copo tocou a chave fim de curso 1
			if((entrada[POSICAO_INICIAL] == 0) ||
			   (entrada[FIM_CURSO_1]     == 0) ||
			   (entrada[FIM_CURSO_2]     == 0))
			{				
				// Desliga esteira
				Controle_Esteira(OFF,OFF);
				// checa se o copo esta na posi��o correta 
				if((entrada[POSICAO_INICIAL] == 0) && 
				   (entrada[FIM_CURSO_1]     == 1) &&
				   (entrada[FIM_CURSO_2]     == 1) )
				{
					// Set FLag que sinaliza que o copo esta na posi��o correta
					Flags_Action(POSITION,SET);
				}
				else
				{
					// caso contrario Set flag que sinaliza erro
					Flags_Action(ERRO_INT,SET);
				}
			}			
		break;	
	}
}
/********************************************************************/
