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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(392, 72);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Cliente.TabIndex = 1;
            this.label_Cliente.Text = "Cliente";
            // 
            // label_FechaVenta
            // 
            this.label_FechaVenta.AutoSize = true;
            this.label_FechaVenta.Location = new System.Drawing.Point(391, 97);
            this.label_FechaVenta.Name = "label_FechaVenta";
            this.label_FechaVenta.Size = new System.Drawing.Size(83, 13);
            this.label_FechaVenta.TabIndex = 2;
            this.label_FechaVenta.Text = "Fecha de Venta";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(486, 64);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cliente.TabIndex = 3;
            // 
            // dateTimePicker_FechaVenta
            // 
            this.dateTimePicker_FechaVenta.Location = new System.Drawing.Point(486, 91);
            this.dateTimePicker_FechaVenta.Name = "dateTimePicker_FechaVenta";
            this.dateTimePicker_FechaVenta.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_FechaVenta.TabIndex = 5;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(486, 291);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(93, 23);
            this.button_Guardar.TabIndex = 6;
            this.button_Guardar.Text = "Guardar Venta";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // textBox_CodigoProd
            // 
            this.textBox_CodigoProd.Enabled = false;
            this.textBox_CodigoProd.Location = new System.Drawing.Point(486, 124);
            this.textBox_CodigoProd.Name = "textBox_CodigoProd";
            this.textBox_CodigoProd.Size = new System.Drawing.Size(117, 20);
            this.textBox_CodigoProd.TabIndex = 23;
            // 
            // label_CodigoProd
            // 
            this.label_CodigoProd.AutoSize = true;
            this.label_CodigoProd.Location = new System.Drawing.Point(392, 124);
            this.label_CodigoProd.Name = "label_CodigoProd";
            this.label_CodigoProd.Size = new System.Drawing.Size(86, 13);
            this.label_CodigoProd.TabIndex = 22;
            this.label_CodigoProd.Text = "Codigo Producto";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(392, 215);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(31, 13);
            this.label_Total.TabIndex = 21;
            this.label_Total.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(486, 215);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(117, 20);
            this.textBox_Total.TabIndex = 20;
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(486, 179);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(117, 20);
            this.textBox_Cantidad.TabIndex = 19;
            this.textBox_Cantidad.TextChanged += new System.EventHandler(this.textBox_Cantidad_TextChanged);
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(392, 179);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 18;
            this.label_Cantidad.Text = "Cantidad";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Enabled = false;
            this.textBox_Precio.Location = new System.Drawing.Point(486, 150);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(117, 20);
            this.textBox_Precio.TabIndex = 17;
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(392, 150);
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
            this.dataGridView_Producto.Location = new System.Drawing.Point(12, 50);
            this.dataGridView_Producto.Name = "dataGridView_Producto";
            this.dataGridView_Producto.ReadOnly = true;
            this.dataGridView_Producto.Size = new System.Drawing.Size(360, 226);
            this.dataGridView_Producto.TabIndex = 24;
            this.dataGridView_Producto.CurrentCellChanged += new System.EventHandler(this.dataGridView_Producto_CurrentCellChanged);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 346);
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
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).EndInit();
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
    }
}