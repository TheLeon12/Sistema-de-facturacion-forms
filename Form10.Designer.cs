namespace Sistema_de_facturacion
{
    partial class Form10
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
            groupBox1 = new GroupBox();
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
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 37);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = " LISTA DE PRODUCTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(272, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(27, 86);
            button1.Name = "button1";
            button1.Size = new Size(187, 34);
            button1.TabIndex = 1;
            button1.Text = "Nuevo Producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(240, 86);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 2;
            button2.Text = " Exportar Excel";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dataGridView1.Location = new Point(12, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(987, 236);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Imagen";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Código";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Marca";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Descripción";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Categoría";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Stock";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Precio";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Estado";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Acciones";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form10";
            Text = "Form10";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}