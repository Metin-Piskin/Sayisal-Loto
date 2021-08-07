using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayısal_Loto
{
    public partial class SayısalLoto : Form
    {
        public SayısalLoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int s1, s2, s3, s4;
            s1 = rast.Next(1, 10);
            s2 = rast.Next(1, 10);
            s3 = rast.Next(1, 10);
            s4 = rast.Next(1, 10);
            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();
            //sayı 1
            if (maskedTextBox1.Text == label1.Text)
            {
                maskedTextBox1.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox1.BackColor = Color.Red;
            }
            //sayı 2
            if (maskedTextBox2.Text == label2.Text)
            {
                maskedTextBox2.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox2.BackColor = Color.Red;
            }
            //sayı 3
            if (maskedTextBox3.Text == label3.Text)
            {
                maskedTextBox3.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox3.BackColor = Color.Red;
            }
            //sayı 4
            if (maskedTextBox4.Text == label4.Text)
            {
                maskedTextBox4.BackColor = Color.Green;
            }
            else
            {
                maskedTextBox4.BackColor = Color.Red;
            }
            button1.Enabled = false;
            BtnTemizle.Enabled = true;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            label1.Text = "Sayı 1";
            label2.Text = "Sayı 2";
            label3.Text = "Sayı 3";
            label4.Text = "Sayı 4";
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            BtnTemizle.Enabled = false;
            button1.Enabled = true;
            maskedTextBox1.BackColor = Color.White;
            maskedTextBox2.BackColor = Color.White;
            maskedTextBox3.BackColor = Color.White;
            maskedTextBox4.BackColor = Color.White;

        }
    }
}
