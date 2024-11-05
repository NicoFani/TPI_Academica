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
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            panel1 = new Panel();
            profesoresBtn = new Button();
            cerrarSesionButton = new Button();
            pictureBox1 = new PictureBox();
            docentesCursosButton = new Button();
            planesButton = new Button();
            especialidadesButton = new Button();
            cursosButton = new Button();
            materiasButton = new Button();
            comisionesButton = new Button();
            alumnosBtn = new Button();
            inscripcionesButton = new Button();
            planesGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planesGraph).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 119, 242);
            panel1.Controls.Add(profesoresBtn);
            panel1.Controls.Add(cerrarSesionButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(docentesCursosButton);
            panel1.Controls.Add(planesButton);
            panel1.Controls.Add(especialidadesButton);
            panel1.Controls.Add(cursosButton);
            panel1.Controls.Add(materiasButton);
            panel1.Controls.Add(comisionesButton);
            panel1.Controls.Add(alumnosBtn);
            panel1.Controls.Add(inscripcionesButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 768);
            panel1.TabIndex = 0;
            // 
            // profesoresBtn
            // 
            profesoresBtn.FlatAppearance.BorderSize = 0;
            profesoresBtn.FlatStyle = FlatStyle.Flat;
            profesoresBtn.Font = new Font("Segoe UI", 11F);
            profesoresBtn.ForeColor = Color.GhostWhite;
            profesoresBtn.Location = new Point(3, 304);
            profesoresBtn.Name = "profesoresBtn";
            profesoresBtn.Size = new Size(252, 29);
            profesoresBtn.TabIndex = 9;
            profesoresBtn.Text = "Profesores";
            profesoresBtn.UseVisualStyleBackColor = true;
            profesoresBtn.Click += profesoresBtn_Click;
            // 
            // cerrarSesionButton
            // 
            cerrarSesionButton.FlatAppearance.BorderSize = 0;
            cerrarSesionButton.FlatStyle = FlatStyle.Flat;
            cerrarSesionButton.Font = new Font("Segoe UI", 11F);
            cerrarSesionButton.ForeColor = Color.GhostWhite;
            cerrarSesionButton.Location = new Point(3, 720);
            cerrarSesionButton.Name = "cerrarSesionButton";
            cerrarSesionButton.Size = new Size(252, 29);
            cerrarSesionButton.TabIndex = 8;
            cerrarSesionButton.Text = "Cerrar Sesión";
            cerrarSesionButton.UseVisualStyleBackColor = true;
            cerrarSesionButton.Click += cerrarSesionButton_Click;
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
            docentesCursosButton.Location = new Point(3, 479);
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
            planesButton.Location = new Point(3, 514);
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
            especialidadesButton.Location = new Point(6, 444);
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
            cursosButton.Location = new Point(3, 409);
            cursosButton.Name = "cursosButton";
            cursosButton.Size = new Size(252, 29);
            cursosButton.TabIndex = 4;
            cursosButton.Text = "Cursos";
            cursosButton.UseVisualStyleBackColor = true;
            cursosButton.Click += cursosButton_Click;
            // 
            // materiasButton
            // 
            materiasButton.FlatAppearance.BorderSize = 0;
            materiasButton.FlatStyle = FlatStyle.Flat;
            materiasButton.Font = new Font("Segoe UI", 11F);
            materiasButton.ForeColor = Color.GhostWhite;
            materiasButton.Location = new Point(6, 374);
            materiasButton.Name = "materiasButton";
            materiasButton.Size = new Size(249, 29);
            materiasButton.TabIndex = 3;
            materiasButton.Text = "Materias";
            materiasButton.UseVisualStyleBackColor = true;
            materiasButton.Click += materiasButton_Click;
            // 
            // comisionesButton
            // 
            comisionesButton.FlatAppearance.BorderSize = 0;
            comisionesButton.FlatStyle = FlatStyle.Flat;
            comisionesButton.Font = new Font("Segoe UI", 11F);
            comisionesButton.ForeColor = Color.GhostWhite;
            comisionesButton.Location = new Point(3, 339);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(252, 29);
            comisionesButton.TabIndex = 2;
            comisionesButton.Text = "Comisiones";
            comisionesButton.UseVisualStyleBackColor = true;
            comisionesButton.Click += comisionesButton_Click;
            // 
            // alumnosBtn
            // 
            alumnosBtn.FlatAppearance.BorderSize = 0;
            alumnosBtn.FlatStyle = FlatStyle.Flat;
            alumnosBtn.Font = new Font("Segoe UI", 11F);
            alumnosBtn.ForeColor = Color.GhostWhite;
            alumnosBtn.Location = new Point(3, 269);
            alumnosBtn.Name = "alumnosBtn";
            alumnosBtn.Size = new Size(252, 29);
            alumnosBtn.TabIndex = 1;
            alumnosBtn.Text = "Alumnos";
            alumnosBtn.UseVisualStyleBackColor = true;
            alumnosBtn.Click += alumnosBtn_Click;
            // 
            // inscripcionesButton
            // 
            inscripcionesButton.FlatAppearance.BorderSize = 0;
            inscripcionesButton.FlatStyle = FlatStyle.Flat;
            inscripcionesButton.Font = new Font("Segoe UI", 11F);
            inscripcionesButton.ForeColor = Color.GhostWhite;
            inscripcionesButton.Location = new Point(3, 234);
            inscripcionesButton.Name = "inscripcionesButton";
            inscripcionesButton.Size = new Size(252, 29);
            inscripcionesButton.TabIndex = 0;
            inscripcionesButton.Text = "Inscripciones";
            inscripcionesButton.UseVisualStyleBackColor = true;
            // 
            // planesGraph
            // 
            chartArea1.Name = "ChartArea1";
            planesGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            planesGraph.Legends.Add(legend1);
            planesGraph.Location = new Point(264, 12);
            planesGraph.Name = "planesGraph";
            planesGraph.Size = new Size(988, 265);
            planesGraph.TabIndex = 1;
            planesGraph.Text = "planes";
            // 
            // frmAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1264, 761);
            Controls.Add(planesGraph);
            Controls.Add(panel1);
            Name = "frmAdminMenu";
            Text = "Menu";
            Load += frmAdminMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)planesGraph).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button inscripcionesButton;
        private Button cursosButton;
        private Button materiasButton;
        private Button comisionesButton;
        private Button alumnosBtn;
        private Button docentesCursosButton;
        private Button planesButton;
        private Button especialidadesButton;
        private PictureBox pictureBox1;
        private Button cerrarSesionButton;
        private Button profesoresBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart planesGraph;
    }
}