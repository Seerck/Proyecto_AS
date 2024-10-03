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
            TxtTipo.KeyPress += TxtTipo_KeyPress;
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

        private void TxtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form_Ver_Producto_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Llamar al método de búsqueda
            BuscarProductos();
        }

        private void BuscarProductos()
        {
            string idProducto = TxtId.Text;
            string nombreProducto = TxtNombre.Text;
            string tipoProducto = TxtTipo.Text;
            string precioProducto = TxtPrecio.Text;
            string ubicacionProducto = TxtUbi.Text;
            string nivelEstante = TxtNivE.Text;

            // Verificar si todos los campos de texto están vacíos
            if (string.IsNullOrEmpty(idProducto) &&
                string.IsNullOrEmpty(nombreProducto) &&
                string.IsNullOrEmpty(tipoProducto) &&
                string.IsNullOrEmpty(precioProducto) &&
                string.IsNullOrEmpty(ubicacionProducto) &&
                string.IsNullOrEmpty(nivelEstante))
            {
                MessageBox.Show("Debe ingresar al menos un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StringBuilder query = new StringBuilder("SELECT * FROM PRODUCTO WHERE 1=1");
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(idProducto))
                {
                    query.Append(" AND Id = @Id");
                    parameters.Add(new SqlParameter("@Id", idProducto));
                }
                if (!string.IsNullOrWhiteSpace(nombreProducto))
                {
                    query.Append(" AND Nombre LIKE @Nombre");
                    parameters.Add(new SqlParameter("@Nombre", "%" + nombreProducto + "%"));
                }
                if (!string.IsNullOrWhiteSpace(tipoProducto))
                {
                    query.Append(" AND Tipo LIKE @Tipo");
                    parameters.Add(new SqlParameter("@Tipo", "%" + tipoProducto + "%"));
                }
                if (!string.IsNullOrWhiteSpace(precioProducto))
                {
                    query.Append(" AND Precio = @Precio");
                    parameters.Add(new SqlParameter("@Precio", decimal.Parse(precioProducto))); // Conversión a decimal
                }
                if (!string.IsNullOrWhiteSpace(ubicacionProducto))
                {
                    query.Append(" AND Ubicacion LIKE @Ubicacion");
                    parameters.Add(new SqlParameter("@Ubicacion", "%" + ubicacionProducto + "%"));
                }
                if (!string.IsNullOrWhiteSpace(nivelEstante))
                {
                    query.Append(" AND NivelEstante LIKE @NivelEstante");
                    parameters.Add(new SqlParameter("@NivelEstante", "%" + nivelEstante + "%"));
                }

                using (SqlConnection connection = new SqlConnection(inicio_sesion))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query.ToString(), connection))
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(param);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Limpiar el DataGridView antes de cargar nuevos datos
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dataTable;

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron productos con los criterios especificados.");
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato del precio: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los productos: " + ex.Message);
            }
        }
    }
}