namespace WinFormsCalcularEdad
{
    partial class CalcularEdadFutura
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
            checkBox2 = new CheckBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 75);
            label1.Name = "label1";
            label1.Size = new Size(489, 20);
            label1.TabIndex = 1;
            label1.Text = "Intoduce el dia en el que quieres ver la edad en el formato dd/mm/aaaa";
            // 
            // button1
            // 
            button1.Location = new Point(674, 375);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(263, 184);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(247, 24);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "cambiar formato a aaaa/mm/dd";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(469, 126);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Comprobar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CalcularEdadFutura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(checkBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CalcularEdadFutura";
            Text = "CalcularEdadFutura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private CheckBox checkBox2;
        private TextBox textBox1;
        private Button button2;
    }
}