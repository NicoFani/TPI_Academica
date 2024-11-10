namespace UI.Desktop
{
    partial class docentesCursosForm
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            acceptButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(252, 95);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(680, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(252, 157);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(680, 28);
            comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 222);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(680, 27);
            textBox1.TabIndex = 4;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(693, 283);
            acceptButton.Margin = new Padding(3, 4, 3, 4);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(86, 31);
            acceptButton.TabIndex = 10;
            acceptButton.Text = "Aceptar";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(846, 283);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(86, 31);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 98);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 12;
            label1.Text = "Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 160);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 13;
            label2.Text = "Docente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 225);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 14;
            label3.Text = "Cargo";
            // 
            // docentesCursosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 414);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "docentesCursosForm";
            Text = "Datos de Docentes y Cursos";
            Load += docentesCursosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Button acceptButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}