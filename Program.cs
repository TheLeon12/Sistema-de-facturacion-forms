using Sistema_de_facturacion;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsConexionDB
{
    static class Program
    {
        // Conexión global accesible desde otros formularios
        public static SqlConnection Conexion;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string cadenaConexion = "Server=DESKTOP-ITEJDQK\\SQLEXPRESS;Database=SistemaFacturacion;Trusted_Connection=True;";

            try
            {
                Conexion = new SqlConnection(cadenaConexion);
                Conexion.Open(); // Se abre la conexión al iniciar la app
                MessageBox.Show("✔️ Conectado a la base de datos correctamente.");
                Application.Run(new Form1()); // Inicia el formulario principal
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión: " + ex.Message);
            }
        }
    }
}
