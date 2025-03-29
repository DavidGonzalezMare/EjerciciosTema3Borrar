using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int producto(int num1, int num2)
        {
            int res = 0;
            bool cambioSigno = false;

            // Si el multiplicador es negativo lo cambiamos 
            // de signo y lo "apuntamos"
            if(num2 < 0)
            {
                num2 = -num2;
                cambioSigno = true;
            }

            // El multiplicador es positivo
            for (int i = 1; i <= num2; i++)
                res = res + num1;

            // Si se cambió el signo al multiplicador 
            // debemos cambiar signo al resultado
            if(cambioSigno)
                res = -res;

            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, res;

            n1 = int.Parse(tNum1.Text);
            n2 = int.Parse(tNum2.Text);

            res = producto(n1, n2);

            MessageBox.Show("El producto es: " + res);
        }
    }
}
