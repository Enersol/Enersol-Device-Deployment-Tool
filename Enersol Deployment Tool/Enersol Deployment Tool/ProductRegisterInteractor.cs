using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Enersol_Deployment_Tool
{
    internal struct Row
    {
        public string JRN;
        public string CN;
        public string DS;
        public string MN;
        public string MV;
        public string SN;
        public string OSV;
        public string OGUI;
        public string MD;
        public string SD;
        public string IND;
        public string NOTE;
    }
    internal class ProductRegisterInteractor
    {

        private string fileExcel;
        private Excel.Application xlapp;
        private Excel.Workbook xlworkbook;
        private Excel._Worksheet xlWorksheet;
        private Excel.Range xlRange;



        public String GetRow()
        {

            return "fart";
        }
        public bool OpenExcel()
        {
            try
            {
                fileExcel = @"C:\Users\jmari\OneDrive\Desktop\Enersol Code\Enersol-Device-Deployment-Tool\Test Product Register.xlsx";

                xlapp = new Excel.Application();
                xlworkbook = xlapp.Workbooks.Open(fileExcel, 0, true, 5, "0235", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorksheet = xlworkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;
                xlapp.Visible = true;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool CloseExcel(bool save)
        {
            try
            {
                xlworkbook.Close(save);
                xlapp.Quit();
                xlapp = null;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public String FindNextSerial(Object Model)
        {
            dynamic allDataRange = xlWorksheet.UsedRange;
            // sort file by Serial Number
            allDataRange.Sort(allDataRange.Columns[6], Excel.XlSortOrder.xlDescending);
            // Read rows till we find the first row with our desired model number
            int rowCount = xlRange.Rows.Count;
            string value = "0000";
            for (int i = 1; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, 4].Value2.ToString() == Model.ToString())
                {
                    // extract last 4 digits from the largest serial number
                    value = xlRange.Cells[i, 6].Value2.ToString();
                    break;
                }
            }
            // extract last 4 digits and increase by 1
            int number = int.Parse(value.Substring((value.Length - 4), 4)) + 1;
            return Model.ToString() + "." + number.ToString().PadLeft(4, '0');
        }
        public bool AddNewRow(Row NewRow)
        {
            try
            {
                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                xlRange.Cells[rowCount + 1, 1].Value2 = NewRow.JRN;
                xlRange.Cells[rowCount + 1, 2].Value2 = NewRow.CN;
                xlRange.Cells[rowCount + 1, 3].Value2 = NewRow.DS;
                xlRange.Cells[rowCount + 1, 4].Value2 = NewRow.MN;
                xlRange.Cells[rowCount + 1, 5].Value2 = NewRow.MV;
                xlRange.Cells[rowCount + 1, 6].Value2 = NewRow.SN;
                xlRange.Cells[rowCount + 1, 7].Value2 = NewRow.OSV;
                xlRange.Cells[rowCount + 1, 8].Value2 = NewRow.OGUI;
                xlRange.Cells[rowCount + 1, 9].SetValueFromText = NewRow.MD;
                xlRange.Cells[rowCount + 1, 10].SetValueFromText = NewRow.SD;
                xlRange.Cells[rowCount + 1, 11].Value2 = NewRow.IND;
                xlRange.Cells[rowCount + 1, 12].Value2 = NewRow.NOTE;

                return true;
            }
            catch
            {
                return false;
            } 
        }
        public bool ReadRowExcel()
        {
            return true;
        }
        public bool WriteRowExcel()
        {
            return true;
        }

    }
}
