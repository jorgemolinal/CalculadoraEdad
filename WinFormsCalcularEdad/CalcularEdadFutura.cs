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
    public partial class CalcularEdadFutura : Form
    {
        public CalcularEdadFutura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static bool checkActivo = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Introduce la fecha de nacimiento como aaaa/mm/dd";
            checkActivo = true; //Para ver si el checkbox esta activo o no
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
