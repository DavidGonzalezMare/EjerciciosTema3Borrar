using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota;

            nota = double.Parse(tNota.Text);

            if (nota >= 0 && nota <= 10) 
            {
                if (nota < 3)
                    MessageBox.Show("Muy Deficiente.");
                else
                    if (nota < 5)
                        MessageBox.Show("Insuficiente");
                    else
                        if (nota < 6)
                            MessageBox.Show("Suficiente.");
                        else
                            if (nota < 7)
                                MessageBox.Show("Bien.");
                            else
                                if (nota < 9)
                                    MessageBox.Show("Notable.");
                                else
                                    MessageBox.Show("Sobresaliente.");
                
            }
            else
                MessageBox.Show("Nota incorrecta. Debe estar entre 0 y 10.");

        }
    }
}
