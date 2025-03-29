using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAnadir_Click(object sender, EventArgs e)
        {
            // Al texto que tenemos en el label le concatenamos el texto del textbox
            // y un retorno de carro (\n). El resultado o asignamos de nuevo al texto del label
            label1.Text = label1.Text + textBox1.Text + "\n";
        }
    }
}
