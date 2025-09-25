using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {     // 制御ボタン☝　　　　　　　　数字☝
                e.Handled = true; // 入力キャンセル
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            { return; }

            int x = int.Parse(textBox1.Text); // テキストの数値を参照



            if (x < 5 && x%2 ==0)
            { label1.Text = "5より小さい2の倍数"; }

            if (x < 5 && x % 2 != 0)
            { label1.Text = "5より小さい2の倍数ではない"; }

            if (5 < x && x % 2 == 0)
            { label1.Text = "5以上　2の倍数"; }

            if (5 < x && x % 2 != 0)
            { label1.Text = "5以上　2の倍数ではない";}
            
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
