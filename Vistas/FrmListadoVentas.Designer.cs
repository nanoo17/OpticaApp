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
            this.dateTimePicker_Desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Hasta = new System.Windows.Forms.DateTimePicker();
            this.button_FiltrarFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CantidadVentas = new System.Windows.Forms.Label();
            this.lbl_kcyo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Listado
            // 
            this.dataGridView_Listado.AllowUserToAddRows = false;
            this.dataGridView_Listado.AllowUserToDeleteRows = false;
            this.dataGridView_Listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listado.Location = new System.Drawing.Point(12, 35);
            this.dataGridView_Listado.Name = "dataGridView_Listado";
            this.dataGridView_Listado.Size = new System.Drawing.Size(517, 305);
            this.dataGridView_Listado.TabIndex = 0;
            this.dataGridView_Listado.CurrentCellChanged += new System.EventHandler(this.dataGridView_Listado_CurrentCellChanged);
            // 
            // dateTimePicker_Desde
            // 
            this.dateTimePicker_Desde.Location = new System.Drawing.Point(9, 43);
            this.dateTimePicker_Desde.Name = "dateTimePicker_Desde";
            this.dateTimePicker_Desde.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker_Desde.TabIndex = 4;
            // 
            // dateTimePicker_Hasta
            // 
            this.dateTimePicker_Hasta.Location = new System.Drawing.Point(9, 89);
            this.dateTimePicker_Hasta.Name = "dateTimePicker_Hasta";
            this.dateTimePicker_Hasta.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker_Hasta.TabIndex = 5;
            // 
            // button_FiltrarFecha
            // 
            this.button_FiltrarFecha.BackColor = System.Drawing.Color.Gainsboro;
            this.button_FiltrarFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FiltrarFecha.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_FiltrarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FiltrarFecha.Location = new System.Drawing.Point(7, 138);
            this.button_FiltrarFecha.Name = "button_FiltrarFecha";
            this.button_FiltrarFecha.Size = new System.Drawing.Size(185, 29);
            this.button_FiltrarFecha.TabIndex = 6;
            this.button_FiltrarFecha.Text = "Filtrar Ventas";
            this.button_FiltrarFecha.UseVisualStyleBackColor = false;
            this.button_FiltrarFecha.Click += new System.EventHandler(this.button_FiltrarFecha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta:";
            // 
            // label_CantidadVentas
            // 
            this.label_CantidadVentas.AutoSize = true;
            this.label_CantidadVentas.Location = new System.Drawing.Point(13, 375);
            this.label_CantidadVentas.Name = "label_CantidadVentas";
            this.label_CantidadVentas.Size = new System.Drawing.Size(0, 13);
            this.label_CantidadVentas.TabIndex = 9;
            // 
            // lbl_kcyo
            // 
            this.lbl_kcyo.AutoSize = true;
            this.lbl_kcyo.Location = new System.Drawing.Point(107, 347);
            this.lbl_kcyo.Name = "lbl_kcyo";
            this.lbl_kcyo.Size = new System.Drawing.Size(0, 13);
            this.lbl_kcyo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Número de venta:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Eliminar.Location = new System.Drawing.Point(10, 29);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(182, 29);
            this.btn_Eliminar.TabIndex = 12;
            this.btn_Eliminar.Text = "Eliminar Venta";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(9, 27);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(185, 21);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Location = new System.Drawing.Point(607, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 66);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_FiltrarFecha);
            this.groupBox2.Controls.Add(this.dateTimePicker_Desde);
            this.groupBox2.Controls.Add(this.dateTimePicker_Hasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(607, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 185);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por fecha";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Eliminar);
            this.groupBox3.Location = new System.Drawing.Point(607, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 77);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar una venta";
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 406);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_kcyo);
            this.Controls.Add(this.label_CantidadVentas);
            this.Controls.Add(this.dataGridView_Listado);
            this.Name = "FrmListadoVentas";
            this.Text = "FrmListadoVentas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Listado;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Hasta;
        private System.Windows.Forms.Button button_FiltrarFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CantidadVentas;
        private System.Windows.Forms.Label lbl_kcyo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}