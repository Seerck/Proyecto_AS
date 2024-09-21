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
            this.tipocmd = new System.Windows.Forms.TextBox();
            this.cantidadcmd = new System.Windows.Forms.TextBox();
            this.ubicacioncmd = new System.Windows.Forms.TextBox();
            this.fechaingresocmd = new System.Windows.Forms.TextBox();
            this.fechasalidacmd = new System.Windows.Forms.TextBox();
            this.estadocmd = new System.Windows.Forms.TextBox();
            this.btnañadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(901, 335);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombrecmd
            // 
            this.nombrecmd.Location = new System.Drawing.Point(12, 384);
            this.nombrecmd.Name = "nombrecmd";
            this.nombrecmd.Size = new System.Drawing.Size(261, 22);
            this.nombrecmd.TabIndex = 2;
            // 
            // tipocmd
            // 
            this.tipocmd.Location = new System.Drawing.Point(12, 445);
            this.tipocmd.Name = "tipocmd";
            this.tipocmd.Size = new System.Drawing.Size(261, 22);
            this.tipocmd.TabIndex = 3;
            // 
            // cantidadcmd
            // 
            this.cantidadcmd.Location = new System.Drawing.Point(9, 504);
            this.cantidadcmd.Name = "cantidadcmd";
            this.cantidadcmd.Size = new System.Drawing.Size(261, 22);
            this.cantidadcmd.TabIndex = 4;
            // 
            // ubicacioncmd
            // 
            this.ubicacioncmd.Location = new System.Drawing.Point(325, 384);
            this.ubicacioncmd.Name = "ubicacioncmd";
            this.ubicacioncmd.Size = new System.Drawing.Size(261, 22);
            this.ubicacioncmd.TabIndex = 5;
            // 
            // fechaingresocmd
            // 
            this.fechaingresocmd.Location = new System.Drawing.Point(325, 445);
            this.fechaingresocmd.Name = "fechaingresocmd";
            this.fechaingresocmd.Size = new System.Drawing.Size(261, 22);
            this.fechaingresocmd.TabIndex = 6;
            // 
            // fechasalidacmd
            // 
            this.fechasalidacmd.Location = new System.Drawing.Point(325, 504);
            this.fechasalidacmd.Name = "fechasalidacmd";
            this.fechasalidacmd.Size = new System.Drawing.Size(261, 22);
            this.fechasalidacmd.TabIndex = 7;
            // 
            // estadocmd
            // 
            this.estadocmd.Location = new System.Drawing.Point(615, 384);
            this.estadocmd.Name = "estadocmd";
            this.estadocmd.Size = new System.Drawing.Size(261, 22);
            this.estadocmd.TabIndex = 8;
            // 
            // btnañadir
            // 
            this.btnañadir.Location = new System.Drawing.Point(638, 445);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(218, 70);
            this.btnañadir.TabIndex = 9;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ubicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha Salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado";
            // 
            // Form_Añadir_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(922, 567);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.estadocmd);
            this.Controls.Add(this.fechasalidacmd);
            this.Controls.Add(this.fechaingresocmd);
            this.Controls.Add(this.ubicacioncmd);
            this.Controls.Add(this.cantidadcmd);
            this.Controls.Add(this.tipocmd);
            this.Controls.Add(this.nombrecmd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Añadir_Productos";
            this.Text = "Añadir Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombrecmd;
        private System.Windows.Forms.TextBox tipocmd;
        private System.Windows.Forms.TextBox cantidadcmd;
        private System.Windows.Forms.TextBox ubicacioncmd;
        private System.Windows.Forms.TextBox fechaingresocmd;
        private System.Windows.Forms.TextBox fechasalidacmd;
        private System.Windows.Forms.TextBox estadocmd;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}