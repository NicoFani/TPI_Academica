namespace UI.Desktop.Profesor {
    partial class AlumnosList {
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
            DataGridView = new DataGridView();
            alumnoBtn = new Button();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 60);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.Size = new Size(776, 378);
            DataGridView.TabIndex = 2;
            // 
            // alumnoBtn
            // 
            alumnoBtn.BackColor = Color.Black;
            alumnoBtn.FlatAppearance.BorderColor = Color.Black;
            alumnoBtn.FlatStyle = FlatStyle.Popup;
            alumnoBtn.Font = new Font("Segoe UI", 11F);
            alumnoBtn.ForeColor = Color.GhostWhite;
            alumnoBtn.Location = new Point(662, 12);
            alumnoBtn.Name = "alumnoBtn";
            alumnoBtn.Size = new Size(126, 31);
            alumnoBtn.TabIndex = 3;
            alumnoBtn.Text = "Asignar estado";
            alumnoBtn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 11F);
            title.Location = new Point(12, 16);
            title.Name = "title";
            title.Size = new Size(644, 23);
            title.TabIndex = 4;
            title.Text = "Curso Info";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlumnosList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(title);
            Controls.Add(alumnoBtn);
            Controls.Add(DataGridView);
            Name = "AlumnosList";
            Text = "Alumnos";
            Load += AlumnosList_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridView;
        private Button alumnoBtn;
        private Label title;
    }
}