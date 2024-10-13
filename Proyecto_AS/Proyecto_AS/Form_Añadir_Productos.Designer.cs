namespace Proyecto_AS
{
    partial class Form_Añadir_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombrecmd = new System.Windows.Forms.TextBox();
            this.ubicacioncmd = new System.Windows.Forms.TextBox();
            this.fechaingresocmd = new System.Windows.Forms.TextBox();
            this.btnañadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.estantecmd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.estadocmb = new System.Windows.Forms.ComboBox();
            this.cmdtipo = new System.Windows.Forms.ComboBox();
            this.fecha_vencimientocmd = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(884, 304);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombrecmd
            // 
            this.nombrecmd.Location = new System.Drawing.Point(10, 28);
            this.nombrecmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombrecmd.MaxLength = 25;
            this.nombrecmd.Name = "nombrecmd";
            this.nombrecmd.Size = new System.Drawing.Size(261, 22);
            this.nombrecmd.TabIndex = 2;
            this.nombrecmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombrecmd_KeyPress);
            // 
            // ubicacioncmd
            // 
            this.ubicacioncmd.Location = new System.Drawing.Point(596, 74);
            this.ubicacioncmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ubicacioncmd.MaxLength = 25;
            this.ubicacioncmd.Name = "ubicacioncmd";
            this.ubicacioncmd.Size = new System.Drawing.Size(261, 22);
            this.ubicacioncmd.TabIndex = 5;
            this.ubicacioncmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ubicacioncmd_KeyPress);
            // 
            // fechaingresocmd
            // 
            this.fechaingresocmd.Location = new System.Drawing.Point(297, 72);
            this.fechaingresocmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaingresocmd.MaxLength = 10;
            this.fechaingresocmd.Name = "fechaingresocmd";
            this.fechaingresocmd.Size = new System.Drawing.Size(261, 22);
            this.fechaingresocmd.TabIndex = 6;
            this.fechaingresocmd.TextChanged += new System.EventHandler(this.fechaingresocmd_TextChanged);
            this.fechaingresocmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fechaingresocmd_KeyPress);
            // 
            // btnañadir
            // 
            this.btnañadir.Location = new System.Drawing.Point(717, 157);
            this.btnañadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(140, 41);
            this.btnañadir.TabIndex = 9;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ubicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha Vencimiento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nivel Estante";
            // 
            // estantecmd
            // 
            this.estantecmd.Location = new System.Drawing.Point(596, 119);
            this.estantecmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estantecmd.MaxLength = 3;
            this.estantecmd.Name = "estantecmd";
            this.estantecmd.Size = new System.Drawing.Size(261, 22);
            this.estantecmd.TabIndex = 18;
            this.estantecmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estantecmd_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Precio";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(10, 119);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad.MaxLength = 3;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(258, 22);
            this.txt_cantidad.TabIndex = 21;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(297, 28);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio.MaxLength = 6;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(261, 22);
            this.txt_precio.TabIndex = 22;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // estadocmb
            // 
            this.estadocmb.FormattingEnabled = true;
            this.estadocmb.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.estadocmb.Location = new System.Drawing.Point(596, 28);
            this.estadocmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadocmb.Name = "estadocmb";
            this.estadocmb.Size = new System.Drawing.Size(261, 24);
            this.estadocmb.TabIndex = 23;
            this.estadocmb.Text = "Seleccionar";
            this.estadocmb.SelectedIndexChanged += new System.EventHandler(this.estadocmb_SelectedIndexChanged);
            this.estadocmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadocmb_KeyPress);
            // 
            // cmdtipo
            // 
            this.cmdtipo.FormattingEnabled = true;
            this.cmdtipo.Items.AddRange(new object[] {
            "Cosmetico",
            "Ropa",
            "Electronico",
            "Calzado"});
            this.cmdtipo.Location = new System.Drawing.Point(10, 72);
            this.cmdtipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdtipo.Name = "cmdtipo";
            this.cmdtipo.Size = new System.Drawing.Size(261, 24);
            this.cmdtipo.TabIndex = 24;
            this.cmdtipo.Text = "Seleccionar";
            this.cmdtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmdtipo_KeyPress);
            // 
            // fecha_vencimientocmd
            // 
            this.fecha_vencimientocmd.Location = new System.Drawing.Point(297, 119);
            this.fecha_vencimientocmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fecha_vencimientocmd.MaxLength = 10;
            this.fecha_vencimientocmd.Name = "fecha_vencimientocmd";
            this.fecha_vencimientocmd.Size = new System.Drawing.Size(261, 22);
            this.fecha_vencimientocmd.TabIndex = 26;
            this.fecha_vencimientocmd.TextChanged += new System.EventHandler(this.fecha_vencimientocmd_TextChanged);
            this.fecha_vencimientocmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fechacaducidad_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(13, 157);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(140, 41);
            this.btn_buscar.TabIndex = 46;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.nombrecmd);
            this.panel1.Controls.Add(this.btnañadir);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.estantecmd);
            this.panel1.Controls.Add(this.estadocmb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.fecha_vencimientocmd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ubicacioncmd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdtipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fechaingresocmd);
            this.panel1.Location = new System.Drawing.Point(9, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 213);
            this.panel1.TabIndex = 47;
            // 
            // Form_Añadir_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(902, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Añadir_Productos";
            this.Load += new System.EventHandler(this.Form_Añadir_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombrecmd;
        private System.Windows.Forms.TextBox ubicacioncmd;
        private System.Windows.Forms.TextBox fechaingresocmd;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox estantecmd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.ComboBox estadocmb;
        private System.Windows.Forms.ComboBox cmdtipo;
        private System.Windows.Forms.TextBox fecha_vencimientocmd;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Panel panel1;
    }
}