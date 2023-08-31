#pragma once
#include "DeviceClass.h"
#include <windows.h>
#include <string.h>
#include <stdio.h>

#define ARDUNO "Arduino Uno"
#define ARDUNOMIC "ATmega328P"
#define ARDUNOPROG "arduino" 
#define ARDNANOEVE "Arduino Nano Every"
#define ARDNANOEVEMIC "atmega4809"
#define ARDNANOEVEPROG "jtag2updi"
#define ARDMEGA "Arduino Mega 2560"
#define ARDMEGAMIC "atmega2560"
#define ARDMEGAPROG "wiring"

// Device list
#define deviceNumber 11

#define S77 "S77"
#define S77A "S77A"
#define S77B "S77B"
#define S78 "S78"
#define S78A "S78A"
#define S78B "S78B"
#define VLT "VLT"
#define ELTP "ELTPlus"
#define S18C "S18C"
#define S79 "S79"
#define AWPSIT "AWPSIT"

#define textLength 20

namespace Globals 
{
	using namespace System;

	extern Device _S77;
	extern Device _S77A;
	extern Device _S77B;
	extern Device _S78;
	extern Device _S78A;
	extern Device _S78B;
	extern Device _S79;
	extern Device _VLT;
	extern Device _AWPSIT;
	extern Device _ELTP;
	extern Device _S18C;
	extern Device* Devices[deviceNumber];
}