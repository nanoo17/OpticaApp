namespace Vistas
{
    partial class FrmGestionClientes
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
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_cuit = new System.Windows.Forms.Label();
            this.label_carnet = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Carnet = new System.Windows.Forms.TextBox();
            this.button_modificar = new System.Windows.Forms.Button();
            this.label_Dni = new System.Windows.Forms.Label();
            this.textBox_Dni = new System.Windows.Forms.TextBox();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.comboBox_ObraSocial = new System.Windows.Forms.ComboBox();
            this.button_NuevoCliente = new System.Windows.Forms.Button();
            this.button_CancelarCarga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.AllowUserToAddRows = false;
            this.dataGridView_Cliente.AllowUserToDeleteRows = false;
            this.dataGridView_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(12, 20);
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.Size = new System.Drawing.Size(438, 308);
            this.dataGridView_Cliente.TabIndex = 0;
            this.dataGridView_Cliente.CurrentCellChanged += new System.EventHandler(this.dataGridView_Cliente_CurrentCellChanged);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Apellido.Location = new System.Drawing.Point(112, 59);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(127, 20);
            this.textBox_Apellido.TabIndex = 1;
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.Location = new System.Drawing.Point(17, 62);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(17, 87);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 3;
            this.label_Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Location = new System.Drawing.Point(17, 153);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(70, 13);
            this.label_cuit.TabIndex = 5;
            this.label_cuit.Text = "Razon Social";
            // 
            // label_carnet
            // 
            this.label_carnet.AutoSize = true;
            this.label_carnet.Location = new System.Drawing.Point(17, 178);
            this.label_carnet.Name = "label_carnet";
            this.label_carnet.Size = new System.Drawing.Size(58, 13);
            this.label_carnet.TabIndex = 6;
            this.label_carnet.Text = "Nro Carnet";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Nombre.Location = new System.Drawing.Point(112, 87);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(127, 20);
            this.textBox_Nombre.TabIndex = 7;
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Direccion.Location = new System.Drawing.Point(112, 115);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(127, 20);
            this.textBox_Direccion.TabIndex = 8;
            // 
            // textBox_Carnet
            // 
            this.textBox_Carnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Carnet.Location = new System.Drawing.Point(112, 176);
            this.textBox_Carnet.Name = "textBox_Carnet";
            this.textBox_Carnet.Size = new System.Drawing.Size(127, 20);
            this.textBox_Carnet.TabIndex = 10;
            // 
            // button_modificar
            // 
            this.button_modificar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modificar.Location = new System.Drawing.Point(20, 230);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(219, 29);
            this.button_modificar.TabIndex = 11;
            this.button_modificar.Text = "Guardar Cliente";
            this.button_modificar.UseVisualStyleBackColor = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // label_Dni
            // 
            this.label_Dni.AutoSize = true;
            this.label_Dni.Location = new System.Drawing.Point(17, 34);
            this.label_Dni.Name = "label_Dni";
            this.label_Dni.Size = new System.Drawing.Size(26, 13);
            this.label_Dni.TabIndex = 12;
            this.label_Dni.Text = "DNI";
            // 
            // textBox_Dni
            // 
            this.textBox_Dni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Dni.Enabled = false;
            this.textBox_Dni.Location = new System.Drawing.Point(112, 34);
            this.textBox_Dni.Name = "textBox_Dni";
            this.textBox_Dni.Size = new System.Drawing.Size(127, 20);
            this.textBox_Dni.TabIndex = 13;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.button_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Eliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Eliminar.Location = new System.Drawing.Point(20, 265);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(219, 29);
            this.button_Eliminar.TabIndex = 14;
            this.button_Eliminar.Text = "Eliminar Cliente";
            this.button_Eliminar.UseVisualStyleBackColor = false;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // comboBox_ObraSocial
            // 
            this.comboBox_ObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ObraSocial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_ObraSocial.FormattingEnabled = true;
            this.comboBox_ObraSocial.Location = new System.Drawing.Point(112, 150);
            this.comboBox_ObraSocial.Name = "comboBox_ObraSocial";
            this.comboBox_ObraSocial.Size = new System.Drawing.Size(127, 21);
            this.comboBox_ObraSocial.TabIndex = 15;
            // 
            // button_NuevoCliente
            // 
            this.button_NuevoCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.button_NuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_NuevoCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_NuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NuevoCliente.Location = new System.Drawing.Point(20, 19);
            this.button_NuevoCliente.Name = "button_NuevoCliente";
            this.button_NuevoCliente.Size = new System.Drawing.Size(153, 29);
            this.button_NuevoCliente.TabIndex = 21;
            this.button_NuevoCliente.Text = "Nuevo Cliente";
            this.button_NuevoCliente.UseVisualStyleBackColor = false;
            this.button_NuevoCliente.Click += new System.EventHandler(this.button_NuevoCliente_Click);
            // 
            // button_CancelarCarga
            // 
            this.button_CancelarCarga.BackColor = System.Drawing.Color.BurlyWood;
            this.button_CancelarCarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CancelarCarga.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_CancelarCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelarCarga.ForeColor = System.Drawing.Color.Black;
            this.button_CancelarCarga.Location = new System.Drawing.Point(778, 98);
            this.button_CancelarCarga.Name = "button_CancelarCarga";
            this.button_CancelarCarga.Size = new System.Drawing.Size(153, 29);
            this.button_CancelarCarga.TabIndex = 22;
            this.button_CancelarCarga.Text = "Cancelar carga de cliente";
            this.button_CancelarCarga.UseVisualStyleBackColor = false;
            this.button_CancelarCarga.Visible = false;
            this.button_CancelarCarga.Click += new System.EventHandler(this.button_CancelarCarga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Los cambios realizados en la grilla deberán ser confirmados con el boton Guardar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Dni);
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.label_Apellido);
            this.groupBox1.Controls.Add(this.label_Nombre);
            this.groupBox1.Controls.Add(this.comboBox_ObraSocial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Eliminar);
            this.groupBox1.Controls.Add(this.label_cuit);
            this.groupBox1.Controls.Add(this.textBox_Dni);
            this.groupBox1.Controls.Add(this.label_carnet);
            this.groupBox1.Controls.Add(this.textBox_Nombre);
            this.groupBox1.Controls.Add(this.button_modificar);
            this.groupBox1.Controls.Add(this.textBox_Direccion);
            this.groupBox1.Controls.Add(this.textBox_Carnet);
            this.groupBox1.Location = new System.Drawing.Point(486, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 308);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_NuevoCliente);
            this.groupBox3.Location = new System.Drawing.Point(758, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 64);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear un nuevo cliente";
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CancelarCarga);
            this.Controls.Add(this.dataGridView_Cliente);
            this.Name = "FrmGestionClientes";
            this.Text = "FrmClienteGrid";
            this.Load += new System.EventHandler(this.FrmClienteGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.Label label_carnet;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Carnet;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Label label_Dni;
        private System.Windows.Forms.TextBox textBox_Dni;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.ComboBox comboBox_ObraSocial;
        private System.Windows.Forms.Button button_NuevoCliente;
        private System.Windows.Forms.Button button_CancelarCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}