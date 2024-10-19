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
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            altasToolStripMenuItem = new ToolStripMenuItem();
            altasToolStripMenuItem1 = new ToolStripMenuItem();
            bajasToolStripMenuItem = new ToolStripMenuItem();
            modificacionesToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, altasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(48, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // altasToolStripMenuItem
            // 
            altasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altasToolStripMenuItem1, bajasToolStripMenuItem, modificacionesToolStripMenuItem, consultasToolStripMenuItem });
            altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            altasToolStripMenuItem.Size = new Size(67, 20);
            altasToolStripMenuItem.Text = "Acciones";
            altasToolStripMenuItem.Click += altasToolStripMenuItem_Click;
            // 
            // altasToolStripMenuItem1
            // 
            altasToolStripMenuItem1.Name = "altasToolStripMenuItem1";
            altasToolStripMenuItem1.Size = new Size(180, 22);
            altasToolStripMenuItem1.Text = "Altas";
            // 
            // bajasToolStripMenuItem
            // 
            bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            bajasToolStripMenuItem.Size = new Size(180, 22);
            bajasToolStripMenuItem.Text = "Bajas";
            // 
            // modificacionesToolStripMenuItem
            // 
            modificacionesToolStripMenuItem.Name = "modificacionesToolStripMenuItem";
            modificacionesToolStripMenuItem.Size = new Size(180, 22);
            modificacionesToolStripMenuItem.Text = "Modificaciones";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(180, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // frmAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmAdminMenu";
            Text = "frmAdminMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem altasToolStripMenuItem;
        private ToolStripMenuItem altasToolStripMenuItem1;
        private ToolStripMenuItem bajasToolStripMenuItem;
        private ToolStripMenuItem modificacionesToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
    }
}