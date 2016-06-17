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
using DogoHelp;

namespace MerchFront.Formularios
{
    public partial class FrmCampanDetalle : Form
    {
        public int Estado;
        public CentroCosto_Cab oCentroCosto_Cab = new CentroCosto_Cab();

        public FrmCampanDetalle()
        {
            InitializeComponent();
        }

        //List<CentroCosto_Lin.ListarUso> oLista = new List<CentroCosto_Lin.ListarUso>();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCampanDetalle_Load(object sender, EventArgs e)
        {

            Win.Validacion.AsignarControlDecimal(txtMonto);
            Win.Validacion.AsignarControlDecimal(txtTotal);
            txtMonto.Text = "0";
            txtTotal.Text = "0";
            CargarControl();

            if (Estado == 2)
            {
                AsignarObjetoControl();
                HabilitarControles(false);
            }
            else
            {
                HabilitarControles(true);
            }
        }

        private void HabilitarControles(bool habilitado)
        {
            txtDescripcion.Enabled = habilitado;
            CboCliente.Enabled = habilitado;
            cboEjecutivo.Enabled = habilitado;

            if (Estado == 1)
            {
                cboEstado.Enabled = !habilitado;
            }
            else {
                cboEstado.Enabled = habilitado;
            }

            cboPartida.Enabled = habilitado;
            txtMonto.Enabled = habilitado;
            btnGrabar.Enabled = habilitado;
            btnAgregar.Enabled = habilitado;
            btnQuitar.Enabled = habilitado;
            btnModificar.Enabled = !habilitado;
        }

        private void AsignarObjetoControl()
        {
            oCentroCosto_Cab.Obtener();
            txtCosto.Text = oCentroCosto_Cab.ccosto;
            txtAnioMes.Text = oCentroCosto_Cab.ej + "-" + oCentroCosto_Cab.mes;
            txtDescripcion.Text = oCentroCosto_Cab.descripcion;
            CboCliente.SelectedValue = oCentroCosto_Cab.idcliente;
            cboEjecutivo.SelectedValue = oCentroCosto_Cab.idPersona;
            txtTotal.Text = oCentroCosto_Cab.total.Value.ToString("0.00");
            cboEstado.SelectedValue = oCentroCosto_Cab.idEstado;

            var oCentroCosto_Lin = new CentroCosto_Lin(oCentroCosto_Cab.ccosto, null);
            var LCentroCosto_LinListarUso = oCentroCosto_Lin.ListarUso();

            for (int i = 0; i <= LCentroCosto_LinListarUso.Count -1; i++)
            {
                int Fila = dgvPartida.Rows.Add();
                dgvPartida.Rows[Fila].Cells[colPartida.Name].Value = LCentroCosto_LinListarUso[i].idPartida;
                dgvPartida.Rows[Fila].Cells[colDescripcion.Name].Value = LCentroCosto_LinListarUso[i].Partida;
                dgvPartida.Rows[Fila].Cells[colTotal.Name].Value = LCentroCosto_LinListarUso[i].total;
            }
        }

