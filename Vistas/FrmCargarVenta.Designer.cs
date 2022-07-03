namespace Vistas
{
    partial class FrmCargarVenta
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
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_FechaVenta = new System.Windows.Forms.Label();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.textBox_CodigoProd = new System.Windows.Forms.TextBox();
            this.label_CodigoProd = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label_Precio = new System.Windows.Forms.Label();
            this.dataGridView_Producto = new System.Windows.Forms.DataGridView();
            this.button_AgregarDetalle = new System.Windows.Forms.Button();
            this.button_EliminarDetalle = new System.Windows.Forms.Button();
            this.dataGridView_DetallesVenta = new System.Windows.Forms.DataGridView();
            this.textBox_IdDetalle = new System.Windows.Forms.TextBox();
            this.label_IdDetalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_nuevoCliente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetallesVenta)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(6, 33);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Cliente.TabIndex = 1;
            this.label_Cliente.Text = "Cliente";
            // 
            // label_FechaVenta
            // 
            this.label_FechaVenta.AutoSize = true;
            this.label_FechaVenta.Location = new System.Drawing.Point(6, 72);
            this.label_FechaVenta.Name = "label_FechaVenta";
            this.label_FechaVenta.Size = new System.Drawing.Size(83, 13);
            this.label_FechaVenta.TabIndex = 2;
            this.label_FechaVenta.Text = "Fecha de Venta";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(51, 30);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(221, 21);
            this.comboBox_Cliente.TabIndex = 3;
            // 
            // dateTimePicker_FechaVenta
            // 
            this.dateTimePicker_FechaVenta.Location = new System.Drawing.Point(95, 69);
            this.dateTimePicker_FechaVenta.Name = "dateTimePicker_FechaVenta";
            this.dateTimePicker_FechaVenta.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker_FechaVenta.TabIndex = 5;
            // 
            // button_Guardar
            // 
            this.button_Guardar.BackColor = System.Drawing.Color.LightGreen;
            this.button_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.button_Guardar.Location = new System.Drawing.Point(29, 356);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(224, 38);
            this.button_Guardar.TabIndex = 6;
            this.button_Guardar.Text = "Guardar Venta";
            this.button_Guardar.UseVisualStyleBackColor = false;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // textBox_CodigoProd
            // 
            this.textBox_CodigoProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CodigoProd.Enabled = false;
            this.textBox_CodigoProd.Location = new System.Drawing.Point(162, 59);
            this.textBox_CodigoProd.Name = "textBox_CodigoProd";
            this.textBox_CodigoProd.Size = new System.Drawing.Size(136, 20);
            this.textBox_CodigoProd.TabIndex = 23;
            // 
            // label_CodigoProd
            // 
            this.label_CodigoProd.AutoSize = true;
            this.label_CodigoProd.Location = new System.Drawing.Point(6, 59);
            this.label_CodigoProd.Name = "label_CodigoProd";
            this.label_CodigoProd.Size = new System.Drawing.Size(86, 13);
            this.label_CodigoProd.TabIndex = 22;
            this.label_CodigoProd.Text = "Codigo Producto";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(6, 150);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(31, 13);
            this.label_Total.TabIndex = 21;
            this.label_Total.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(162, 150);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(136, 20);
            this.textBox_Total.TabIndex = 20;
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Cantidad.Location = new System.Drawing.Point(162, 114);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(136, 20);
            this.textBox_Cantidad.TabIndex = 19;
            this.textBox_Cantidad.TextChanged += new System.EventHandler(this.textBox_Cantidad_TextChanged);
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(6, 114);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 18;
            this.label_Cantidad.Text = "Cantidad";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Precio.Enabled = false;
            this.textBox_Precio.Location = new System.Drawing.Point(162, 85);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(136, 20);
            this.textBox_Precio.TabIndex = 17;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(6, 85);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(37, 13);
            this.label_Precio.TabIndex = 16;
            this.label_Precio.Text = "Precio";
            // 
            // dataGridView_Producto
            // 
            this.dataGridView_Producto.AllowUserToAddRows = false;
            this.dataGridView_Producto.AllowUserToDeleteRows = false;
            this.dataGridView_Producto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Producto.Location = new System.Drawing.Point(15, 40);
            this.dataGridView_Producto.Name = "dataGridView_Producto";
            this.dataGridView_Producto.ReadOnly = true;
            this.dataGridView_Producto.Size = new System.Drawing.Size(430, 168);
            this.dataGridView_Producto.TabIndex = 24;
            this.dataGridView_Producto.CurrentCellChanged += new System.EventHandler(this.dataGridView_Producto_CurrentCellChanged);
            // 
            // button_AgregarDetalle
            // 
            this.button_AgregarDetalle.BackColor = System.Drawing.Color.Gainsboro;
            this.button_AgregarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AgregarDetalle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_AgregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AgregarDetalle.Location = new System.Drawing.Point(9, 293);
            this.button_AgregarDetalle.Name = "button_AgregarDetalle";
            this.button_AgregarDetalle.Size = new System.Drawing.Size(298, 29);
            this.button_AgregarDetalle.TabIndex = 26;
            this.button_AgregarDetalle.Text = "Agregar Detalle";
            this.button_AgregarDetalle.UseVisualStyleBackColor = false;
            this.button_AgregarDetalle.Click += new System.EventHandler(this.button_AgregarDetalle_Click);
            // 
            // button_EliminarDetalle
            // 
            this.button_EliminarDetalle.BackColor = System.Drawing.Color.IndianRed;
            this.button_EliminarDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_EliminarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button_EliminarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EliminarDetalle.ForeColor = System.Drawing.Color.DarkRed;
            this.button_EliminarDetalle.Location = new System.Drawing.Point(9, 338);
            this.button_EliminarDetalle.Name = "button_EliminarDetalle";
            this.button_EliminarDetalle.Size = new System.Drawing.Size(298, 29);
            this.button_EliminarDetalle.TabIndex = 27;
            this.button_EliminarDetalle.Text = "Eliminar Detalle";
            this.button_EliminarDetalle.UseVisualStyleBackColor = false;
            this.button_EliminarDetalle.Click += new System.EventHandler(this.button_EliminarDetalle_Click);
            // 
            // dataGridView_DetallesVenta
            // 
            this.dataGridView_DetallesVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_DetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetallesVenta.Location = new System.Drawing.Point(15, 245);
            this.dataGridView_DetallesVenta.Name = "dataGridView_DetallesVenta";
            this.dataGridView_DetallesVenta.Size = new System.Drawing.Size(430, 167);
            this.dataGridView_DetallesVenta.TabIndex = 28;
            this.dataGridView_DetallesVenta.CurrentCellChanged += new System.EventHandler(this.dataGridView_DetallesVenta_CurrentCellChanged);
            // 
            // textBox_IdDetalle
            // 
            this.textBox_IdDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IdDetalle.Enabled = false;
            this.textBox_IdDetalle.Location = new System.Drawing.Point(162, 32);
            this.textBox_IdDetalle.Name = "textBox_IdDetalle";
            this.textBox_IdDetalle.Size = new System.Drawing.Size(136, 20);
            this.textBox_IdDetalle.TabIndex = 29;
            // 
            // label_IdDetalle
            // 
            this.label_IdDetalle.AutoSize = true;
            this.label_IdDetalle.Location = new System.Drawing.Point(6, 34);
            this.label_IdDetalle.Name = "label_IdDetalle";
            this.label_IdDetalle.Size = new System.Drawing.Size(54, 13);
            this.label_IdDetalle.TabIndex = 30;
            this.label_IdDetalle.Text = "ID Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Productos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Detalles:";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar.Location = new System.Drawing.Point(6, 21);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(183, 20);
            this.txt_Buscar.TabIndex = 33;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(6, 67);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(183, 29);
            this.btn_buscar.TabIndex = 34;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_nuevoCliente
            // 
            this.btn_nuevoCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_nuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevoCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btn_nuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoCliente.Location = new System.Drawing.Point(5, 36);
            this.btn_nuevoCliente.Name = "btn_nuevoCliente";
            this.btn_nuevoCliente.Size = new System.Drawing.Size(189, 29);
            this.btn_nuevoCliente.TabIndex = 36;
            this.btn_nuevoCliente.Text = "Nuevo Cliente";
            this.btn_nuevoCliente.UseVisualStyleBackColor = false;
            this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 456);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear una venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_Cliente);
            this.groupBox4.Controls.Add(this.dateTimePicker_FechaVenta);
            this.groupBox4.Controls.Add(this.comboBox_Cliente);
            this.groupBox4.Controls.Add(this.button_Guardar);
            this.groupBox4.Controls.Add(this.label_FechaVenta);
            this.groupBox4.Location = new System.Drawing.Point(8, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 410);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Confirmar venta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_nuevoCliente);
            this.groupBox3.Location = new System.Drawing.Point(647, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 82);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Crear un nuevo cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Buscar);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Location = new System.Drawing.Point(647, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 117);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar un cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView_Producto);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView_DetallesVenta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargar Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AgregarDetalle);
            this.groupBox1.Controls.Add(this.button_EliminarDetalle);
            this.groupBox1.Controls.Add(this.label_IdDetalle);
            this.groupBox1.Controls.Add(this.textBox_IdDetalle);
            this.groupBox1.Controls.Add(this.textBox_Cantidad);
            this.groupBox1.Controls.Add(this.textBox_Total);
            this.groupBox1.Controls.Add(this.label_Cantidad);
            this.groupBox1.Controls.Add(this.label_Total);
            this.groupBox1.Controls.Add(this.textBox_CodigoProd);
            this.groupBox1.Controls.Add(this.textBox_Precio);
            this.groupBox1.Controls.Add(this.label_Precio);
            this.groupBox1.Controls.Add(this.label_CodigoProd);
            this.groupBox1.Location = new System.Drawing.Point(521, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 388);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la venta";
            // 
            // FrmCargarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCargarVenta";
            this.Text = "Gestion de Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetallesVenta)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_FechaVenta;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaVenta;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.TextBox textBox_CodigoProd;
        private System.Windows.Forms.Label label_CodigoProd;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.DataGridView dataGridView_Producto;
        private System.Windows.Forms.Button button_AgregarDetalle;
        private System.Windows.Forms.Button button_EliminarDetalle;
        private System.Windows.Forms.DataGridView dataGridView_DetallesVenta;
        private System.Windows.Forms.TextBox textBox_IdDetalle;
        private System.Windows.Forms.Label label_IdDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_nuevoCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}