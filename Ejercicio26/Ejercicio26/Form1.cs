using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            string texto;
            int contador = 0, suma = 0;

            texto = "Serie: \n";
            for (int i = 3; i <= 99; i = i + 3)
            {
                texto = texto + i + ", ";
                suma = suma + i;
                contador++;
                if (contador == 7)
                {
                    texto = texto + "\n";
                    contador = 0;
                }
            }

            MessageBox.Show(texto + "\n\nLa suma es: " + suma);
        }
    }
}
