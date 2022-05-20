namespace Vistas
{
    partial class FrmUsuarioCargar
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
            this.button1_guardar = new System.Windows.Forms.Button();
            this.textBox1_ApellidoNombre = new System.Windows.Forms.TextBox();
            this.textBox2_Usuario = new System.Windows.Forms.TextBox();
            this.textBox3_Contraseña = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1_Rol = new System.Windows.Forms.Label();
            this.label_ApellidoNombre = new System.Windows.Forms.Label();
            this.label1_Usuario = new System.Windows.Forms.Label();
            this.label1_contraseña = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_guardar
            // 
            this.button1_guardar.Location = new System.Drawing.Point(109, 227);
            this.button1_guardar.Name = "button1_guardar";
            this.button1_guardar.Size = new System.Drawing.Size(75, 23);
            this.button1_guardar.TabIndex = 0;
            this.button1_guardar.Text = "Guardar";
            this.button1_guardar.UseVisualStyleBackColor = true;
            this.button1_guardar.Click += new System.EventHandler(this.button1_guardar_Click);
            // 
            // textBox1_ApellidoNombre
            // 
            this.textBox1_ApellidoNombre.Location = new System.Drawing.Point(147, 94);
            this.textBox1_ApellidoNombre.Name = "textBox1_ApellidoNombre";
            this.textBox1_ApellidoNombre.Size = new System.Drawing.Size(115, 20);
            this.textBox1_ApellidoNombre.TabIndex = 1;
            // 
            // textBox2_Usuario
            // 
            this.textBox2_Usuario.Location = new System.Drawing.Point(147, 138);
            this.textBox2_Usuario.Name = "textBox2_Usuario";
            this.textBox2_Usuario.Size = new System.Drawing.Size(115, 20);
            this.textBox2_Usuario.TabIndex = 2;
            // 
            // textBox3_Contraseña
            // 
            this.textBox3_Contraseña.Location = new System.Drawing.Point(147, 179);
            this.textBox3_Contraseña.Name = "textBox3_Contraseña";
            this.textBox3_Contraseña.Size = new System.Drawing.Size(115, 20);
            this.textBox3_Contraseña.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1_Rol
            // 
            this.label1_Rol.AutoSize = true;
            this.label1_Rol.Location = new System.Drawing.Point(85, 52);
            this.label1_Rol.Name = "label1_Rol";
            this.label1_Rol.Size = new System.Drawing.Size(23, 13);
            this.label1_Rol.TabIndex = 5;
            this.label1_Rol.Text = "Rol";
            // 
            // label_ApellidoNombre
            // 
            this.label_ApellidoNombre.AutoSize = true;
            this.label_ApellidoNombre.Location = new System.Drawing.Point(47, 97);
            this.label_ApellidoNombre.Name = "label_ApellidoNombre";
            this.label_ApellidoNombre.Size = new System.Drawing.Size(94, 13);
            this.label_ApellidoNombre.TabIndex = 6;
            this.label_ApellidoNombre.Text = "Apellido Y Nombre";
            // 
            // label1_Usuario
            // 
            this.label1_Usuario.AutoSize = true;
            this.label1_Usuario.Location = new System.Drawing.Point(78, 144);
            this.label1_Usuario.Name = "label1_Usuario";
            this.label1_Usuario.Size = new System.Drawing.Size(43, 13);
            this.label1_Usuario.TabIndex = 7;
            this.label1_Usuario.Text = "Usuario";
            // 
            // label1_contraseña
            // 
            this.label1_contraseña.AutoSize = true;
            this.label1_contraseña.Location = new System.Drawing.Point(78, 182);
            this.label1_contraseña.Name = "label1_contraseña";
            this.label1_contraseña.Size = new System.Drawing.Size(61, 13);
            this.label1_contraseña.TabIndex = 8;
            this.label1_contraseña.Text = "Contraseña";
            // 
            // FrmUsuarioCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1_contraseña);
            this.Controls.Add(this.label1_Usuario);
            this.Controls.Add(this.label_ApellidoNombre);
            this.Controls.Add(this.label1_Rol);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3_Contraseña);
            this.Controls.Add(this.textBox2_Usuario);
            this.Controls.Add(this.textBox1_ApellidoNombre);
            this.Controls.Add(this.button1_guardar);
            this.Name = "FrmUsuarioCargar";
            this.Text = "FrmUsuarioCargar";
            this.Load += new System.EventHandler(this.FrmUsuarioCargar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_guardar;
        private System.Windows.Forms.TextBox textBox1_ApellidoNombre;
        private System.Windows.Forms.TextBox textBox2_Usuario;
        private System.Windows.Forms.TextBox textBox3_Contraseña;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1_Rol;
        private System.Windows.Forms.Label label_ApellidoNombre;
        private System.Windows.Forms.Label label1_Usuario;
        private System.Windows.Forms.Label label1_contraseña;
    }
}