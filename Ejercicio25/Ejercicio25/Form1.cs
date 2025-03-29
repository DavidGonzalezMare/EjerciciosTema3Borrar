using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;

            for (int i = 1; i <= 10; i++)
            {
                // En este punto empieza la tabla del i
                texto = "Tabla del " + i + "\n";
                for (int j = 1; j <= 10; j++)
                {
                    texto = texto + i + " * " + j + " = " + i * j + "\n";
                }

                // Aquí hemos montado la tabla del i y la mostramos
                MessageBox.Show(texto);
            }
        }
    }
}
