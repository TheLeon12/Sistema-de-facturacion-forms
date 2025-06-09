
namespace Sistema_de_facturacion
{
    partial class Form18
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
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 59);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE CLIENTES";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(178, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 601);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(520, 31);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 232);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 6;
            label5.Text = "N° Identificación:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(193, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(520, 31);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(520, 31);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cédula", "Pasaporte", "RUC", "Otro" });
            comboBox1.Location = new Point(193, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(520, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 170);
            label4.Name = "label4";
            label4.Size = new Size(161, 25);
            label4.TabIndex = 2;
            label4.Text = "Tipo Identificación:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 1;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 296);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 2;
            label6.Text = "Teléfono:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 354);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 8;
            label7.Text = "Celular:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 408);
            label8.Name = "label8";
            label8.Size = new Size(70, 25);
            label8.TabIndex = 9;
            label8.Text = "Correo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 460);
            label9.Name = "label9";
            label9.Size = new Size(85, 25);
            label9.TabIndex = 10;
            label9.Text = "Dirección";
            label9.Click += label9_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(193, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(520, 31);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(193, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(520, 31);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(193, 402);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(520, 31);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(193, 454);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(520, 31);
            textBox7.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(6, 533);
            button1.Name = "button1";
            button1.Size = new Size(176, 34);
            button1.TabIndex = 15;
            button1.Text = "Registrar Cliente ";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(26, 712);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1045, 225);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellidos:";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tipo Identificación:";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column4
            // 
            Column4.HeaderText = "N° Identificación:";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // Column5
            // 
            Column5.HeaderText = "Teléfono:";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 120;
            // 
            // Column6
            // 
            Column6.HeaderText = "Celular:";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // Column7
            // 
            Column7.HeaderText = "Correo:";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.Width = 120;
            // 
            // Column8
            // 
            Column8.HeaderText = "Dirección";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.Width = 120;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 1034);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form18";
            Text = "Form18";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
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
    }
}