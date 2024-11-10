namespace UI.Desktop.Profesor {
    partial class AsignacionNotasAlumno {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            title = new Label();
            aceptarBtn = new Button();
            alumnoInfo = new Label();
            condicionText = new Label();
            notaText = new Label();
            condicionCombobox = new ComboBox();
            nota = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoEllipsis = true;
            title.Font = new Font("Segoe UI", 11F);
            title.Location = new Point(12, 12);
            title.Name = "title";
            title.Size = new Size(657, 31);
            title.TabIndex = 5;
            title.Text = "Curso Info";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // aceptarBtn
            // 
            aceptarBtn.BackColor = Color.Black;
            aceptarBtn.Enabled = false;
            aceptarBtn.FlatAppearance.BorderColor = Color.Black;
            aceptarBtn.FlatStyle = FlatStyle.Popup;
            aceptarBtn.Font = new Font("Segoe UI", 11F);
            aceptarBtn.ForeColor = Color.GhostWhite;
            aceptarBtn.Location = new Point(281, 253);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(126, 31);
            aceptarBtn.TabIndex = 6;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = false;
            aceptarBtn.Click += aceptarBtn_Click;
            // 
            // alumnoInfo
            // 
            alumnoInfo.Font = new Font("Segoe UI", 11F);
            alumnoInfo.Location = new Point(12, 63);
            alumnoInfo.Name = "alumnoInfo";
            alumnoInfo.Size = new Size(657, 31);
            alumnoInfo.TabIndex = 7;
            alumnoInfo.Text = "Alumno Info";
            alumnoInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // condicionText
            // 
            condicionText.Font = new Font("Segoe UI", 11F);
            condicionText.Location = new Point(160, 135);
            condicionText.Name = "condicionText";
            condicionText.Size = new Size(91, 25);
            condicionText.TabIndex = 8;
            condicionText.Text = "Condicion";
            condicionText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // notaText
            // 
            notaText.Font = new Font("Segoe UI", 11F);
            notaText.Location = new Point(160, 186);
            notaText.Name = "notaText";
            notaText.Size = new Size(91, 25);
            notaText.TabIndex = 9;
            notaText.Text = "Nota";
            notaText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // condicionCombobox
            // 
            condicionCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            condicionCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            condicionCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            condicionCombobox.Enabled = false;
            condicionCombobox.FormattingEnabled = true;
            condicionCombobox.Items.AddRange(new object[] { "Cursando", "Aprobado", "Regular" });
            condicionCombobox.Location = new Point(257, 135);
            condicionCombobox.Name = "condicionCombobox";
            condicionCombobox.Size = new Size(228, 23);
            condicionCombobox.TabIndex = 10;
            // 
            // nota
            // 
            nota.Enabled = false;
            nota.Location = new Point(257, 186);
            nota.Name = "nota";
            nota.Size = new Size(228, 23);
            nota.TabIndex = 11;
            // 
            // AsignacionNotasAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 296);
            Controls.Add(nota);
            Controls.Add(condicionCombobox);
            Controls.Add(notaText);
            Controls.Add(condicionText);
            Controls.Add(alumnoInfo);
            Controls.Add(aceptarBtn);
            Controls.Add(title);
            Name = "AsignacionNotasAlumno";
            Text = "Establecer Nota";
            Load += AsignacionNotasAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button aceptarBtn;
        private Label alumnoInfo;
        private Label condicionText;
        private Label notaText;
        private ComboBox condicionCombobox;
        private TextBox nota;
    }
}