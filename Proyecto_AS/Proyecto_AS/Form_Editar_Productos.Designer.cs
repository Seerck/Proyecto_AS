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
            this.cmdtipo = new System.Windows.Forms.ComboBox();
            this.estadocmb = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.estantecmd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnañadir = new System.Windows.Forms.Button();
            this.fechasalidacmd = new System.Windows.Forms.TextBox();
            this.fechaingresocmd = new System.Windows.Forms.TextBox();
            this.ubicacioncmd = new System.Windows.Forms.TextBox();
            this.nombrecmd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(879, 335);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdtipo
            // 
            this.cmdtipo.FormattingEnabled = true;
            this.cmdtipo.Items.AddRange(new object[] {
            "Cosmetico",
            "Ropa",
            "Electronico",
            "Calzado"});
            this.cmdtipo.Location = new System.Drawing.Point(17, 425);
            this.cmdtipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdtipo.Name = "cmdtipo";
            this.cmdtipo.Size = new System.Drawing.Size(257, 24);
            this.cmdtipo.TabIndex = 43;
            this.cmdtipo.Text = "Seleccionar";
            this.cmdtipo.SelectedIndexChanged += new System.EventHandler(this.cmdtipo_SelectedIndexChanged);
            // 
            // estadocmb
            // 
            this.estadocmb.FormattingEnabled = true;
            this.estadocmb.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.estadocmb.Location = new System.Drawing.Point(597, 383);
            this.estadocmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadocmb.Name = "estadocmb";
            this.estadocmb.Size = new System.Drawing.Size(217, 24);
            this.estadocmb.TabIndex = 42;
            this.estadocmb.Text = "Seleccionar";
            this.estadocmb.SelectedIndexChanged += new System.EventHandler(this.estadocmb_SelectedIndexChanged);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(17, 519);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(257, 22);
            this.txt_precio.TabIndex = 41;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(15, 471);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad.MaxLength = 6;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(261, 22);
            this.txt_cantidad.TabIndex = 40;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Precio";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // estantecmd
            // 
            this.estantecmd.Location = new System.Drawing.Point(313, 519);
            this.estantecmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estantecmd.Name = "estantecmd";
            this.estantecmd.Size = new System.Drawing.Size(261, 22);
            this.estantecmd.TabIndex = 38;
            this.estantecmd.TextChanged += new System.EventHandler(this.estantecmd_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nivel Estante";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fecha Salida";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Fecha Ingreso";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ubicacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnañadir
            // 
            this.btnañadir.Location = new System.Drawing.Point(597, 426);
            this.btnañadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(219, 70);
            this.btnañadir.TabIndex = 29;
            this.btnañadir.Text = "Editar";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // fechasalidacmd
            // 
            this.fechasalidacmd.Location = new System.Drawing.Point(313, 471);
            this.fechasalidacmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechasalidacmd.Name = "fechasalidacmd";
            this.fechasalidacmd.Size = new System.Drawing.Size(261, 22);
            this.fechasalidacmd.TabIndex = 28;
            this.fechasalidacmd.TextChanged += new System.EventHandler(this.fechasalidacmd_TextChanged);
            // 
            // fechaingresocmd
            // 
            this.fechaingresocmd.Location = new System.Drawing.Point(313, 426);
            this.fechaingresocmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaingresocmd.Name = "fechaingresocmd";
            this.fechaingresocmd.Size = new System.Drawing.Size(261, 22);
            this.fechaingresocmd.TabIndex = 27;
            this.fechaingresocmd.TextChanged += new System.EventHandler(this.fechaingresocmd_TextChanged);
            // 
            // ubicacioncmd
            // 
            this.ubicacioncmd.Location = new System.Drawing.Point(313, 383);
            this.ubicacioncmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ubicacioncmd.Name = "ubicacioncmd";
            this.ubicacioncmd.Size = new System.Drawing.Size(261, 22);
            this.ubicacioncmd.TabIndex = 26;
            this.ubicacioncmd.TextChanged += new System.EventHandler(this.ubicacioncmd_TextChanged);
            // 
            // nombrecmd
            // 
            this.nombrecmd.Location = new System.Drawing.Point(15, 383);
            this.nombrecmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombrecmd.MaxLength = 25;
            this.nombrecmd.Name = "nombrecmd";
            this.nombrecmd.Size = new System.Drawing.Size(261, 22);
            this.nombrecmd.TabIndex = 25;
            this.nombrecmd.TextChanged += new System.EventHandler(this.nombrecmd_TextChanged);
            // 
            // Form_Editar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(903, 567);
            this.Controls.Add(this.cmdtipo);
            this.Controls.Add(this.estadocmb);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.estantecmd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.fechasalidacmd);
            this.Controls.Add(this.fechaingresocmd);
            this.Controls.Add(this.ubicacioncmd);
            this.Controls.Add(this.nombrecmd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Editar_Productos";
            this.Text = "Editar Productos";
            this.Load += new System.EventHandler(this.Form_Editar_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmdtipo;
        private System.Windows.Forms.ComboBox estadocmb;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox estantecmd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.TextBox fechasalidacmd;
        private System.Windows.Forms.TextBox fechaingresocmd;
        private System.Windows.Forms.TextBox ubicacioncmd;
        private System.Windows.Forms.TextBox nombrecmd;
    }
}