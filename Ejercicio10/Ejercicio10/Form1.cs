using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double cantidad;
            int billetes, monedas, euros, centimos;

            cantidad = double.Parse(tCantidad.Text);

            euros = (int)cantidad;
            centimos = (int)(cantidad * 100 - euros * 100);
            // Otra posible forma de calcular los céntimos.
            //centimos = Convert.ToInt32((cantidad - euros) * 100);
            
            MessageBox.Show("Tenemos " + euros + " euros con " + centimos + "céntimos.");
            if (euros >= 500)
            {
                // Obtenemos el número de billetes
                billetes = euros / 500;
                // Lo reflejamos en el label
                lResultado.Text = lResultado.Text + billetes + " billetes de 500\n";
                // Nos quedamos con el resto de dinero que nos queda
                euros = euros % 500;
            }

            // Hacemos lo mismo con el resto de billetes
            if (euros >= 200)
            {
                billetes = euros / 200;
                lResultado.Text = lResultado.Text + billetes + " billetes de 200\n";
                euros = euros % 200;
            }

            if (euros >= 100)
            {
                billetes = euros / 100;
                lResultado.Text = lResultado.Text + billetes + " billetes de 100 euros\n";
                euros = euros % 100;
            }

            if (euros >= 50)
            {
                billetes = euros / 50;
                lResultado.Text = lResultado.Text + billetes + " billetes de 50 euros\n";
                euros = euros % 50;
            }

            if (euros >= 20)
            {
                billetes = euros / 20;
                lResultado.Text = lResultado.Text + billetes + " billetes de 20 euros\n";
                euros = euros % 20;
            }

            if (euros >= 10)
            {
                billetes = euros / 10;
                lResultado.Text = lResultado.Text + billetes + " billetes de 10 euros\n";
                euros = euros % 10;
            }

            if (euros >= 5)
            {
                billetes = euros / 5;
                lResultado.Text = lResultado.Text + billetes + " billetes de 5 euros\n";
                euros = euros % 5;
            }

            if (euros >= 2)
            {
                billetes = euros / 2;
                lResultado.Text = lResultado.Text + billetes + " monedas de 2 euros\n";
                euros = euros % 2;
            }

            if (euros > 0)
            {
                lResultado.Text = lResultado.Text + euros + " moneda de 1 euro\n";
            }

            // Lo mismo con los céntimos
            if (centimos >= 50)
            {
                monedas = centimos / 50;
                lResultado.Text = lResultado.Text + monedas + " moneda de 50 centimos\n";
                centimos = centimos % 50;
            }

            if (centimos >= 20)
            {
                monedas = centimos / 20;
                lResultado.Text = lResultado.Text + monedas + " monedas de 20 centimos\n";
                centimos = centimos % 20;
            }

            if (centimos >= 10)
            {
                monedas = centimos / 10;
                lResultado.Text = lResultado.Text + monedas + " moneda de 10 centimos\n";
                centimos = centimos % 10;
            }

            if (centimos >= 5)
            {
                monedas = centimos / 5;
                lResultado.Text = lResultado.Text + monedas + " moneda de 5 centimos\n";
                centimos = centimos % 5;
            }

            if (centimos >= 2)
            {
                monedas = centimos / 2;
                lResultado.Text = lResultado.Text + monedas + " monedas de 2 centimos\n";
                centimos = centimos % 2;
            }

            if(centimos > 0)
                lResultado.Text = lResultado.Text + centimos + " moneda de 1 centimo\n";



        }
    }
}
