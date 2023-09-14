#pragma once
#include "Functions.h"
#include "DeviceClass.h"
#include "Globals.h"


namespace EnersolFirmwareUpdateTool {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;

	//using namespace System::Windows::Forms::FileDialog;

	/// <summary>
	/// Summary for Form1
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}
	protected:

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ bNext0;
	protected:

	protected:
	private: System::Windows::Forms::Button^ bQuit;

	private: System::Windows::Forms::ComboBox^ cbComPorts;

	private: System::Windows::Forms::Button^ bComSearch;
	private: System::Windows::Forms::Label^ label1;
	private: System::IO::Ports::SerialPort^ serialPort1;



	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::OpenFileDialog^ openFileDialog1;
	private: System::Windows::Forms::SaveFileDialog^ saveFileDialog1;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::ComboBox^ cbArduinoSelect;

	private: System::ComponentModel::IContainer^ components;

	protected:




	protected:

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->bNext0 = (gcnew System::Windows::Forms::Button());
			this->bQuit = (gcnew System::Windows::Forms::Button());
			this->cbComPorts = (gcnew System::Windows::Forms::ComboBox());
			this->bComSearch = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->serialPort1 = (gcnew System::IO::Ports::SerialPort(this->components));
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			this->saveFileDialog1 = (gcnew System::Windows::Forms::SaveFileDialog());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->cbArduinoSelect = (gcnew System::Windows::Forms::ComboBox());
			this->SuspendLayout();
			// 
			// bNext0
			// 
			this->bNext0->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Bottom | System::Windows::Forms::AnchorStyles::Right));
			this->bNext0->Location = System::Drawing::Point(168, 196);
			this->bNext0->Name = L"bNext0";
			this->bNext0->Size = System::Drawing::Size(70, 23);
			this->bNext0->TabIndex = 0;
			this->bNext0->Text = L"Next";
			this->bNext0->UseVisualStyleBackColor = true;
			this->bNext0->Click += gcnew System::EventHandler(this, &Form1::bUpload_Click);
			// 
			// bQuit
			// 
			this->bQuit->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Bottom | System::Windows::Forms::AnchorStyles::Right));
			this->bQuit->Location = System::Drawing::Point(244, 196);
			this->bQuit->Name = L"bQuit";
			this->bQuit->Size = System::Drawing::Size(70, 23);
			this->bQuit->TabIndex = 1;
			this->bQuit->Text = L"Quit";
			this->bQuit->UseVisualStyleBackColor = true;
			this->bQuit->Click += gcnew System::EventHandler(this, &Form1::bQuit_Click);
			// 
			// cbComPorts
			// 
			this->cbComPorts->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->cbComPorts->FormattingEnabled = true;
			this->cbComPorts->Location = System::Drawing::Point(12, 102);
			this->cbComPorts->Name = L"cbComPorts";
			this->cbComPorts->Size = System::Drawing::Size(150, 21);
			this->cbComPorts->TabIndex = 3;
			// 
			// bComSearch
			// 
			this->bComSearch->Anchor = static_cast<System::Windows::Forms::AnchorStyles>(((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->bComSearch->Location = System::Drawing::Point(168, 101);
			this->bComSearch->Name = L"bComSearch";
			this->bComSearch->Size = System::Drawing::Size(146, 21);
			this->bComSearch->TabIndex = 4;
			this->bComSearch->Text = L"Com Port Search";
			this->bComSearch->UseVisualStyleBackColor = true;
			this->bComSearch->Click += gcnew System::EventHandler(this, &Form1::bComSearch_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(9, 86);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(56, 13);
			this->label1->TabIndex = 5;
			this->label1->Text = L"Com Port: ";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(9, 9);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(316, 26);
			this->label3->TabIndex = 8;
			this->label3->Text = L"Please complete the following information to create a new Enersol\r\ndevice.";
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"openFileDialog1";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(9, 46);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(47, 13);
			this->label4->TabIndex = 10;
			this->label4->Text = L"Device: ";
			// 
			// cbArduinoSelect
			// 
			this->cbArduinoSelect->DropDownStyle = System::Windows::Forms::ComboBoxStyle::DropDownList;
			this->cbArduinoSelect->FormattingEnabled = true;
			this->cbArduinoSelect->Location = System::Drawing::Point(12, 62);
			this->cbArduinoSelect->Name = L"cbArduinoSelect";
			this->cbArduinoSelect->Size = System::Drawing::Size(302, 21);
			this->cbArduinoSelect->TabIndex = 9;
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(326, 231);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->cbArduinoSelect);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->bComSearch);
			this->Controls->Add(this->cbComPorts);
			this->Controls->Add(this->bQuit);
			this->Controls->Add(this->bNext0);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"Form1";
			this->Text = L"Enersol Device Deployment Tool";
			this->Load += gcnew System::EventHandler(this, &Form1::Form1_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

		// Component functions
		private: System::Void bQuit_Click(System::Object^ sender, System::EventArgs^ e);
		private: System::Void bComSearch_Click(System::Object^ sender, System::EventArgs^ e);
		private: System::Void bUpload_Click(System::Object^ sender, System::EventArgs^ e);
		private: System::Void Form1_Load(System::Object^ sender, System::EventArgs^ e);
		private: System::Void bBrowse_Click(System::Object^ sender, System::EventArgs^ e);
	}
}

