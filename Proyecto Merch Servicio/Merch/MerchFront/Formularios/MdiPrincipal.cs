using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchFront.Formularios
{
    public partial class MdiPrincipal : Form
    {
        public MdiPrincipal()
        {
            InitializeComponent();
        }

        private void resgistroDePartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPartida frmPartida = new FrmPartida();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == frmPartida.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                frmPartida.MdiParent = this;
                frmPartida.Show();
            }
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente Formulario = new FrmCliente();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == Formulario.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                Formulario.MdiParent = this;
                Formulario.Show();
            }
        }

        private void nmuRegistroCampan_Click(object sender, EventArgs e)
        {
            FrmCampanC Formulario = new FrmCampanC();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == Formulario.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                Formulario.MdiParent = this;
                Formulario.Show();
            }
        }

        private void mnuRegistroGastos_Click(object sender, EventArgs e)
        {
            FrmDocumento Formulario = new FrmDocumento();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == Formulario.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                Formulario.MdiParent = this;
                Formulario.Show();
            }
        }

        private void mnuRegistroPersonal_Click(object sender, EventArgs e)
        {
            FrmPersonal Formulario = new FrmPersonal();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == Formulario.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                Formulario.MdiParent = this;
                Formulario.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MdiPrincipal_Load(object sender, EventArgs e)
        {
            //Ruta donde se encuentra nuestra imagen
            string ruta = Application.StartupPath + "\\Imagenes\\fondo.jpg";

            //Comprobamos que la ruta exista
            if (File.Exists(ruta))
            {
                //Creamos un Bitmap con la imagen
                Bitmap bmp = new Bitmap(ruta);

                //Se la colocamos de fondo al formulario
                this.BackgroundImage = bmp;
            }
        }

        private void mnuControlUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Formulario = new FrmUsuarios();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == Formulario.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                Formulario.MdiParent = this;
                Formulario.Show();
            }
        }

        private void mnuCambioClave_Click(object sender, EventArgs e)
        {
            FrmClave Formulario = new FrmClave();

            bool Cargado = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == Formulario.Name)
                {
                    Cargado = true;
                }
            }

            if (!Cargado)
            {
                Formulario.MdiParent = this;
                Formulario.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
