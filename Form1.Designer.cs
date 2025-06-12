namespace Sistema_de_facturacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panelmenulateral = new Panel();
            panelSubMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            adminbt = new Button();
            panel1 = new Panel();
            button1 = new Button();
            PanelLogo = new Panel();
            panelChildForm = new Panel();
            Panelmenulateral.SuspendLayout();
            panelSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panelmenulateral
            // 
            Panelmenulateral.BackColor = Color.FromArgb(13, 61, 161);
            Panelmenulateral.Controls.Add(panelSubMenu);
            Panelmenulateral.Controls.Add(panel2);
            Panelmenulateral.Controls.Add(panel1);
            Panelmenulateral.Controls.Add(PanelLogo);
            Panelmenulateral.Dock = DockStyle.Left;
            Panelmenulateral.Location = new Point(0, 0);
            Panelmenulateral.Margin = new Padding(4);
            Panelmenulateral.Name = "Panelmenulateral";
            Panelmenulateral.Size = new Size(231, 544);
            Panelmenulateral.TabIndex = 7;
            // 
            // panelSubMenu
            // 
            panelSubMenu.Controls.Add(button5);
            panelSubMenu.Controls.Add(button4);
            panelSubMenu.Controls.Add(button3);
            panelSubMenu.Dock = DockStyle.Top;
            panelSubMenu.Location = new Point(0, 198);
            panelSubMenu.Name = "panelSubMenu";
            panelSubMenu.Size = new Size(231, 159);
            panelSubMenu.TabIndex = 3;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 92);
            button5.Name = "button5";
            button5.Size = new Size(231, 46);
            button5.TabIndex = 2;
            button5.Text = "Comprobantes";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Location = new Point(0, 46);
            button4.Name = "button4";
            button4.Size = new Size(231, 46);
            button4.TabIndex = 1;
            button4.Text = "Negocio";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(231, 46);
            button3.TabIndex = 0;
            button3.Text = "Usuarios";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(adminbt);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 46);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // adminbt
            // 
            adminbt.Dock = DockStyle.Right;
            adminbt.Location = new Point(88, 0);
            adminbt.Name = "adminbt";
            adminbt.Size = new Size(143, 46);
            adminbt.TabIndex = 0;
            adminbt.Text = "Administracion";
            adminbt.UseVisualStyleBackColor = true;
            adminbt.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 46);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Location = new Point(119, 0);
            button1.Name = "button1";
            button1.Size = new Size(112, 46);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // PanelLogo
            // 
            PanelLogo.Dock = DockStyle.Top;
            PanelLogo.Location = new Point(0, 0);
            PanelLogo.Name = "PanelLogo";
            PanelLogo.Size = new Size(231, 106);
            PanelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(231, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(697, 544);
            panelChildForm.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 544);
            Controls.Add(panelChildForm);
            Controls.Add(Panelmenulateral);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Panelmenulateral.ResumeLayout(false);
            panelSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Panelmenulateral;
        private Panel PanelLogo;
        private Panel panel2;
        private Button adminbt;
        private Panel panel1;
        private Button button1;
        private Panel panelSubMenu;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panelChildForm;
    }
}
