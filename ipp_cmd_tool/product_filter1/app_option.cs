using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Save app settings, no need to use .text file
 https://stackoverflow.com/questions/1121427/what-is-the-best-way-for-save-and-load-setting-in-my-program
 Using Triple DES in C#
https://www.codeguru.com/csharp/csharp/cs_misc/security/triple-des-encryption-and-decryption-in-c.html#:~:text=The%20Triple%20Data%20Encryption%20Standard,To%20implement%20TripleDES%2C%20.

 */
namespace product_filter1
{
    public partial class app_option : Form
    {
        public app_option()
        {
            InitializeComponent();
        }

        string decrypted_password;
        private void app_option_Shown(object sender, EventArgs e)
        {
            txt_stringtemplate.Text = Properties.Settings.Default.char_template;
            txt_maxlength.Text = Properties.Settings.Default.max_in_length.ToString();
            txt_incol.Text = Properties.Settings.Default.input_col.ToString();
            txt_outcol.Text = Properties.Settings.Default.output_col.ToString();
            chkbox_autocopy.Checked = Properties.Settings.Default.bool_autocopy;
            if (Properties.Settings.Default.excel_password != "")
            {
                decrypted_password = TripleDES.Decrypt(Properties.Settings.Default.excel_password);
                txt_filepass.Text = decrypted_password;
            }
        }

        private void save_appop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Save click");
            Properties.Settings.Default.char_template = txt_stringtemplate.Text;
            Properties.Settings.Default.max_in_length= Convert.ToUInt32(txt_maxlength.Text);
            Properties.Settings.Default.input_col = Convert.ToUInt32(txt_incol.Text);
            Properties.Settings.Default.output_col = Convert.ToUInt32(txt_outcol.Text);
            Properties.Settings.Default.bool_autocopy = chkbox_autocopy.Checked;
            /*
             save encrypted password to excel password in settings file
             */
            Properties.Settings.Default.excel_password = TripleDES.Encrypt(txt_filepass.Text);
            Console.WriteLine(Properties.Settings.Default.excel_password);

            Properties.Settings.Default.Save();
            //txt_filepass.Text = TripleDES.Encrypt(Properties.Settings.Default.excel_password);

        }

        private void app_option_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Form closed 1");

           // ipp_cmd_tool.
        }

        private void app_option_Load(object sender, EventArgs e)
        {

        }

        private void btn_select_logfile_Click(object sender, EventArgs e)
        {

        }
    }


}
