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

                dataGridView1.DataSource = null;   // Limpiar datos anteriores

                MessageBox.Show("Se han actualizado los datos del usuario");

                conectar.Open();
                string consulta = "SELECT * FROM USUARIO WHERE Id = '" + variable_id + "'";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conectar); // Ejecutamos la consulta con SqlDataAdapter
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                conectar.Close();

                dataGridView1.DataSource = null;   // Limpiar datos anteriores
                dataGridView1.DataSource = dt;     // Asignar los nuevos datos
                dataGridView1.Refresh();           // Forzar refresco
            }
            else
            {
                MessageBox.Show("Falta rellenar todos los campos para realizar el cambio", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Form_Editar_Usuario_Load(object sender, EventArgs e)
        {
            //consulta_usuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            consulta_usuario();
            editar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el código ASCII del carácter presionado
            int asciiCode = (int)e.KeyChar;

            // Permitir solo letras del abecedario (códigos ASCII entre 65-90 para mayúsculas y 97-122 para minúsculas y 8 para la tecla de borrar y 32 para el espacio)
            if (!((asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122) || asciiCode == 8 || asciiCode == 32))
            {
                // Si el carácter no es una letra, se cancela la entrada
                e.Handled = true;
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asciiCode = (int)e.KeyChar;

            // Permitir letras (A-Z, a-z), números (0-9) y la tecla de borrar (Backspace)
            // ASCII 8 corresponde a Backspace
            // Números 0-9: ASCII 48-57

            if (!((asciiCode >= 65 && asciiCode <= 90) ||   // Mayúsculas A-Z
                  (asciiCode >= 97 && asciiCode <= 122) ||  // Minúsculas a-z
                  (asciiCode >= 48 && asciiCode <= 57) ||   // Números 0-9
                  asciiCode == 8))                          // Tecla de borrar (Backspace)
            {
                // Si no es una letra, número o Backspace, se cancela la entrada
                e.Handled = true;
            }
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Obtener el código ASCII del carácter presionado
            int asciiCode = (int)e.KeyChar;

            // Permitir solo letras del abecedario (códigos ASCII entre 65-90 para mayúsculas y 97-122 para minúsculas y 8 para la tecla de borrar y 32 para el espacio)
            if (!((asciiCode >= 65 && asciiCode <= 90) || (asciiCode >= 97 && asciiCode <= 122) || asciiCode == 8 || asciiCode == 32))
            {
                // Si el carácter no es una letra, se cancela la entrada
                e.Handled = true;
            }
        }

        private void cmd_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Cancela cualquier tecla presionada, impidiendo que se escriba cualquier carácter
        }
    }
}
