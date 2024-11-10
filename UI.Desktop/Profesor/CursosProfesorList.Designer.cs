namespace UI.Desktop.Profesor {
    partial class CursosProfesorList {
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
            logOutBtn = new Button();
            DataGridView = new DataGridView();
            alumnosBtn = new Button();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.Black;
            logOutBtn.FlatAppearance.BorderColor = Color.Black;
            logOutBtn.FlatStyle = FlatStyle.Popup;
            logOutBtn.Font = new Font("Segoe UI", 11F);
            logOutBtn.ForeColor = Color.GhostWhite;
            logOutBtn.Location = new Point(12, 12);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(126, 31);
            logOutBtn.TabIndex = 0;
            logOutBtn.Text = "Cerrar Sesión";
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Click += cerrarSesionButton_Click;
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
            DataGridView.TabIndex = 1;
            // 
            // alumnosBtn
            // 
            alumnosBtn.BackColor = Color.Black;
            alumnosBtn.FlatAppearance.BorderColor = Color.Black;
            alumnosBtn.FlatStyle = FlatStyle.Popup;
            alumnosBtn.Font = new Font("Segoe UI", 11F);
            alumnosBtn.ForeColor = Color.GhostWhite;
            alumnosBtn.Location = new Point(662, 12);
            alumnosBtn.Name = "alumnosBtn";
            alumnosBtn.Size = new Size(126, 31);
            alumnosBtn.TabIndex = 2;
            alumnosBtn.Text = "Ver alumnos";
            alumnosBtn.UseVisualStyleBackColor = false;
            alumnosBtn.Click += alumnosBtn_Click;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 11F);
            title.Location = new Point(144, 17);
            title.Name = "title";
            title.Size = new Size(512, 23);
            title.TabIndex = 3;
            title.Text = "Profesor name";
            title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CursosProfesorList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(title);
            Controls.Add(alumnosBtn);
            Controls.Add(DataGridView);
            Controls.Add(logOutBtn);
            Name = "CursosProfesorList";
            Text = "Cursos Asignados";
            VisibleChanged += CursosProfesorList_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logOutBtn;
        private DataGridView DataGridView;
        private Button alumnosBtn;
        private Label title;
    }
}