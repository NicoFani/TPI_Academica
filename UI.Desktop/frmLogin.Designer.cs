namespace UI.Desktop
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            usuarioInput = new TextBox();
            claveInput = new TextBox();
            label2 = new Label();
            signInBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 78);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(86, 198);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // usuarioInput
            // 
            usuarioInput.Anchor = AnchorStyles.None;
            usuarioInput.Location = new Point(86, 216);
            usuarioInput.Margin = new Padding(3, 2, 3, 2);
            usuarioInput.Name = "usuarioInput";
            usuarioInput.Size = new Size(309, 23);
            usuarioInput.TabIndex = 3;
            // 
            // claveInput
            // 
            claveInput.Anchor = AnchorStyles.None;
            claveInput.Location = new Point(86, 273);
            claveInput.Margin = new Padding(3, 2, 3, 2);
            claveInput.Name = "claveInput";
            claveInput.Size = new Size(309, 23);
            claveInput.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(86, 256);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // signInBtn
            // 
            signInBtn.Anchor = AnchorStyles.None;
            signInBtn.BackColor = SystemColors.MenuHighlight;
            signInBtn.FlatAppearance.BorderColor = Color.White;
            signInBtn.FlatAppearance.BorderSize = 0;
            signInBtn.FlatStyle = FlatStyle.Flat;
            signInBtn.ForeColor = SystemColors.ButtonHighlight;
            signInBtn.Location = new Point(86, 346);
            signInBtn.Margin = new Padding(3, 2, 3, 2);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(309, 31);
            signInBtn.TabIndex = 6;
            signInBtn.Text = "Iniciar sesión";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += signInBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 20);
            label3.Name = "label3";
            label3.Size = new Size(275, 40);
            label3.TabIndex = 7;
            label3.Text = "ADMINISTRADORES";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 431);
            Controls.Add(label3);
            Controls.Add(signInBtn);
            Controls.Add(claveInput);
            Controls.Add(label2);
            Controls.Add(usuarioInput);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academica";
            Load += frmMain_Load;
            KeyDown += frmLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox usuarioInput;
        private TextBox claveInput;
        private Label label2;
        private Button signInBtn;
        private Label label3;
    }
}
