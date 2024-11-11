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
        private void InitializeComponent() {
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            acceptButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cargoComboBox = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(220, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(596, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(220, 118);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(596, 23);
            comboBox2.TabIndex = 3;
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(606, 212);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(75, 23);
            acceptButton.TabIndex = 10;
            acceptButton.Text = "Aceptar";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(740, 212);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 74);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 12;
            label1.Text = "Curso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 120);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Docente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 169);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 14;
            label3.Text = "Cargo";
            // 
            // cargoComboBox
            // 
            cargoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cargoComboBox.FormattingEnabled = true;
            cargoComboBox.Items.AddRange(new object[] { "Profesor", "Auxiliar" });
            cargoComboBox.Location = new Point(220, 166);
            cargoComboBox.Name = "cargoComboBox";
            cargoComboBox.Size = new Size(596, 23);
            cargoComboBox.TabIndex = 15;
            // 
            // docentesCursosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 310);
            Controls.Add(cargoComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(acceptButton);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "docentesCursosForm";
            Text = "Datos de Docentes y Cursos";
            Load += docentesCursosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button acceptButton;
        private Button cancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cargoComboBox;
    }
}