/*
 * application.h
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */

#ifndef APPLICATION_H_
#define APPLICATION_H_

#include "derivative.h"
#include "main.h"

#define RIGHT 0
#define LEFT  1			

uint8_t data_tx[8]; 
uint8_t data_rx[8];
uint8_t entrada[8];

void Inicializa_Entrada(void);
void Inicializa_Reles(void);
void Bomba_Mel(bool x);
void Bomba_Energetico(bool x);
void Bomba_Vodka(bool x);
void Bomba_Corante(bool x);
void Controle_Esteira(bool x, bool dir);

#endif /* APPLICATION_H_ */
