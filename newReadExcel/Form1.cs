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
using System.IO;
/*
 resources: https://www.c-sharpcorner.com/UploadFile/mahesh/openfiledialog-in-C-Sharp/
 */

namespace newReadExcel
{
    public partial class Form1 : Form
    {
        public static int rowCount, colCount;
        public static int startCol, endCol;
        public static string[,] excel_values;
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;
        string file_path;
        public Form1()
        {
            AllocConsole();
            InitializeComponent();
            Shown += Form1_Shown;
        }
        /*
         * Open console in Windows C# Form.
         https://stackoverflow.com/questions/18601515/how-to-use-console-writeline-in-windows-forms-application
         */
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        /*
         Occurs before a form is displayed for the first time.
         */
        private void Form1_Load(object sender, System.EventArgs e)
        {
          
        }
        string io_dir_text;
        /*
         
         https://stackoverflow.com/questions/7462748/how-to-run-code-when-form-is-shown
        */
        string temp_txt_path;
        private void Form1_Shown(object sender, System.EventArgs e)
        {
            temp_txt_path = Application.StartupPath + @"working_dir_path.txt";
            io_dir_text = System.IO.File.ReadAllText(temp_txt_path);
            txt_filedir.Text = io_dir_text;
            file_path = io_dir_text;
            txt_input.Text = "2019-";
            readExcelFile();
            /*
             move this code block to here to be effective
             */
            startCol = 1;
            endCol = 3;
        }
        private void read_Click(object sender, EventArgs e)
        {
            readExcelFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_show2.Text = "";
            string input_txt_read = txt_input.Text;
            string[] decode_first_col = new string[rowCount];
            /*
             * https://stackoverflow.com/questions/27427527/how-to-get-a-complete-row-or-column-from-2d-array-in-c-sharp
             * To get a complete row out of an multi-dimensional array, you have to loop
             */
            for (int k=0; k < rowCount; k++)
            {
                decode_first_col[k] = excel_values[k, startCol];
               // Console.WriteLine(decode_first_col[k].ToString());
            }
            int index = Array.IndexOf(decode_first_col, input_txt_read);
            if (decode_first_col.Contains(input_txt_read))
            {
                lb_out_stt.Text = "The output value for input " + input_txt_read + " is:";
                txt_show2.Text = excel_values[index, startCol+1];
                
               // lb_out_stt.Text = "The output value for input " + input_txt_read + " is:";
            }
            else
            {
                lb_out_stt.Text = "Can't find a match";
                txt_show2.Text = "NaN";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_show2.Text);
            txt_show2.Text = "";
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\nguye\Downloads\Excel_file_ws\fileio_excel_ws\newReadExcel";
            /*
             To be opened Supported files
             */
            openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != file_path)
                {
                    file_path = openFileDialog1.FileName;
                    txt_filedir.Text = openFileDialog1.FileName;
                    /*
                     if file dir is changed, perform readExcel
                     */
                    readExcelFile();
                    /*
                        https://www.c-sharpcorner.com/article/c-sharp-write-to-file/
                        Write string to the target text file
                     */
                    File.WriteAllText(temp_txt_path, file_path);

                }
            }

        }

        public void readExcelFile()
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            xlApp = new Excel.Application();
            if (System.IO.File.Exists(file_path)) {
                xlWorkbook = xlApp.Workbooks.Open(file_path, ReadOnly:true, Password: "m3e");
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;
                rowCount = xlRange.Rows.Count;
                colCount = xlRange.Columns.Count;
                Console.WriteLine(rowCount.ToString());
                Console.WriteLine(colCount.ToString());
                excel_values = new string[rowCount, colCount];
                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                Console.WriteLine("Start reading data from a new excel file");
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (xlRange.Cells[i, j] != null && ((Excel.Range)xlRange.Cells[i, j]).Value2 != null)
                        {
                            excel_values[i - 1, j - 1] = ((Excel.Range)xlRange.Cells[i, j]).Value2.ToString();
                            // Console.WriteLine(excel_values[i - 1, j - 1].ToString());
                        }
                    }
                }
                Console.WriteLine("Reading new file done");
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();
                /*
                 * rule of thumb for releasing com objects:
                 * never use two dots, all COM objects must be referenced and released individually
                  * ex: [somthing].[something].[something] is bad
                */
                //Console.WriteLine(excel_values[0, 0] + excel_values[1, 1]);
                //close and release
                xlWorkbook.Close();
                //quit and release
                xlApp.Quit();
            }
        }


    }
}
