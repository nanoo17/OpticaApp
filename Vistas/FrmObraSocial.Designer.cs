namespace Vistas
{
    partial class FrmObraSocial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_confirmar = new System.Windows.Forms.Button();
            this.textBox_cuit = new System.Windows.Forms.TextBox();
            this.textBox_razonSocial = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // button_confirmar
            // 
            this.button_confirmar.BackColor = System.Drawing.Color.Gainsboro;
            this.button_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_confirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirmar.Location = new System.Drawing.Point(101, 211);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(111, 29);
            this.button_confirmar.TabIndex = 4;
            this.button_confirmar.Text = "Confirmar";
            this.button_confirmar.UseVisualStyleBackColor = false;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // textBox_cuit
            // 
            this.textBox_cuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cuit.Location = new System.Drawing.Point(136, 56);
            this.textBox_cuit.Name = "textBox_cuit";
            this.textBox_cuit.Size = new System.Drawing.Size(100, 20);
            this.textBox_cuit.TabIndex = 5;
            // 
            // textBox_razonSocial
            // 
            this.textBox_razonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_razonSocial.Location = new System.Drawing.Point(136, 90);
            this.textBox_razonSocial.Name = "textBox_razonSocial";
            this.textBox_razonSocial.Size = new System.Drawing.Size(100, 20);
            this.textBox_razonSocial.TabIndex = 6;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_telefono.Location = new System.Drawing.Point(136, 131);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefono.TabIndex = 7;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_direccion.Location = new System.Drawing.Point(136, 165);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccion.TabIndex = 8;
            // 
            // FrmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_razonSocial);
            this.Controls.Add(this.textBox_cuit);
            this.Controls.Add(this.button_confirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmObraSocial";
            this.Text = "FrmObraSocial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_confirmar;
        private System.Windows.Forms.TextBox textBox_cuit;
        private System.Windows.Forms.TextBox textBox_razonSocial;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_direccion;
    }
}