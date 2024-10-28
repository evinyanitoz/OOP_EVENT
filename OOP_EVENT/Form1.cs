using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_EVENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "KIRMIZI" | textBox1.Text == "kırmızı")
            {
                this.BackColor = Color.DarkRed; 
            }
            if (textBox1.Text == "SİYAH" | textBox1.Text == "siyah")
            {
                this.BackColor = Color.Black;
            }
            if (textBox1.Text == "MAVİ" | textBox1.Text == "mavi")
            {
                this.BackColor = Color.Teal;
            }
            if (textBox1.Text == "BEYAZ" | textBox1.Text == "beyaz")
            {
                this.BackColor = Color.White;
            }
            if (textBox1.Text == "SARI" | textBox1.Text == "sarı")
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}
