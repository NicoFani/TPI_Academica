namespace UI.Desktop
{
    partial class InscripcionesList
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
            dataGridView1 = new DataGridView();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(887, 372);
            dataGridView1.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(519, 469);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 31);
            addButton.TabIndex = 4;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(671, 469);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(86, 31);
            updateButton.TabIndex = 5;
            updateButton.Text = "Modificar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(815, 469);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 31);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // InscripcionesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 560);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Name = "InscripcionesList";
            Text = "Lista de Inscripciones";
            Load += Inscripciones_Load;
            Click += Inscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
    }
}