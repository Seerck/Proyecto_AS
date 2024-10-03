using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //usamos para utilizar sql

namespace Proyecto_AS
{
    public partial class Form_Añadir_Usuario : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la coneccion*/

        public Form_Añadir_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Añadir_Usuario_Load(object sender, EventArgs e)
        {
        
        }

        public void consulta_usuario()
        {
            conectar.Open(); //abrimos la conexion a la bd
            //SqlCommand comando = new SqlCommand("SELECT * FROM USUARIO WHERE Nombre LIKE '" + txtUsuario.Text + "%' AND Contraseña LIKE '" + txtContraseña.Text + "%' OR TipoUsuario LIKE '" + cmbTipoUsuario.Text + "%' AND TipoUsuario <> 'Seleccionar'", conectar);
            SqlCommand comando = new SqlCommand("SELECT * FROM USUARIO WHERE Nombre LIKE '" + txtbuscar.Text + "%'", conectar); //creamos la consulta sql
            SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos la consulta de sql
            DataTable dt = new DataTable(); //creamos una tabla c#
            dato.Fill(dt); //rellenamos la tabla de c# con los datos obtenido al ejecutar la linea sql
            dataGridView1.DataSource = dt; //motramos los datos en el datagriedview
            
            txtbuscar.Text = "";

            conectar.Close(); //cerramos la conexion a la bd
        }

        public void sp_agregar()
        {
            if (txtUsuario.Text != "" & txtContraseña.Text != "" & cmbTipoUsuario.SelectedIndex > -1)
            {
                string sp = "INS_USUARIO"; //creamos un string con el nombre del procedimiento almacenado
                conectar.Open(); //abrimos la conexion con la bd
                SqlDataAdapter dato = new SqlDataAdapter(sp, conectar); //ejecutamos el sp
                DataTable dt = new DataTable(); //creamos una tabla c#
                dato.SelectCommand.CommandType = CommandType.StoredProcedure; //le decimos a c# que ejecutaremos un sp
                dato.SelectCommand.Parameters.Add("@Nombre", SqlDbType.Text).Value = txtUsuario.Text;
                dato.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.Text).Value = txtContraseña.Text;
                dato.SelectCommand.Parameters.Add("@TipoUsuario", SqlDbType.Text).Value = cmbTipoUsuario.Text;
                dato.Fill(dt);
                conectar.Close();

                MessageBox.Show("El usuario a sido agregado correctamente", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Rellene todos los campos porfavor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void limpiar_campos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cmbTipoUsuario.Text= "Seleccionar";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            sp_agregar();
            limpiar_campos();
        }
        //aqui se almacenan los codigos de keypress de los txt usuario/contraseña
        #region Keypress
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;  // Cancela cualquier tecla presionada, impidiendo que se escriba cualquier carácter
        }
        #endregion

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            consulta_usuario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
