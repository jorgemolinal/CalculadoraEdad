namespace WinFormsCalcularEdad
{
    public partial class MenuPrincipal : Form
    {
        public DateTime DatosRecibidos { get; set; }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void LanzaForm(Form form)
        {
            form.Show();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Sirve para cerrarlo
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ActualizarLabel()
        {
            if (DatosRecibidos != DateTime.MinValue) // Verifica si hay datos recibidos
            {
                label1.Text = DatosRecibidos.ToString();
            }
            else
            {
                label1.Text = "Aquí aparecerán tus datos";
            }
        }


        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    CalcularEdad form = new CalcularEdad();
                    LanzaForm(form);
                    break;
                case 1:
                    CalcularEdadFutura form2 = new CalcularEdadFutura();
                    LanzaForm(form2);
                    break;
                case 2:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RellenarDatos form = new RellenarDatos();
            LanzaForm(form);
        }
    }
}