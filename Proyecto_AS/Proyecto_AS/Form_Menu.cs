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
using static Proyecto_AS.Form_login;

namespace Proyecto_AS
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ocultar_paneles();
            mostrar_btnUsuarios();
        }

        private void ocultar_paneles() /*Creamos un metodo para ocultar los submenus al iniciar*/
        {
            panelProductosSubMenu.Visible = false; /*con esta linea ocultamos el submenu de productos*/
            panelUsuariosSubMenu.Visible = false;
        }

        private void hideSubMenu() /*creamos un funcion para ocultar los submenu*/ 
        {
            if (panelProductosSubMenu.Visible == true)
                panelProductosSubMenu.Visible = false;
            if (panelUsuariosSubMenu.Visible == true)
                panelUsuariosSubMenu.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu) 
        { /*creamos un funcion que muestre los sub menus cada vez que se le hacen click*/
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

                //ocultamos ciertos botones del submenu productos al rol usuario
                if(VG_TipoUsuario.TipoUsuario == "usuario")
                {
                    btnAñadirProductos.Visible = false; //ocultamos el boton añadir productos
                    btnEditarProductos.Visible = false; //ocualtamos el boton de editar productos
                    panelProductosSubMenu.Height = 41;  //cambiamos el tamaño del panel del submenu productos
                }
            }
            else
                subMenu.Visible = false;
        }
        #region subMenuProductos

        private void btnProductos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelProductosSubMenu);
        }

        private void btnMostrarProdutos_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Ver_Producto()); /*abrimos el form de ver productos en el panel*/
            hideSubMenu();
        }

        private void btnAñadirProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Añadir_Productos());
            hideSubMenu();
        }

        private void btnEditarProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Editar_Productos());
            hideSubMenu();
        }
        #endregion 

        #region subMenuUsuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelUsuariosSubMenu);
        }
        private void btnMostarUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Ver_Usuario());
            hideSubMenu();
        }

        private void btnAñadirUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Añadir_Usuario());
            hideSubMenu();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Editar_Usuario());
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null; /*esta linea nos dice si hay un formulario abierto*/
        private void openChildForm(Form chilForm)
        { /*creamos una funcion para abrir solo un form dentro del panel*/
            if (activeForm != null)
                activeForm.Close();
            activeForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(chilForm);
            panelChildForm.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }

        private void btnCerraSesion_Click(object sender, EventArgs e)
        {
            //creamos una variable que contendra el resultado del mensaje ("si" o "no")
            DialogResult = MessageBox.Show("¿Desea volver al login?", "confirmacion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(DialogResult == DialogResult.Yes) //si el resultado de la variable es "si"
            {
            this.Hide(); //cerramos el formulario actual
            new Form_login().Show(); //mostramor el form de login
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mostrar_btnUsuarios()
        {
            //creamos una funcion que oculte el boton de los usuario para los roles de usuario y super-usuario
            if (VG_TipoUsuario.TipoUsuario == "usuario" || VG_TipoUsuario.TipoUsuario == "super-usuario")
            {
                btnUsuarios.Visible = false;
                //Console.WriteLine($"Ancho: {panelProductosSubMenu.Width}, Alto: {panelProductosSubMenu.Height}");
            }
        }
    }

    
}
