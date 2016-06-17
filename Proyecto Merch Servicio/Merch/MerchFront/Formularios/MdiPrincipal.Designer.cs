namespace MerchFront.Formularios
{
    partial class MdiPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuControlUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCambioClave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResgistroPartida = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nmuRegistroCampan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistroGastos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.recursosHumanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistroPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nivelDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 403);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(962, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Inicio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuPresupuesto,
            this.toolStripMenuItem2,
            this.operacionesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.recursosHumanosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuControlUsuarios,
            this.mnuCambioClave,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Image = global::MerchFront.Properties.Resources.Engranaje;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuControlUsuarios
            // 
            this.mnuControlUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnuControlUsuarios.Image")));
            this.mnuControlUsuarios.Name = "mnuControlUsuarios";
            this.mnuControlUsuarios.Size = new System.Drawing.Size(164, 22);
            this.mnuControlUsuarios.Text = "Control Usuarios";
            this.mnuControlUsuarios.Click += new System.EventHandler(this.mnuControlUsuarios_Click);
            // 
            // mnuCambioClave
            // 
            this.mnuCambioClave.Image = global::MerchFront.Properties.Resources.Engranaje2;
            this.mnuCambioClave.Name = "mnuCambioClave";
            this.mnuCambioClave.Size = new System.Drawing.Size(164, 22);
            this.mnuCambioClave.Text = "Cambio de Clave";
            this.mnuCambioClave.Click += new System.EventHandler(this.mnuCambioClave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mnuPresupuesto
            // 
            this.mnuPresupuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResgistroPartida,
            this.mnuRegistroClientes,
            this.toolStripSeparator1,
            this.nmuRegistroCampan});
            this.mnuPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("mnuPresupuesto.Image")));
            this.mnuPresupuesto.Name = "mnuPresupuesto";
            this.mnuPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.mnuPresupuesto.Text = "Presupuesto";
            // 
            // mnuResgistroPartida
            // 
            this.mnuResgistroPartida.Name = "mnuResgistroPartida";
            this.mnuResgistroPartida.Size = new System.Drawing.Size(187, 22);
            this.mnuResgistroPartida.Text = "Resgistro de Partida";
            this.mnuResgistroPartida.Click += new System.EventHandler(this.resgistroDePartidaToolStripMenuItem_Click);
            // 
            // mnuRegistroClientes
            // 
            this.mnuRegistroClientes.Name = "mnuRegistroClientes";
            this.mnuRegistroClientes.Size = new System.Drawing.Size(187, 22);
            this.mnuRegistroClientes.Text = "Registro de Clientes";
            this.mnuRegistroClientes.Click += new System.EventHandler(this.registroDeClientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // nmuRegistroCampan
            // 
            this.nmuRegistroCampan.Name = "nmuRegistroCampan";
            this.nmuRegistroCampan.Size = new System.Drawing.Size(187, 22);
            this.nmuRegistroCampan.Text = "Registro de Campaña";
            this.nmuRegistroCampan.Click += new System.EventHandler(this.nmuRegistroCampan_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegistroGastos});
            this.operacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operacionesToolStripMenuItem.Image")));
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // mnuRegistroGastos
            // 
            this.mnuRegistroGastos.Name = "mnuRegistroGastos";
            this.mnuRegistroGastos.Size = new System.Drawing.Size(171, 22);
            this.mnuRegistroGastos.Text = "Registro de Gastos";
            this.mnuRegistroGastos.Click += new System.EventHandler(this.mnuRegistroGastos_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = "|";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            this.recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegistroPersonal,
            this.toolStripSeparator2,
            this.nivelDePersonalToolStripMenuItem});
            this.recursosHumanosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recursosHumanosToolStripMenuItem.Image")));
            this.recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            this.recursosHumanosToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.recursosHumanosToolStripMenuItem.Text = "Recursos Humanos";
            // 
            // mnuRegistroPersonal
            // 
            this.mnuRegistroPersonal.Name = "mnuRegistroPersonal";
            this.mnuRegistroPersonal.Size = new System.Drawing.Size(181, 22);
            this.mnuRegistroPersonal.Text = "Registro de Personal";
            this.mnuRegistroPersonal.Click += new System.EventHandler(this.mnuRegistroPersonal_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // nivelDePersonalToolStripMenuItem
            // 
            this.nivelDePersonalToolStripMenuItem.Name = "nivelDePersonalToolStripMenuItem";
            this.nivelDePersonalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nivelDePersonalToolStripMenuItem.Text = "Nivel de Personal";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MerchFront.Properties.Resources.bgcontrol1;
            this.ClientSize = new System.Drawing.Size(962, 425);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiPrincipal";
            this.Text = "Sistema de Gestion y Control de Presupuestos MERCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MdiPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem mnuResgistroPartida;
        private System.Windows.Forms.ToolStripMenuItem nmuRegistroCampan;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistroClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistroGastos;
        private System.Windows.Forms.ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistroPersonal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuControlUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuCambioClave;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem nivelDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}