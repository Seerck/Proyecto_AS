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
    public partial class Form_Ver_Producto : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;"; 
        static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Ver_Producto()
        {
            InitializeComponent();

            // Asignar eventos KeyPress para cada TextBox
            TxtId.KeyPress += textBoxID_KeyPress;
            TxtPrecio.KeyPress += TxtPrecio_KeyPress;
            TxtNombre.KeyPress += TxtNombre_KeyPress;
            TxtUbi.KeyPress += TxtUbi_KeyPress;
            TxtNivE.KeyPress += TxtNivE_KeyPress;
        }

        private void Form_Ver_Producto_Load(object sender, EventArgs e)
        {

        }
        public void mostrar_producto()
        {
            conectar.Open(); //abrimos la conexion a la bd
            SqlCommand comando = new SqlCommand("SELECT * FROM PRODUCTO", conectar); //creamos la consulta sql
            SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos la consulta de sql
            DataTable dt = new DataTable(); //creamos una tabla c#
            dato.Fill(dt); //rellenamos la tabla de c# con los datos obtenido al ejecutar la linea sql
            dataGridView1.DataSource = dt; //motramos los datos en el datagriedview

            conectar.Close(); //cerramos la conexion a la bd
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los campos de búsqueda
            string idProducto = TxtId.Text.Trim();
            string nombreProducto = TxtNombre.Text.Trim();
            string tipoProducto = TxtTipo.Text.Trim();
            string precioProducto = TxtPrecio.Text.Trim();
            string ubicacionProducto = TxtUbi.Text.Trim();
            string nivelEstante = TxtNivE.Text.Trim();

            // Verificar si todos los campos de texto están vacíos
            if (string.IsNullOrEmpty(idProducto) &&
                string.IsNullOrEmpty(nombreProducto) &&
                string.IsNullOrEmpty(tipoProducto) &&
                string.IsNullOrEmpty(precioProducto) &&
                string.IsNullOrEmpty(ubicacionProducto) &&
                string.IsNullOrEmpty(nivelEstante))
            {
                // Mostrar mensaje si todos los campos están vacíos
                MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución si no hay datos ingresados
            }

            // Si hay al menos un campo con datos, continuar con la búsqueda
            string query = @"SELECT Id, Nombre, Tipo, Cantidad, Precio, Caducidad, Ubicacion, FechaIngreso, Estado, NivelEstante 
                     FROM PRODUCTO WHERE 1=1"; // Consulta base

            // Crear una lista de parámetros para los valores que se ingresen
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Construir dinámicamente la consulta SQL según los campos que no estén vacíos
            if (!string.IsNullOrWhiteSpace(idProducto))
            {
                query += " AND Id = @Id";
                parameters.Add(new SqlParameter("@Id", idProducto));
            }

            if (!string.IsNullOrWhiteSpace(nombreProducto))
            {
                query += " AND Nombre LIKE @Nombre";
                parameters.Add(new SqlParameter("@Nombre", "%" + nombreProducto + "%"));
            }

            if (!string.IsNullOrWhiteSpace(tipoProducto))
            {
                query += " AND Tipo LIKE @Tipo";
                parameters.Add(new SqlParameter("@Tipo", "%" + tipoProducto + "%"));
            }

            if (!string.IsNullOrWhiteSpace(precioProducto))
            {
                query += " AND Precio = @Precio";
                parameters.Add(new SqlParameter("@Precio", precioProducto));
            }

            if (!string.IsNullOrWhiteSpace(ubicacionProducto))
            {
                query += " AND Ubicacion LIKE @Ubicacion";
                parameters.Add(new SqlParameter("@Ubicacion", "%" + ubicacionProducto + "%"));
            }

            if (!string.IsNullOrWhiteSpace(nivelEstante))
            {
                query += " AND NivelEstante LIKE @NivelEstante";
                parameters.Add(new SqlParameter("@NivelEstante", "%" + nivelEstante + "%"));
            }

            try
            {
                // Crear la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(inicio_sesion))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Añadir los parámetros dinámicos a la consulta
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(param);
                        }

                        // Crear un adaptador de datos para llenar el DataGridView
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();

                        // Llenar el DataTable con los datos de la consulta
                        adapter.Fill(dataTable);

                        // Asignar el DataTable al DataGridView
                        dataGridView1.DataSource = dataTable;
                    }

                    // Cerrar la conexión
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje si ocurre un error
                MessageBox.Show("Error al buscar los productos: " + ex.Message);
            }
        }
        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control como retroceso (Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignora el carácter
                MessageBox.Show("Solo se permiten números en este campo.");
            }
        }

        private void TxtNivE_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números y teclas de control como retroceso (Backspace)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignora el carácter
                MessageBox.Show("Solo se permiten letras y números en este campo.");
            }
        }

        private void TxtUbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir letras, números, espacios y teclas de control como retroceso (Backspace)
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignora el carácter
                MessageBox.Show("Solo se permiten letras, números y espacios en este campo.");
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control como retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignora el carácter
                MessageBox.Show("Solo se permiten letras y espacios en este campo.");
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, una coma o punto para decimales, y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Ignora el carácter
                MessageBox.Show("Solo se permiten números o decimales en este campo.");
            }
        }
    }
}