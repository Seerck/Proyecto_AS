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

namespace Proyecto_AS
{
    public partial class Form_Ver_Usuario : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Ver_Usuario()
        {
            InitializeComponent();
        }
        private void Form_Ver_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void BuscarUsuarios()
        {
            string nombreUsuario = txt_nombre.Text.Trim();
            string tipoUsuario = cmd_tipo.Text.Trim();

            // Verificar si ambos campos están vacíos
            if (string.IsNullOrEmpty(nombreUsuario) && string.IsNullOrEmpty(tipoUsuario))
            {
                MessageBox.Show("Debe ingresar un nombre o un tipo de usuario para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear la consulta base
                string query = "SELECT Nombre, TipoUsuario FROM USUARIO WHERE 1=1";
                List<SqlParameter> parametros = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(nombreUsuario))
                {
                    query += " AND Nombre = @Nombre";
                    parametros.Add(new SqlParameter("@Nombre", nombreUsuario));
                }

                if (!string.IsNullOrEmpty(tipoUsuario))
                {
                    query += " AND TipoUsuario LIKE @TipoUsuario";
                    parametros.Add(new SqlParameter("@TipoUsuario", "%" + tipoUsuario + "%"));
                }

                // Ejecutar la consulta
                using (SqlConnection conexion = new SqlConnection(inicio_sesion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddRange(parametros.ToArray());
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaDatos = new DataTable();
                        adaptador.Fill(tablaDatos);

                        // Mostrar resultados en el DataGridView
                        dataGridView1.DataSource = tablaDatos;

                        // Verificar si no hay resultados
                        if (tablaDatos.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron usuarios con esos criterios.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los usuarios: " + ex.Message);
            }
        }
private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
