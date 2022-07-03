namespace Vistas
{
    partial class FrmListadoProductos
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
            this.button_CargarProducto = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Ordenar = new System.Windows.Forms.Button();
            this.radioButton_Categoria = new System.Windows.Forms.RadioButton();
            this.radioButton_Descripcion = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Codigo = new System.Windows.Forms.TextBox();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView_Productos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CargarProducto
            // 
            this.button_CargarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.button_CargarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CargarProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_CargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CargarProducto.Location = new System.Drawing.Point(12, 19);
            this.button_CargarProducto.Name = "button_CargarProducto";
            this.button_CargarProducto.Size = new System.Drawing.Size(173, 29);
            this.button_CargarProducto.TabIndex = 1;
            this.button_CargarProducto.Text = "Nuevo Producto";
            this.button_CargarProducto.UseVisualStyleBackColor = false;
            this.button_CargarProducto.Click += new System.EventHandler(this.button_CargarProducto_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.BackColor = System.Drawing.Color.BurlyWood;
            this.button_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancelar.Location = new System.Drawing.Point(770, 255);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(173, 29);
            this.button_Cancelar.TabIndex = 2;
            this.button_Cancelar.Text = "Cancelar Carga de Producto";
            this.button_Cancelar.UseVisualStyleBackColor = false;
            this.button_Cancelar.Visible = false;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Ordenar
            // 
            this.button_Ordenar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Ordenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ordenar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_Ordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ordenar.Location = new System.Drawing.Point(12, 56);
            this.button_Ordenar.Name = "button_Ordenar";
            this.button_Ordenar.Size = new System.Drawing.Size(173, 29);
            this.button_Ordenar.TabIndex = 3;
            this.button_Ordenar.Text = "Ordenar";
            this.button_Ordenar.UseVisualStyleBackColor = false;
            this.button_Ordenar.Click += new System.EventHandler(this.button_Ordenar_Click);
            // 
            // radioButton_Categoria
            // 
            this.radioButton_Categoria.AutoSize = true;
            this.radioButton_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton_Categoria.Location = new System.Drawing.Point(114, 23);
            this.radioButton_Categoria.Name = "radioButton_Categoria";
            this.radioButton_Categoria.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Categoria.TabIndex = 4;
            this.radioButton_Categoria.TabStop = true;
            this.radioButton_Categoria.Text = "Categoría";
            this.radioButton_Categoria.UseVisualStyleBackColor = true;
            // 
            // radioButton_Descripcion
            // 
            this.radioButton_Descripcion.AutoSize = true;
            this.radioButton_Descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButton_Descripcion.Location = new System.Drawing.Point(12, 23);
            this.radioButton_Descripcion.Name = "radioButton_Descripcion";
            this.radioButton_Descripcion.Size = new System.Drawing.Size(80, 17);
            this.radioButton_Descripcion.TabIndex = 5;
            this.radioButton_Descripcion.TabStop = true;
            this.radioButton_Descripcion.Text = "Descripcion";
            this.radioButton_Descripcion.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Codigo.Enabled = false;
            this.textBox_Codigo.Location = new System.Drawing.Point(100, 34);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.Size = new System.Drawing.Size(118, 20);
            this.textBox_Codigo.TabIndex = 11;
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Categoria.Location = new System.Drawing.Point(100, 67);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(118, 20);
            this.textBox_Categoria.TabIndex = 12;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Descripcion.Location = new System.Drawing.Point(100, 108);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(118, 20);
            this.textBox_Descripcion.TabIndex = 13;
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Precio.Location = new System.Drawing.Point(100, 141);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(118, 20);
            this.textBox_Precio.TabIndex = 14;
            this.textBox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Precio_KeyPress);
            // 
            // button_Guardar
            // 
            this.button_Guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Guardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guardar.Location = new System.Drawing.Point(19, 218);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(199, 29);
            this.button_Guardar.TabIndex = 15;
            this.button_Guardar.Text = "Guardar Producto";
            this.button_Guardar.UseVisualStyleBackColor = false;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.button_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Eliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Eliminar.Location = new System.Drawing.Point(19, 253);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(199, 29);
            this.button_Eliminar.TabIndex = 16;
            this.button_Eliminar.Text = "Eliminar Producto";
            this.button_Eliminar.UseVisualStyleBackColor = false;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // dataGridView_Productos
            // 
            this.dataGridView_Productos.AllowUserToAddRows = false;
            this.dataGridView_Productos.AllowUserToDeleteRows = false;
            this.dataGridView_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos.Location = new System.Drawing.Point(12, 37);
            this.dataGridView_Productos.Name = "dataGridView_Productos";
            this.dataGridView_Productos.ReadOnly = true;
            this.dataGridView_Productos.Size = new System.Drawing.Size(448, 301);
            this.dataGridView_Productos.TabIndex = 0;
            this.dataGridView_Productos.CurrentCellChanged += new System.EventHandler(this.dataGridView_Productos_CurrentCellChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Eliminar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_Guardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Precio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Descripcion);
            this.groupBox1.Controls.Add(this.textBox_Codigo);
            this.groupBox1.Controls.Add(this.textBox_Categoria);
            this.groupBox1.Location = new System.Drawing.Point(497, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 301);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_CargarProducto);
            this.groupBox2.Location = new System.Drawing.Point(758, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear un nuevo producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Ordenar);
            this.groupBox3.Controls.Add(this.radioButton_Descripcion);
            this.groupBox3.Controls.Add(this.radioButton_Categoria);
            this.groupBox3.Location = new System.Drawing.Point(761, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenar";
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 368);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.dataGridView_Productos);
            this.Name = "FrmListadoProductos";
            this.Text = "Listado de Productos";
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CargarProducto;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Ordenar;
        private System.Windows.Forms.RadioButton radioButton_Categoria;
        private System.Windows.Forms.RadioButton radioButton_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Codigo;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView_Productos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}