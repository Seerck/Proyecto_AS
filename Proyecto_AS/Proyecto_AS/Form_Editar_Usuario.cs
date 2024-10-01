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
    public partial class Form_Editar_Usuario : Form
    {
        static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
        SqlConnection conectar = new SqlConnection(inicio_sesion);
        public Form_Editar_Usuario()
        {
            InitializeComponent();
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

        public void editar()
        {
            if (txt_nombre.Text != "" & txt_pass.Text != "" & cmd_tipo.SelectedIndex > -1)
            {
               string edit = "UPDATE USUARIO SET Nombre = '" + txt_nombre.Text + "', Contraseña = '" + txt_pass.Text + "', TipoUsuario = '" + cmd_tipo.SelectedItem.ToString() + "' WHERE Id = '" + variable_id + "'";
                SqlCommand sqlCommand = new SqlCommand(edit, conectar);
                conectar.Open();
                sqlCommand.ExecuteNonQuery();
                conectar.Close();

                MessageBox.Show("Se han actualizado los datos del usuario");
            }
            else
            {
                MessageBox.Show("Falta rellenar todos los campos para realizar el cambio", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form_Editar_Usuario_Load(object sender, EventArgs e)
        {
            consulta_usuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            consulta_usuario();
            editar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //consulta_usuario();
        }   

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            conectar.Open();
            string consulta = "SELECT * FROM USUARIO WHERE Nombre = '" + txt_buscar.Text + "'";
            
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

            txt_buscar.Text = "";
            conectar.Close();
        }

        string variable_id;

        private void btn_extraer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)  // Comprueba si hay filas seleccionadas
            {
                // Obtenemos la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Asignamos los valores de las columnas a los controles
                txt_nombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();  // Rellena el TextBox del nombre
                txt_pass.Text = filaSeleccionada.Cells["Contraseña"].Value.ToString();  // Rellena el TextBox de la contraseña

                variable_id = filaSeleccionada.Cells["Id"].Value.ToString();

                // Asegúrate de usar el nombre correcto de la columna
                string rolSeleccionado = filaSeleccionada.Cells["TipoUsuario"]?.Value?.ToString();  // Extrae el rol, asegurando que no sea nulo

                if (!string.IsNullOrEmpty(rolSeleccionado))
                {
                    // Establece el rol en el ComboBox
                    if (cmd_tipo.Items.Contains(rolSeleccionado))
                    {
                        cmd_tipo.SelectedItem = rolSeleccionado;  // Establece el valor si existe
                    }
                    else
                    {
                        MessageBox.Show("El rol seleccionado no está disponible en el ComboBox.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró un rol para el usuario seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para extraer los datos.");
            }
        }
    }
}
