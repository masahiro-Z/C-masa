using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                label1.Text = "からっぽ";
                label1.ForeColor = Color.Yellow;
            }
            else { CheckInput(input); }
        }

        private void CheckInput(string input)
        {
            bool Yama = input.Contains("山");
            bool Umi = input.Contains("海");

            if (Yama && Umi)
            {
                label1.Text = "どちらも含まれている";
                label1.ForeColor = Color.Red;
            }
            else if (Yama)
            {
                label1.Text = "山が含まれている";
                label1.ForeColor = Color.Green;
            }
            else if (Umi)
            {
                label1.Text = "海が含まれている";
                label1.ForeColor = Color.Blue;
            }
            else
            {
                label1.Text = "どちらも含まれてない";
                label1.ForeColor = Color.Black;
            }












        }
    }
}