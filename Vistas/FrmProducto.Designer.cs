namespace Vistas
{
    partial class FrmProducto
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
            this.label_ProdCodigo = new System.Windows.Forms.Label();
            this.label_ProdCategoria = new System.Windows.Forms.Label();
            this.label_ProdDescripcion = new System.Windows.Forms.Label();
            this.label_ProdPrecio = new System.Windows.Forms.Label();
            this.textBox_ProdCodigo = new System.Windows.Forms.TextBox();
            this.textBox_ProdCategoria = new System.Windows.Forms.TextBox();
            this.textBox_ProdDescripcion = new System.Windows.Forms.TextBox();
            this.textBox_ProdPrecio = new System.Windows.Forms.TextBox();
            this.button_Cargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ProdCodigo
            // 
            this.label_ProdCodigo.AutoSize = true;
            this.label_ProdCodigo.Location = new System.Drawing.Point(44, 70);
            this.label_ProdCodigo.Name = "label_ProdCodigo";
            this.label_ProdCodigo.Size = new System.Drawing.Size(40, 13);
            this.label_ProdCodigo.TabIndex = 0;
            this.label_ProdCodigo.Text = "Codigo";
            // 
            // label_ProdCategoria
            // 
            this.label_ProdCategoria.AutoSize = true;
            this.label_ProdCategoria.Location = new System.Drawing.Point(44, 98);
            this.label_ProdCategoria.Name = "label_ProdCategoria";
            this.label_ProdCategoria.Size = new System.Drawing.Size(52, 13);
            this.label_ProdCategoria.TabIndex = 1;
            this.label_ProdCategoria.Text = "Categoria";
            // 
            // label_ProdDescripcion
            // 
            this.label_ProdDescripcion.AutoSize = true;
            this.label_ProdDescripcion.Location = new System.Drawing.Point(44, 125);
            this.label_ProdDescripcion.Name = "label_ProdDescripcion";
            this.label_ProdDescripcion.Size = new System.Drawing.Size(63, 13);
            this.label_ProdDescripcion.TabIndex = 2;
            this.label_ProdDescripcion.Text = "Descripcion";
            // 
            // label_ProdPrecio
            // 
            this.label_ProdPrecio.AutoSize = true;
            this.label_ProdPrecio.Location = new System.Drawing.Point(44, 151);
            this.label_ProdPrecio.Name = "label_ProdPrecio";
            this.label_ProdPrecio.Size = new System.Drawing.Size(37, 13);
            this.label_ProdPrecio.TabIndex = 3;
            this.label_ProdPrecio.Text = "Precio";
            // 
            // textBox_ProdCodigo
            // 
            this.textBox_ProdCodigo.Location = new System.Drawing.Point(143, 67);
            this.textBox_ProdCodigo.Name = "textBox_ProdCodigo";
            this.textBox_ProdCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProdCodigo.TabIndex = 4;
            // 
            // textBox_ProdCategoria
            // 
            this.textBox_ProdCategoria.Location = new System.Drawing.Point(143, 95);
            this.textBox_ProdCategoria.Name = "textBox_ProdCategoria";
            this.textBox_ProdCategoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProdCategoria.TabIndex = 5;
            // 
            // textBox_ProdDescripcion
            // 
            this.textBox_ProdDescripcion.Location = new System.Drawing.Point(143, 122);
            this.textBox_ProdDescripcion.Name = "textBox_ProdDescripcion";
            this.textBox_ProdDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProdDescripcion.TabIndex = 6;
            // 
            // textBox_ProdPrecio
            // 
            this.textBox_ProdPrecio.Location = new System.Drawing.Point(143, 148);
            this.textBox_ProdPrecio.Name = "textBox_ProdPrecio";
            this.textBox_ProdPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBox_ProdPrecio.TabIndex = 7;
            // 
            // button_Cargar
            // 
            this.button_Cargar.Location = new System.Drawing.Point(93, 211);
            this.button_Cargar.Name = "button_Cargar";
            this.button_Cargar.Size = new System.Drawing.Size(98, 23);
            this.button_Cargar.TabIndex = 8;
            this.button_Cargar.Text = "Cargar Producto";
            this.button_Cargar.UseVisualStyleBackColor = true;
            this.button_Cargar.Click += new System.EventHandler(this.button_Cargar_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Cargar);
            this.Controls.Add(this.textBox_ProdPrecio);
            this.Controls.Add(this.textBox_ProdDescripcion);
            this.Controls.Add(this.textBox_ProdCategoria);
            this.Controls.Add(this.textBox_ProdCodigo);
            this.Controls.Add(this.label_ProdPrecio);
            this.Controls.Add(this.label_ProdDescripcion);
            this.Controls.Add(this.label_ProdCategoria);
            this.Controls.Add(this.label_ProdCodigo);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ProdCodigo;
        private System.Windows.Forms.Label label_ProdCategoria;
        private System.Windows.Forms.Label label_ProdDescripcion;
        private System.Windows.Forms.Label label_ProdPrecio;
        private System.Windows.Forms.TextBox textBox_ProdCodigo;
        private System.Windows.Forms.TextBox textBox_ProdCategoria;
        private System.Windows.Forms.TextBox textBox_ProdDescripcion;
        private System.Windows.Forms.TextBox textBox_ProdPrecio;
        private System.Windows.Forms.Button button_Cargar;
    }
}