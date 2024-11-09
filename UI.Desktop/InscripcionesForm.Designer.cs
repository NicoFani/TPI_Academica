namespace UI.Desktop
{
    partial class InscripcionesForm
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 98);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 160);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 225);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Condición";
            // 
            // button1
            // 
            button1.Location = new Point(305, 283);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += acceptButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(412, 283);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancelButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(252, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(252, 157);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(246, 28);
            comboBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 222);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 27);
            textBox1.TabIndex = 7;
            // 
            // InscripcionesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 414);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InscripcionesForm";
            Text = "Datos de Inscripciones";
            Load += inscripcionesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
    }
}