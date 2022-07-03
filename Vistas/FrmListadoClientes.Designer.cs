namespace Vistas
{
    partial class FrmListadoClientes
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
            this.button_Ordenar = new System.Windows.Forms.Button();
            this.button_OrdenarApellido = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_BuscarApellido = new System.Windows.Forms.TextBox();
            this.label_BuscarApellido = new System.Windows.Forms.Label();
            this.dataGridView_Cliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Ordenar
            // 
            this.button_Ordenar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Ordenar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ordenar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_Ordenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ordenar.Location = new System.Drawing.Point(15, 56);
            this.button_Ordenar.Name = "button_Ordenar";
            this.button_Ordenar.Size = new System.Drawing.Size(171, 29);
            this.button_Ordenar.TabIndex = 30;
            this.button_Ordenar.Text = "Ordenar Todos";
            this.button_Ordenar.UseVisualStyleBackColor = false;
            this.button_Ordenar.Click += new System.EventHandler(this.button_Ordenar_Click_1);
            // 
            // button_OrdenarApellido
            // 
            this.button_OrdenarApellido.BackColor = System.Drawing.Color.Gainsboro;
            this.button_OrdenarApellido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OrdenarApellido.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_OrdenarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OrdenarApellido.Location = new System.Drawing.Point(15, 21);
            this.button_OrdenarApellido.Name = "button_OrdenarApellido";
            this.button_OrdenarApellido.Size = new System.Drawing.Size(171, 29);
            this.button_OrdenarApellido.TabIndex = 29;
            this.button_OrdenarApellido.Text = "Ordenar por Apellido";
            this.button_OrdenarApellido.UseVisualStyleBackColor = false;
            this.button_OrdenarApellido.Click += new System.EventHandler(this.button_OrdenarApellido_Click_1);
            // 
            // button_Buscar
            // 
            this.button_Buscar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Buscar.Location = new System.Drawing.Point(14, 79);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(172, 29);
            this.button_Buscar.TabIndex = 28;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = false;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_BuscarApellido
            // 
            this.textBox_BuscarApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_BuscarApellido.Location = new System.Drawing.Point(14, 53);
            this.textBox_BuscarApellido.Name = "textBox_BuscarApellido";
            this.textBox_BuscarApellido.Size = new System.Drawing.Size(172, 20);
            this.textBox_BuscarApellido.TabIndex = 27;
            // 
            // label_BuscarApellido
            // 
            this.label_BuscarApellido.AutoSize = true;
            this.label_BuscarApellido.Location = new System.Drawing.Point(11, 37);
            this.label_BuscarApellido.Name = "label_BuscarApellido";
            this.label_BuscarApellido.Size = new System.Drawing.Size(123, 13);
            this.label_BuscarApellido.TabIndex = 26;
            this.label_BuscarApellido.Text = "DNI o Apellido y Nombre";
            // 
            // dataGridView_Cliente
            // 
            this.dataGridView_Cliente.AllowUserToAddRows = false;
            this.dataGridView_Cliente.AllowUserToDeleteRows = false;
            this.dataGridView_Cliente.AllowUserToResizeColumns = false;
            this.dataGridView_Cliente.AllowUserToResizeRows = false;
            this.dataGridView_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(28, 35);
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.Size = new System.Drawing.Size(449, 238);
            this.dataGridView_Cliente.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Buscar);
            this.groupBox1.Controls.Add(this.textBox_BuscarApellido);
            this.groupBox1.Controls.Add(this.label_BuscarApellido);
            this.groupBox1.Location = new System.Drawing.Point(556, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar un cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_OrdenarApellido);
            this.groupBox2.Controls.Add(this.button_Ordenar);
            this.groupBox2.Location = new System.Drawing.Point(556, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar";
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Cliente);
            this.Name = "FrmListadoClientes";
            this.Text = "FrmListadoClientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Ordenar;
        private System.Windows.Forms.Button button_OrdenarApellido;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_BuscarApellido;
        private System.Windows.Forms.Label label_BuscarApellido;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}