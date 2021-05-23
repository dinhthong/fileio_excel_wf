using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace newReadExcel
{
    public partial class Form1 : Form
    {
        public static int rowCount, colCount;
        public static string[,] decode;
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Occurs before a form is displayed for the first time.
         */
        private void Form1_Load(object sender, System.EventArgs e)
        {
            getExcelFile();
        }
        private void read_Click(object sender, EventArgs e)
        {
            getExcelFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_txt_read = txt_input.Text;

            //string text = txt_input.Text;
            //input_txt_read = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void getExcelFile()
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\nguye\Downloads\Excel_file\FileIO_Excel\newReadExcel"+ @"/test3.xlsx");
            //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Cuahang_ap\Database.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            rowCount = xlRange.Rows.Count;
            colCount = xlRange.Columns.Count;
            decode = new string[rowCount, colCount];
            //iterate over the rows and columns and print to the console as it appears in the file
            //excel is not zero based!!
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (xlRange.Cells[i, j] != null && ((Excel.Range)xlRange.Cells[i, j]).Value2 != null)
                    {
                        decode[i - 1, j - 1] = ((Excel.Range)xlRange.Cells[i, j]).Value2.ToString();
                        richTextBox1.Text += Environment.NewLine + decode[i - 1, j - 1];
                    }
                }
            }
      //      xlRange.Cells[9, 8].Value2 = "hello";
      //      xlRange.Cells[9, 15].Value2 = "hello2";
            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad
            Console.WriteLine(decode[0, 0] + decode[1, 1]);
            //close and release
            xlWorkbook.Close();
            //quit and release
            xlApp.Quit();
        }

    }
}
