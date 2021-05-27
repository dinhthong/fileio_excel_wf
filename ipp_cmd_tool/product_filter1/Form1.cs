using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Linq;
using System.Configuration;
//using SavingUserSettings.Properties;

namespace product_filter1
{
    public partial class ipp_cmd_tool : Form
    {
        List<string> SerialList = new List<string>();
        public static int rowCount, colCount;
        public static int startCol, endCol;
        public static string[,] excel_values;
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;
        string ex_file_path;
        string io_dir_text;
        string config_file_name = "ipp_program_config.txt";
        //string op_template_text;
        /*
         
         https://stackoverflow.com/questions/7462748/how-to-run-code-when-form-is-shown
        */
        string config_txt_path;
        public ipp_cmd_tool()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        private void txt_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            txt_show.Text = "";
            string input_txt_read = txt_input_serial.Text;
            /*
             * https://stackoverflow.com/questions/27427527/how-to-get-a-complete-row-or-column-from-2d-array-in-c-sharp
             * To get a complete row out of an multi-dimensional array, you have to loop
             */

            int index = SerialList.IndexOf(input_txt_read);
            if (index != -1)
            {
                txt_show.Text = excel_values[index, startCol + 1];
                btn_copy.Enabled = true;
                /*
                 Position the Cursor at the Beginning or End of Text in a TextBox Control
                 */
                Clipboard.SetText(txt_show.Text);
                lb_kq.Text = "The output value for input " + input_txt_read.ToString() + " is:";
            }
            else
            {
                lb_kq.Text = "Khong tim thay";
                txt_show.Text = "NaN";
            }

            txt_input_serial.Text = Properties.Settings.Default.char_template;
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            lb_kq.Text = "";
            Clipboard.SetText(txt_show.Text);
            txt_show.Text = "";
            btn_copy.Enabled = false;
            lb_status.Text = "Copy thanh cong";
        }

        private void ipp_cmd_tool_Shown(object sender, EventArgs e)
        {
            txt_filepath.Text = Properties.Settings.Default.excel_file_path;
            ex_file_path = Properties.Settings.Default.excel_file_path;
            txt_input_serial.Text = Properties.Settings.Default.char_template;
            /*
             move this code block to here to be effective
             */
            startCol = 1;
            endCol = 3;
        }

        private void txt_input_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_read_Click(this, new EventArgs());
            }
            txt_input_serial.Select(txt_input_serial.Text.Length, 0);
        }

        private void btn_opensetting_Click(object sender, EventArgs e)
        {
            app_option settingsForm = new app_option();
            //settingsForm.FormClosed += ;
            /*
             Register Form Closing Event
             */
            // Show the settings form
            settingsForm.Show();
        }
        private void settingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txt_input_serial.Text = Properties.Settings.Default.char_template;
            Console.WriteLine("Set form closed");
        }

        private void btn_readfile_Click(object sender, EventArgs e)
        {
            readExcelFile();
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\nguye\Downloads\Excel_file_ws\fileio_excel_ws\newReadExcel";
            /*
             To be opened Supported files
             */
            openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            /*
             If the file path changes
             */
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != ex_file_path)
                {
                    
                    ex_file_path = openFileDialog1.FileName;
                    txt_filepath.Text = openFileDialog1.FileName;
                    Properties.Settings.Default.excel_file_path = ex_file_path;
                    Properties.Settings.Default.Save();
                    btn_read.Enabled = false;
                }
            }
        }


        public void readExcelFile()
        {
            string read_temp_txt;
            //Create COM Objects. Create a COM object for everything that is referenced
            xlApp = new Excel.Application();
            if (System.IO.File.Exists(ex_file_path))
            {
                string excelpass = TripleDES.Decrypt(Properties.Settings.Default.excel_password);
                try
                {
                    // If there is error when open excel, SO the excel is protected by password
                    // Excel.Workbook wb = xlApp.Workbooks.Open(filename）
                    xlWorkbook = xlApp.Workbooks.Open(ex_file_path, ReadOnly: true, Password: excelpass);
                    xlWorksheet = xlWorkbook.Sheets[1];
                    xlRange = xlWorksheet.UsedRange;
                    rowCount = xlRange.Rows.Count;
                    colCount = xlRange.Columns.Count;
                    excel_values = new string[rowCount, colCount];
                    //iterate over the rows and columns and print to the console as it appears in the file
                    //excel is not zero based!!
                    read_temp_txt = "Reading data from new file: ";
                    int read_size = rowCount * colCount;
                    int read_cnt = 0;
                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            if (xlRange.Cells[i, j] != null && ((Excel.Range)xlRange.Cells[i, j]).Value2 != null)
                            {
                                excel_values[i - 1, j - 1] = ((Excel.Range)xlRange.Cells[i, j]).Value2.ToString();
                                read_cnt++;
                                lb_status.Text = read_temp_txt + read_cnt.ToString() + "/" + read_size.ToString();
                            }
                        }
                    }
                    SerialList.Clear();
                    for (int k = 0; k < rowCount; k++)
                    {
                        SerialList.Add(excel_values[k, startCol]);
                    }
                    lb_status.Text = "Reading new file done";
                    //  Console.WriteLine("Reading new file done");
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
                }
                catch (Exception ex)
                {
                    //ex.GetType
                    Console.WriteLine(ex.HResult);
                    MessageBox.Show("May be wrong password");
                    // remove the password protected excel to a new folder
                }
                xlApp.Quit();
            }
            btn_read.Enabled = true;
        }

        //public void toExcelFile()
        //{
        //    //Create COM Objects. Create a COM object for everything that is referenced
        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(Application.StartupPath + @"\Database.xlsx");
        //    //Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Cuahang_ap\Database.xlsx");
        //    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //    Excel.Range xlRange = xlWorksheet.UsedRange;
        //    decode = new string[rowCount, colCount];
        //    rowCount = xlRange.Rows.Count;
        //    colCount = xlRange.Columns.Count;
        //    //iterate over the rows and columns and print to the console as it appears in the file
        //    //excel is not zero based!!
        //    for (int i = rowCount + 1; i <= rowCount + productList.Count; i++)
        //    {
        //        xlRange.Cells[i, 1].Value2 = productList[i-rowCount-1].Name;
        //        xlRange.Cells[i, 2].Value2 = productList[i-rowCount-1].Image_url;
        //        xlRange.Cells[i, 3].Value2 = productList[i-rowCount-1].Product_url;
        //        xlRange.Cells[i, 4].Value2 = productList[i-rowCount-1].Price;
        //    }

        //    //cleanup
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();
        //    //rule of thumb for releasing com objects:
        //    //  never use two dots, all COM objects must be referenced and released individually
        //    //  ex: [somthing].[something].[something] is bad
        //  //  Console.WriteLine(decode[0, 0] + decode[1, 1]);
        //    //close and release
        //    xlWorkbook.Close();
        //    //quit and release
        //    xlApp.Quit();
        //}
    }
}
