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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton1_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechadateTimePicker1.Value;

            DiatextBox1.Text = fecha.Day.ToString();
            MesTextBox1.Text = fecha.Month.ToString("MMMM");
            AnioTextBox2.Text = fecha.Year.ToString("");
            SemanaTextBox3.Text = fecha.DayOfWeek.ToString();

            int numeroDias = Convert.ToInt32(DiasTextBox1.Text);
            DateTime fechaActual = DateTime.Now;

            CitaTextBox1.Text = fechaActual.AddDays(numeroDias).ToShortDateString();

            int diasRestar = Convert.ToInt32(RestarTextBox1.Text);

            NuevaFechaTextBox1.Text = fecha.AddDays(-diasRestar).ToLongDateString();

            MessageBox.Show("La edad es: " + devolverEdad(fecha));

        }

        private int devolverEdad (DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            int edad = 0;
            if(fechaNacimiento >= fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if(fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
                return edad;
            }
        }
    }
}
