namespace Vistas
{
    partial class FrmListadoVentas
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
            this.dataGridView_Listado = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.button_FiltrarFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Listado
            // 
            this.dataGridView_Listado.AllowUserToAddRows = false;
            this.dataGridView_Listado.AllowUserToDeleteRows = false;
            this.dataGridView_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listado.Location = new System.Drawing.Point(41, 152);
            this.dataGridView_Listado.Name = "dataGridView_Listado";
            this.dataGridView_Listado.Size = new System.Drawing.Size(568, 191);
            this.dataGridView_Listado.TabIndex = 0;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(491, 39);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(443, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar Ventas por Cliente";
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(41, 36);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker_Desde.TabIndex = 4;
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(200, 36);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker_Hasta.TabIndex = 5;
            // 
            // button_FiltrarFecha
            // 
            this.button_FiltrarFecha.Location = new System.Drawing.Point(41, 83);
            this.button_FiltrarFecha.Name = "button_FiltrarFecha";
            this.button_FiltrarFecha.Size = new System.Drawing.Size(108, 23);
            this.button_FiltrarFecha.TabIndex = 6;
            this.button_FiltrarFecha.Text = "Filtrar por Fecha";
            this.button_FiltrarFecha.UseVisualStyleBackColor = true;
            this.button_FiltrarFecha.Click += new System.EventHandler(this.button_FiltrarFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta:";
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_FiltrarFecha);
            this.Controls.Add(this.dateTimePicker_Hasta);
            this.Controls.Add(this.dateTimePicker_Desde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dataGridView_Listado);
            this.Name = "FrmListadoVentas";
            this.Text = "FrmListadoVentas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Listado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.Button button_FiltrarFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}