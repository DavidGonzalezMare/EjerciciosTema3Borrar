using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, num;
            string texto = "";

            num = int.Parse(txtNum.Text);

            for(i = 1; i <= num; i++)
            {
                texto += i;     // Equivale a hacer texto = texto + i;

                if (i < num)
                    texto += ", ";
            }

            MessageBox.Show(texto);
        }
    }
}
