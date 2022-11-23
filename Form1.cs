using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

namespace CS_AESDES128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_Result.Clear();
            tb_KeyValue.Clear(); 
            tb_Sentence.Text = "Input a sentence to be encrypted";

        }

        private void tb_Sentence_Click(object sender, EventArgs e)
        {
            tb_Sentence.SelectAll();

        }

        private void tb_Result_Click(object sender, EventArgs e)
        {
            tb_Result.SelectAll();
        }

        private void tb_KeyValue_Click(object sender, EventArgs e)
        {
            tb_KeyValue.SelectAll();
        }

        public static string Encrypt(string textToEncrypt, string key)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
            byte[] keyBytes = new byte[16];
            int len = pwdBytes.Length;
            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }

            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();
            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);
            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public static string Decrypt(string textToDecrypt, string key)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;

            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;
            try
            {
                byte[] encryptedData = Convert.FromBase64String(textToDecrypt);
                byte[] pwdBytes = Encoding.UTF8.GetBytes(key);
                byte[] keyBytes = new byte[16];
                int len = pwdBytes.Length;
                if (len > keyBytes.Length) { len = keyBytes.Length; }

                Array.Copy(pwdBytes, keyBytes, len);
                rijndaelCipher.Key = keyBytes;
                rijndaelCipher.IV = keyBytes;
                byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                return Encoding.UTF8.GetString(plainText);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Please, input the encrypted sentence");
                return null;      // 또는 return "";  => return값이 string으로 정의 되어 있으므로
            }

        }

        private void bt_Encryption_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();

            if (tb_Sentence.Text == "")
            {
                MessageBox.Show("Please, input a sentence to be encrypted or decrypted");
                return;
            }

            if (tb_KeyValue.Text == "" )
                MessageBox.Show("Please, input the key value");
             else
                tb_Result.Text = Encrypt(tb_Sentence.Text, tb_KeyValue.Text);

        }

        private void bt_Decryption_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();

            if (tb_KeyValue.Text == "")
                MessageBox.Show("Please, input the key value");
            else
                tb_Result.Text = Decrypt(tb_Sentence.Text, tb_KeyValue.Text);

        }

    }

}
