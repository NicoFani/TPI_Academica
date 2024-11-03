namespace UI.Desktop
{
    partial class specialityForm
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
            descTextBox = new TextBox();
            label1 = new Label();
            acceptButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(124, 63);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(248, 23);
            descTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 66);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion";
            // 
            // acceptButton
            // 
            acceptButton.Location = new Point(191, 168);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(75, 23);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "Aceptar";
            acceptButton.UseVisualStyleBackColor = true;
            acceptButton.Click += acceptButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(297, 168);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Cancelar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += cancelButton_Click;
            // 
            // specialityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 215);
            Controls.Add(deleteButton);
            Controls.Add(acceptButton);
            Controls.Add(label1);
            Controls.Add(descTextBox);
            Name = "specialityForm";
            Text = "Especialidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descTextBox;
        private Label label1;
        private Button acceptButton;
        private Button deleteButton;
    }
}