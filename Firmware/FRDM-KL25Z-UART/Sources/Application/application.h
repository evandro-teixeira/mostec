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

//metodo de controle
#define CONTROLE_TEMPO	1 	// 1 Controle baseado em tempo
							// 0 Controle orientado pelas chaves

#define RIGHT 0
#define LEFT  1	

#define PARADO		0
#define EXECUTANDO 	1
#define OK			2
#define ERRO		3

//ESTADO DE APLICA��O
#define STOP		0
#define RUNNING     1
#define POSITIONING 2

// DEFINE DE FLAGS
#define NEW_DATA     	FLAG_0
#define INICIA_PROCESSO FLAG_1
#define POSITION		FLAG_2 //position
#define ERRO_INT		FLAG_3
#define FIM_PROCESSO    FLAG_4
#define RESET_MAQ		FLAG_5

// ENTRADAS
#define BOTAO_EMERGENCIA 	0
#define POSICAO_INICIAL  	1
#define POSICAO_MEL      	2
#define POSICAO_VODKA    	3
#define POSICAO_ENERGETICO  4
#define POSICAO_CORANTE     5
#define FIM_CURSO_1    		6
#define FIM_CURSO_2			7

#define TEMPO_BOMBA_MEL			30 // segundos
#define TEMPO_BOMBA_VODKA		30 // segundos
#define TEMPO_BOMBA_ENERGETICO 	30 // segundos
#define TEMPO_BOMBA_CORANTE		30 // segundos
#define TEMPO_ESTEIRA_STEP		120 // segundos
#define TEMPO_ESTEIRA_TOTAL		240 // segundos

#define TEMPO_MUX   1000

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

void Interpreter(void);
uint8_t Machine_Status(void);
void Change_Machine_Status(uint8_t st);

void Le_Entradas(void);

#endif /* APPLICATION_H_ */
