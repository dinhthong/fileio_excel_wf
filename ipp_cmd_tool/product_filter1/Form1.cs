using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Linq;
namespace product_filter1
{
    public partial class ipp_cmd_tool : Form
    {
        //private List<Product> productList = new List<Product>();
        //string strStart;
        //string strEnd;
        //string product_temp;
        //int index;
        //bool stop = false;
        List<string> SerialList = new List<string>();
        public static int rowCount, colCount;
        public static int startCol, endCol;
        public static string[,] excel_values;
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel._Worksheet xlWorksheet;
        Excel.Range xlRange;
        string file_path;
        string io_dir_text;
        /*
         
         https://stackoverflow.com/questions/7462748/how-to-run-code-when-form-is-shown
        */
        string temp_txt_path;
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
        //private void bt_do_Click(object sender, EventArgs e)
        //{
        //    {

        //       // string text_read = txt_1.Text;
        //        strStart = "<a href=\"/products/";
        //        strEnd = "</em>";
        //        while (stop == false)
        //        {
        //            product_temp = getBetween(text_read, strStart, strEnd);
        //            if (product_temp == "")
        //            {
        //                stop = true;
        //                break;
        //            }
        //            //code pro add to product list
        //            newproduct(product_temp);
        //            txt_2.Text += product_temp;
        //            txt_2.Text += Environment.NewLine;
        //            index = text_read.IndexOf(strEnd) + strEnd.Length;
        //            text_read = text_read.Substring(index);
        //        }
        //    }
        //}
        //private void newproduct(string product_temp)
        //{
        //    string price, name;
        //    Product newProduct = new Product();
        //    name = getBetween(product_temp, "title=\"", "\"");
        //    newProduct.Name = name;
        //    newProduct.Image_url = getBetween(product_temp, "src=\"//", "\"");
        //    newProduct.Product_url = getBetween(product_temp, "<strong><a href='", "'>");
        //    price = getBetween(product_temp, "\"price\"><em>", "₫");
        //    price = price.Replace(" ", "");
        //    newProduct.Price = price;
        //    productList.Add(newProduct);
        //}

        //private void bt_excel_Click(object sender, EventArgs e)
        //{
        // //   toExcelFile();
        //}
        // public static int rowCount, colCount;
        // public static string[,] decode;

        private void txt_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            txt_show.Text = "";
            string input_txt_read = txt_input_serial.Text;
            string[] decode_first_col = new string[rowCount];
            /*
             * https://stackoverflow.com/questions/27427527/how-to-get-a-complete-row-or-column-from-2d-array-in-c-sharp
             * To get a complete row out of an multi-dimensional array, you have to loop
             */

            int index = SerialList.IndexOf(input_txt_read);
            if (index != -1)
            {
              //  index = Array.IndexOf(decode_first_col, input_txt_read);
                // lb_out_stt.Text = "The output value for input " + input_txt_read + " is:";
                txt_show.Text = excel_values[index, startCol + 1];
                btn_copy.Enabled = true;
                /*
                 Position the Cursor at the Beginning or End of Text in a TextBox Control
                 */
                Clipboard.SetText(txt_show.Text);
                lb_kq.Text = "The output value for input " + input_txt_read.ToString() + " is:";
                //txt_status.Text = "Read thanh cong";
            }
            else
            {
                lb_kq.Text = "Khong tim thay";
                txt_show.Text = "NaN";
               // txt_status.Text = "";
            }

            //if (SerialList.Any(str => str.Contains(input_txt_read))) {
            //    MessageBox.Show("Yes");

            //    MessageBox.Show(index2.ToString());
            //}
            //else
            //{

            //}
            //if (decode_first_col.Contains(input_txt_read))
            //{ 
            //    index = Array.IndexOf(decode_first_col, input_txt_read);
            //// lb_kq.Text = "The output value for input " + input_txt_read + " is:";
            //     txt_show.Text = excel_values[index, startCol + 1];
            //    btn_copy.Enabled = true;
            //    /*
            //     Position the Cursor at the Beginning or End of Text in a TextBox Control
            //     */
            //    Clipboard.SetText(txt_show.Text);
            //    txt_status.Text = "Read thanh cong";
            //}
            //else
            //{ 
            //    txt_show.Text = "NaN";
            //    txt_status.Text = "Can't find a match";
            //}
            txt_input_serial.Text = "2019-0";
            //txt_input_serial.Select(txt_input_serial.Text.Length, 0);
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            lb_kq.Text = "";
            Clipboard.SetText(txt_show.Text);
            txt_show.Text = "";
            btn_copy.Enabled = false;
            txt_status.Text = "Copy thanh cong";
        }

        private void ipp_cmd_tool_Shown(object sender, EventArgs e)
        {
            temp_txt_path = Application.StartupPath + @"..\..\..\..\" + @"working_dir_path.txt";
            io_dir_text = System.IO.File.ReadAllText(temp_txt_path);
            txt_filepath.Text = io_dir_text;
            file_path = io_dir_text;
            txt_input_serial.Text = "2019-0";
            /*
             move this code block to here to be effective
             */
            startCol = 1;
            endCol = 3;
            readExcelFile();
        }

        private void btn_read_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_read_Click(this, new EventArgs());
            }
        }

        private void txt_input_serial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_read_Click(this, new EventArgs());
            }
            txt_input_serial.Select(txt_input_serial.Text.Length, 0);
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

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != file_path)
                {
                    btn_read.Enabled = false;
                    file_path = openFileDialog1.FileName;
                    txt_filepath.Text = openFileDialog1.FileName;
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
            if (System.IO.File.Exists(file_path))
            {
                xlWorkbook = xlApp.Workbooks.Open(file_path, ReadOnly: true, Password: "m3e");
                xlWorksheet = xlWorkbook.Sheets[1];
                xlRange = xlWorksheet.UsedRange;
                rowCount = xlRange.Rows.Count;
                colCount = xlRange.Columns.Count;
                // Console.WriteLine(rowCount.ToString());
                //  Console.WriteLine(colCount.ToString());
                excel_values = new string[rowCount, colCount];
                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                txt_status.Text = "Start reading data from a new excel file";
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
                SerialList.Clear();
                for (int k = 0; k < rowCount; k++)
                {
                    SerialList.Add(excel_values[k, startCol]);
                }
                txt_status.Text = "Reading new file done";
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
