using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_AS
{
    public partial class Form_Ver_Usuario : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/

        Dictionary<string, string> datos = new Dictionary<string, string>()
        {
            { "Opción 1", "usuario" },
            { "Opción 2", "super-usuario" },
            { "Opción 3", "administrador" }
        };
        public Form_Ver_Usuario()
        {
            InitializeComponent();
        }
        private void Form_Ver_Usuario_Load(object sender, EventArgs e)
        {
            //BtnBuscarU.Enabled = false;
            //consulta_usuario();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void consulta_usuario()
        {
            conectar.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM USUARIO", conectar);
            SqlDataAdapter dato = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            dato.Fill(dt);
            dataGridView1.DataSource = dt;
            conectar.Close();
        }

        private void validarCampo()
        {
            var vr = !string.IsNullOrEmpty(TxtNombreU.Text);
                     BtnBuscarU.Enabled = vr;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            //validarCampo();
        }

        private void cmd_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validarCampo();
        }
        private void BtnBuscarU_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una opción válida
            if (CBBTipoU.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una opción válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                conectar.Open();
                string consulta = "SELECT * FROM USUARIO WHERE Nombre LIKE '" + TxtNombreU.Text + "%' AND TipoUsuario = '" + CBBTipoU.SelectedItem.ToString() + "'";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar); // Ejecutamos la consulta con SqlDataAdapter
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)  // Verificamos si se encontraron resultados
                {
                    dataGridView1.DataSource = dt;  // Si hay resultados, los mostramos en el DataGridView
                }

                else
                {
                    MessageBox.Show("No se encontró ningún usuario con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;  // Limpiamos el DataGridView si no encontramos ningun nombre
                }

                TxtNombreU.Text = "";
                CBBTipoU.Text = "Seleccionar";
                conectar.Close();
            }
        }

        private void TxtNombreU_Keypress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control como retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignora el carácter
                MessageBox.Show("Solo se permiten letras y espacios en este campo.");
            }
        }
    }
}
