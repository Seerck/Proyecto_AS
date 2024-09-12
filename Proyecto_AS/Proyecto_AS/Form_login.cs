using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; /*esto sirve para poder ocupar sql*/

namespace Proyecto_AS
{
    public partial class Form_login : Form
    {
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la coneccion*/
        public Form_login()
        {
            InitializeComponent();
        }

        public void iniciar(string nombre, string contraseña)
        {
            try 
            {
                conectar.Open(); /*abrimo la conexion a la base de datos*/
                //creamos la consulta de sql
                SqlCommand comando = new SqlCommand("SELECT TipoUsuario FROM USUARIO WHERE Nombre=@nombre and Contraseña=@contraseña",conectar);
                comando.Parameters.AddWithValue("nombre", nombre);
                comando.Parameters.AddWithValue("contraseña",contraseña);
                SqlDataAdapter dato = new SqlDataAdapter(comando); //ejecutamos el comando de sql
                DataTable dt = new DataTable(); //creamos una tabla en c#
                dato.Fill(dt); //rellenamos la tabla con los datos obtenidos al ejecutar la consulta sql

                if(dt.Rows.Count == 1)
                {
                    this.Hide(); //cerramos el formulario
                    if (dt.Rows[0][0].ToString() =="administrador" | dt.Rows[0][0].ToString() =="usuario")
                    {
                        new Form_Menu().Show();
                    }
                }

                else
                {
                    MessageBox.Show("El usuario o contraseña es incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); //esto nos muestra un mensaje del error
            }
            finally
            {
                conectar.Close(); //cerramos la conexion a la base de datos
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            iniciar(this.txtUsuario.Text, this.txtContraseña.Text); //agregamos el metodo iniciar al boton ingresar
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void txtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();  //cerramos todos los formularios en conjunto a la aplicacion
        }
    }
}
