namespace Vistas
{
    partial class FrmGestionUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.button1_Guardar = new System.Windows.Forms.Button();
            this.label1_Rol = new System.Windows.Forms.Label();
            this.label2_Apellido = new System.Windows.Forms.Label();
            this.label5_Usuario = new System.Windows.Forms.Label();
            this.label6_Contraseña = new System.Windows.Forms.Label();
            this.textBox1_ApellidoNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4_Usuario = new System.Windows.Forms.TextBox();
            this.textBox5_Contraseña = new System.Windows.Forms.TextBox();
            this.button2_Eliminar = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opticaDataSet = new Vistas.opticaDataSet();
            this.usuarioTableAdapter = new Vistas.opticaDataSetTableAdapters.UsuarioTableAdapter();
            this.dataGridView_Usuario = new System.Windows.Forms.DataGridView();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label1_id = new System.Windows.Forms.Label();
            this.textBox1_UsuarioBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_NuevoUsuario = new System.Windows.Forms.Button();
            this.button_CancelarCarga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Guardar
            // 
            this.button1_Guardar.Location = new System.Drawing.Point(571, 315);
            this.button1_Guardar.Name = "button1_Guardar";
            this.button1_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button1_Guardar.TabIndex = 0;
            this.button1_Guardar.Text = "Guardar";
            this.button1_Guardar.UseVisualStyleBackColor = true;
            this.button1_Guardar.Click += new System.EventHandler(this.button1_Guardar_Click);
            // 
            // label1_Rol
            // 
            this.label1_Rol.AutoSize = true;
            this.label1_Rol.Location = new System.Drawing.Point(485, 138);
            this.label1_Rol.Name = "label1_Rol";
            this.label1_Rol.Size = new System.Drawing.Size(23, 13);
            this.label1_Rol.TabIndex = 1;
            this.label1_Rol.Text = "Rol";
            // 
            // label2_Apellido
            // 
            this.label2_Apellido.AutoSize = true;
            this.label2_Apellido.Location = new System.Drawing.Point(447, 183);
            this.label2_Apellido.Name = "label2_Apellido";
            this.label2_Apellido.Size = new System.Drawing.Size(92, 13);
            this.label2_Apellido.TabIndex = 2;
            this.label2_Apellido.Text = "Apellido y Nombre";
            // 
            // label5_Usuario
            // 
            this.label5_Usuario.AutoSize = true;
            this.label5_Usuario.Location = new System.Drawing.Point(458, 227);
            this.label5_Usuario.Name = "label5_Usuario";
            this.label5_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label5_Usuario.TabIndex = 5;
            this.label5_Usuario.Text = "Usuario";
            // 
            // label6_Contraseña
            // 
            this.label6_Contraseña.AutoSize = true;
            this.label6_Contraseña.Location = new System.Drawing.Point(458, 267);
            this.label6_Contraseña.Name = "label6_Contraseña";
            this.label6_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.label6_Contraseña.TabIndex = 6;
            this.label6_Contraseña.Text = "Contraseña";
            // 
            // textBox1_ApellidoNombre
            // 
            this.textBox1_ApellidoNombre.Location = new System.Drawing.Point(545, 180);
            this.textBox1_ApellidoNombre.Name = "textBox1_ApellidoNombre";
            this.textBox1_ApellidoNombre.Size = new System.Drawing.Size(101, 20);
            this.textBox1_ApellidoNombre.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(525, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox4_Usuario
            // 
            this.textBox4_Usuario.Location = new System.Drawing.Point(525, 227);
            this.textBox4_Usuario.Name = "textBox4_Usuario";
            this.textBox4_Usuario.Size = new System.Drawing.Size(121, 20);
            this.textBox4_Usuario.TabIndex = 11;
            // 
            // textBox5_Contraseña
            // 
            this.textBox5_Contraseña.Location = new System.Drawing.Point(525, 267);
            this.textBox5_Contraseña.Name = "textBox5_Contraseña";
            this.textBox5_Contraseña.Size = new System.Drawing.Size(121, 20);
            this.textBox5_Contraseña.TabIndex = 12;
            // 
            // button2_Eliminar
            // 
            this.button2_Eliminar.Location = new System.Drawing.Point(12, 336);
            this.button2_Eliminar.Name = "button2_Eliminar";
            this.button2_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button2_Eliminar.TabIndex = 13;
            this.button2_Eliminar.Text = "Eliminar";
            this.button2_Eliminar.UseVisualStyleBackColor = true;
            this.button2_Eliminar.Click += new System.EventHandler(this.button2_Eliminar_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.opticaDataSet;
            // 
            // opticaDataSet
            // 
            this.opticaDataSet.DataSetName = "opticaDataSet";
            this.opticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Usuario
            // 
            this.dataGridView_Usuario.AllowUserToAddRows = false;
            this.dataGridView_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Usuario.Location = new System.Drawing.Point(26, 101);
            this.dataGridView_Usuario.Name = "dataGridView_Usuario";
            this.dataGridView_Usuario.Size = new System.Drawing.Size(376, 194);
            this.dataGridView_Usuario.TabIndex = 14;
            this.dataGridView_Usuario.CurrentCellChanged += new System.EventHandler(this.dataGridView_Usuario_CurrentCellChanged);
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(525, 105);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.ReadOnly = true;
            this.textBox1_id.Size = new System.Drawing.Size(121, 20);
            this.textBox1_id.TabIndex = 15;
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Enabled = false;
            this.label1_id.Location = new System.Drawing.Point(484, 105);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(15, 13);
            this.label1_id.TabIndex = 16;
            this.label1_id.Text = "id";
            // 
            // textBox1_UsuarioBuscar
            // 
            this.textBox1_UsuarioBuscar.Location = new System.Drawing.Point(80, 21);
            this.textBox1_UsuarioBuscar.Name = "textBox1_UsuarioBuscar";
            this.textBox1_UsuarioBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBox1_UsuarioBuscar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_NuevoUsuario
            // 
            this.button_NuevoUsuario.Location = new System.Drawing.Point(545, 21);
            this.button_NuevoUsuario.Name = "button_NuevoUsuario";
            this.button_NuevoUsuario.Size = new System.Drawing.Size(101, 23);
            this.button_NuevoUsuario.TabIndex = 20;
            this.button_NuevoUsuario.Text = "Nuevo Usuario";
            this.button_NuevoUsuario.UseVisualStyleBackColor = true;
            this.button_NuevoUsuario.Click += new System.EventHandler(this.button_NuevoUsuario_Click);
            // 
            // button_CancelarCarga
            // 
            this.button_CancelarCarga.Location = new System.Drawing.Point(545, 50);
            this.button_CancelarCarga.Name = "button_CancelarCarga";
            this.button_CancelarCarga.Size = new System.Drawing.Size(101, 23);
            this.button_CancelarCarga.TabIndex = 21;
            this.button_CancelarCarga.Text = "Cancelar Carga";
            this.button_CancelarCarga.UseVisualStyleBackColor = true;
            this.button_CancelarCarga.Visible = false;
            this.button_CancelarCarga.Click += new System.EventHandler(this.button_CancelarCarga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Los cambios realizados en la grilla deberán ser confirmados con el boton Guardar";
            // 
            // FrmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_CancelarCarga);
            this.Controls.Add(this.button_NuevoUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_UsuarioBuscar);
            this.Controls.Add(this.label1_id);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.dataGridView_Usuario);
            this.Controls.Add(this.button2_Eliminar);
            this.Controls.Add(this.textBox5_Contraseña);
            this.Controls.Add(this.textBox4_Usuario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1_ApellidoNombre);
            this.Controls.Add(this.label6_Contraseña);
            this.Controls.Add(this.label5_Usuario);
            this.Controls.Add(this.label2_Apellido);
            this.Controls.Add(this.label1_Rol);
            this.Controls.Add(this.button1_Guardar);
            this.Name = "FrmGestionUsuarios";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Guardar;
        private System.Windows.Forms.Label label1_Rol;
        private System.Windows.Forms.Label label2_Apellido;
        private System.Windows.Forms.Label label5_Usuario;
        private System.Windows.Forms.Label label6_Contraseña;
        private System.Windows.Forms.TextBox textBox1_ApellidoNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4_Usuario;
        private System.Windows.Forms.TextBox textBox5_Contraseña;
        private System.Windows.Forms.Button button2_Eliminar;
        private opticaDataSet opticaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private opticaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Usuario;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label1_id;
        private System.Windows.Forms.TextBox textBox1_UsuarioBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_NuevoUsuario;
        private System.Windows.Forms.Button button_CancelarCarga;
        private System.Windows.Forms.Label label2;
    }
}