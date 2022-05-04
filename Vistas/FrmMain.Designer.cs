namespace Vistas
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inquilinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alquilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Salir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.inquilinosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.alquilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarClienteToolStripMenuItem,
            this.cargarProductoToolStripMenuItem,
            this.registrarObraSocialToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // registrarClienteToolStripMenuItem
            // 
            this.registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            this.registrarClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            this.registrarClienteToolStripMenuItem.Click += new System.EventHandler(this.registrarClienteToolStripMenuItem_Click);
            // 
            // cargarProductoToolStripMenuItem
            // 
            this.cargarProductoToolStripMenuItem.Name = "cargarProductoToolStripMenuItem";
            this.cargarProductoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cargarProductoToolStripMenuItem.Text = "Cargar Producto";
            this.cargarProductoToolStripMenuItem.Click += new System.EventHandler(this.cargarProductoToolStripMenuItem_Click);
            // 
            // registrarObraSocialToolStripMenuItem
            // 
            this.registrarObraSocialToolStripMenuItem.Name = "registrarObraSocialToolStripMenuItem";
            this.registrarObraSocialToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarObraSocialToolStripMenuItem.Text = "Registrar Obra Social";
            this.registrarObraSocialToolStripMenuItem.Click += new System.EventHandler(this.registrarObraSocialToolStripMenuItem_Click);
            // 
            // inquilinosToolStripMenuItem
            // 
            this.inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            this.inquilinosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inquilinosToolStripMenuItem.Text = "Inquilinos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // alquilerToolStripMenuItem
            // 
            this.alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            this.alquilerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.alquilerToolStripMenuItem.Text = "Alquiler";
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.Red;
            this.button_Salir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.ForeColor = System.Drawing.Color.Black;
            this.button_Salir.Location = new System.Drawing.Point(684, 27);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(79, 29);
            this.button_Salir.TabIndex = 1;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 383);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inquilinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alquilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarObraSocialToolStripMenuItem;
        private System.Windows.Forms.Button button_Salir;
    }
}