        private void CargarControl()
        {
            var oCliente = new Cliente();
            oCliente.idEstado = "A";
            var LClienteListarDes = oCliente.ListarDes();
            LClienteListarDes.Insert(0, new Cliente.ListarDes { idCliente = 0, cliente = "-Seleccionar-" });
            Win.CargarCombo(CboCliente, LClienteListarDes);

            var oEjecutivo = new Nivel_Personal();
            oEjecutivo.idEstado = "A";
            oEjecutivo.idNivel = "E";
            var LEjecutivoListarDes = oEjecutivo.ListarDes();
            LEjecutivoListarDes.Insert(0, new Nivel_Personal.ListarDes { idPersona = 0, Nombre = "-Seleccionar-" });
            Win.CargarCombo(cboEjecutivo, LEjecutivoListarDes);


            var oPartida = new Partida();
            oPartida.idEstado = "A";
            var LoPartidaListarDes = oPartida.ListarDes();
            LoPartidaListarDes.Insert(0, new Partida.ListarDes { idPartida = "", Partida = "-Seleccionar-" });
            Win.CargarCombo(cboPartida, LoPartidaListarDes);

            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Cerrado");
            cboEstado.SelectedIndex = 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            decimal Monto = Global.ConvertirDecimal(txtMonto.Text);
            int i = cboPartida.SelectedIndex;

            if (i == 0)
            {
                MessageBox.Show("Debe seleccionar una partida para agregar al detalle", Global.tituloPres,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                cboPartida.Focus();
                return;
            }

            if (Monto <= 0) 
            {
                MessageBox.Show("Debe indicar un un monto para la partida seleccionada", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonto.Focus();
                return;
            }


            for (int j = 0; j <= dgvPartida.Rows.Count-1; j++)
            {
                if (dgvPartida.Rows[j].Cells[colPartida.Name].Value == cboPartida.SelectedValue)
                {
                    MessageBox.Show("La partida seleccionada ya se encuentra registrada en el detalle, favor de verificar", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPartida.Focus();
                    return;
                } 
            }

            int index = dgvPartida.Rows.Add();
            dgvPartida.Rows[index].Cells[colPartida.Name].Value= cboPartida.SelectedValue;
            dgvPartida.Rows[index].Cells[colDescripcion.Name].Value = cboPartida.Text;
            dgvPartida.Rows[index].Cells[colTotal.Name].Value = Monto;

            txtMonto.Text = "0";
            cboPartida.SelectedIndex = 0;

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal MontoTotal = 0;
            for (int j = 0; j <= dgvPartida.Rows.Count - 1; j++)
            {
                MontoTotal = MontoTotal + (decimal)dgvPartida.Rows[j].Cells[colTotal.Name].Value;
            }
            txtTotal.Text = MontoTotal.ToString("0.00");
        }

        private void dgvPartida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            if(dgvPartida.CurrentCell == null)
              {
                MessageBox.Show("No hay registros en el detalle", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvPartida.Focus();
                return; 
            }

            if (MessageBox.Show("¿Desea quitar el registro seleccionado del detalle?", Global.tituloPres, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int i = dgvPartida.CurrentCell.RowIndex;
                dgvPartida.Rows.RemoveAt(i);
                dgvPartida.Focus();
            }

            CalcularTotal();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Exige que se ingrese los datos antes de guardar
            if (!validarDatos())
            {
                return;
            }
            //Confirmacion para guardar
            if (MessageBox.Show("¿Desea guardar el Centro de Costo?", Global.tituloPres, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var oCabecera = new CentroCosto_Cab();
            var oLista = new List<CentroCosto_Lin>();

            oCabecera.idcliente = (int)CboCliente.SelectedValue;
            oCabecera.idPersona = (int)cboEjecutivo.SelectedValue;
            oCabecera.idEstado = (string)cboEstado.SelectedValue;
            oCabecera.descripcion = txtDescripcion.Text;
            oCabecera.total = Convert.ToDecimal(txtTotal.Text);
            oCabecera.usr = Global._Usr;
            oCabecera.idEstado = cboEstado.Text.Substring(0 ,1);

            for (int j = 0; j <= dgvPartida.Rows.Count - 1; j++)
            {
                var oDetalle = new CentroCosto_Lin();
                oDetalle.idPartida = dgvPartida.Rows[j].Cells[colPartida.Name].Value.ToString();
                oDetalle.total = Convert.ToDecimal(dgvPartida.Rows[j].Cells[colTotal.Name].Value);
                oLista.Add(oDetalle);
            }

            if (Estado == 1)
                oCabecera.Insertar(oLista);
            else
            {
                oCabecera.ccosto = oCentroCosto_Cab.ccosto;
                oCabecera.Actualizar(oLista);
            }

            txtAnioMes.Text = oCabecera.ej + " - " + oCabecera.mes;
            txtCosto.Text = oCabecera.ccosto;

            DialogResult = DialogResult.OK;
            MessageBox.Show("La campaña " + oCabecera.ccosto + " se guardó satisfactoriamente.", Global.tituloPres, MessageBoxButtons.OK,MessageBoxIcon.Information);

            Close();
        }

        private bool validarDatos()
        {
            //Variables para la validacion de ingreso de Datos
            string descripcion = txtDescripcion.Text;
            int indexCliente = CboCliente.SelectedIndex;
            int indexEjecutivo = cboEjecutivo.SelectedIndex;
            int cantidadDetalle = dgvPartida.Rows.Count;
            decimal totalIngreso = Global.ConvertirDecimal(txtTotal.Text);
           

            if (descripcion.Equals(""))
            {
                MessageBox.Show("Debe indicar una descripcion para en Centro de Costo", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return false;
            }

            if (indexCliente == 0)
            {
                MessageBox.Show("Debe seleccionar un Cliente", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CboCliente.Focus();
                return false;
            }

            if (indexEjecutivo == 0)
            {
                MessageBox.Show("Debe seleccionar un Ejecutivo", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboEjecutivo.Focus();
                return false;
            }

            if (cantidadDetalle == 0)
            {
                MessageBox.Show("Debe ingresar partidas con saldo en el detalle", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPartida.Focus();
                return false;
            }

            if (totalIngreso == 0)
            {
                MessageBox.Show("Verifique que el calculo del total este correcto", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
