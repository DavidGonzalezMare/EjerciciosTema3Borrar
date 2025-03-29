using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Pues voy a meter un comentario para que se refleje
        // en el repositorio
        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            num = int.Parse(tNumero.Text);

            if (num == 2)
                MessageBox.Show("Es el 2.");
            else
                MessageBox.Show("NO es el 2.");

        }
    }
}
