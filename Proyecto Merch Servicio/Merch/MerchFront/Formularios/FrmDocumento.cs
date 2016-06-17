using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPresupuesto.Logic;

namespace MerchFront.Formularios
{
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmDocumentoDetalle oFrm = new FrmDocumentoDetalle();
            oFrm.Estado = 1;
            if (oFrm.ShowDialog() == DialogResult.Cancel)
                return;

            MostrarLista();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void MostrarLista()
        {
            var oDocumento = new Documento_Cab();
            oDocumento.filtro = txtBusqueda.Text.Trim();
            var LDocumentoListarUso = oDocumento.ListarUso();
            dgvGastos.DataSource = LDocumentoListarUso;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            var oFrm = new FrmDocumentoDetalle();
            oFrm.Estado = 2;
            oFrm.oDocumento_Cab.ccosto = (string)dgvGastos.CurrentRow.Cells[colCosto.Name].Value;
            oFrm.oDocumento_Cab.doc = (string)dgvGastos.CurrentRow.Cells[colDoc.Name].Value;
            oFrm.oDocumento_Cab.numero = (string)dgvGastos.CurrentRow.Cells[ColNumero.Name].Value;
            if (oFrm.ShowDialog() == DialogResult.Cancel)
                return;

            MostrarLista();
        }
    }
}
