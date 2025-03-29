namespace Ejercicio29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i;
            double res;

            n = int.Parse(txtNum.Text);

            res = 0;
            for(i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    res = res - 1.0 / i;
                }
                else
                {
                    res = res + 1.0 / i;
                }
            }

            MessageBox.Show("El resultado de la serie es: " + res);

        }
    }
}