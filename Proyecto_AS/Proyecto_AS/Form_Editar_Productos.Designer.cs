namespace Proyecto_AS
{
    partial class Form_Editar_Productos
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
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nivel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.txt_fecha_v = new System.Windows.Forms.TextBox();
            this.txt_fecha_i = new System.Windows.Forms.TextBox();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(7, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(659, 245);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Cosmetico",
            "Ropa",
            "Electronico",
            "Calzado"});
            this.cmb_tipo.Location = new System.Drawing.Point(10, 318);
            this.cmb_tipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(197, 21);
            this.cmb_tipo.TabIndex = 43;
            this.cmb_tipo.Text = "Seleccionar";
            this.cmb_tipo.SelectedIndexChanged += new System.EventHandler(this.cmdtipo_SelectedIndexChanged);
            this.cmb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_tipo_KeyPress);
            // 
            // cmb_estado
            // 
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Habilitado",
            "desabilitado"});
            this.cmb_estado.Location = new System.Drawing.Point(464, 283);
            this.cmb_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(197, 21);
            this.cmb_estado.TabIndex = 42;
            this.cmb_estado.Text = "Seleccionar";
            this.cmb_estado.SelectedIndexChanged += new System.EventHandler(this.estadocmb_SelectedIndexChanged);
            this.cmb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_estado_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(234, 282);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(2);
            this.txt_precio.MaxLength = 7;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(197, 20);
            this.txt_precio.TabIndex = 41;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(10, 356);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad.MaxLength = 6;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(197, 20);
            this.txt_cantidad.TabIndex = 40;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Precio";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_nivel
            // 
            this.txt_nivel.Location = new System.Drawing.Point(464, 355);
            this.txt_nivel.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nivel.MaxLength = 3;
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.Size = new System.Drawing.Size(197, 20);
            this.txt_nivel.TabIndex = 38;
            this.txt_nivel.TextChanged += new System.EventHandler(this.estantecmd_TextChanged);
            this.txt_nivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nivel_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 340);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nivel Estante";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha Vencimiento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha Ingreso";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ubicacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(556, 414);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(105, 36);
            this.btn_actualizar.TabIndex = 29;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // txt_fecha_v
            // 
            this.txt_fecha_v.Location = new System.Drawing.Point(234, 356);
            this.txt_fecha_v.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fecha_v.Name = "txt_fecha_v";
            this.txt_fecha_v.Size = new System.Drawing.Size(197, 20);
            this.txt_fecha_v.TabIndex = 28;
            this.txt_fecha_v.TextChanged += new System.EventHandler(this.fechasalidacmd_TextChanged);
            this.txt_fecha_v.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_v_KeyPress);
            // 
            // txt_fecha_i
            // 
            this.txt_fecha_i.Location = new System.Drawing.Point(234, 319);
            this.txt_fecha_i.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fecha_i.Name = "txt_fecha_i";
            this.txt_fecha_i.Size = new System.Drawing.Size(197, 20);
            this.txt_fecha_i.TabIndex = 27;
            this.txt_fecha_i.TextChanged += new System.EventHandler(this.fechaingresocmd_TextChanged);
            this.txt_fecha_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_i_KeyPress);
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Location = new System.Drawing.Point(464, 319);
            this.txt_ubicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ubicacion.MaxLength = 20;
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(197, 20);
            this.txt_ubicacion.TabIndex = 26;
            this.txt_ubicacion.TextChanged += new System.EventHandler(this.ubicacioncmd_TextChanged);
            this.txt_ubicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ubicacion_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(10, 284);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.MaxLength = 25;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(197, 20);
            this.txt_nombre.TabIndex = 25;
            this.txt_nombre.TextChanged += new System.EventHandler(this.nombrecmd_TextChanged);
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(7, 417);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(105, 33);
            this.btn_buscar.TabIndex = 45;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Form_Editar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(679, 461);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.cmb_estado);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nivel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.txt_fecha_v);
            this.Controls.Add(this.txt_fecha_i);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Editar_Productos";
            this.Text = "Editar Productos";
            this.Load += new System.EventHandler(this.Form_Editar_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.TextBox txt_fecha_v;
        private System.Windows.Forms.TextBox txt_fecha_i;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_buscar;
    }
}