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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.AllowUserToAddRows = false;
            this.dataGridView_Cliente.AllowUserToDeleteRows = false;
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(26, 109);
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.Size = new System.Drawing.Size(409, 195);
            this.dataGridView_Cliente.TabIndex = 0;
            this.dataGridView_Cliente.CurrentCellChanged += new System.EventHandler(this.dataGridView_Cliente_CurrentCellChanged);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(561, 134);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_Apellido.TabIndex = 1;
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.Location = new System.Drawing.Point(480, 137);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 2;
            this.label_Apellido.Text = "Apellido";
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.Location = new System.Drawing.Point(480, 162);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 3;
            this.label_Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Location = new System.Drawing.Point(467, 228);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(88, 13);
            this.label_cuit.TabIndex = 5;
            this.label_cuit.Text = "OS Razon Social";
            // 
            // label_carnet
            // 
            this.label_carnet.AutoSize = true;
            this.label_carnet.Location = new System.Drawing.Point(480, 249);
            this.label_carnet.Name = "label_carnet";
            this.label_carnet.Size = new System.Drawing.Size(58, 13);
            this.label_carnet.TabIndex = 6;
            this.label_carnet.Text = "Nro Carnet";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(561, 162);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 7;
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(561, 190);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_Direccion.TabIndex = 8;
            // 
            // textBox_Carnet
            // 
            this.textBox_Carnet.Location = new System.Drawing.Point(561, 251);
            this.textBox_Carnet.Name = "textBox_Carnet";
            this.textBox_Carnet.Size = new System.Drawing.Size(100, 20);
            this.textBox_Carnet.TabIndex = 10;
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(528, 313);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(116, 38);
            this.button_modificar.TabIndex = 11;
            this.button_modificar.Text = "Guardar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // label_Dni
            // 
            this.label_Dni.AutoSize = true;
            this.label_Dni.Location = new System.Drawing.Point(480, 109);
            this.label_Dni.Name = "label_Dni";
            this.label_Dni.Size = new System.Drawing.Size(26, 13);
            this.label_Dni.TabIndex = 12;
            this.label_Dni.Text = "DNI";
            // 
            // textBox_Dni
            // 
            this.textBox_Dni.Enabled = false;
            this.textBox_Dni.Location = new System.Drawing.Point(561, 109);
            this.textBox_Dni.Name = "textBox_Dni";
            this.textBox_Dni.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dni.TabIndex = 13;
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(345, 313);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(138, 38);
            this.button_Eliminar.TabIndex = 14;
            this.button_Eliminar.Text = "Eliminar Cliente";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // comboBox_ObraSocial
            // 
            this.comboBox_ObraSocial.FormattingEnabled = true;
            this.comboBox_ObraSocial.Location = new System.Drawing.Point(561, 225);
            this.comboBox_ObraSocial.Name = "comboBox_ObraSocial";
            this.comboBox_ObraSocial.Size = new System.Drawing.Size(100, 21);
            this.comboBox_ObraSocial.TabIndex = 15;
            // 
            // button_NuevoCliente
            // 
            this.button_NuevoCliente.Location = new System.Drawing.Point(550, 12);
            this.button_NuevoCliente.Name = "button_NuevoCliente";
            this.button_NuevoCliente.Size = new System.Drawing.Size(111, 23);
            this.button_NuevoCliente.TabIndex = 21;
            this.button_NuevoCliente.Text = "Nuevo Cliente";
            this.button_NuevoCliente.UseVisualStyleBackColor = true;
            this.button_NuevoCliente.Click += new System.EventHandler(this.button_NuevoCliente_Click);
            // 
            // button_CancelarCarga
            // 
            this.button_CancelarCarga.Location = new System.Drawing.Point(551, 41);
            this.button_CancelarCarga.Name = "button_CancelarCarga";
            this.button_CancelarCarga.Size = new System.Drawing.Size(110, 23);
            this.button_CancelarCarga.TabIndex = 22;
            this.button_CancelarCarga.Text = "Cancelar Carga";
            this.button_CancelarCarga.UseVisualStyleBackColor = true;
            this.button_CancelarCarga.Visible = false;
            this.button_CancelarCarga.Click += new System.EventHandler(this.button_CancelarCarga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Los cambios realizados en la grilla deberán ser confirmados con el boton Guardar";
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CancelarCarga);
            this.Controls.Add(this.button_NuevoCliente);
            this.Controls.Add(this.comboBox_ObraSocial);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.textBox_Dni);
            this.Controls.Add(this.label_Dni);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.textBox_Carnet);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label_carnet);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label_Apellido);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.dataGridView_Cliente);
            this.Name = "FrmGestionClientes";
            this.Text = "FrmClienteGrid";
            this.Load += new System.EventHandler(this.FrmClienteGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
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
    }
}