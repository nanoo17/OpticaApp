﻿namespace Vistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUnaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verObrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            this.modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            this.modificarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
            this.modificarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarClientesToolStripMenuItem,
            this.listadoClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // modificarClientesToolStripMenuItem
            // 
            this.modificarClientesToolStripMenuItem.Name = "modificarClientesToolStripMenuItem";
            this.modificarClientesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modificarClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.modificarClientesToolStripMenuItem.Click += new System.EventHandler(this.modificarClientesToolStripMenuItem_Click);
            // 
            // listadoClientesToolStripMenuItem
            // 
            this.listadoClientesToolStripMenuItem.Name = "listadoClientesToolStripMenuItem";
            this.listadoClientesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listadoClientesToolStripMenuItem.Text = "Listado Clientes";
            this.listadoClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoClientesToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarUnaVentaToolStripMenuItem,
            this.verVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // cargarUnaVentaToolStripMenuItem
            // 
            this.cargarUnaVentaToolStripMenuItem.Name = "cargarUnaVentaToolStripMenuItem";
            this.cargarUnaVentaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cargarUnaVentaToolStripMenuItem.Text = "Cargar Venta";
            this.cargarUnaVentaToolStripMenuItem.Click += new System.EventHandler(this.cargarUnaVentaToolStripMenuItem_Click);
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.verVentasToolStripMenuItem.Text = "Ver Ventas";
            this.verVentasToolStripMenuItem.Click += new System.EventHandler(this.verVentasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProductosToolStripMenuItem,
            this.productosVendidosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // gestionarProductosToolStripMenuItem
            // 
            this.gestionarProductosToolStripMenuItem.Name = "gestionarProductosToolStripMenuItem";
            this.gestionarProductosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestionarProductosToolStripMenuItem.Text = "Gestionar Productos";
            this.gestionarProductosToolStripMenuItem.Click += new System.EventHandler(this.gestionarProductosToolStripMenuItem_Click);
            // 
            // productosVendidosToolStripMenuItem
            // 
            this.productosVendidosToolStripMenuItem.Name = "productosVendidosToolStripMenuItem";
            this.productosVendidosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.productosVendidosToolStripMenuItem.Text = "Productos Vendidos";
            this.productosVendidosToolStripMenuItem.Click += new System.EventHandler(this.productosVendidosToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarObraSocialToolStripMenuItem,
            this.verObrasSocialesToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.sistemaToolStripMenuItem.Text = "Obra Social";
            // 
            // registrarObraSocialToolStripMenuItem
            // 
            this.registrarObraSocialToolStripMenuItem.Name = "registrarObraSocialToolStripMenuItem";
            this.registrarObraSocialToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarObraSocialToolStripMenuItem.Text = "Registrar Obra Social";
            this.registrarObraSocialToolStripMenuItem.Click += new System.EventHandler(this.registrarObraSocialToolStripMenuItem_Click);
            // 
            // verObrasSocialesToolStripMenuItem
            // 
            this.verObrasSocialesToolStripMenuItem.Name = "verObrasSocialesToolStripMenuItem";
            this.verObrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.verObrasSocialesToolStripMenuItem.Text = "Ver Obras Sociales";
            this.verObrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.verObrasSocialesToolStripMenuItem_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.Firebrick;
            this.button_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir.ForeColor = System.Drawing.Color.Silver;
            this.button_Salir.Location = new System.Drawing.Point(672, 27);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(79, 31);
            this.button_Salir.TabIndex = 1;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(672, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Optica Lobo Jujeño";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarObraSocialToolStripMenuItem;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarUnaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verObrasSocialesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

