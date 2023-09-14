using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Enersol_Deployment_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            // Initialisers

            Models[0] = "S77.02";
            Models[1] = "S77A.03";
            Models[2] = "S77B.03";
            Models[3] = "S78.02";
            Models[4] = "S78A.03";
            Models[5] = "S78B.03";
            Models[6] = "AWPSIT.MC.01";
            Models[7] = "AWPSIT.FC.01";
            Models[8] = "ELTP.01";
            Models[9] = "VLT.02";
            Models[10] = "S18C.01";
            Models[11] = "S79.01";

            ModelDeviceInput.Items.AddRange(Models);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // If Required information has been supplied we can progress to the next page.
            if (PageNumber == 1 && (sender as System.Windows.Forms.Button).Text == "Check")
            {
                if (
                    JobRecordInput.Text.Length > 0 &&
                    CustomerNameInput.Text.Length > 0 &&
                    ModelDeviceInput.Text.Length > 0 &&
                    UsersNameInput.Text.Length > 0
                    )
                {
                    BackButton.Enabled = true; // Show Back 
                    JobRecordInput.Enabled = false;
                    CustomerNameInput.Enabled = false;
                    ModelDeviceInput.Enabled = false;
                    DistributerInput.Enabled = false;   
                    ShippingDateInput.Enabled = false;
                    UsersNameInput.Enabled = false;
                    CommentsInput.Enabled = false;
                    SerialNumberText.Text = SerialNumberFinder(ModelDeviceInput.Text);
                    NextButton.Text = "Save";

                }
                else
                {
                    SerialNumberText.Text = "Please Complete Form";
                }
            }
            else
            {
                SaveNewDevice();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (PageNumber == 1)
            {
                BackButton.Enabled = false; // Show Back 
                JobRecordInput.Enabled = true;
                CustomerNameInput.Enabled = true;
                ModelDeviceInput.Enabled = true;
                DistributerInput.Enabled = true;
                ShippingDateInput.Enabled = true;
                UsersNameInput.Enabled = true;
                CommentsInput.Enabled = true;
                SerialNumberText.Text = "";
                NextButton.Text = "Check";

            }
            else 
            {
                //ChangeGroupBox(false);
            }
        }

        //private void ChangeGroupBox(bool Forward)
        //{
        //    int size = Pages.Length;
        //    this.Pages[PageNumber-1].Hide();
        //    if (Forward)
        //    {
        //        if (size > PageNumber) { PageNumber++; }
        //    }
        //    else
        //    {
        //        if (PageNumber>1){ PageNumber--; }
        //    }
        //    this.Pages[PageNumber-1].Show();

        //}
        private string SerialNumberFinder(object ModelNumber)
        {
            ProductRegisterInteractor ProdReg = new ProductRegisterInteractor();
            // Open Product Register
            ProdReg.OpenExcel();
            // Find the next avaliable serial number.
            string ser = ProdReg.FindNextSerial(ModelNumber);
            // close excel
            ProdReg.CloseExcel(false);
            return ser;
        }
        private bool SaveNewDevice()
        {
            try
            {
                Row NewDevice = new Row();
                NewDevice.JRN = JobRecordInput.Text;
                NewDevice.CN = CustomerNameInput.Text;
                NewDevice.DS = DistributerInput.Text;
                NewDevice.MN = ModelDeviceInput.Text;
                NewDevice.MV = "";
                NewDevice.SN = SerialNumberText.Text;
                NewDevice.OSV = "Not Sorted Yet";
                NewDevice.OGUI = "Not Sorted Yet";
                DateTime myDate = DateTime.Now;
                NewDevice.MD = myDate.ToString("dd/MM/yyyy");
                NewDevice.SD = ShippingDateInput.Text;
                NewDevice.IND = UsersNameInput.Text;
                NewDevice.NOTE = CommentsInput.Text;
                ProductRegisterInteractor ProdReg = new ProductRegisterInteractor();
                // Open Product Register
                ProdReg.OpenExcel();
                // Find the next avaliable serial number.
                bool worked = ProdReg.AddNewRow(NewDevice);
                // close excel
                if (worked) { ProdReg.CloseExcel(true); } 
                else { ProdReg.CloseExcel(false); }

                return worked;
            } catch { return false; }

        }

        private void CnclButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
