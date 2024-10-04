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

        }

        private void Form_Ver_Producto_Load(object sender, EventArgs e)
        {
            BtnBuscar.Enabled = false;
        }

        private void validarCampos()
        {
            var vr = !string.IsNullOrEmpty(TxtNombre.Text) &&
                     !string.IsNullOrEmpty(TxtTipo.Text);
                     BtnBuscar.Enabled = vr;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }
        private void TxtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCampos();
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

        private void TxtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Llamar al método de búsqueda
            BuscarProductos();
        }

        private void BuscarProductos()
        {

            try
            {
                StringBuilder query = new StringBuilder("SELECT * FROM PRODUCTO WHERE 1=1");
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    query.Append(" AND Nombre LIKE @Nombre");
                    parameters.Add(new SqlParameter("@Nombre", "%" + TxtNombre.Text + "%"));
                }
                if (!string.IsNullOrWhiteSpace(TxtTipo.Text))
                {
                    query.Append(" AND Tipo LIKE @Tipo");
                    parameters.Add(new SqlParameter("@Tipo", "%" + TxtTipo.Text + "%"));
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
                            MessageBox.Show("No hay productos con ese nombre o tipo.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los productos: " + ex.Message);
            
            }
        }
    }
}