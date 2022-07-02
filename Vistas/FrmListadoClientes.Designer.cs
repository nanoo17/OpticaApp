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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Ordenar
            // 
            this.button_Ordenar.Location = new System.Drawing.Point(29, 82);
            this.button_Ordenar.Name = "button_Ordenar";
            this.button_Ordenar.Size = new System.Drawing.Size(120, 42);
            this.button_Ordenar.TabIndex = 30;
            this.button_Ordenar.Text = "Ordenar Todos";
            this.button_Ordenar.UseVisualStyleBackColor = true;
            this.button_Ordenar.Click += new System.EventHandler(this.button_Ordenar_Click_1);
            // 
            // button_OrdenarApellido
            // 
            this.button_OrdenarApellido.Location = new System.Drawing.Point(155, 82);
            this.button_OrdenarApellido.Name = "button_OrdenarApellido";
            this.button_OrdenarApellido.Size = new System.Drawing.Size(127, 42);
            this.button_OrdenarApellido.TabIndex = 29;
            this.button_OrdenarApellido.Text = "Ordenar por Apellido";
            this.button_OrdenarApellido.UseVisualStyleBackColor = true;
            this.button_OrdenarApellido.Click += new System.EventHandler(this.button_OrdenarApellido_Click_1);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(285, 11);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 28;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_BuscarApellido
            // 
            this.textBox_BuscarApellido.Location = new System.Drawing.Point(155, 11);
            this.textBox_BuscarApellido.Name = "textBox_BuscarApellido";
            this.textBox_BuscarApellido.Size = new System.Drawing.Size(124, 20);
            this.textBox_BuscarApellido.TabIndex = 27;
            // 
            // label_BuscarApellido
            // 
            this.label_BuscarApellido.AutoSize = true;
            this.label_BuscarApellido.Location = new System.Drawing.Point(26, 15);
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
            this.dataGridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cliente.Location = new System.Drawing.Point(29, 130);
            this.dataGridView_Cliente.Name = "dataGridView_Cliente";
            this.dataGridView_Cliente.Size = new System.Drawing.Size(556, 203);
            this.dataGridView_Cliente.TabIndex = 31;
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 345);
            this.Controls.Add(this.dataGridView_Cliente);
            this.Controls.Add(this.button_Ordenar);
            this.Controls.Add(this.button_OrdenarApellido);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.textBox_BuscarApellido);
            this.Controls.Add(this.label_BuscarApellido);
            this.Name = "FrmListadoClientes";
            this.Text = "FrmListadoClientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ordenar;
        private System.Windows.Forms.Button button_OrdenarApellido;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_BuscarApellido;
        private System.Windows.Forms.Label label_BuscarApellido;
        private System.Windows.Forms.DataGridView dataGridView_Cliente;
    }
}