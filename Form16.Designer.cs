namespace Sistema_de_facturacion
{
    partial class Form16
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 69);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "LISTA DE USUARIOS";
            // 
            // button1
            // 
            button1.Location = new Point(341, 128);
            button1.Name = "button1";
            button1.Size = new Size(205, 34);
            button1.TabIndex = 1;
            button1.Text = "Nuevo Usuario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(584, 128);
            button2.Name = "button2";
            button2.Size = new Size(205, 34);
            button2.TabIndex = 2;
            button2.Text = "Mostrar 10 filas ";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(29, 201);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1044, 225);
            dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Foto";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 140;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = " Correo";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Teléfono";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 140;
            // 
            // Column5
            // 
            Column5.HeaderText = "Rol";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.HeaderText = "Estado";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 140;
            // 
            // Column7
            // 
            Column7.HeaderText = "Acciones";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 140;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 517);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form16";
            Text = "Form16";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}