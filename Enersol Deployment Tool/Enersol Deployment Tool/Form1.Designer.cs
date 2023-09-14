using System;
using System.Windows.Forms;

namespace Enersol_Deployment_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.JRLabel = new System.Windows.Forms.Label();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.DistLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ShipLabel = new System.Windows.Forms.Label();
            this.CommLabel = new System.Windows.Forms.Label();
            this.JobRecordInput = new System.Windows.Forms.TextBox();
            this.CustomerNameInput = new System.Windows.Forms.TextBox();
            this.DistributerInput = new System.Windows.Forms.TextBox();
            this.ModelDeviceInput = new System.Windows.Forms.ComboBox();
            this.ShippingDateInput = new System.Windows.Forms.DateTimePicker();
            this.CommentsInput = new System.Windows.Forms.TextBox();
            this.PageDescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CnclButton = new System.Windows.Forms.Button();
            this.UsersNameInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SNLabel = new System.Windows.Forms.Label();
            this.SerialNumberText = new System.Windows.Forms.TextBox();
            this.IsFuckedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JRLabel
            // 
            this.JRLabel.AutoSize = true;
            this.JRLabel.Location = new System.Drawing.Point(10, 56);
            this.JRLabel.Name = "JRLabel";
            this.JRLabel.Size = new System.Drawing.Size(115, 13);
            this.JRLabel.TabIndex = 0;
            this.JRLabel.Text = "Job Record Number * :";
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Location = new System.Drawing.Point(211, 56);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(95, 13);
            this.CustNameLabel.TabIndex = 1;
            this.CustNameLabel.Text = "Customer Name * :";
            // 
            // DistLabel
            // 
            this.DistLabel.AutoSize = true;
            this.DistLabel.Location = new System.Drawing.Point(211, 95);
            this.DistLabel.Name = "DistLabel";
            this.DistLabel.Size = new System.Drawing.Size(91, 13);
            this.DistLabel.TabIndex = 2;
            this.DistLabel.Text = "Distributer/Seller :";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(10, 95);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(88, 13);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model/Device * :";
            // 
            // ShipLabel
            // 
            this.ShipLabel.AutoSize = true;
            this.ShipLabel.Location = new System.Drawing.Point(10, 135);
            this.ShipLabel.Name = "ShipLabel";
            this.ShipLabel.Size = new System.Drawing.Size(80, 13);
            this.ShipLabel.TabIndex = 4;
            this.ShipLabel.Text = "Shipping Date :";
            // 
            // CommLabel
            // 
            this.CommLabel.AutoSize = true;
            this.CommLabel.Location = new System.Drawing.Point(10, 174);
            this.CommLabel.Name = "CommLabel";
            this.CommLabel.Size = new System.Drawing.Size(62, 13);
            this.CommLabel.TabIndex = 5;
            this.CommLabel.Text = "Comments :";
            // 
            // JobRecordInput
            // 
            this.JobRecordInput.Location = new System.Drawing.Point(13, 72);
            this.JobRecordInput.Name = "JobRecordInput";
            this.JobRecordInput.Size = new System.Drawing.Size(189, 20);
            this.JobRecordInput.TabIndex = 6;
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Location = new System.Drawing.Point(214, 72);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(240, 20);
            this.CustomerNameInput.TabIndex = 7;
            // 
            // DistributerInput
            // 
            this.DistributerInput.Location = new System.Drawing.Point(214, 112);
            this.DistributerInput.Name = "DistributerInput";
            this.DistributerInput.Size = new System.Drawing.Size(240, 20);
            this.DistributerInput.TabIndex = 8;
            // 
            // ModelDeviceInput
            // 
            this.ModelDeviceInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelDeviceInput.FormattingEnabled = true;
            this.ModelDeviceInput.Location = new System.Drawing.Point(13, 111);
            this.ModelDeviceInput.Name = "ModelDeviceInput";
            this.ModelDeviceInput.Size = new System.Drawing.Size(189, 21);
            this.ModelDeviceInput.TabIndex = 9;
            // 
            // ShippingDateInput
            // 
            this.ShippingDateInput.Location = new System.Drawing.Point(13, 151);
            this.ShippingDateInput.Name = "ShippingDateInput";
            this.ShippingDateInput.Size = new System.Drawing.Size(189, 20);
            this.ShippingDateInput.TabIndex = 10;
            // 
            // CommentsInput
            // 
            this.CommentsInput.Location = new System.Drawing.Point(13, 190);
            this.CommentsInput.Multiline = true;
            this.CommentsInput.Name = "CommentsInput";
            this.CommentsInput.Size = new System.Drawing.Size(441, 62);
            this.CommentsInput.TabIndex = 11;
            // 
            // PageDescriptionLabel
            // 
            this.PageDescriptionLabel.AutoSize = true;
            this.PageDescriptionLabel.Location = new System.Drawing.Point(6, 20);
            this.PageDescriptionLabel.Name = "PageDescriptionLabel";
            this.PageDescriptionLabel.Size = new System.Drawing.Size(442, 26);
            this.PageDescriptionLabel.TabIndex = 12;
            this.PageDescriptionLabel.Text = "This application is for the deployment of new Enersol devices which contain micro" +
    "controllers.\r\nPlease complete this form with the correct information. Deatils wi" +
    "th an * are compulsory.\r\n";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(211, 135);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(124, 13);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Your Name (First Last) * :";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(292, 322);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 23);
            this.NextButton.TabIndex = 14;
            this.NextButton.Text = "Check";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CnclButton
            // 
            this.CnclButton.Location = new System.Drawing.Point(382, 322);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(84, 23);
            this.CnclButton.TabIndex = 15;
            this.CnclButton.Text = "Cancel";
            this.CnclButton.UseVisualStyleBackColor = true;
            this.CnclButton.Click += new System.EventHandler(this.CnclButton_Click);
            // 
            // UsersNameInput
            // 
            this.UsersNameInput.Location = new System.Drawing.Point(214, 151);
            this.UsersNameInput.Name = "UsersNameInput";
            this.UsersNameInput.Size = new System.Drawing.Size(240, 20);
            this.UsersNameInput.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PageDescriptionLabel);
            this.groupBox1.Controls.Add(this.UsersNameInput);
            this.groupBox1.Controls.Add(this.CommentsInput);
            this.groupBox1.Controls.Add(this.JRLabel);
            this.groupBox1.Controls.Add(this.CustNameLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.DistLabel);
            this.groupBox1.Controls.Add(this.ModelLabel);
            this.groupBox1.Controls.Add(this.ShippingDateInput);
            this.groupBox1.Controls.Add(this.ShipLabel);
            this.groupBox1.Controls.Add(this.ModelDeviceInput);
            this.groupBox1.Controls.Add(this.CommLabel);
            this.groupBox1.Controls.Add(this.DistributerInput);
            this.groupBox1.Controls.Add(this.JobRecordInput);
            this.groupBox1.Controls.Add(this.CustomerNameInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 258);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Details";
            // 
            // BackButton
            // 
            this.BackButton.Enabled = false;
            this.BackButton.Location = new System.Drawing.Point(202, 322);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 23);
            this.BackButton.TabIndex = 18;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNLabel.Location = new System.Drawing.Point(21, 289);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(197, 20);
            this.SNLabel.TabIndex = 33;
            this.SNLabel.Text = "Avaliable Serial Number # :";
            // 
            // SerialNumberText
            // 
            this.SerialNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumberText.Location = new System.Drawing.Point(226, 286);
            this.SerialNumberText.Name = "SerialNumberText";
            this.SerialNumberText.ReadOnly = true;
            this.SerialNumberText.Size = new System.Drawing.Size(240, 26);
            this.SerialNumberText.TabIndex = 34;
            // 
            // IsFuckedLabel
            // 
            this.IsFuckedLabel.AutoSize = true;
            this.IsFuckedLabel.Location = new System.Drawing.Point(21, 313);
            this.IsFuckedLabel.Name = "IsFuckedLabel";
            this.IsFuckedLabel.Size = new System.Drawing.Size(35, 13);
            this.IsFuckedLabel.TabIndex = 35;
            this.IsFuckedLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 357);
            this.Controls.Add(this.IsFuckedLabel);
            this.Controls.Add(this.SerialNumberText);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SNLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.NextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enersol Deployment Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JRLabel;
        private System.Windows.Forms.Label CustNameLabel;
        private System.Windows.Forms.Label DistLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ShipLabel;
        private System.Windows.Forms.Label CommLabel;
        private System.Windows.Forms.TextBox JobRecordInput;
        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.TextBox DistributerInput;
        private System.Windows.Forms.ComboBox ModelDeviceInput;
        private System.Windows.Forms.DateTimePicker ShippingDateInput;
        private System.Windows.Forms.TextBox CommentsInput;
        private System.Windows.Forms.Label PageDescriptionLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CnclButton;
        private System.Windows.Forms.TextBox UsersNameInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BackButton;

        private byte PageNumber = 1;

        System.Object[] Models = new System.Object[12];

        private Label SNLabel;
        private TextBox SerialNumberText;
        private Label IsFuckedLabel;


        //private string jrnumber;
        //private string customername;
        //private string modeldevice;
        //private string distributorseller;
        //private datetime shippingdate = new datetime();
        //private string username;
        //private string comments;

    }
}

