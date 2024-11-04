namespace UI.Desktop
{
    partial class comissionsList
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
            comissionDataGridView = new DataGridView();
            deleteButton = new Button();
            updateButton = new Button();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)comissionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // comissionDataGridView
            // 
            comissionDataGridView.AllowUserToOrderColumns = true;
            comissionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comissionDataGridView.Location = new Point(12, 12);
            comissionDataGridView.Name = "comissionDataGridView";
            comissionDataGridView.ReadOnly = true;
            comissionDataGridView.RowHeadersWidth = 51;
            comissionDataGridView.Size = new Size(776, 327);
            comissionDataGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(694, 376);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(569, 376);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 2;
            updateButton.Text = "Modificar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(444, 376);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 3;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // comissionsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(comissionDataGridView);
            Name = "comissionsList";
            Text = "comissionsList";
            Load += Comissions_Load;
            ((System.ComponentModel.ISupportInitialize)comissionDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView comissionDataGridView;
        private Button deleteButton;
        private Button updateButton;
        private Button addButton;
    }
}