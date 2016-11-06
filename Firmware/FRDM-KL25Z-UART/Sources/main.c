/*
 * Projeto: Mostec 2016 - Kit de Automa��o
 * 			Maquina de Tchay
 * Autor: Evandro Teixeira
 * 		  Raul Marques
 * 		  Jo�o Vitor
 * 		  Luciano
 */
#include "main.h"

int main(void)
{
	int counter = 0;
	// Inicializa perifeicos
	rgb_init();
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
		counter++;
		if(counter >= DLY)
		{
			GREEN_TOGGLE;
			counter = 0;
		}
	}
	
	return 0;
}
