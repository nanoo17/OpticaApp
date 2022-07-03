namespace Vistas
{
    partial class FrmProductosVendidos
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
            this.comboBox_Clientes = new System.Windows.Forms.ComboBox();
            this.dataGridView_Productos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_FiltrarFecha = new System.Windows.Forms.Button();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.label_ProductosVendidos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(6, 19);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(188, 21);
            this.comboBox_Clientes.TabIndex = 21;
            this.comboBox_Clientes.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Clientes_SelectionChangeCommitted);
            // 
            // dataGridView_Productos
            // 
            this.dataGridView_Productos.AllowUserToAddRows = false;
            this.dataGridView_Productos.AllowUserToDeleteRows = false;
            this.dataGridView_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos.Location = new System.Drawing.Point(12, 28);
            this.dataGridView_Productos.Name = "dataGridView_Productos";
            this.dataGridView_Productos.ReadOnly = true;
            this.dataGridView_Productos.Size = new System.Drawing.Size(466, 260);
            this.dataGridView_Productos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Desde:";
            // 
            // button_FiltrarFecha
            // 
            this.button_FiltrarFecha.BackColor = System.Drawing.Color.Gainsboro;
            this.button_FiltrarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FiltrarFecha.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_FiltrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FiltrarFecha.Location = new System.Drawing.Point(6, 131);
            this.button_FiltrarFecha.Name = "button_FiltrarFecha";
            this.button_FiltrarFecha.Size = new System.Drawing.Size(188, 29);
            this.button_FiltrarFecha.TabIndex = 24;
            this.button_FiltrarFecha.Text = "Filtrar por Fecha";
            this.button_FiltrarFecha.UseVisualStyleBackColor = false;
            this.button_FiltrarFecha.Click += new System.EventHandler(this.button_FiltrarFecha_Click);
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(6, 91);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker_Hasta.TabIndex = 23;
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(6, 43);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker_Desde.TabIndex = 22;
            // 
            // label_ProductosVendidos
            // 
            this.label_ProductosVendidos.AutoSize = true;
            this.label_ProductosVendidos.Location = new System.Drawing.Point(12, 311);
            this.label_ProductosVendidos.Name = "label_ProductosVendidos";
            this.label_ProductosVendidos.Size = new System.Drawing.Size(49, 13);
            this.label_ProductosVendidos.TabIndex = 27;
            this.label_ProductosVendidos.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_Hasta);
            this.groupBox1.Controls.Add(this.button_FiltrarFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker_Desde);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(612, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 174);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por fechas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Clientes);
            this.groupBox2.Location = new System.Drawing.Point(612, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 56);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por clientes";
            // 
            // FrmProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_ProductosVendidos);
            this.Controls.Add(this.dataGridView_Productos);
            this.Name = "FrmProductosVendidos";
            this.Text = "Listado Productos Vendidos";
            this.Load += new System.EventHandler(this.FrmProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.DataGridView dataGridView_Productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_FiltrarFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
        private System.Windows.Forms.Label label_ProductosVendidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}