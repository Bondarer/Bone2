using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Кістки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;

            if (string.IsNullOrEmpty(label1.Text) || string.IsNullOrEmpty(label2.Text))
            {
                MessageBox.Show("Будь ласка, введіть імена обох гравців.");
                return;
            }
            textBox1.Visible = false;
            textBox2.Visible = false;

            label1.Text = label1.Text;
            label2.Text = label2.Text;
            
            Random random1 = new Random();
            int value1 = random1.Next(2, 12);
            int value2 = random1.Next(2, 12);
            label3.Text = value1.ToString();
            label4.Text = value2.ToString();
            if (value1 > value2)
            {
                label5.Text = $"{label1.Text} переміг";
            }
            else if (value1 < value2)
            {
                label5.Text = $"{label2.Text} переміг";
            }
            else
            {
                label5.Text = "Нічия";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
