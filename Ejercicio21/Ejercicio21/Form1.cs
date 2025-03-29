using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, num;
            string texto;

            num = int.Parse(tNumero.Text);

            if (num >= 1 && num <= 15)
            {
                texto = "";
                for (i = 1; i <= num; i++)
                {
                    // Aquí vamos montando en el texto 1, 2, 3, ... 10, 
                    for (j = 1; j <= 10; j++)
                        texto = texto + j + ", ";
                    // Al terminar cada línea metemos el retorno de carro.
                    texto = texto + "\n";
                }

                MessageBox.Show(texto, "Resultado");
            }
            else
                MessageBox.Show("El número debe estar entre 1 y 15.");
        }
    }
}
