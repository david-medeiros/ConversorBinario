using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorBinario
{
    public partial class Form1 : Form
    {
        string text;
        int numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {    
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           text = textBox1.Text;
           numero = Convert.ToInt32(text);
           textBox2.Text = Convert.ToString(numero, 2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
