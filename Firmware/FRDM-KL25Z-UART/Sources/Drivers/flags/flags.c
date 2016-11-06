/*
 * flags.c
 *
 *  Created on: Nov 6, 2016
 *      Author: Evandro
 */

#include "flags.h"
/******************************************************************************/
//
/******************************************************************************/
static uint8_t Flag_Var  = 0;
/******************************************************************************/
//
/******************************************************************************/
void Flags_Action(uint8_t flag, uint8_t action)
{
	switch(flag)
	{
		case FLAG_0:
				if(action == SET)
				{
						Flag_Var |= FLAG_0;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_0;
				}
		break;

		case FLAG_1:
				if(action == SET)
				{
						Flag_Var |= FLAG_1;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_1;
				}
		break;

		case FLAG_2:
				if(action == SET)
				{
						Flag_Var |= FLAG_2;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_2;
				}
		break;

		case FLAG_3:
				if(action == SET)
				{
						Flag_Var |= FLAG_3;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_3;
				}
		break;

		case FLAG_4:
				if(action == SET)
				{
						Flag_Var |= FLAG_4;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_4;
				}
		break;

		case FLAG_5:
				if(action == SET)
				{
						Flag_Var |= FLAG_5;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_5;
				}
		break;

		case FLAG_6:
				if(action == SET)
				{
						Flag_Var |= FLAG_6;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_6;
				}
		break;

		case FLAG_7:
				if(action == SET)
				{
						Flag_Var |= FLAG_7;
				}
				if(action == RESET)
				{
						Flag_Var &= ~FLAG_7;
				}
		break;
	}
}
/******************************************************************************/
//
/******************************************************************************/
bool Flag_Check(uint8_t flag)
{
    uint8_t var_flag;
    switch(flag)
    {
		case FLAG_0:
		var_flag = Flag_Var & FLAG_0;
		if(var_flag==FLAG_0)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;

		case FLAG_1:
		var_flag = Flag_Var & FLAG_1;
		if(var_flag==FLAG_1)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;

		case FLAG_2:
		var_flag = Flag_Var & FLAG_2;
		if(var_flag==FLAG_2)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;

		case FLAG_3:
		var_flag = Flag_Var & FLAG_3;
		if(var_flag==FLAG_3)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;

		case FLAG_4:
		var_flag = Flag_Var & FLAG_4;
		if(var_flag==FLAG_4)
				return TRUE;
		else
				return FALSE;
		break;

		case FLAG_5:
		var_flag = Flag_Var & FLAG_5;
		if(var_flag==FLAG_5)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;

		case FLAG_6:
		var_flag = Flag_Var & FLAG_6;
		if(var_flag==FLAG_6)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;

		case FLAG_7:
		var_flag = Flag_Var & FLAG_7;
		if(var_flag==FLAG_7)
		{
				return TRUE;
		}
		else
		{
				return FALSE;
		}
		break;
    }
}
/******************************************************************************/


