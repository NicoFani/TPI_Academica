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
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            aceptarBtn = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            condicionCombobox = new ComboBox();
            label4 = new Label();
            nota = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 74);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 120);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Curso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 169);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Condición";
            // 
            // aceptarBtn
            // 
            aceptarBtn.Enabled = false;
            aceptarBtn.Location = new Point(623, 259);
            aceptarBtn.Margin = new Padding(3, 2, 3, 2);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(75, 23);
            aceptarBtn.TabIndex = 3;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = true;
            aceptarBtn.Click += acceptButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(740, 259);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancelButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(220, 71);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(596, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(220, 118);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(596, 23);
            comboBox2.TabIndex = 6;
            // 
            // condicionCombobox
            // 
            condicionCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            condicionCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            condicionCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            condicionCombobox.Enabled = false;
            condicionCombobox.FormattingEnabled = true;
            condicionCombobox.Items.AddRange(new object[] { "Cursando", "Aprobado", "Regular" });
            condicionCombobox.Location = new Point(220, 166);
            condicionCombobox.Name = "condicionCombobox";
            condicionCombobox.Size = new Size(595, 23);
            condicionCombobox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 216);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 12;
            label4.Text = "Nota";
            // 
            // nota
            // 
            nota.Enabled = false;
            nota.Location = new Point(220, 213);
            nota.Name = "nota";
            nota.Size = new Size(596, 23);
            nota.TabIndex = 13;
            // 
            // InscripcionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 310);
            Controls.Add(nota);
            Controls.Add(label4);
            Controls.Add(condicionCombobox);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(aceptarBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button aceptarBtn;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox condicionCombobox;
        private Label label4;
        private TextBox nota;
    }
}