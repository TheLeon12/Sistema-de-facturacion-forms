namespace Sistema_de_facturacion
{
    partial class Form12
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 27);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Estado de Caja ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(224, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(438, 384);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 69);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Apertura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 147);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 2;
            label3.Text = "Monto Inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 226);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 3;
            label4.Text = "Monto Final:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(40, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(355, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(40, 175);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(355, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 254);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(355, 31);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(69, 306);
            button1.Name = "button1";
            button1.Size = new Size(131, 34);
            button1.TabIndex = 7;
            button1.Text = "Abrir Caja";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(234, 306);
            button2.Name = "button2";
            button2.Size = new Size(120, 34);
            button2.TabIndex = 8;
            button2.Text = "Cerrar Caja";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form12";
            Text = "Form12";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
    }
}