using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraEdadC_;


namespace WinFormsCalcularEdad
{
    public partial class CalcularEdad : Form
    {
        public CalcularEdad()
        {
            InitializeComponent();
        }

        private static bool checkActivo = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Introduce la fecha de nacimiento como aaaa/mm/dd";
            checkActivo = true; //Para ver si el checkbox esta activo o no
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!checkActivo)
            {

                if (DateTime.TryParseExact(textBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                {
                    DateTime fechaActual = DateTime.Now;
                    Edad edad = CalculaEdad(fechaActual, fechaNacimiento);
                    if (edad.edadAnios > 0 && edad.edadMeses > 0 && edad.edadDias > 0)
                    {
                        label2.Text = "Su edad es: " + edad.edadAnios.ToString() + " años, " + edad.edadMeses.ToString() + " meses y " + edad.edadDias.ToString() + " días.";
                    }
                    else
                    {
                        label2.Text = "No has nacido todavia";
                    }
                }
                else
                {
                    label2.Text = "Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.";
                }

            }
            else
            {
                if (DateTime.TryParseExact(textBox1.Text, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                {
                    DateTime fechaActual = DateTime.Now;
                    Edad edad = CalculaEdad(fechaActual, fechaNacimiento);
                    if (edad.edadAnios > 0 && edad.edadMeses > 0 && edad.edadDias > 0)
                    {
                        label2.Text = "Su edad es: " + edad.edadAnios.ToString() + " años, " + edad.edadMeses.ToString() + " meses y " + edad.edadDias.ToString() + " días.";
                    }
                    else
                    {
                        label2.Text = "No has nacido todavia";
                    };
                }
                else
                {
                    label2.Text = "Fecha de nacimiento inválida. Asegúrese de seguir el formato aaaa/mm/dd.";
                }

            }
        }

        //////////////////////////////////////////////////////////////////////////
        private static Edad CalculaEdad(DateTime fechaFutura, DateTime fechaAnterior)
        {
            int edadAnios = fechaFutura.Year - fechaAnterior.Year;
            int edadMeses = fechaFutura.Month - fechaAnterior.Month;
            int edadDias = fechaFutura.Day - fechaAnterior.Day;
            if (edadDias < 0)
            {
                edadMeses--;
                int ultimoDiaMesPrevio = DateTime.DaysInMonth(fechaFutura.Year, fechaFutura.Month - 1);
                edadDias += ultimoDiaMesPrevio;
            }
            if (edadMeses < 0)
            {
                edadAnios--;
                edadMeses += 12;
            }
            Edad edad = new Edad(edadAnios, edadMeses, edadDias);
            return edad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
