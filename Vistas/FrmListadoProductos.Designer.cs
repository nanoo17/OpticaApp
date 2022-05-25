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
            this.dataGridView_Productos = new System.Windows.Forms.DataGridView();
            this.button_CargarProducto = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Ordenar = new System.Windows.Forms.Button();
            this.radioButton_Categoria = new System.Windows.Forms.RadioButton();
            this.radioButton_Descripcion = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Productos
            // 
            this.dataGridView_Productos.AllowUserToAddRows = false;
            this.dataGridView_Productos.AllowUserToDeleteRows = false;
            this.dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos.Location = new System.Drawing.Point(23, 103);
            this.dataGridView_Productos.Name = "dataGridView_Productos";
            this.dataGridView_Productos.ReadOnly = true;
            this.dataGridView_Productos.Size = new System.Drawing.Size(375, 202);
            this.dataGridView_Productos.TabIndex = 0;
            // 
            // button_CargarProducto
            // 
            this.button_CargarProducto.Location = new System.Drawing.Point(529, 12);
            this.button_CargarProducto.Name = "button_CargarProducto";
            this.button_CargarProducto.Size = new System.Drawing.Size(95, 26);
            this.button_CargarProducto.TabIndex = 1;
            this.button_CargarProducto.Text = "Nuevo Producto";
            this.button_CargarProducto.UseVisualStyleBackColor = true;
            this.button_CargarProducto.Click += new System.EventHandler(this.button_CargarProducto_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(529, 44);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(95, 24);
            this.button_Cancelar.TabIndex = 2;
            this.button_Cancelar.Text = "Cancelar Carga";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Visible = false;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Ordenar
            // 
            this.button_Ordenar.Location = new System.Drawing.Point(196, 74);
            this.button_Ordenar.Name = "button_Ordenar";
            this.button_Ordenar.Size = new System.Drawing.Size(75, 23);
            this.button_Ordenar.TabIndex = 3;
            this.button_Ordenar.Text = "Ordenar";
            this.button_Ordenar.UseVisualStyleBackColor = true;
            // 
            // radioButton_Categoria
            // 
            this.radioButton_Categoria.AutoSize = true;
            this.radioButton_Categoria.Location = new System.Drawing.Point(105, 74);
            this.radioButton_Categoria.Name = "radioButton_Categoria";
            this.radioButton_Categoria.Size = new System.Drawing.Size(72, 17);
            this.radioButton_Categoria.TabIndex = 4;
            this.radioButton_Categoria.TabStop = true;
            this.radioButton_Categoria.Text = "Categoría";
            this.radioButton_Categoria.UseVisualStyleBackColor = true;
            // 
            // radioButton_Descripcion
            // 
            this.radioButton_Descripcion.AutoSize = true;
            this.radioButton_Descripcion.Location = new System.Drawing.Point(23, 74);
            this.radioButton_Descripcion.Name = "radioButton_Descripcion";
            this.radioButton_Descripcion.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Descripcion.TabIndex = 5;
            this.radioButton_Descripcion.TabStop = true;
            this.radioButton_Descripcion.Text = "Descripcion";
            this.radioButton_Descripcion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ordenar por :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // textBox_Codigo
            // 
            this.textBox_Codigo.Enabled = false;
            this.textBox_Codigo.Location = new System.Drawing.Point(524, 121);
            this.textBox_Codigo.Name = "textBox_Codigo";
            this.textBox_Codigo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Codigo.TabIndex = 11;
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.Location = new System.Drawing.Point(524, 154);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_Categoria.TabIndex = 12;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(524, 195);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_Descripcion.TabIndex = 13;
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Location = new System.Drawing.Point(524, 228);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_Precio.TabIndex = 14;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(524, 300);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 15;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Location = new System.Drawing.Point(443, 300);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_Eliminar.TabIndex = 16;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            // 
            // FrmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 350);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_Descripcion);
            this.Controls.Add(this.radioButton_Categoria);
            this.Controls.Add(this.button_Ordenar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_CargarProducto);
            this.Controls.Add(this.dataGridView_Productos);
            this.Name = "FrmListadoProductos";
            this.Text = "FrmListadoProductos";
            this.Load += new System.EventHandler(this.FrmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CargarProducto;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Ordenar;
        private System.Windows.Forms.RadioButton radioButton_Categoria;
        private System.Windows.Forms.RadioButton radioButton_Descripcion;
        private System.Windows.Forms.Label label1;
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
    }
}