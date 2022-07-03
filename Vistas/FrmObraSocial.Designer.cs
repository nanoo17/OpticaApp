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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
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
            this.button_confirmar.Location = new System.Drawing.Point(18, 257);
            this.button_confirmar.Name = "button_confirmar";
            this.button_confirmar.Size = new System.Drawing.Size(197, 29);
            this.button_confirmar.TabIndex = 4;
            this.button_confirmar.Text = "Guardar Obra Social";
            this.button_confirmar.UseVisualStyleBackColor = false;
            this.button_confirmar.Click += new System.EventHandler(this.button_confirmar_Click);
            // 
            // textBox_cuit
            // 
            this.textBox_cuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_cuit.Location = new System.Drawing.Point(115, 36);
            this.textBox_cuit.Name = "textBox_cuit";
            this.textBox_cuit.Size = new System.Drawing.Size(100, 20);
            this.textBox_cuit.TabIndex = 5;
            // 
            // textBox_razonSocial
            // 
            this.textBox_razonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_razonSocial.Location = new System.Drawing.Point(115, 70);
            this.textBox_razonSocial.Name = "textBox_razonSocial";
            this.textBox_razonSocial.Size = new System.Drawing.Size(100, 20);
            this.textBox_razonSocial.TabIndex = 6;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_telefono.Location = new System.Drawing.Point(115, 111);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefono.TabIndex = 7;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_direccion.Location = new System.Drawing.Point(115, 145);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccion.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_razonSocial);
            this.groupBox1.Controls.Add(this.textBox_direccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_telefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_cuit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_confirmar);
            this.groupBox1.Location = new System.Drawing.Point(68, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 302);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obra Social";
            // 
            // FrmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 326);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmObraSocial";
            this.Text = "FrmObraSocial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
    }
}