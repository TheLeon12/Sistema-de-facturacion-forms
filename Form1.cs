namespace Sistema_de_facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelSubMenu.Visible = false;
            PanelSubMenu2.Visible = false;
            PanelSubMenu3.Visible = false;
            PanelSubMenu4.Visible = false;
        }
        private void hidesubmenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
            if (PanelSubMenu2.Visible == true)
                PanelSubMenu2.Visible = false;

            if (PanelSubMenu3.Visible == true)
                PanelSubMenu3.Visible = false;
            if (PanelSubMenu4.Visible == true)
                PanelSubMenu4.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            showsubmenu(panelSubMenu);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            showsubmenu(PanelSubMenu4);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            showsubmenu(PanelSubMenu2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showsubmenu(PanelSubMenu3);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new DetalleDeUsuario());
            hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            hidesubmenu();

        }
       
    }
}
