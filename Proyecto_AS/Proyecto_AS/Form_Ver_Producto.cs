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
        //static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public Form_Ver_Producto()
        {
            InitializeComponent();

        }

        private void Form_Ver_Producto_Load(object sender, EventArgs e)
        {
            //BtnBuscar.Enabled = false;
        }

        private void validarCampos()
        {
            var vr = !string.IsNullOrEmpty(TxtNombre.Text) &&
                     !string.IsNullOrEmpty(TxtTipo.Text);
                     BtnBuscar.Enabled = vr;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            //validarCampos();
        }
        private void TxtTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validarCampos();
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
            // Validar que se haya seleccionado una opción válida
            if (TxtTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una opción válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Usamos un bloque using para asegurar que la conexión se cierra correctamente
                using (SqlConnection conectar = new SqlConnection(inicio_sesion))
                {

                conectar.Open();

                // Consulta usando parámetros para evitar inyección de SQL
                string consulta = "SELECT * FROM PRODUCTO WHERE Nombre LIKE '" + TxtNombre.Text + "%' AND Tipo = '" + TxtTipo.SelectedItem.ToString() + "' AND Estado = 'habilitado'";

                using (SqlCommand comando = new SqlCommand(consulta, conectar))
                {

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar); // Ejecutamos la consulta con SqlDataAdapter
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)  // Verificamos si se encontraron resultados
                {
                    dataGridView1.DataSource = dt;  // Si hay resultados, los mostramos en el DataGridView
                }

                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre o tipo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;  // Limpiamos el DataGridView si no encontramos ningun nombre
                }
            }
        }

                TxtNombre.Text = "";
                TxtTipo.SelectedIndex = -1;
                conectar.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los productos: " + ex.Message);
            
            }
        }
    }
}