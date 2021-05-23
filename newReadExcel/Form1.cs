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
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;
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
            string[] decode_first_col = new string[rowCount];
            /*
             * https://stackoverflow.com/questions/27427527/how-to-get-a-complete-row-or-column-from-2d-array-in-c-sharp
             * To get a complete row out of an multi-dimensional array, you have to loop
             */
            for (int k=0; k < rowCount; k++)
            {
                decode_first_col[k] = decode[k, 0];
            }
            int index = Array.IndexOf(decode_first_col, input_txt_read);

            txt_show2.Text = decode[index, 1];
            Console.WriteLine(index.ToString());
            //string text = txt_input.Text;
            //input_txt_read = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void getExcelFile()
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            xlApp = new Excel.Application();
            xlWorkbook = xlApp.Workbooks.Open(@"C:/Users/nguye/Downloads/Excel_file/fileio_excel_ws/newReadExcel" + @"/test3.xlsx");
            xlWorksheet = xlWorkbook.Sheets[1];
            xlRange = xlWorksheet.UsedRange;
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
            //Console.WriteLine(decode[0, 0] + decode[1, 1]);
            //close and release
            xlWorkbook.Close();
            //quit and release
            xlApp.Quit();
        }


    }
}
