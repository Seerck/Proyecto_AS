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
               string edit = "UPDATE USUARIO SET Nombre = '" + txt_nombre.Text + "', Contraseña = '" + txt_pass.Text + "', TipoUsuario = '" + cmd_tipo.SelectedItem.ToString() + "' WHERE ID = @ID ";
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
            consulta_usuario();
        }
    }
}
