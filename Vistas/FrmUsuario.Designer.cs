namespace Vistas
{
    partial class FrmUsuario
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
            this.label3_Nombre = new System.Windows.Forms.Label();
            this.label4_Email = new System.Windows.Forms.Label();
            this.label5_Usuario = new System.Windows.Forms.Label();
            this.label6_Contraseña = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuNombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuContraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuApellidoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opticaDataSet = new Vistas.opticaDataSet();
            this.usuarioTableAdapter = new Vistas.opticaDataSetTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Guardar
            // 
            this.button1_Guardar.Location = new System.Drawing.Point(569, 281);
            this.button1_Guardar.Name = "button1_Guardar";
            this.button1_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button1_Guardar.TabIndex = 0;
            this.button1_Guardar.Text = "Guardar";
            this.button1_Guardar.UseVisualStyleBackColor = true;
            // 
            // label1_Rol
            // 
            this.label1_Rol.AutoSize = true;
            this.label1_Rol.Location = new System.Drawing.Point(482, 31);
            this.label1_Rol.Name = "label1_Rol";
            this.label1_Rol.Size = new System.Drawing.Size(23, 13);
            this.label1_Rol.TabIndex = 1;
            this.label1_Rol.Text = "Rol";
            // 
            // label2_Apellido
            // 
            this.label2_Apellido.AutoSize = true;
            this.label2_Apellido.Location = new System.Drawing.Point(471, 73);
            this.label2_Apellido.Name = "label2_Apellido";
            this.label2_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label2_Apellido.TabIndex = 2;
            this.label2_Apellido.Text = "Apellido";
            // 
            // label3_Nombre
            // 
            this.label3_Nombre.AutoSize = true;
            this.label3_Nombre.Location = new System.Drawing.Point(471, 114);
            this.label3_Nombre.Name = "label3_Nombre";
            this.label3_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label3_Nombre.TabIndex = 3;
            this.label3_Nombre.Text = "Nombre";
            // 
            // label4_Email
            // 
            this.label4_Email.AutoSize = true;
            this.label4_Email.Location = new System.Drawing.Point(483, 152);
            this.label4_Email.Name = "label4_Email";
            this.label4_Email.Size = new System.Drawing.Size(32, 13);
            this.label4_Email.TabIndex = 4;
            this.label4_Email.Text = "Email";
            // 
            // label5_Usuario
            // 
            this.label5_Usuario.AutoSize = true;
            this.label5_Usuario.Location = new System.Drawing.Point(471, 190);
            this.label5_Usuario.Name = "label5_Usuario";
            this.label5_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label5_Usuario.TabIndex = 5;
            this.label5_Usuario.Text = "Usuario";
            // 
            // label6_Contraseña
            // 
            this.label6_Contraseña.AutoSize = true;
            this.label6_Contraseña.Location = new System.Drawing.Point(456, 232);
            this.label6_Contraseña.Name = "label6_Contraseña";
            this.label6_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.label6_Contraseña.TabIndex = 6;
            this.label6_Contraseña.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(523, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(523, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(523, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(523, 187);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(523, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 12;
            // 
            // button2_Eliminar
            // 
            this.button2_Eliminar.Location = new System.Drawing.Point(474, 281);
            this.button2_Eliminar.Name = "button2_Eliminar";
            this.button2_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button2_Eliminar.TabIndex = 13;
            this.button2_Eliminar.Text = "Eliminar";
            this.button2_Eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuIDDataGridViewTextBoxColumn,
            this.usuNombreUsuarioDataGridViewTextBoxColumn,
            this.usuContraseñaDataGridViewTextBoxColumn,
            this.usuApellidoNombreDataGridViewTextBoxColumn,
            this.rolCodigoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 192);
            this.dataGridView1.TabIndex = 14;
            // 
            // usuIDDataGridViewTextBoxColumn
            // 
            this.usuIDDataGridViewTextBoxColumn.DataPropertyName = "Usu_ID";
            this.usuIDDataGridViewTextBoxColumn.HeaderText = "Usu_ID";
            this.usuIDDataGridViewTextBoxColumn.Name = "usuIDDataGridViewTextBoxColumn";
            // 
            // usuNombreUsuarioDataGridViewTextBoxColumn
            // 
            this.usuNombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usu_NombreUsuario";
            this.usuNombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usu_NombreUsuario";
            this.usuNombreUsuarioDataGridViewTextBoxColumn.Name = "usuNombreUsuarioDataGridViewTextBoxColumn";
            // 
            // usuContraseñaDataGridViewTextBoxColumn
            // 
            this.usuContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Usu_Contraseña";
            this.usuContraseñaDataGridViewTextBoxColumn.HeaderText = "Usu_Contraseña";
            this.usuContraseñaDataGridViewTextBoxColumn.Name = "usuContraseñaDataGridViewTextBoxColumn";
            // 
            // usuApellidoNombreDataGridViewTextBoxColumn
            // 
            this.usuApellidoNombreDataGridViewTextBoxColumn.DataPropertyName = "Usu_ApellidoNombre";
            this.usuApellidoNombreDataGridViewTextBoxColumn.HeaderText = "Usu_ApellidoNombre";
            this.usuApellidoNombreDataGridViewTextBoxColumn.Name = "usuApellidoNombreDataGridViewTextBoxColumn";
            // 
            // rolCodigoDataGridViewTextBoxColumn
            // 
            this.rolCodigoDataGridViewTextBoxColumn.DataPropertyName = "Rol_Codigo";
            this.rolCodigoDataGridViewTextBoxColumn.HeaderText = "Rol_Codigo";
            this.rolCodigoDataGridViewTextBoxColumn.Name = "rolCodigoDataGridViewTextBoxColumn";
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
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 326);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2_Eliminar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6_Contraseña);
            this.Controls.Add(this.label5_Usuario);
            this.Controls.Add(this.label4_Email);
            this.Controls.Add(this.label3_Nombre);
            this.Controls.Add(this.label2_Apellido);
            this.Controls.Add(this.label1_Rol);
            this.Controls.Add(this.button1_Guardar);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Guardar;
        private System.Windows.Forms.Label label1_Rol;
        private System.Windows.Forms.Label label2_Apellido;
        private System.Windows.Forms.Label label3_Nombre;
        private System.Windows.Forms.Label label4_Email;
        private System.Windows.Forms.Label label5_Usuario;
        private System.Windows.Forms.Label label6_Contraseña;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private opticaDataSet opticaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private opticaDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuNombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuContraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuApellidoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolCodigoDataGridViewTextBoxColumn;
    }
}