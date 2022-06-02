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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetallesVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(585, 37);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Cliente.TabIndex = 1;
            this.label_Cliente.Text = "Cliente";
            // 
            // label_FechaVenta
            // 
            this.label_FechaVenta.AutoSize = true;
            this.label_FechaVenta.Location = new System.Drawing.Point(584, 62);
            this.label_FechaVenta.Name = "label_FechaVenta";
            this.label_FechaVenta.Size = new System.Drawing.Size(83, 13);
            this.label_FechaVenta.TabIndex = 2;
            this.label_FechaVenta.Text = "Fecha de Venta";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(679, 29);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cliente.TabIndex = 3;
            // 
            // dateTimePicker_FechaVenta
            // 
            this.dateTimePicker_FechaVenta.Location = new System.Drawing.Point(679, 56);
            this.dateTimePicker_FechaVenta.Name = "dateTimePicker_FechaVenta";
            this.dateTimePicker_FechaVenta.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_FechaVenta.TabIndex = 5;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(696, 108);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(103, 23);
            this.button_Guardar.TabIndex = 6;
            this.button_Guardar.Text = "Guardar Venta";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // textBox_CodigoProd
            // 
            this.textBox_CodigoProd.Enabled = false;
            this.textBox_CodigoProd.Location = new System.Drawing.Point(542, 261);
            this.textBox_CodigoProd.Name = "textBox_CodigoProd";
            this.textBox_CodigoProd.Size = new System.Drawing.Size(117, 20);
            this.textBox_CodigoProd.TabIndex = 23;
            // 
            // label_CodigoProd
            // 
            this.label_CodigoProd.AutoSize = true;
            this.label_CodigoProd.Location = new System.Drawing.Point(448, 261);
            this.label_CodigoProd.Name = "label_CodigoProd";
            this.label_CodigoProd.Size = new System.Drawing.Size(86, 13);
            this.label_CodigoProd.TabIndex = 22;
            this.label_CodigoProd.Text = "Codigo Producto";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(448, 352);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(31, 13);
            this.label_Total.TabIndex = 21;
            this.label_Total.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(542, 352);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(117, 20);
            this.textBox_Total.TabIndex = 20;
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(542, 316);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(117, 20);
            this.textBox_Cantidad.TabIndex = 19;
            this.textBox_Cantidad.TextChanged += new System.EventHandler(this.textBox_Cantidad_TextChanged);
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(448, 316);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 18;
            this.label_Cantidad.Text = "Cantidad";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Enabled = false;
            this.textBox_Precio.Location = new System.Drawing.Point(542, 287);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(117, 20);
            this.textBox_Precio.TabIndex = 17;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(448, 287);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(37, 13);
            this.label_Precio.TabIndex = 16;
            this.label_Precio.Text = "Precio";
            // 
            // dataGridView_Producto
            // 
            this.dataGridView_Producto.AllowUserToAddRows = false;
            this.dataGridView_Producto.AllowUserToDeleteRows = false;
            this.dataGridView_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Producto.Location = new System.Drawing.Point(12, 25);
            this.dataGridView_Producto.Name = "dataGridView_Producto";
            this.dataGridView_Producto.ReadOnly = true;
            this.dataGridView_Producto.Size = new System.Drawing.Size(430, 168);
            this.dataGridView_Producto.TabIndex = 24;
            this.dataGridView_Producto.CurrentCellChanged += new System.EventHandler(this.dataGridView_Producto_CurrentCellChanged);
            // 
            // button_AgregarDetalle
            // 
            this.button_AgregarDetalle.Location = new System.Drawing.Point(559, 397);
            this.button_AgregarDetalle.Name = "button_AgregarDetalle";
            this.button_AgregarDetalle.Size = new System.Drawing.Size(113, 23);
            this.button_AgregarDetalle.TabIndex = 26;
            this.button_AgregarDetalle.Text = "Agregar Detalle";
            this.button_AgregarDetalle.UseVisualStyleBackColor = true;
            this.button_AgregarDetalle.Click += new System.EventHandler(this.button_AgregarDetalle_Click);
            // 
            // button_EliminarDetalle
            // 
            this.button_EliminarDetalle.Location = new System.Drawing.Point(12, 397);
            this.button_EliminarDetalle.Name = "button_EliminarDetalle";
            this.button_EliminarDetalle.Size = new System.Drawing.Size(96, 23);
            this.button_EliminarDetalle.TabIndex = 27;
            this.button_EliminarDetalle.Text = "Eliminar Detalle";
            this.button_EliminarDetalle.UseVisualStyleBackColor = true;
            this.button_EliminarDetalle.Click += new System.EventHandler(this.button_EliminarDetalle_Click);
            // 
            // dataGridView_DetallesVenta
            // 
            this.dataGridView_DetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetallesVenta.Location = new System.Drawing.Point(12, 224);
            this.dataGridView_DetallesVenta.Name = "dataGridView_DetallesVenta";
            this.dataGridView_DetallesVenta.Size = new System.Drawing.Size(430, 167);
            this.dataGridView_DetallesVenta.TabIndex = 28;
            this.dataGridView_DetallesVenta.CurrentCellChanged += new System.EventHandler(this.dataGridView_DetallesVenta_CurrentCellChanged);
            // 
            // textBox_IdDetalle
            // 
            this.textBox_IdDetalle.Enabled = false;
            this.textBox_IdDetalle.Location = new System.Drawing.Point(542, 234);
            this.textBox_IdDetalle.Name = "textBox_IdDetalle";
            this.textBox_IdDetalle.Size = new System.Drawing.Size(61, 20);
            this.textBox_IdDetalle.TabIndex = 29;
            // 
            // label_IdDetalle
            // 
            this.label_IdDetalle.AutoSize = true;
            this.label_IdDetalle.Location = new System.Drawing.Point(448, 236);
            this.label_IdDetalle.Name = "label_IdDetalle";
            this.label_IdDetalle.Size = new System.Drawing.Size(54, 13);
            this.label_IdDetalle.TabIndex = 30;
            this.label_IdDetalle.Text = "ID Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Productos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Detalles:";
            // 
            // FrmCargarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_IdDetalle);
            this.Controls.Add(this.textBox_IdDetalle);
            this.Controls.Add(this.dataGridView_DetallesVenta);
            this.Controls.Add(this.button_EliminarDetalle);
            this.Controls.Add(this.button_AgregarDetalle);
            this.Controls.Add(this.dataGridView_Producto);
            this.Controls.Add(this.textBox_CodigoProd);
            this.Controls.Add(this.label_CodigoProd);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.label_Cantidad);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.dateTimePicker_FechaVenta);
            this.Controls.Add(this.comboBox_Cliente);
            this.Controls.Add(this.label_FechaVenta);
            this.Controls.Add(this.label_Cliente);
            this.Name = "FrmCargarVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetallesVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}