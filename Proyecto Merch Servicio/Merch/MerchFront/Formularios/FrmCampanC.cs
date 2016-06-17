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
    public partial class FrmCampanC : Form
    {
        public FrmCampanC()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCampanDetalle oFrm = new FrmCampanDetalle();
            oFrm.Estado = 1;
            if (oFrm.ShowDialog() == DialogResult.Cancel)
                return;

            MostrarLista();
        }

        private void FrmCampanC_Load(object sender, EventArgs e)
        {
            MostrarLista();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmCampanDetalle oFrm = new FrmCampanDetalle();
            oFrm.Estado = 2;
            oFrm.oCentroCosto_Cab.ccosto = (string)DgvCabecera.CurrentRow.Cells[colCosto.Name].Value;
            if (oFrm.ShowDialog() == DialogResult.Cancel)
                return;

            MostrarLista();
        }

        private void MostrarLista()
        {
            var oCentroCosto = new CentroCosto_Cab();
            oCentroCosto.filtro = txtFiltro.Text.Trim();
            var LCentroCostoListarUso = oCentroCosto.ListarUso();
            DgvCabecera.DataSource = LCentroCostoListarUso;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            MostrarLista();
        }
    }
}
