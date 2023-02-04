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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox1.Text;

            LongitudTextBox2.Text = cadena.Length.ToString();

            PrimerCaracterTextBox1.Text = cadena.Substring(0,1);

            UltimoCaracterTextBox1.Text = cadena.Substring(cadena.Length - 1,1);

            MayusculasTextBox1.Text = cadena.ToUpper();

            MinusculasTextBox1.Text = cadena.ToLower();

            ReemplazarTextBox1.Text = cadena.ToUpper().Replace("A", "E").ToLower();

        }
    }
}
