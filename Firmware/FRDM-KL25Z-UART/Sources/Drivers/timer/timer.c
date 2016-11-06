/*
 * timer.c
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */
#include "timer.h"

uint64_t Tick = 0;

bool Check_Tick(uint64_t n_Tick)
{
	if(Tick >= n_Tick)
	{
		return TRUE;
	}
	else
	{
		return FALSE;
	}
}

uint64_t Calcula_Tick(uint64_t n_Tick)
{
	return (Tick + n_Tick); 
}



