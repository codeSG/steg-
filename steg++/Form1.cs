using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace steg__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SCREEN));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void SCREEN()
        {
            Application.Run(new Form2());
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files(*.png)|*.png";
            openDialog.InitialDirectory = @"C:\";
            if(openDialog.ShowDialog()==DialogResult.OK)
            {
                FileBox.Text = openDialog.FileName.ToString();
                pictureBox.ImageLocation = FileBox.Text;
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            try {

                Bitmap image = new Bitmap(pictureBox.Image);
                int maxlen, len;
                if (image.Height * image.Width - 2 > 999999)
                    maxlen = 999999;
                else
                    maxlen = image.Height * image.Width - 2;
                len = enterMessageBox.TextLength;
                if (len < maxlen)
                {

                    Color firstPixel = image.GetPixel(image.Width - 1, image.Height - 1);
                    Color secondPixel = image.GetPixel(image.Width - 1, image.Height - 2);
                    image.SetPixel(image.Width - 1, image.Height - 1, setPix(firstPixel, len % 1000));
                    image.SetPixel(image.Width - 1, image.Height - 2, setPix(secondPixel, len / 1000));
                    string message = encodeRC4(enterMessageBox.Text);
                    int k = 0;
                    for (int i = 0; i < image.Width - 1; i++)
                    {
                        for (int j = 0; j < image.Height - 1; j++)
                        {
                            Color pixel = image.GetPixel(i, j);
                            char letter = Convert.ToChar(message.Substring(k, 1));
                            int value = Convert.ToInt32(letter);
                            image.SetPixel(i, j, setPix(pixel, value));
                            k++;
                            if (k == len)
                                break;
                        }
                        if (k == len)
                            break;
                    }
                    ErrorLabel.Text = "";
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Image Files(*.png)|*.png";
                    saveDialog.InitialDirectory = @"C:\";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileBox.Text = saveDialog.FileName.ToString();
                        pictureBox.ImageLocation = FileBox.Text;
                    }
                    image.Save(FileBox.Text);
                }
            }
            catch
            {
                ErrorLabel.Text="Either image field or key field or text feld is empty";
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            try {
                Bitmap image = new Bitmap(pictureBox.Image);
                Color firstPixel = image.GetPixel(image.Width - 1, image.Height - 1);
                Color secondPixel = image.GetPixel(image.Width - 1, image.Height - 2);
                int len = getValue(firstPixel) + getValue(secondPixel) * 1000;
                string message = "";
                int k = 0;
                for (int i = 0; i < image.Width - 1; i++)
                {
                    for (int j = 0; j < image.Height - 1; j++)
                    {
                        Color pixel = image.GetPixel(i, j);
                        int value = getValue(pixel);
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                        message = message + letter;
                        k++;
                        if (k == len)
                            break;
                    }
                    if (k == len)
                        break;
                }


                
                Form3 f = new Form3(encodeRC4(message));
                ErrorLabel.Text = "";
                
                f.ShowDialog();

            }
            catch
            {
                ErrorLabel.Text = "Either image field or key field is empty";

            }
        }

        private Color setPix(Color pixel, int value)
        {
            int value1 = (pixel.R / 10) * 10 + value % 10;
            if (value1 > 255)
                value1 -= 10;
            int value2 = (pixel.G / 10) * 10 + (value / 10) % 10;
            if (value2 > 255)
                value2 -= 10;
            int value3 = (pixel.B / 10) * 10 + value / 100;
            if (value3 > 255)
                value3 -= 10;
            return Color.FromArgb(value1, value2, value3);
        }

        private int getValue(Color pixel)
        {
            return (pixel.R % 10) + (pixel.G % 10) * 10 + (pixel.B % 10) * 100;
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?","Exit",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                e.Cancel = false;

            else if (dialog == DialogResult.No)
                e.Cancel = true;
        }
        private string encodeRC4(string plain)
        {

            Int32[] plaintext = convert(plain);
            Int32[] key = convert(KeyBox.Text);
            Int32[] S = new Int32[128];
            Int32[] T = new Int32[128];
            int keylen = key.Length;
            int i, j, k, t;
            for (i = 0; i < 128; i++)
            {
                S[i] = i;
                T[i] = key[i % keylen];
            }
            j = 0;
            for (i = 0; i < 128; i++)
            {
                j = (j + S[i] + T[i]) % 128;
                S[i] ^= S[j];
                S[j] ^= S[i];
                S[i] ^= S[j];
            }

            Int32[] ciphertext = new Int32[plaintext.Length];
            j = 0;
            i = 0;
            for (int counter = 0; counter < plaintext.Length; counter++)
            {
                i = (i + 1) % 128;
                j = (j + S[i]) % 128;
                S[i] ^= S[j];
                S[j] ^= S[i];
                S[i] ^= S[j];
                t = (S[i] + S[j]) % 128;
                k = S[t];
                ciphertext[counter] = plaintext[counter] ^ k;
            }
            return convert(ciphertext);
        }

    
        private Int32[] convert(string name)
        {
            Int32[] a=new Int32[name.Length];
            for (int k = 0; k < name.Length; k++)
            {
                char letter = Convert.ToChar(name.Substring(k, 1));
                Int32 value = Convert.ToInt16(letter);
                a[k] = value;
            }
            return a;
        }
        
        private string convert(Int32[] arr)
        {
            string name="";
            for(int i=0;i<arr.Length;i++)
            {
                char c = Convert.ToChar(arr[i]);
                string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                name = name + letter;
            }
            return name;
        }

        
        

        private void checkBoxKey_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxKey.Checked==true)
            {
                KeyBox.UseSystemPasswordChar = false;
                checkBoxKey.Text = "Hide";
            }
            else
            {
                KeyBox.UseSystemPasswordChar = true;
                checkBoxKey.Text = "Show";
            }
        }

        private void checkBoxMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMessage.Checked == true)
            {
                
                enterMessageBox.UseSystemPasswordChar = false;
                checkBoxMessage.Text = "Hide";
            }
            else
            {
                enterMessageBox.UseSystemPasswordChar = true;
                checkBoxMessage.Text = "Show";
            }
        }

        
    }

}
