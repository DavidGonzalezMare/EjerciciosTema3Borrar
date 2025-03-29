using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bComparar_Click(object sender, EventArgs e)
        {
            int n1, n2;

            n1 = int.Parse(tNum1.Text);
            n2 = int.Parse(tNum2.Text);

            if (n1 > n2)
                MessageBox.Show("El número mayor es: " + n1);
            else
                MessageBox.Show("El número mayor es: " + n2);

        }
    }
}
