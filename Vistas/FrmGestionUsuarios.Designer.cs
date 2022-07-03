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
            this.button1 = new System.Windows.Forms.Button();
            this.button_NuevoUsuario = new System.Windows.Forms.Button();
            this.button_CancelarCarga = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.error_Completar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_Completar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Guardar
            // 
            this.button1_Guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.button1_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button1_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Guardar.Location = new System.Drawing.Point(19, 237);
            this.button1_Guardar.Name = "button1_Guardar";
            this.button1_Guardar.Size = new System.Drawing.Size(227, 29);
            this.button1_Guardar.TabIndex = 0;
            this.button1_Guardar.Text = "Guardar Usuario";
            this.button1_Guardar.UseVisualStyleBackColor = false;
            this.button1_Guardar.Click += new System.EventHandler(this.button1_Guardar_Click);
            // 
            // label1_Rol
            // 
            this.label1_Rol.AutoSize = true;
            this.label1_Rol.Location = new System.Drawing.Point(17, 69);
            this.label1_Rol.Name = "label1_Rol";
            this.label1_Rol.Size = new System.Drawing.Size(23, 13);
            this.label1_Rol.TabIndex = 1;
            this.label1_Rol.Text = "Rol";
            // 
            // label2_Apellido
            // 
            this.label2_Apellido.AutoSize = true;
            this.label2_Apellido.Location = new System.Drawing.Point(16, 103);
            this.label2_Apellido.Name = "label2_Apellido";
            this.label2_Apellido.Size = new System.Drawing.Size(92, 13);
            this.label2_Apellido.TabIndex = 2;
            this.label2_Apellido.Text = "Apellido y Nombre";
            // 
            // label5_Usuario
            // 
            this.label5_Usuario.AutoSize = true;
            this.label5_Usuario.Location = new System.Drawing.Point(16, 141);
            this.label5_Usuario.Name = "label5_Usuario";
            this.label5_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label5_Usuario.TabIndex = 5;
            this.label5_Usuario.Text = "Usuario";
            // 
            // label6_Contraseña
            // 
            this.label6_Contraseña.AutoSize = true;
            this.label6_Contraseña.Location = new System.Drawing.Point(16, 181);
            this.label6_Contraseña.Name = "label6_Contraseña";
            this.label6_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.label6_Contraseña.TabIndex = 6;
            this.label6_Contraseña.Text = "Contraseña";
            // 
            // textBox1_ApellidoNombre
            // 
            this.textBox1_ApellidoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_ApellidoNombre.Location = new System.Drawing.Point(121, 100);
            this.textBox1_ApellidoNombre.Name = "textBox1_ApellidoNombre";
            this.textBox1_ApellidoNombre.Size = new System.Drawing.Size(125, 20);
            this.textBox1_ApellidoNombre.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox4_Usuario
            // 
            this.textBox4_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4_Usuario.Location = new System.Drawing.Point(121, 141);
            this.textBox4_Usuario.Name = "textBox4_Usuario";
            this.textBox4_Usuario.Size = new System.Drawing.Size(125, 20);
            this.textBox4_Usuario.TabIndex = 11;
            // 
            // textBox5_Contraseña
            // 
            this.textBox5_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5_Contraseña.Location = new System.Drawing.Point(121, 181);
            this.textBox5_Contraseña.Name = "textBox5_Contraseña";
            this.textBox5_Contraseña.Size = new System.Drawing.Size(125, 20);
            this.textBox5_Contraseña.TabIndex = 12;
            // 
            // button2_Eliminar
            // 
            this.button2_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.button2_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button2_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Eliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.button2_Eliminar.Location = new System.Drawing.Point(19, 272);
            this.button2_Eliminar.Name = "button2_Eliminar";
            this.button2_Eliminar.Size = new System.Drawing.Size(227, 29);
            this.button2_Eliminar.TabIndex = 13;
            this.button2_Eliminar.Text = "Eliminar Usuario";
            this.button2_Eliminar.UseVisualStyleBackColor = false;
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
            this.dataGridView_Usuario.AllowUserToDeleteRows = false;
            this.dataGridView_Usuario.AllowUserToResizeColumns = false;
            this.dataGridView_Usuario.AllowUserToResizeRows = false;
            this.dataGridView_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Usuario.Location = new System.Drawing.Point(12, 24);
            this.dataGridView_Usuario.Name = "dataGridView_Usuario";
            this.dataGridView_Usuario.Size = new System.Drawing.Size(422, 309);
            this.dataGridView_Usuario.TabIndex = 14;
            this.dataGridView_Usuario.CurrentCellChanged += new System.EventHandler(this.dataGridView_Usuario_CurrentCellChanged);
            // 
            // textBox1_id
            // 
            this.textBox1_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_id.Location = new System.Drawing.Point(121, 34);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.ReadOnly = true;
            this.textBox1_id.Size = new System.Drawing.Size(125, 20);
            this.textBox1_id.TabIndex = 15;
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Enabled = false;
            this.label1_id.Location = new System.Drawing.Point(16, 36);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(18, 13);
            this.label1_id.TabIndex = 16;
            this.label1_id.Text = "ID";
            // 
            // textBox1_UsuarioBuscar
            // 
            this.textBox1_UsuarioBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_UsuarioBuscar.Location = new System.Drawing.Point(15, 27);
            this.textBox1_UsuarioBuscar.Name = "textBox1_UsuarioBuscar";
            this.textBox1_UsuarioBuscar.Size = new System.Drawing.Size(168, 20);
            this.textBox1_UsuarioBuscar.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar Usuario";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_NuevoUsuario
            // 
            this.button_NuevoUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.button_NuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_NuevoUsuario.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_NuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NuevoUsuario.Location = new System.Drawing.Point(15, 28);
            this.button_NuevoUsuario.Name = "button_NuevoUsuario";
            this.button_NuevoUsuario.Size = new System.Drawing.Size(168, 29);
            this.button_NuevoUsuario.TabIndex = 20;
            this.button_NuevoUsuario.Text = "Nuevo Usuario";
            this.button_NuevoUsuario.UseVisualStyleBackColor = false;
            this.button_NuevoUsuario.Click += new System.EventHandler(this.button_NuevoUsuario_Click);
            // 
            // button_CancelarCarga
            // 
            this.button_CancelarCarga.BackColor = System.Drawing.Color.BurlyWood;
            this.button_CancelarCarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CancelarCarga.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_CancelarCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CancelarCarga.Location = new System.Drawing.Point(775, 252);
            this.button_CancelarCarga.Name = "button_CancelarCarga";
            this.button_CancelarCarga.Size = new System.Drawing.Size(168, 29);
            this.button_CancelarCarga.TabIndex = 21;
            this.button_CancelarCarga.Text = "Cancelar carga de usuario";
            this.button_CancelarCarga.UseVisualStyleBackColor = false;
            this.button_CancelarCarga.Visible = false;
            this.button_CancelarCarga.Click += new System.EventHandler(this.button_CancelarCarga_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(9, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Los cambios realizados en la grilla deberán ser confirmados con el boton Guardar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1_id);
            this.groupBox1.Controls.Add(this.button1_Guardar);
            this.groupBox1.Controls.Add(this.label1_Rol);
            this.groupBox1.Controls.Add(this.label2_Apellido);
            this.groupBox1.Controls.Add(this.label5_Usuario);
            this.groupBox1.Controls.Add(this.label6_Contraseña);
            this.groupBox1.Controls.Add(this.textBox1_ApellidoNombre);
            this.groupBox1.Controls.Add(this.label1_id);
            this.groupBox1.Controls.Add(this.button2_Eliminar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox4_Usuario);
            this.groupBox1.Controls.Add(this.textBox5_Contraseña);
            this.groupBox1.Location = new System.Drawing.Point(464, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 309);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1_UsuarioBuscar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(760, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 116);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_NuevoUsuario);
            this.groupBox3.Location = new System.Drawing.Point(760, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 72);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear un nuevo usuario";
            // 
            // error_Completar
            // 
            this.error_Completar.ContainerControl = this;
            // 
            // FrmGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_CancelarCarga);
            this.Controls.Add(this.dataGridView_Usuario);
            this.Name = "FrmGestionUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Usuario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_Completar)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_NuevoUsuario;
        private System.Windows.Forms.Button button_CancelarCarga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider error_Completar;
    }
}