#pragma once
#include <windows.h>
#include <string.h>
#include <stdio.h>

using namespace System;

#define textLength 20

class Device
{
public:
	Device() {};
	Device(CHAR name[], CHAR con[], CHAR chip[], CHAR usbdri[])
	{
		strcpy(_Name, name);
		strcpy(_Controller, con);
		strcpy(_uChip, chip);
		strcpy(_usbDriver, usbdri);
	}
	CHAR _Name[textLength];
	CHAR _Controller[textLength];
	CHAR _uChip[textLength];
	CHAR _usbDriver[textLength];
};