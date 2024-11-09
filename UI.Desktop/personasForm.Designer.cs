namespace UI.Desktop
{
    partial class personasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personasForm));
            pictureBox1 = new PictureBox();
            nombreInput = new TextBox();
            apellidoInput = new TextBox();
            label1 = new Label();
            userInput = new TextBox();
            label2 = new Label();
            contraseñaInput = new TextBox();
            label3 = new Label();
            direccionInput = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            telefonoInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            emailInput = new TextBox();
            label8 = new Label();
            nacimientoInput = new DateTimePicker();
            label9 = new Label();
            legajoInput = new TextBox();
            label10 = new Label();
            planInput = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nombreInput
            // 
            nombreInput.Anchor = AnchorStyles.None;
            nombreInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nombreInput.Location = new Point(17, 203);
            nombreInput.Name = "nombreInput";
            nombreInput.Size = new Size(350, 27);
            nombreInput.TabIndex = 0;
            // 
            // apellidoInput
            // 
            apellidoInput.Anchor = AnchorStyles.None;
            apellidoInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            apellidoInput.Location = new Point(17, 260);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(350, 27);
            apellidoInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(17, 180);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // userInput
            // 
            userInput.Anchor = AnchorStyles.None;
            userInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            userInput.Location = new Point(17, 317);
            userInput.Name = "userInput";
            userInput.Size = new Size(350, 27);
            userInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(17, 237);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // contraseñaInput
            // 
            contraseñaInput.Anchor = AnchorStyles.None;
            contraseñaInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            contraseñaInput.Location = new Point(17, 375);
            contraseñaInput.Name = "contraseñaInput";
            contraseñaInput.PasswordChar = '*';
            contraseñaInput.Size = new Size(350, 27);
            contraseñaInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(17, 295);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre de Usuario";
            // 
            // direccionInput
            // 
            direccionInput.Anchor = AnchorStyles.None;
            direccionInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            direccionInput.Location = new Point(513, 203);
            direccionInput.Name = "direccionInput";
            direccionInput.Size = new Size(350, 27);
            direccionInput.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(17, 352);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 5;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(513, 180);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Dirección";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.HotTrack;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(272, 496);
            button1.Name = "button1";
            button1.Size = new Size(350, 43);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // telefonoInput
            // 
            telefonoInput.Anchor = AnchorStyles.None;
            telefonoInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            telefonoInput.Location = new Point(512, 261);
            telefonoInput.Name = "telefonoInput";
            telefonoInput.Size = new Size(350, 27);
            telefonoInput.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(518, 239);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 8;
            label6.Text = "Telefono";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(518, 296);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 10;
            label7.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.Anchor = AnchorStyles.None;
            emailInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            emailInput.Location = new Point(512, 319);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(350, 27);
            emailInput.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(518, 352);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 11;
            label8.Text = "Fecha Nacimiento";
            // 
            // nacimientoInput
            // 
            nacimientoInput.Location = new Point(511, 376);
            nacimientoInput.Margin = new Padding(3, 4, 3, 4);
            nacimientoInput.Name = "nacimientoInput";
            nacimientoInput.Size = new Size(350, 27);
            nacimientoInput.TabIndex = 12;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(17, 408);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 13;
            label9.Text = "Legajo";
            // 
            // legajoInput
            // 
            legajoInput.Anchor = AnchorStyles.None;
            legajoInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            legajoInput.Location = new Point(17, 431);
            legajoInput.Name = "legajoInput";
            legajoInput.Size = new Size(350, 27);
            legajoInput.TabIndex = 14;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(518, 407);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 15;
            label10.Text = "Plan";
            // 
            // planInput
            // 
            planInput.FormattingEnabled = true;
            planInput.Location = new Point(511, 431);
            planInput.Margin = new Padding(3, 4, 3, 4);
            planInput.Name = "planInput";
            planInput.Size = new Size(350, 28);
            planInput.TabIndex = 16;
            // 
            // personasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(886, 571);
            Controls.Add(planInput);
            Controls.Add(label10);
            Controls.Add(legajoInput);
            Controls.Add(label9);
            Controls.Add(nacimientoInput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(emailInput);
            Controls.Add(label6);
            Controls.Add(telefonoInput);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(nombreInput);
            Controls.Add(direccionInput);
            Controls.Add(apellidoInput);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(contraseñaInput);
            Controls.Add(userInput);
            Controls.Add(label2);
            KeyPreview = true;
            Name = "personasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos de Persona";
            Load += personasForm_Load;
            KeyDown += personasForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox nombreInput;
        private TextBox apellidoInput;
        private Label label1;
        private TextBox userInput;
        private Label label2;
        private TextBox contraseñaInput;
        private Label label3;
        private TextBox direccionInput;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox telefonoInput;
        private Label label6;
        private Label label7;
        private TextBox emailInput;
        private Label label8;
        private DateTimePicker nacimientoInput;
        private Label label9;
        private TextBox legajoInput;
        private Label label10;
        private ComboBox planInput;
    }
}