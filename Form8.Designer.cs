namespace Sistema_de_facturacion
{
    partial class Form8
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 69);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista de Categoria ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 27);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 1;
            label2.Text = "Nueva Categoría";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 64);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripción:";
            // 
            // button1
            // 
            button1.Location = new Point(28, 153);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(315, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 205);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 31);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(315, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(474, 169);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripción";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "Acciones";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 106);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 5;
            label4.Text = "Estado:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "No Activo" });
            comboBox1.Location = new Point(140, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 33);
            comboBox1.TabIndex = 6;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 549);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form8";
            Text = "Form8";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox comboBox1;
        private Label label4;
    }
}