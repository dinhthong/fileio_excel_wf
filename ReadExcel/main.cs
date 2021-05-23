using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace ReadExcel
{
    public partial class main : Form
    {
        public static int rowCount, colCount;
        public static string[,] decode;
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            getExcelFile();
        }
        public void getExcelFile()
        {
            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(Application.StartupPath + @"\Database.xlsx");
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
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                        decode[i - 1, j - 1] = xlRange.Cells[i, j].Value2.ToString();
                        txt_show.Text += Environment.NewLine + xlRange.Cells[i, j].Value2.ToString();
                      
                        // in theo cac hang
                    }
                }
            }
            xlRange.Cells[9, 8].Value2 = "hello";
            xlRange.Cells[9, 15].Value2 = "hello2";
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
