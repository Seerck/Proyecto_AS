namespace Proyecto_AS
{
    partial class Form_Ver_Usuario
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
            this.CBBTipoU = new System.Windows.Forms.ComboBox();
            this.TxtNombreU = new System.Windows.Forms.TextBox();
            this.BtnBuscarU = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(609, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CBBTipoU
            // 
            this.CBBTipoU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBBTipoU.FormattingEnabled = true;
            this.CBBTipoU.Items.AddRange(new object[] {
            "usuario",
            "super-usuario",
            "administrador"});
            this.CBBTipoU.Location = new System.Drawing.Point(187, 72);
            this.CBBTipoU.Name = "CBBTipoU";
            this.CBBTipoU.Size = new System.Drawing.Size(197, 24);
            this.CBBTipoU.TabIndex = 21;
            this.CBBTipoU.Text = "Seleccionar";
            this.CBBTipoU.SelectedIndexChanged += new System.EventHandler(this.cmd_tipo_SelectedIndexChanged);
            // 
            // TxtNombreU
            // 
            this.TxtNombreU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.TxtNombreU.Location = new System.Drawing.Point(187, 18);
            this.TxtNombreU.MaxLength = 25;
            this.TxtNombreU.Name = "TxtNombreU";
            this.TxtNombreU.Size = new System.Drawing.Size(197, 23);
            this.TxtNombreU.TabIndex = 20;
            this.TxtNombreU.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.TxtNombreU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreU_Keypress);
            // 
            // BtnBuscarU
            // 
            this.BtnBuscarU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarU.Location = new System.Drawing.Point(408, 66);
            this.BtnBuscarU.Name = "BtnBuscarU";
            this.BtnBuscarU.Size = new System.Drawing.Size(110, 35);
            this.BtnBuscarU.TabIndex = 23;
            this.BtnBuscarU.Text = "Buscar";
            this.BtnBuscarU.UseVisualStyleBackColor = true;
            this.BtnBuscarU.Click += new System.EventHandler(this.BtnBuscarU_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnBuscarU);
            this.panel1.Controls.Add(this.CBBTipoU);
            this.panel1.Controls.Add(this.TxtNombreU);
            this.panel1.Location = new System.Drawing.Point(9, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 144);
            this.panel1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Usuario";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Usuario";
            // 
            // Form_Ver_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Ver_Usuario";
            this.Text = "Mostrar Usuario";
            this.Load += new System.EventHandler(this.Form_Ver_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CBBTipoU;
        private System.Windows.Forms.TextBox TxtNombreU;
        private System.Windows.Forms.Button BtnBuscarU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}