using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalcularEdad
{
    public partial class RellenarDatos : Form
    {
        private static List<DateTime> registroFechas = new List<DateTime>();

        public RellenarDatos()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(textBox1.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNueva))
            {
                registroFechas.Add(fechaNueva);
                label3.Text = "Fecha registrada con exito";
            } else
            {
                label3.Text = "Formato incorrecto. Introducelo como dd/mm/aaaa";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
