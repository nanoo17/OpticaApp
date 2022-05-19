namespace Vistas
{
    partial class FrmVenta
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
            this.label_NumeroVenta = new System.Windows.Forms.Label();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_FechaVenta = new System.Windows.Forms.Label();
            this.comboBox_Cliente = new System.Windows.Forms.ComboBox();
            this.textBox_NumeroVenta = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_NumeroVenta
            // 
            this.label_NumeroVenta.AutoSize = true;
            this.label_NumeroVenta.Location = new System.Drawing.Point(40, 39);
            this.label_NumeroVenta.Name = "label_NumeroVenta";
            this.label_NumeroVenta.Size = new System.Drawing.Size(90, 13);
            this.label_NumeroVenta.TabIndex = 0;
            this.label_NumeroVenta.Text = "Numero de Venta";
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(40, 84);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(39, 13);
            this.label_Cliente.TabIndex = 1;
            this.label_Cliente.Text = "Cliente";
            // 
            // label_FechaVenta
            // 
            this.label_FechaVenta.AutoSize = true;
            this.label_FechaVenta.Location = new System.Drawing.Point(40, 125);
            this.label_FechaVenta.Name = "label_FechaVenta";
            this.label_FechaVenta.Size = new System.Drawing.Size(83, 13);
            this.label_FechaVenta.TabIndex = 2;
            this.label_FechaVenta.Text = "Fecha de Venta";
            // 
            // comboBox_Cliente
            // 
            this.comboBox_Cliente.FormattingEnabled = true;
            this.comboBox_Cliente.Location = new System.Drawing.Point(134, 76);
            this.comboBox_Cliente.Name = "comboBox_Cliente";
            this.comboBox_Cliente.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cliente.TabIndex = 3;
            // 
            // textBox_NumeroVenta
            // 
            this.textBox_NumeroVenta.Location = new System.Drawing.Point(135, 36);
            this.textBox_NumeroVenta.Name = "textBox_NumeroVenta";
            this.textBox_NumeroVenta.Size = new System.Drawing.Size(120, 20);
            this.textBox_NumeroVenta.TabIndex = 4;
            // 
            // dateTimePicker_FechaVenta
            // 
            this.dateTimePicker_FechaVenta.Location = new System.Drawing.Point(135, 119);
            this.dateTimePicker_FechaVenta.Name = "dateTimePicker_FechaVenta";
            this.dateTimePicker_FechaVenta.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_FechaVenta.TabIndex = 5;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(43, 179);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(93, 23);
            this.button_Guardar.TabIndex = 6;
            this.button_Guardar.Text = "Guardar Venta";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.dateTimePicker_FechaVenta);
            this.Controls.Add(this.textBox_NumeroVenta);
            this.Controls.Add(this.comboBox_Cliente);
            this.Controls.Add(this.label_FechaVenta);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.label_NumeroVenta);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NumeroVenta;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_FechaVenta;
        private System.Windows.Forms.ComboBox comboBox_Cliente;
        private System.Windows.Forms.TextBox textBox_NumeroVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaVenta;
        private System.Windows.Forms.Button button_Guardar;
    }
}