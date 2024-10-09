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
            this.label5 = new System.Windows.Forms.Label();
            this.CBBTipoU = new System.Windows.Forms.ComboBox();
            this.TxtNombreU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscarU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(11, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tipo Usuario:";
            // 
            // CBBTipoU
            // 
            this.CBBTipoU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBBTipoU.FormattingEnabled = true;
            this.CBBTipoU.Items.AddRange(new object[] {
            "usuario",
            "super-usuario",
            "administrador"});
            this.CBBTipoU.Location = new System.Drawing.Point(260, 454);
            this.CBBTipoU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBBTipoU.Name = "CBBTipoU";
            this.CBBTipoU.Size = new System.Drawing.Size(245, 27);
            this.CBBTipoU.TabIndex = 21;
            this.CBBTipoU.Text = "Seleccionar";
            this.CBBTipoU.SelectedIndexChanged += new System.EventHandler(this.cmd_tipo_SelectedIndexChanged);
            // 
            // TxtNombreU
            // 
            this.TxtNombreU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.TxtNombreU.Location = new System.Drawing.Point(260, 388);
            this.TxtNombreU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNombreU.MaxLength = 25;
            this.TxtNombreU.Name = "TxtNombreU";
            this.TxtNombreU.Size = new System.Drawing.Size(245, 27);
            this.TxtNombreU.TabIndex = 20;
            this.TxtNombreU.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            this.TxtNombreU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreU_Keypress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre Usuario:";
            // 
            // BtnBuscarU
            // 
            this.BtnBuscarU.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BtnBuscarU.Location = new System.Drawing.Point(555, 447);
            this.BtnBuscarU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscarU.Name = "BtnBuscarU";
            this.BtnBuscarU.Size = new System.Drawing.Size(147, 43);
            this.BtnBuscarU.TabIndex = 23;
            this.BtnBuscarU.Text = "Buscar";
            this.BtnBuscarU.UseVisualStyleBackColor = true;
            this.BtnBuscarU.Click += new System.EventHandler(this.BtnBuscarU_Click);
            // 
            // Form_Ver_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(832, 567);
            this.Controls.Add(this.BtnBuscarU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBBTipoU);
            this.Controls.Add(this.TxtNombreU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Ver_Usuario";
            this.Text = "Mostrar Usuario";
            this.Load += new System.EventHandler(this.Form_Ver_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBBTipoU;
        private System.Windows.Forms.TextBox TxtNombreU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscarU;
    }
}