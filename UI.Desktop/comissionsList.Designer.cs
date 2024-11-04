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
        private void InitializeComponent() {
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
            comissionDataGridView.Location = new Point(10, 9);
            comissionDataGridView.Margin = new Padding(3, 2, 3, 2);
            comissionDataGridView.Name = "comissionDataGridView";
            comissionDataGridView.ReadOnly = true;
            comissionDataGridView.RowHeadersWidth = 51;
            comissionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comissionDataGridView.Size = new Size(679, 245);
            comissionDataGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(607, 282);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(82, 22);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(498, 282);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(82, 22);
            updateButton.TabIndex = 2;
            updateButton.Text = "Modificar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(388, 282);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 22);
            addButton.TabIndex = 3;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // comissionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(addButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(comissionDataGridView);
            Margin = new Padding(3, 2, 3, 2);
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