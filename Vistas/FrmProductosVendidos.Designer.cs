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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Productos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_FiltrarFecha = new System.Windows.Forms.Button();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(424, 42);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Clientes.TabIndex = 21;
            this.comboBox_Clientes.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Clientes_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Filtrar Productos Vendidos por Cliente:";
            // 
            // dataGridView_Productos
            // 
            this.dataGridView_Productos.AllowUserToAddRows = false;
            this.dataGridView_Productos.AllowUserToDeleteRows = false;
            this.dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos.Location = new System.Drawing.Point(34, 147);
            this.dataGridView_Productos.Name = "dataGridView_Productos";
            this.dataGridView_Productos.ReadOnly = true;
            this.dataGridView_Productos.Size = new System.Drawing.Size(537, 233);
            this.dataGridView_Productos.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Desde:";
            // 
            // button_FiltrarFecha
            // 
            this.button_FiltrarFecha.Location = new System.Drawing.Point(23, 82);
            this.button_FiltrarFecha.Name = "button_FiltrarFecha";
            this.button_FiltrarFecha.Size = new System.Drawing.Size(108, 23);
            this.button_FiltrarFecha.TabIndex = 24;
            this.button_FiltrarFecha.Text = "Filtrar por Fecha";
            this.button_FiltrarFecha.UseVisualStyleBackColor = true;
            this.button_FiltrarFecha.Click += new System.EventHandler(this.button_FiltrarFecha_Click);
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(182, 35);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker_Hasta.TabIndex = 23;
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(23, 35);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker_Desde.TabIndex = 22;
            // 
            // FrmProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_FiltrarFecha);
            this.Controls.Add(this.dateTimePicker_Hasta);
            this.Controls.Add(this.dateTimePicker_Desde);
            this.Controls.Add(this.comboBox_Clientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView_Productos);
            this.Name = "FrmProductosVendidos";
            this.Text = "FrmProductosVendidos";
            this.Load += new System.EventHandler(this.FrmProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_FiltrarFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
    }
}