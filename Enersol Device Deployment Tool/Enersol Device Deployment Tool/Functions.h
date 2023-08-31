#pragma once
#include <windows.h>
#include <psapi.h>
#include <tchar.h>
#include <stdio.h>
#include <string.h>
#include "Globals.h"
#include <array>

using namespace System;
using namespace System::Windows::Forms;
using namespace System::IO::Ports;
using namespace System::IO;
using namespace Globals;

#define ARRAY_SIZE 1024

//Required Drivers
// UNO - oem30.inf 
// Mega 2560 - oem30.inf
// Nano Every - oem125.inf

array<String^>^ arduinoModels()
{
	array<String^>^ models = gcnew array<String^>(deviceNumber);
	int arrSize = *(Devices + 1) - *Devices;
	for (INT i = 0; i < deviceNumber; i++)
	{
		CHAR val[20];
		strcpy(val, Devices[i]->_Name);
		models[i] = gcnew String{Devices[i]->_Name};
	}
	return models;
}

bool arduinoDriversInstalled()
{
	LPVOID drivers[ARRAY_SIZE];
	DWORD cbNeeded;
	int cDrivers, i;
	TCHAR commonDriver[20];
	_tcscpy(commonDriver, _T("oem30.inf"));

	if (EnumDeviceDrivers(drivers, sizeof(drivers), &cbNeeded) && cbNeeded < sizeof(drivers))
	{
		TCHAR szDriver[ARRAY_SIZE];

		cDrivers = cbNeeded / sizeof(drivers[0]);

		for (i = 0; i < cDrivers; i++)
		{
			if (GetDeviceDriverBaseName(drivers[i], szDriver, sizeof(szDriver) / sizeof(szDriver[0])))
			{
				char conDriver[ARRAY_SIZE];
				wcstombs(conDriver, szDriver, wcslen(szDriver) + 1);
				char cmd[ARRAY_SIZE];
				strcat(cmd, "/K echo ");
				strcat(cmd, conDriver);
				System::Diagnostics::Process^ myCommand = gcnew System::Diagnostics::Process;
				myCommand->StartInfo->UseShellExecute = false;
				myCommand->StartInfo->FileName = "CMD.exe";
				System::String^ scmd = gcnew String(cmd);
				myCommand->StartInfo->Arguments = scmd;
				//myCommand->Start();


				if (_tcscmp(szDriver, commonDriver) == 0)
				{
					char conDriver[ARRAY_SIZE];
					wcstombs(conDriver, szDriver, wcslen(szDriver) + 1);
					char cmd[ARRAY_SIZE];
					strcat(cmd, "/K echo ");
					strcat(cmd, conDriver);
					System::Diagnostics::Process^ myCommand = gcnew System::Diagnostics::Process;
					myCommand->StartInfo->UseShellExecute = false;
					myCommand->StartInfo->FileName = "CMD.exe";
					System::String^ scmd = gcnew String(cmd);
					myCommand->StartInfo->Arguments = scmd;
					myCommand->Start();

					return true;
				}
			}
		}
	}
	return false;
}


String^ whichProgramString(ComboBox^ port, TextBox^ hexFile, ComboBox^ device)
{
	System::String^ dev = "" + device->SelectedItem;
	int i = 0;
	for (i; i < deviceNumber; i++)
	{
		String^ _devices = gcnew String(Devices[i]->_Name);
		if (!String::Compare(_devices,dev))
		{
			break;
		}
	}
	String^ SelectedDevice = gcnew String(Devices[i]->_Controller);
	if (!String::Compare(SelectedDevice, ARDUNO))
	{
		return "/K C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/avrdude/6.3.0-arduino17/bin/avrdude -C C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/avrdude/6.3.0-arduino17/etc/avrdude.conf -v -p " + ARDUNOMIC + " -c " + ARDUNOPROG + " -P " + port->SelectedItem + " -b 115200 -D -U flash:w:\"" + hexFile->Text + "\":i";
	}
	else if (!String::Compare(SelectedDevice, ARDNANOEVE))
	{
		return "/K C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/avrdude/6.3.0-arduino17/bin/avrdude -C C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/avrdude/6.3.0-arduino17/etc/avrdude.conf -v -p " + ARDNANOEVEMIC + " -c " + ARDNANOEVEPROG + " -P " + port->SelectedItem + " -b 115200 -e -D -Uflash:w:\"" + hexFile->Text + "\":i -Ufuse2:w:0x01:m -Ufuse5:w:0xC9:m -Ufuse8:w:0x00:m {upload.extra_files}";
	}
	else if(!String::Compare(SelectedDevice, ARDMEGA))
	{
		return "/K C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/avrdude/6.3.0-arduino17/bin/avrdude -C C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/avrdude/6.3.0-arduino17/etc/avrdude.conf -v -p " + ARDMEGAMIC + " -c " + ARDMEGAPROG + " -P " + port->SelectedItem + " -b 115200 -D -U flash:w:\"" + hexFile->Text + "\":i";
	}
	else
	{
		return "ERROR";
	}

}



void cmdUploadFirmware(ComboBox^ port, TextBox^ hexFile, ComboBox^ device)
{
	if (port->SelectedItem != "" && hexFile->Text != "" && device->SelectedItem != "")
	{
		System::String^ cmd =  whichProgramString(port, hexFile, device);
		System::Diagnostics::Process^ myCommand = gcnew System::Diagnostics::Process;
		myCommand->StartInfo->UseShellExecute = false;
		myCommand->StartInfo->FileName = "CMD.exe";
		myCommand->StartInfo->Arguments = cmd;
		myCommand->Start();
	}
}

void cmdInstallDrivers()
{
	System::String^ cmd = "/K pnputil /add-driver C:/\"Program Files\"/Enersol/\"Enersol Firmware Update Tool\"/drivers/*.inf";
	System::Diagnostics::Process^ myCommand = gcnew System::Diagnostics::Process;
	myCommand->StartInfo->UseShellExecute = false;
	myCommand->StartInfo->FileName = "CMD.exe";
	myCommand->StartInfo->Arguments = cmd;
	myCommand->Start();
}

array<Object^>^ findPorts()
{
	return System::IO::Ports::SerialPort::GetPortNames();
}

void openFile(TextBox^ hexFile)
{
	Stream^ myStream;
	OpenFileDialog^ openFileDialog1 = gcnew OpenFileDialog;

	openFileDialog1->InitialDirectory = "c:\\";
	openFileDialog1->Filter = "Hex Files |*.hex";
	openFileDialog1->FilterIndex = 2;
	openFileDialog1->RestoreDirectory = true;

	if (openFileDialog1->ShowDialog() == System::Windows::Forms::DialogResult::OK)
	{
		if ((myStream = openFileDialog1->OpenFile()) != nullptr)
		{
			hexFile->Text = openFileDialog1->FileName;
			myStream->Close();
		}
	}
}