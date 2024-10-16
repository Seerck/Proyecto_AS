﻿using System;
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
        //wena mati
        //Creamos un string el cual contendra los datos para necesario para poder conectarse a la bd
        //static string inicio_sesion = "Server=LAPTOP-9H0B86NU ;Database=BD_AS ;User id=sa ;Password=697400naxo;";
        //static string inicio_sesion = "Server=DESKTOP-5RJ2UO2\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";
        //static string inicio_sesion = "Server=LAPTOP-PEB8KTKM ;Database=BD_AS ;User id=sa ;Password=1253351;";
        //static string inicio_sesion = "Server=LAPTOP-OBQGVQ1D ;Database=BD_AS ;User id=sa ;Password=2024;";
        static string inicio_sesion = "Server=PAOLO\\SQLEXPRESS ;Database=BD_AS ;User id=sa ;Password=12345678;";

        SqlConnection conectar = new SqlConnection(inicio_sesion); /*asignamos el comando para la conexion*/
        public class VG_TipoUsuario
        {
            public static string TipoUsuario;
        }
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
                    if (dt.Rows[0][0].ToString() =="administrador" || dt.Rows[0][0].ToString() =="usuario" || dt.Rows[0][0].ToString() == "super-usuario")
                    {
                        VG_TipoUsuario.TipoUsuario = dt.Rows[0][0].ToString();
                        Console.WriteLine($"Valor: {VG_TipoUsuario.TipoUsuario}, Tipo: {VG_TipoUsuario.TipoUsuario.GetType()}");
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
            //creamos una variable que contendra el resultado del mensaje ("si" o "no")
            DialogResult = MessageBox.Show("¿Desea salir del programa?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes) //si el resultado de la variable es "si"
            {
            Application.Exit();  //cerramos todos los formularios en conjunto a la aplicacion
            }
        }
    }
}
