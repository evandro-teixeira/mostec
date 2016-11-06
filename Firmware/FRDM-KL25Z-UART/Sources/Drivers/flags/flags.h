/*
 * flags.h
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */

#ifndef FLAGS_H_
#define FLAGS_H_

#include "main.h"

#define FLAG_0       1
#define FLAG_1       2
#define FLAG_2       4
#define FLAG_3       8
#define FLAG_4       16
#define FLAG_5       32
#define FLAG_6       64
#define FLAG_7       128
#define SET          1
#define RESET        0

#define NEW_DATA     FLAG_0

void Flags_Action(uint8_t flag, uint8_t action);
bool Flag_Check(uint8_t flag);


#endif /* FLAGS_H_ */
