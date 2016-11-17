/*
 * Projeto: Mostec 2016 - Kit de Automa��o
 * 			Maquina de Tchay
 * Autor: Evandro Teixeira
 * 		  Raul Marques
 * 		  Jo�o Vitor
 * 		  Luciano
 */
#include "main.h"

//uint8_t i = 0;
uint32_t contador = 0;
uint8_t maq_led = 0;
uint64_t tempo_led = 0;

int main(void)
{
	//int counter = 0;
	// Inicializa perifeicos
	/*rgb_init();
	GREEN_OFF;
	RED_OFF;
	BLUE_OFF;*/
	gpio_direction(PORT_B,18,OUTPUT,NO_PULL_RESISTOR);
	gpio_direction(PORT_C,1,OUTPUT,NO_PULL_RESISTOR);
	
	PIT_Init();
	
	Inicializa_Entrada();
	Inicializa_Reles();
	
	// Desliga Perifericos
	Controle_Esteira(OFF,OFF);
	Bomba_Mel(OFF);
	Bomba_Energetico(OFF);
	Bomba_Vodka(OFF);
	Bomba_Corante(OFF);
	
	EnableInterrupts;
	enable_irq(INT_UART0 -16);
	set_irq_priority((INT_UART0 -16), 2);
	
	put("\r\nProjeto Mostec 2016");
	put("\r\nKiT de Automacao");
	put("\r\nMaquina de Tchay");
	put("\r\n");
	
	while(TRUE)
	{
		//entrada[i] = (uint8_t)Le_Entradas(i);
	   	/*contador++;
	   	if(contador >= 10000)
	   	{
	   		contador = 0;
	   		entrada[i] = (bool)Le_Entradas(i);
	   		i++;
	   		if(i >= 8)
	   		{
	   			i = 0;
	   		}
	   	}
	   	*/
		//Le_Entradas();	   	
		Interpreter();
		if(entrada[BOTAO_EMERGENCIA] == 1)
		{
			//Flags_Action(RESET_MAQ,RESET);
			Controle_Aplicacao();
			Flags_Action(RESET_MAQ,RESET);
		}	
		else
		{
			Flags_Action(RESET_MAQ,SET);
			// Desliga esteira e bombas
			Controle_Esteira(OFF,OFF);
			Bomba_Mel(OFF);
			Bomba_Energetico(OFF);
			Bomba_Vodka(OFF);
			Bomba_Corante(OFF);
			put("\r\nBotao de Emergencia precionado");
			contador++;
			if(contador > 10000)
			{
				contador = 0;
			}
		}
		/*counter++;
		if(counter >= DLY)
		{
			GREEN_TOGGLE;
			counter = 0;
		}*/
		switch(maq_led)
		{
			/*case 0:
				RED_ON;
				tempo_led = Calcula_Tick(10);
				maq_led = 1;
			break;
			
			case 1:
				if(Check_Tick(tempo_led) == TRUE)
				{
					maq_led = 2;
					RED_OFF;
				}
			break;	
			
			case 2:
				GREEN_ON;
				tempo_led = Calcula_Tick(10);
				maq_led = 3;
			break;
			
			case 3:
				if(Check_Tick(tempo_led) == TRUE)
				{
					maq_led = 4;
					GREEN_OFF;
				}
			break;*/	
			
			case 0:
				//BLUE_ON;
				gpio_set(PORT_B,18,ON);
				tempo_led = Calcula_Tick(10);
				maq_led = 1;
			break;
			
			case 1:
				if(Check_Tick(tempo_led) == TRUE)
				{
					maq_led = 0;
					//BLUE_OFF;
					gpio_set(PORT_B,18,OFF);
				}
			break;
		}
	}
	
	return 0;
}
