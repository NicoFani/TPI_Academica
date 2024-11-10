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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            materiasGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            yearInput = new TextBox();
            reloadBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planesGraph).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiasGraph).BeginInit();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 1024);
            panel1.TabIndex = 0;
            // 
            // profesoresBtn
            // 
            profesoresBtn.FlatAppearance.BorderSize = 0;
            profesoresBtn.FlatStyle = FlatStyle.Flat;
            profesoresBtn.Font = new Font("Segoe UI", 11F);
            profesoresBtn.ForeColor = Color.GhostWhite;
            profesoresBtn.Location = new Point(3, 312);
            profesoresBtn.Margin = new Padding(3, 4, 3, 4);
            profesoresBtn.Name = "profesoresBtn";
            profesoresBtn.Size = new Size(272, 39);
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
            cerrarSesionButton.Location = new Point(3, 765);
            cerrarSesionButton.Margin = new Padding(3, 4, 3, 4);
            cerrarSesionButton.Name = "cerrarSesionButton";
            cerrarSesionButton.Size = new Size(275, 39);
            cerrarSesionButton.TabIndex = 8;
            cerrarSesionButton.Text = "Cerrar Sesión";
            cerrarSesionButton.UseVisualStyleBackColor = true;
            cerrarSesionButton.Click += cerrarSesionButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._271_imagen_750x480xrecortarSuperior1;
            pictureBox1.Location = new Point(7, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 119);
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
            docentesCursosButton.Location = new Point(3, 545);
            docentesCursosButton.Margin = new Padding(3, 4, 3, 4);
            docentesCursosButton.Name = "docentesCursosButton";
            docentesCursosButton.Size = new Size(288, 39);
            docentesCursosButton.TabIndex = 7;
            docentesCursosButton.Text = "Docentes y Cursos";
            docentesCursosButton.UseVisualStyleBackColor = true;
            docentesCursosButton.Click += docentesCursosButton_Click;
            // 
            // planesButton
            // 
            planesButton.FlatAppearance.BorderSize = 0;
            planesButton.FlatStyle = FlatStyle.Flat;
            planesButton.Font = new Font("Segoe UI", 11F);
            planesButton.ForeColor = Color.GhostWhite;
            planesButton.Location = new Point(3, 592);
            planesButton.Margin = new Padding(3, 4, 3, 4);
            planesButton.Name = "planesButton";
            planesButton.Size = new Size(288, 39);
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
            especialidadesButton.Location = new Point(7, 499);
            especialidadesButton.Margin = new Padding(3, 4, 3, 4);
            especialidadesButton.Name = "especialidadesButton";
            especialidadesButton.Size = new Size(285, 39);
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
            cursosButton.Location = new Point(3, 452);
            cursosButton.Margin = new Padding(3, 4, 3, 4);
            cursosButton.Name = "cursosButton";
            cursosButton.Size = new Size(288, 39);
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
            materiasButton.Location = new Point(7, 405);
            materiasButton.Margin = new Padding(3, 4, 3, 4);
            materiasButton.Name = "materiasButton";
            materiasButton.Size = new Size(272, 39);
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
            comisionesButton.Location = new Point(3, 359);
            comisionesButton.Margin = new Padding(3, 4, 3, 4);
            comisionesButton.Name = "comisionesButton";
            comisionesButton.Size = new Size(272, 39);
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
            alumnosBtn.Location = new Point(3, 265);
            alumnosBtn.Margin = new Padding(3, 4, 3, 4);
            alumnosBtn.Name = "alumnosBtn";
            alumnosBtn.Size = new Size(272, 39);
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
            inscripcionesButton.Location = new Point(3, 219);
            inscripcionesButton.Margin = new Padding(3, 4, 3, 4);
            inscripcionesButton.Name = "inscripcionesButton";
            inscripcionesButton.Size = new Size(272, 39);
            inscripcionesButton.TabIndex = 0;
            inscripcionesButton.Text = "Inscripciones";
            inscripcionesButton.UseVisualStyleBackColor = true;
            inscripcionesButton.Click += inscripcionesButton_Click;
            // 
            // planesGraph
            // 
            chartArea1.Name = "ChartArea1";
            planesGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            planesGraph.Legends.Add(legend1);
            planesGraph.Location = new Point(302, 16);
            planesGraph.Margin = new Padding(3, 4, 3, 4);
            planesGraph.Name = "planesGraph";
            planesGraph.Size = new Size(1129, 353);
            planesGraph.TabIndex = 1;
            planesGraph.Text = "planes";
            // 
            // materiasGraph
            // 
            chartArea2.Name = "ChartArea1";
            materiasGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            materiasGraph.Legends.Add(legend2);
            materiasGraph.Location = new Point(302, 451);
            materiasGraph.Margin = new Padding(3, 4, 3, 4);
            materiasGraph.Name = "materiasGraph";
            materiasGraph.Size = new Size(1129, 353);
            materiasGraph.TabIndex = 2;
            materiasGraph.Text = "materias";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.GhostWhite;
            label1.Location = new Point(1185, 411);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 3;
            label1.Text = "Año";
            // 
            // yearInput
            // 
            yearInput.Font = new Font("Segoe UI", 11F);
            yearInput.Location = new Point(1233, 407);
            yearInput.Margin = new Padding(3, 4, 3, 4);
            yearInput.Name = "yearInput";
            yearInput.PlaceholderText = "2022";
            yearInput.Size = new Size(97, 32);
            yearInput.TabIndex = 4;
            yearInput.TextAlign = HorizontalAlignment.Right;
            // 
            // reloadBtn
            // 
            reloadBtn.BackColor = Color.GhostWhite;
            reloadBtn.FlatAppearance.BorderSize = 0;
            reloadBtn.FlatStyle = FlatStyle.Flat;
            reloadBtn.Font = new Font("Segoe UI", 11F);
            reloadBtn.ForeColor = Color.Black;
            reloadBtn.Location = new Point(1343, 405);
            reloadBtn.Margin = new Padding(3, 4, 3, 4);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(88, 39);
            reloadBtn.TabIndex = 10;
            reloadBtn.Text = "Aceptar";
            reloadBtn.UseVisualStyleBackColor = false;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // frmAdminMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1445, 820);
            Controls.Add(reloadBtn);
            Controls.Add(yearInput);
            Controls.Add(label1);
            Controls.Add(materiasGraph);
            Controls.Add(planesGraph);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdminMenu";
            Text = "Menu";
            Load += frmAdminMenu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)planesGraph).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiasGraph).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart materiasGraph;
        private Label label1;
        private TextBox yearInput;
        private Button reloadBtn;
    }
}