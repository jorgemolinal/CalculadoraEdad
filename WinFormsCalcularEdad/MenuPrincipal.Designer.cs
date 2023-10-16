namespace WinFormsCalcularEdad
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            buttonSiguiente = new Button();
            buttonCerrar = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Calcular tu edad", "Calcular tu edad en un futuro", "Calcular tu edad en otro planeta" });
            comboBox1.Location = new Point(129, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(412, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Selecciona un modo ";
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.Location = new Point(547, 103);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(94, 29);
            buttonSiguiente.TabIndex = 1;
            buttonSiguiente.Text = "Siguiente";
            buttonSiguiente.UseVisualStyleBackColor = true;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.Location = new Point(436, 257);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(94, 29);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(206, 257);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 3;
            button1.Text = "Rellenar datos del usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Location = new Point(206, 344);
            label1.Name = "label1";
            label1.Size = new Size(324, 29);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonSiguiente);
            Controls.Add(comboBox1);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonSiguiente;
        private Button buttonCerrar;
        private Button button1;
        private Label label1;
    }
}