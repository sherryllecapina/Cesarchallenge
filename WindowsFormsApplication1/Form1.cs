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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string encrypt = textBox1.Text;
            encrypt.ToLower();


            bool tbNull = textBox1.Text == "";

            if (tbNull)
                MessageBox.Show("There is nothing to encrypt.");

            else
            {
                char[] array = encrypt.ToCharArray();

                for (int i = 0; i < array.Length; i++)
                {
                    int num = (int)array[i];
                    if (num >= 'a' && num <= 'z')
                    {
                        num += Convert.ToInt32(textBox2.Text);
                        if (num > 'z')
                        {
                            num = num - 26;
                        }
                    }
                    else if (num >= 'A' && num <= 'Z')
                    {
                        num += Convert.ToInt32(textBox2.Text);
                        if (num > 'Z')
                        {
                            num = num - 26;
                        }
                    }
                    array[i] = (char)num;
                }
               
                textBox3.Text = new string(array).ToLower();
            }

            textBox1.Copy();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
