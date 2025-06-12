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
        }
        private void hidesubmenu()
        {
            if (panelSubMenu.Visible == true)
                panelSubMenu.Visible = false;
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
    }   
}
// This code is part of a Windows Forms application for a billing system.
// It includes the main form (Form1) with a method to customize the design and handle submenu visibility.// It includes the main form (Form1) with a method to customize the design and handle submenu visibility.
// The form contains methods to show and hide submenus, open child forms, and handle form events.// The form contains methods to show and hide submenus, open child forms, and handle form events.
// The `openChildForm` method allows opening child forms within the main form, managing active forms and their display properties.// The `openChildForm` method allows opening child forms within the main form, managing active forms and their display properties.
// The `customizeDesing` method initializes the design of the form.
// The `hidesubmenu` and `showsubmenu` methods manage the visibility of submenus.
// The `Form1_Load` method is an event handler for when the form loads.
// The `panel2_Paint` method is an event handler for painting operations on a panel.// The `panel2_Paint` method is an event handler for painting operations on a panel.
// The `button1_Click` and `button2_Click` methods handle button click events, with `button2_Click` showing the submenu.
// The class is part of the `Sistema_de_facturacion` namespace, indicating it is part of a billing system application.// The class is part of the `Sistema_de_facturacion` namespace, indicating it is part of a billing system application.
// This code is part of a Windows Forms application for a billing system.
// It includes the main form (Form1) with methods to customize the design and handle submenu visibility.
// The form contains methods to show and hide submenus, open child forms, and handle form events.// The form contains methods to show and hide submenus, open child forms, and handle form events.
// The `openChildForm` method allows opening child forms within the main form, managing active forms and their display properties.
// The `customizeDesing` method initializes the design of the form.
// The `hidesubmenu` and `showsubmenu` methods manage the visibility of submenus.
// The `Form1_Load` method is an event handler for when the form loads.
// The `panel2_Paint` method is an event handler for painting operations on a panel.
// The `button1_Click` and `button2_Click` methods handle button click events, with `button2_Click` showing the submenu.
// The class is part of the `Sistema_de_facturacion` namespace, indicating it is part of a billing system application.// The class is part of the `Sistema_de_facturacion` namespace, indicating it is part of a billing system application.
// This code is part of a Windows Forms application for a billing system.
// It includes the main form (Form1) with methods to customize the design and handle submenu visibility.
// The form contains methods to show and hide submenus, open child forms, and handle form events.// The form contains methods to show and hide submenus, open child forms, and handle form events.
// The `openChildForm` method allows opening child forms within the main form, managing active forms and their display properties.
// The `customizeDesing` method initializes the design of the form.
// The `hidesubmenu` and `showsubmenu` methods manage the visibility of submenus.
// The `Form1_Load` method is an event handler for when the form loads.
// The `panel2_Paint` method is an event handler for painting operations on a panel.
// The `button1_Click` and `button2_Click` methods handle button click events, with `button2_Click` showing the submenu.
// The class is part of the `Sistema_de_facturacion` namespace, indicating it is part of a billing system application.