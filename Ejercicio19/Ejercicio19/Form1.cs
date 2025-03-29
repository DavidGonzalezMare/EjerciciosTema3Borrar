using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            // Recordamos la utilización de try
            try
            {
                int num, factorial, i;

                num = int.Parse(tNumero.Text);

                // Inicializamos a 1 ya que es el neutro del producto
                factorial = 1;

                for (i = num; i >= 1; i--)
                    factorial = factorial * i;

                MessageBox.Show("El factorial de " + num + " es " + factorial);

                // El bucle también se podría haber hecho   
                // for(i = 1; i <= num; i++)
                // ya que es lo mismo 5 * 4 * 3 * 2 * 1 que 1 * 2 * 3 * 4 * 5
            }
            catch (FormatException fEx) 
            {
                MessageBox.Show(fEx.Message);
            }
        }
    }
}
