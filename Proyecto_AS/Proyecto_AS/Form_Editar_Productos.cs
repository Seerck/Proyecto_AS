using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_AS
{
    public partial class Form_Editar_Productos : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        //static string inicio_sesion = "Server=PAOLO\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        //static string inicio_sesion = "Server=LAPTOP-OBQGVQ1D ;Database=BD_AS ;User id=sa ;Password=2024;";
        static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/

        public Form_Editar_Productos()
        {
            InitializeComponent();
        }
        public void consultar()
        {
            conectar.Open(); //abrimos la conexion a la bd
            SqlCommand comando = new SqlCommand("SELECT * FROM PRODUCTO", conectar); //creamos la consulta sql
            SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos la consulta de sql
            DataTable dt = new DataTable(); //creamos una tabla c#
            dato.Fill(dt); //rellenamos la tabla de c# con los datos obtenido al ejecutar la linea sql
            dataGridView1.DataSource = dt; //motramos los datos en el datagriedview

            conectar.Close(); //cerramos la conexion a la bd
        }

        public void insertar()
        {
            if (txt_nombre.Text != "" && cmb_tipo.SelectedIndex > -1 && txt_cantidad.Text != "" && txt_precio.Text != "" && txt_ubicacion.Text != "" &&
                txt_fecha_i.Text != "" && txt_fecha_v.Text != "" && cmb_estado.SelectedIndex > -1)
            {
                string cmd = "INSERT INTO PRODUCTO (Nombre, Tipo, Cantidad, Precio, Ubicacion, FechaIngreso, FechaSalida, Estado, NivelEstante) " +
             "VALUES ('" + txt_nombre.Text + "','" + cmb_tipo.Text + "', '" + txt_cantidad.Text + "','" + txt_precio.Text + "','" + txt_ubicacion.Text + "','" + txt_fecha_i.Text + "','" + txt_fecha_v.Text + "','" + cmb_estado.Text + "', '" + txt_nivel.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(cmd, conectar);
                conectar.Open();
                sqlCommand.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Se ha registrado correctamente");
            }
            else
            {
                MessageBox.Show("Rellene todos los campos porfavor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Editar_Productos_Load(object sender, EventArgs e)
        {
            consultar();
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {

        }

        private void estadocmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void estantecmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fechasalidacmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdtipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fechaingresocmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void ubicacioncmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombrecmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            consultar();

        }

        string variable_id;

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)  // Comprueba si hay filas seleccionadas
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];  // Obtenemos la fila seleccionada

                // Asignamos los valores de las columnas a los controles
                variable_id = filaSeleccionada.Cells["Id"].Value.ToString();
                txt_nombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string tipoSeleccionado = filaSeleccionada.Cells["Tipo"]?.Value?.ToString();
                
                if (!string.IsNullOrEmpty(tipoSeleccionado))
                {
                    cmb_tipo.SelectedItem = tipoSeleccionado;
                }
                else
                {
                    MessageBox.Show("El tipo no esta registrado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txt_cantidad.Text = filaSeleccionada.Cells["Cantidad"].Value?.ToString();
                txt_precio.Text = filaSeleccionada.Cells["Precio"].Value?.ToString();
                txt_ubicacion.Text = filaSeleccionada.Cells["Ubicacion"].Value?.ToString();
                txt_fecha_i.Text = filaSeleccionada.Cells["FechaIngreso"].Value?.ToString();
                txt_fecha_v.Text = filaSeleccionada.Cells["Caducidad"].Value?.ToString();
                txt_nivel.Text = filaSeleccionada.Cells["NivelEstante"].Value?.ToString();

                string tipoEstado = filaSeleccionada.Cells["Estado"]?.Value?.ToString();
                if (!string.IsNullOrEmpty(tipoEstado))
                {
                    cmb_estado.SelectedItem = tipoSeleccionado;
                }
                else
                {
                    MessageBox.Show("El estado no esta correctamente guardado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para extraer los datos.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) || cmb_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, ingrese el nombre y tipo de producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                conectar.Open();
                string consulta = "SELECT * FROM PRODUCTO WHERE Nombre LIKE '" + txt_nombre.Text + "%' AND Tipo = '" + cmb_tipo.SelectedItem.ToString() + "'";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar); // Ejecutamos la consulta con SqlDataAdapter
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)  // Verificamos si se encontraron resultados
                {
                    dataGridView1.DataSource = dt;  // Si hay resultados, los mostramos en el DataGridView
                }

                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;  // Limpiamos el DataGridView si no encontramos ningun nombre
                }

                txt_nombre.Text = "";
                cmb_tipo.SelectedIndex = -1;

                conectar.Close();
            }

        }
    }
}
