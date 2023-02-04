using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Parcial
{
    public partial class Tarea1 : Form
    {
        public Tarea1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El numero es " + positivoNegativo(Convert.ToDecimal(ValorTextBox1.Text)) + " y es un numero " + parImpar(Convert.ToDecimal(ValorTextBox1.Text)),"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private String positivoNegativo(decimal num)
        {
            decimal numero = Convert.ToDecimal(ValorTextBox1.Text);
            string simbolo = "";
            if(num < 0)
                simbolo = "Negativo";
            else if(num > 0)
                simbolo = "Positivo";
            return simbolo;
        }

        private string parImpar(decimal num)
        {
            decimal numero = Convert.ToDecimal(ValorTextBox1.Text);
            string tipo = "";
            if (num % 2 ==0)
                tipo = "Par";
            else
                tipo = "Impar";
            return tipo;
        }
    }
}
