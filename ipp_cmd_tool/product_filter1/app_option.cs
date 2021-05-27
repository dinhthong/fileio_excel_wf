using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
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
            if (Properties.Settings.Default.excel_password != "")
            {
                decrypted_password = ClsTripleDES.Decrypt(Properties.Settings.Default.excel_password);
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
            /*
             save encrypted password to excel password in settings file
             */
            Properties.Settings.Default.excel_password = ClsTripleDES.Encrypt(txt_filepass.Text);
            Console.WriteLine(Properties.Settings.Default.excel_password);
            Properties.Settings.Default.Save();
            //txt_filepass.Text = ClsTripleDES.Encrypt(Properties.Settings.Default.excel_password);
        }

        private void app_option_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Form closed 1");
        }
    }

    public class ClsTripleDES
    {

        private const string mysecurityKey = "entrepreneur";

        public static string Encrypt(string TextToEncrypt)
        {
            byte[] MyEncryptedArray = UTF8Encoding.UTF8
               .GetBytes(TextToEncrypt);

            MD5CryptoServiceProvider MyMD5CryptoService = new
               MD5CryptoServiceProvider();

            byte[] MysecurityKeyArray = MyMD5CryptoService.ComputeHash
               (UTF8Encoding.UTF8.GetBytes(mysecurityKey));

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new
               TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = MysecurityKeyArray;

            MyTripleDESCryptoService.Mode = CipherMode.ECB;

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService
               .CreateEncryptor();

            byte[] MyresultArray = MyCrytpoTransform
               .TransformFinalBlock(MyEncryptedArray, 0,
               MyEncryptedArray.Length);

            MyTripleDESCryptoService.Clear();

            return Convert.ToBase64String(MyresultArray, 0,
               MyresultArray.Length);
        }



        public static string Decrypt(string TextToDecrypt)
        {
            byte[] MyDecryptArray = Convert.FromBase64String
               (TextToDecrypt);

            MD5CryptoServiceProvider MyMD5CryptoService = new
               MD5CryptoServiceProvider();

            byte[] MysecurityKeyArray = MyMD5CryptoService.ComputeHash
               (UTF8Encoding.UTF8.GetBytes(mysecurityKey));

            MyMD5CryptoService.Clear();

            var MyTripleDESCryptoService = new
               TripleDESCryptoServiceProvider();

            MyTripleDESCryptoService.Key = MysecurityKeyArray;

            MyTripleDESCryptoService.Mode = CipherMode.ECB;

            MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

            var MyCrytpoTransform = MyTripleDESCryptoService
               .CreateDecryptor();

            byte[] MyresultArray = MyCrytpoTransform
               .TransformFinalBlock(MyDecryptArray, 0,
               MyDecryptArray.Length);

            MyTripleDESCryptoService.Clear();

            return UTF8Encoding.UTF8.GetString(MyresultArray);
        }
    }

}
