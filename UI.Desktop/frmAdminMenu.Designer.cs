namespace UI.Desktop
{
    partial class frmAdminMenu
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
            panel1 = new Panel();
            cerrarSesionButton = new Button();
            pictureBox1 = new PictureBox();
            docentesCursosButton = new Button();
            planesButton = new Button();
            especialidadesButton = new Button();
            cursosButton = new Button();
            materiasButton = new Button();
            comisionesButton = new Button();
            personasButton = new Button();
            inscripcionesButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 119, 242);
            panel1.Controls.Add(cerrarSesionButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(docentesCursosButton);
            panel1.Controls.Add(planesButton);
            panel1.Controls.Add(especialidadesButton);
            panel1.Controls.Add(cursosButton);
            panel1.Controls.Add(materiasButton);
            panel1.Controls.Add(comisionesButton);
            panel1.Controls.Add(personasButton);
            panel1.Controls.Add(inscripcionesButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 582);
            panel1.TabIndex = 0;
            // 
            // cerrarSesionButton
            // 
            cerrarSesionButton.FlatAppearance.BorderSize = 0;
            cerrarSesionButton.FlatStyle = FlatStyle.Flat;
            cerrarSesionButton.Font = new Font("Segoe UI", 11F);
            cerrarSesionButton.ForeColor = Color.GhostWhite;
            cerrarSesionButton.Location = new Point(3, 540);
            cerrarSesionButton.Name = "cerrarSesionButton";
            cerrarSesionButton.Size = new Size(252, 29);
            cerrarSesionButton.TabIndex = 8;
            cerrarSesionButton.Text = "Cerrar Sesión";
            cerrarSesionButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._271_imagen_750x480xrecortarSuperior1;
            pictureBox1.Location = new Point(12, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // docentesCursosButton
            // 
            docentesCursosButton.FlatAppearance.BorderSize = 0;
            docentesCursosButton.FlatStyle = FlatStyle.Flat;
            docentesCursosButton.Font = new Font("Segoe UI", 11F);
            docentesCursosButton.ForeColor = Color.GhostWhite;
            docentesCursosButton.Location = new Point(3, 404);
            docentesCursosButton.Name = "docentesCursosButton";
            docentesCursosButton.Size = new Size(252, 29);
            docentesCursosButton.TabIndex = 7;
            docentesCursosButton.Text = "Docentes y Cursos";
            docentesCursosButton.UseVisualStyleBackColor = true;
            // 
            // planesButton
            // 
            planesButton.FlatAppearance.BorderSize = 0;
            planesButton.FlatStyle = FlatStyle.Flat;
            planesButton.Font = new Font("Segoe UI", 11F);
            planesButton.ForeColor = Color.GhostWhite;
            planesButton.Location = new Point(3, 369);
            planesButton.Name = "planesButton";
            planesButton.Size = new Size(252, 29);
            planesButton.TabIndex = 6;
            planesButton.Text = "Planes";
            planesButton.UseVisualStyleBackColor = true;
            planesButton.Click += planesButton_Click;
            // 
            // especialidadesButton
            // 
            especialidadesButton.FlatAppearance.BorderSize = 0;
            especialidadesButton.FlatStyle = FlatStyle.Flat;
            especialidadesButton.Font = new Font("Segoe UI", 11F);
            especialidadesButton.ForeColor = Color.GhostWhite;
            especialidadesButton.Location = new Point(6, 334);
            especialidadesButton.Name = "especialidadesButton";
            especialidadesButton.Size = new Size(249, 29);
            especialidadesButton.TabIndex = 5;
            especialidadesButton.Text = "Especialidades";
            especialidadesButton.UseVisualStyleBackColor = true;
            especialidadesButton.Click += especialidadesButton_Click;
            // 
            // cursosButton
            // 
            cursosButton.FlatAppearance.BorderSize = 0;
            cursosButton.FlatStyle = FlatStyle.Flat;
            cursosButton.Font = new Font("Segoe UI", 11F);
            cursosButton.ForeColor = Color.GhostWhite;
            cursosButton.Location = new Point(3, 299);
            cursosButton.Name = "cursosButton";
            cursosButton.Size = new Size(252, 29);
            cursosButton.TabIndex = 4;
            cursosButton.Text = "Cursos";
            cursosButton.UseVisualStyleBackColor = true;
            // 
            // materiasButton
            // 
            materiasButton.FlatAppearance.BorderSize = 0;
            materiasButton.FlatStyle = FlatStyle.Flat;
            materiasButton.Font = new Font("Segoe UI", 11F);
            materiasButton.ForeColor = Color.GhostWhite;
            materiasButton.Location = new Point(6, 264);
            materiasButton.Name = "materiasButton";
            materiasButton.Size = new Size(249, 29);
            materiasButton.TabIndex = 3;
            materiasButton.Text = "Materias";
            materiasButton.UseVisualStyleBackColor = true;
            // 
            // comisionesButton
            // 
            comisionesButton.FlatAppearance.BorderSize = 0;
            comisionesButton.FlatStyle = FlatStyle.Flat;
            comisionesButton.Font = new Font("Segoe UI", 11F);
            comisionesButton.ForeColor = Color.GhostWhite;
            comisionesButton.Location = new Point(3, 229);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(252, 29);
            comisionesButton.TabIndex = 2;
            comisionesButton.Text = "Comisiones";
            comisionesButton.UseVisualStyleBackColor = true;
            comisionesButton.Click += comisionesButton_Click;
            // 
            // personasButton
            // 
            personasButton.FlatAppearance.BorderSize = 0;
            personasButton.FlatStyle = FlatStyle.Flat;
            personasButton.Font = new Font("Segoe UI", 11F);
            personasButton.ForeColor = Color.GhostWhite;
            personasButton.Location = new Point(3, 194);
            personasButton.Name = "personasButton";
            personasButton.Size = new Size(252, 29);
            personasButton.TabIndex = 1;
            personasButton.Text = "Personas";
            personasButton.UseVisualStyleBackColor = true;
            // 
            // inscripcionesButton
            // 
            inscripcionesButton.FlatAppearance.BorderSize = 0;
            inscripcionesButton.FlatStyle = FlatStyle.Flat;
            inscripcionesButton.Font = new Font("Segoe UI", 11F);
            inscripcionesButton.ForeColor = Color.GhostWhite;
            inscripcionesButton.Location = new Point(3, 159);
            inscripcionesButton.Name = "inscripcionesButton";
            inscripcionesButton.Size = new Size(252, 29);
            inscripcionesButton.TabIndex = 0;
            inscripcionesButton.Text = "Inscripciones";
            inscripcionesButton.UseVisualStyleBackColor = true;
            // 
            // frmAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1096, 581);
            Controls.Add(panel1);
            Name = "frmAdminMenu";
            Text = "frmAdminMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button inscripcionesButton;
        private Button cursosButton;
        private Button materiasButton;
        private Button comisionesButton;
        private Button personasButton;
        private Button docentesCursosButton;
        private Button planesButton;
        private Button especialidadesButton;
        private PictureBox pictureBox1;
        private Button cerrarSesionButton;
    }
}