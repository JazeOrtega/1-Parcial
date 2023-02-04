using System;
using System.Windows.Forms;

namespace I_Parcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Sumarbutton1_Click(object sender, EventArgs e)
        {
            //variable
            decimal numero1 = Convert.ToDecimal(Numero1textBox1.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox2.Text);

            decimal resultado = numero1 + numero2;
            MessageBox.Show("La suma es: " + resultado);
            //Resultadolabel3.Text = Convert.ToString(resultado);
        }

    }
}
