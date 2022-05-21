namespace Vistas
{
    partial class FrmVentaDetalle
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
            this.comboBox_NumeroVenta = new System.Windows.Forms.ComboBox();
            this.label_NumeroVenta = new System.Windows.Forms.Label();
            this.label_Precio = new System.Windows.Forms.Label();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label_Total = new System.Windows.Forms.Label();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.dataGridView_Producto = new System.Windows.Forms.DataGridView();
            this.label_CodigoProd = new System.Windows.Forms.Label();
            this.textBox_CodigoProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_NumeroVenta
            // 
            this.comboBox_NumeroVenta.FormattingEnabled = true;
            this.comboBox_NumeroVenta.Location = new System.Drawing.Point(512, 40);
            this.comboBox_NumeroVenta.Name = "comboBox_NumeroVenta";
            this.comboBox_NumeroVenta.Size = new System.Drawing.Size(100, 21);
            this.comboBox_NumeroVenta.TabIndex = 0;
            // 
            // label_NumeroVenta
            // 
            this.label_NumeroVenta.AutoSize = true;
            this.label_NumeroVenta.Location = new System.Drawing.Point(401, 43);
            this.label_NumeroVenta.Name = "label_NumeroVenta";
            this.label_NumeroVenta.Size = new System.Drawing.Size(90, 13);
            this.label_NumeroVenta.TabIndex = 1;
            this.label_NumeroVenta.Text = "Numero de Venta";
            // 
            // label_Precio
            // 
            this.label_Precio.AutoSize = true;
            this.label_Precio.Location = new System.Drawing.Point(401, 96);
            this.label_Precio.Name = "label_Precio";
            this.label_Precio.Size = new System.Drawing.Size(37, 13);
            this.label_Precio.TabIndex = 4;
            this.label_Precio.Text = "Precio";
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.Enabled = false;
            this.textBox_Precio.Location = new System.Drawing.Point(512, 96);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_Precio.TabIndex = 6;
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(401, 125);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 8;
            this.label_Cantidad.Text = "Cantidad";
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(512, 125);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cantidad.TabIndex = 9;
            this.textBox_Cantidad.TextChanged += new System.EventHandler(this.textBox_Cantidad_TextChanged);
            this.textBox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Cantidad_KeyPress);
            // 
            // textBox_Total
            // 
            this.textBox_Total.Enabled = false;
            this.textBox_Total.Location = new System.Drawing.Point(512, 161);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.Size = new System.Drawing.Size(100, 20);
            this.textBox_Total.TabIndex = 10;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(401, 161);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(31, 13);
            this.label_Total.TabIndex = 11;
            this.label_Total.Text = "Total";
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(404, 211);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 12;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // dataGridView_Producto
            // 
            this.dataGridView_Producto.AllowUserToAddRows = false;
            this.dataGridView_Producto.AllowUserToDeleteRows = false;
            this.dataGridView_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Producto.Location = new System.Drawing.Point(12, 24);
            this.dataGridView_Producto.Name = "dataGridView_Producto";
            this.dataGridView_Producto.ReadOnly = true;
            this.dataGridView_Producto.Size = new System.Drawing.Size(360, 226);
            this.dataGridView_Producto.TabIndex = 13;
            this.dataGridView_Producto.CurrentCellChanged += new System.EventHandler(this.dataGridView_Producto_CurrentCellChanged);
            // 
            // label_CodigoProd
            // 
            this.label_CodigoProd.AutoSize = true;
            this.label_CodigoProd.Location = new System.Drawing.Point(401, 70);
            this.label_CodigoProd.Name = "label_CodigoProd";
            this.label_CodigoProd.Size = new System.Drawing.Size(86, 13);
            this.label_CodigoProd.TabIndex = 14;
            this.label_CodigoProd.Text = "Codigo Producto";
            // 
            // textBox_CodigoProd
            // 
            this.textBox_CodigoProd.Enabled = false;
            this.textBox_CodigoProd.Location = new System.Drawing.Point(512, 70);
            this.textBox_CodigoProd.Name = "textBox_CodigoProd";
            this.textBox_CodigoProd.Size = new System.Drawing.Size(100, 20);
            this.textBox_CodigoProd.TabIndex = 15;
            // 
            // FrmVentaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 262);
            this.Controls.Add(this.textBox_CodigoProd);
            this.Controls.Add(this.label_CodigoProd);
            this.Controls.Add(this.dataGridView_Producto);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.textBox_Cantidad);
            this.Controls.Add(this.label_Cantidad);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.label_Precio);
            this.Controls.Add(this.label_NumeroVenta);
            this.Controls.Add(this.comboBox_NumeroVenta);
            this.Name = "FrmVentaDetalle";
            this.Text = "FrmVentaDetalle";
            this.Load += new System.EventHandler(this.FrmVentaDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_NumeroVenta;
        private System.Windows.Forms.Label label_NumeroVenta;
        private System.Windows.Forms.Label label_Precio;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.DataGridView dataGridView_Producto;
        private System.Windows.Forms.Label label_CodigoProd;
        private System.Windows.Forms.TextBox textBox_CodigoProd;
    }
}