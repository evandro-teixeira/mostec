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
	gpio_direction(PORT_D,5,INPUT,NO_PULL_RESISTOR);      // X
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
			gpio_set(PORT_A,4,OFF); // B
			gpio_set(PORT_A,12,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}			
		break;
		
		case 1:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,4,OFF); // B
			gpio_set(PORT_A,12,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;
		
		case 2:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,4,ON);  // B
			gpio_set(PORT_A,12,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;		
		
		case 3:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,4,ON);  // B
			gpio_set(PORT_A,12,OFF); // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;
		
		case 4:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,4,OFF); // B
			gpio_set(PORT_A,12,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;
		
		case 5:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,4,OFF); // B
			gpio_set(PORT_A,12,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;
		
		case 6:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,4,ON);  // B
			gpio_set(PORT_A,12,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;
		
		case 7:
			gpio_set(PORT_A,5,ON);	// A
			gpio_set(PORT_A,4,ON);  // B
			gpio_set(PORT_A,12,ON);  // C
			gpio_set(PORT_D,4,OFF); // EN
			
			for(i=0;i<TEMPO_MUX;i++);
			
			//return (bool)(gpio_read(PORT_D,5));
			if(gpio_read(PORT_D,5))
			{
				return TRUE;
			}
			else
			{
				return FALSE;
			}
		break;
		
		default:
			gpio_set(PORT_A,5,OFF);	// A
			gpio_set(PORT_A,4,OFF); // B
			gpio_set(PORT_A,12,OFF); // C
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
	
	if(( Flag_Check(NEW_DATA) == TRUE ) ||
	  ( Flag_Check(FIM_PROCESSO) == TRUE ))		
	{
		Flags_Action(NEW_DATA,RESET);
		Flags_Action(FIM_PROCESSO,RESET);
		
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
				
				put("\r\nRecebeu dados");
				put("\r\nSet Flag para iniciar o processo");
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
				
				put("\r\nMaquina Oucupada");
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
				
				put("\r\nProcesso Finalizado");
				
				Change_Machine_Status( PARADO );
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
	static uint8_t maq_estado = 0;
	static uint64_t tempo = 0;
	
	switch(estado_aplicacao)
	{
		case STOP:
			//put("\r\n Estado parado ");
			//if((Flag_Check(POSITION) == TRUE) && // Checa se o copo esta posi��o inicial
			//   (Flag_Check(ERRO_INT) == FALSE))  // e checa se n�o ha erro
			//{
				if( Flag_Check( INICIA_PROCESSO ) == TRUE )
				{
					// Reset flag
					put("\r\nInicia processo");
					Flags_Action( INICIA_PROCESSO,RESET );
					Change_Machine_Status( EXECUTANDO );
					estado_aplicacao = RUNNING;
				}
			//}
			/*
			else // se o copo n�o estiver na posi��o inicial, deve posicionar o mesmo
			{
				// muda para estado 
				estado_aplicacao = POSITIONING;
			}*/
		break;
		
		case RUNNING:
			// Checa se as chaves fim de curso
			//if((entrada[FIM_CURSO_1] == 1) &&
			//   (entrada[FIM_CURSO_2] == 1) )
			//{
				switch(maq_estado)
				{
					case 0:
						put("\r\nLiga Bomba de Mel");
						
						Bomba_Mel(ON);// Liga Bomba de MEL
						tempo = Calcula_Tick(TEMPO_BOMBA_MEL); // inicia contagem de tempo em segundos
						maq_estado = 1;
					break;
					
					case 1:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Bomba de Mel");
							Bomba_Mel(OFF);// Liga Bomba de MEL
							maq_estado = 2;
						}
					break;
					
					case 2: // liga esteira
						put("\r\nLiga Esteira");
						Controle_Esteira( ON , RIGHT);
						tempo = Calcula_Tick(TEMPO_ESTEIRA_STEP); // inicia contagem de tempo em segundos
						maq_estado = 3;
					break;	
					
					case 3:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Esteira");
							Controle_Esteira( OFF , OFF); // desliga esteira
							maq_estado = 4;
						}
					break;
					
					case 4:
						put("\r\nLiga Bomba de Vodka");
						Bomba_Vodka(ON);// Liga Bomba de Vodka
						tempo = Calcula_Tick(TEMPO_BOMBA_VODKA); // inicia contagem de tempo
						maq_estado = 5;
					break;
					
					case 5:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Bomba de Vodka");
							Bomba_Vodka(OFF);// Liga Bomba de Vodka
							maq_estado = 6;
						}
					break;
					
					case 6:
						put("\r\nLiga de Esteira");
						Controle_Esteira( ON , RIGHT);
						tempo = Calcula_Tick(TEMPO_ESTEIRA_STEP); // inicia contagem de tempo em segundos
						maq_estado = 7;
					break;	
					
					case 7:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Esteira");
							Controle_Esteira( OFF , OFF);
							maq_estado = 8;
						}
					break;	
					
					case 8:
						put("\r\nLiga Bomba de Esteira");
						Bomba_Energetico( ON );
						tempo = Calcula_Tick(TEMPO_BOMBA_ENERGETICO); // inicia contagem de tempo em segundos 
						maq_estado = 9;
					break;	
					
					case 9:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Bomba de Energetico");
							Bomba_Energetico( OFF );
							maq_estado = 10;
						}
					break;	
					
					case 10:
						put("\r\nLiga Esteira");
						Controle_Esteira( ON , RIGHT);
						tempo = Calcula_Tick(TEMPO_ESTEIRA_STEP); // inicia contagem de tempo em segundos
						maq_estado = 11;
					break;	
					
					case 11:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Esteira");
							Controle_Esteira( OFF, OFF );
							maq_estado = 12;
						}
					break;	
					
					case 12:
						put("\r\nLiga Bomba de Corante");
						Bomba_Corante(ON);
						tempo = Calcula_Tick(TEMPO_BOMBA_CORANTE); // inicia contagem de tempo em segundos
						maq_estado = 13;
					break;	
					
					case 13:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Corante");
							Bomba_Corante(OFF);
							maq_estado = 14;
						}
					break;	
					
					case 14:
						put("\r\nLiga Esteira ");
						put("\r\nRetorna posi��o inicial");
						Controle_Esteira( ON , LEFT);
						tempo = Calcula_Tick(TEMPO_ESTEIRA_TOTAL); // inicia contagem de tempo em segundos
						maq_estado = 15;
					break;
					
					case 15:
						if(Check_Tick(tempo) == TRUE)
						{
							put("\r\nDesliga Esteira");
							put("\r\nPosi��o Inicial");
							Controle_Esteira( OFF , OFF);
							maq_estado = 0;
							estado_aplicacao = STOP;
							
							Change_Machine_Status( OK );
							
							Flags_Action(FIM_PROCESSO,SET);
						}
					break;	
				}
			//}
			/*	
			else // caso algumas da chaves seja acionadas deve desligar a esteira e set a flag de erro
			{
				// desliga Esteira
				Controle_Esteira(OFF,OFF);
				// Set flag que sinaliza erro
				Flags_Action(ERRO_INT,SET);
			}*/
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
