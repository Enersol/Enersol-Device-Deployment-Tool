#include "Form1.h"


using namespace System;
using namespace System::Windows::Forms;

//array<System::String^, 2>^ deviceTypes = { {"Arduino Uno", "ATmega328P"}, { "Arduino Mega 2560", "atmega2560" }, { "Arduino Nano Every","atmega4809" }};


[STAThread]
void main(array<String^>^ args)
{
	//Check to see that the DPint-amd64 has been installed.
	//if (!arduinoDriversInstalled())
	//{
	//	cmdInstallDrivers();
	//}
	//else 
	//{
		Application::EnableVisualStyles();
		Application::SetCompatibleTextRenderingDefault(false);
		EnersolFirmwareUpdateTool::Form1 form;
		Application::Run(% form);
	//}
}

namespace EnersolFirmwareUpdateTool
{
	System::Void Form1::bQuit_Click(System::Object^ sender, System::EventArgs^ e)
	{
		this->Close();
	}
	System::Void Form1::bComSearch_Click(System::Object^ sender, System::EventArgs^ e)
	{
		this->cbComPorts->Items->Clear();
		this->cbComPorts->Items->AddRange(findPorts());
	}
	System::Void Form1::bUpload_Click(System::Object^ sender, System::EventArgs^ e)
	{
		cmdUploadFirmware(cbComPorts, tbHexFile, cbArduinoSelect);
	}
	System::Void Form1::Form1_Load(System::Object^ sender, System::EventArgs^ e)
	{
		this->cbComPorts->Items->AddRange(findPorts());
		this->cbArduinoSelect->Items->AddRange(arduinoModels());
		//arduinoModels();

	}
	System::Void Form1::bBrowse_Click(System::Object^ sender, System::EventArgs^ e)
	{
		openFile(tbHexFile);
	}
}