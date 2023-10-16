namespace WinFormsCalcularEdad
{
    partial class RellenarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 41);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 2;
            label1.Text = "Registro de fechas";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Menu;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(303, 351);
            button1.Name = "button1";
            button1.Size = new Size(145, 29);
            button1.TabIndex = 3;
            button1.Text = "Confirmar fecha";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Location = new Point(470, 351);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 201);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(242, 94);
            label2.Name = "label2";
            label2.Size = new Size(405, 32);
            label2.TabIndex = 6;
            label2.Text = "Introduce tu fecha de nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 231);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // RellenarDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 497);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "RellenarDatos";
            Text = "RellenarDatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}