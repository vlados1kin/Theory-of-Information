using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ByteArrToString(byte[] byteArr)
        {
            var stringBuilder = new StringBuilder();
            var length = byteArr.Length < 512 ? byteArr.Length : 512;
            for (var i = 0; i < length; i++)
            {
                stringBuilder.Append(Convert.ToString(byteArr[i], 2).PadLeft(8, '0') + " ");
            }

            return stringBuilder.ToString();
        }
        
        private void cipherButton_Click(object sender, EventArgs e)
        {
            if (StartTextBox.Text.Length == 0)
                return;
            var keyStrBuilder = new StringBuilder();
            foreach (var c in keyTextBox.Text)
            {
                if (c == '1' || c == '0')
                    keyStrBuilder.Append(c);
            }
            if (keyStrBuilder.Length != 32)
            {
                MessageBox.Show(@"неправильная длина ключа", @"Ошибка");
                return;
            }
            var keyString = keyStrBuilder.ToString();
            uint key = 0;
            for (var i = 0; i < 32; i++)
            {
                if (keyString[i] == '1')
                {
                     key |=  0x80000000 >> i;
                }
            }
            
            Cipher.Code(key);
            
            GenTextBox.Text = ByteArrToString(Cipher.KeyByteArr);
            EndTextBox.Text = ByteArrToString(Cipher.CipherByteArr);
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            
            Cipher.PlainByteArr = File.ReadAllBytes(openFileDialog1.FileName);
            
            StartTextBox.Text = ByteArrToString(Cipher.PlainByteArr);
            EndTextBox.Text = "";
            GenTextBox.Text = "";
        }
        
        private void writeButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            
            File.WriteAllBytes(saveFileDialog1.FileName ,Cipher.CipherByteArr);
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            keyLabel.Text = $@"ключ({keyTextBox.Text.Length} симв.)";
        }
    }
}