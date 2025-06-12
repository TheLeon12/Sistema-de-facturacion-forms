namespace Sistema_de_facturacion
{
    partial class Clientes
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBox3 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox4 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 36);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(53, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 33);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Seleccione un cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 88);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 1;
            label2.Text = "Documento del Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 180);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre completo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 180);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 3;
            label4.Text = "Id del cliente ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 88);
            label5.Name = "label5";
            label5.Size = new Size(174, 25);
            label5.TabIndex = 4;
            label5.Text = "Seleccione un cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(370, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(53, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 31);
            textBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(664, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(280, 38);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 0;
            label6.Text = "Productos";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(53, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(551, 33);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Buscar Producto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(53, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(559, 160);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Producto";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(710, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(379, 345);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 27);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 0;
            label7.Text = "DETALLE DE PAGO ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 104);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 1;
            label8.Text = "Tipo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 162);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 2;
            label9.Text = "Sub total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 220);
            label10.Name = "label10";
            label10.Size = new Size(89, 25);
            label10.TabIndex = 3;
            label10.Text = "IGV(18%):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 279);
            label11.Name = "label11";
            label11.Size = new Size(53, 25);
            label11.TabIndex = 4;
            label11.Text = "Total:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(166, 101);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 33);
            comboBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 31);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(166, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 31);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(166, 276);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(182, 31);
            textBox6.TabIndex = 8;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(710, 391);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(379, 92);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // button1
            // 
            button1.Location = new Point(6, 30);
            button1.Name = "button1";
            button1.Size = new Size(367, 44);
            button1.TabIndex = 0;
            button1.Text = "TERMINAR VENTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 654);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form9";
            Text = "Form9";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private Label label6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox comboBox2;
        private GroupBox groupBox3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox comboBox3;
        private GroupBox groupBox4;
        private Button button1;
    }
}