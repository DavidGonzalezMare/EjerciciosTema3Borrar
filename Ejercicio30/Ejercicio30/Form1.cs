using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int kINTENTOS = 5;
        private void bIniciar_Click(object sender, EventArgs e)
        {
            string usuario, contrasena; 
            bool encontrado;
            int intentos;

            // En intentos guardaremos cuantos intentos lleva el usuario
            intentos = 0;
            // En la variable booleana encontrado tendremos si el usuario ha encontrado la clave correcta
            encontrado = false;

            // Mientras no lo encontremos y el número de intentos sea menor que 5
            // seguiremos pidiendo el usuario y contraseña.
            while(!encontrado && intentos < kINTENTOS)
            {
                MessageBox.Show("Quedan " + (kINTENTOS - intentos) + " intentos.");
                usuario = Interaction.InputBox("Introduzca el usuario");
                contrasena = Interaction.InputBox("Introduzca la contraseña");

                if (usuario == "root" && contrasena == "1234")
                    encontrado = true;
                else
                    intentos++;
            }

            if (encontrado)
                MessageBox.Show("Bienvenido al sistema");
            else
                MessageBox.Show("Ha agotado los " + kINTENTOS + " intentos");

        }
    }
}
