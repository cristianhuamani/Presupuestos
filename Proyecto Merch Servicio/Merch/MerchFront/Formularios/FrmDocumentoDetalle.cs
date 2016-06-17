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
    public partial class FrmDocumentoDetalle : Form
    {

        public int Estado;
        public Documento_Cab oDocumento_Cab = new Documento_Cab();

        public FrmDocumentoDetalle()
        {
            InitializeComponent();
        }

        private void FrmDocumentoDetalle_Load(object sender, EventArgs e)
        {
            Win.Validacion.AsignarControlDecimal(txtMonto);
            Win.Validacion.AsignarControlEntero(txtCantidad);
            Win.Validacion.AsignarControlDecimal(txtTotalEgreso);
            txtCantidad.Text = "0";
            txtMonto.Text = "0";
            txtTotalEgreso.Text = "0";

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
            cboEncargado.Enabled = habilitado;
            cboPartidas.Enabled = habilitado;
            txtCantidad.Enabled = habilitado;
            txtMonto.Enabled = habilitado;
            if(this.Estado==1) txtCosto.Enabled = habilitado;

            btnAgregar.Enabled = habilitado;
            btnQuitar.Enabled = habilitado;
            btnGuardar.Enabled = habilitado;
            btnModificar.Enabled = !habilitado;
            btnEnviar.Enabled = !habilitado;
        }

        private void CargarControl()
        {
            var oEncargado= new Nivel_Personal();
            oEncargado.idEstado = "A";
            oEncargado.idNivel = "S";
            var LEncargadoListarDes = oEncargado.ListarDes();
            LEncargadoListarDes.Insert(0, new Nivel_Personal.ListarDes { idPersona = 0, Nombre = "-Seleccionar-" });
            Win.CargarCombo(cboEncargado, LEncargadoListarDes);

            var oCliente = new Cliente();
            oCliente.idEstado = "A";
            var LClienteListarDes = oCliente.ListarDes();
            LClienteListarDes.Insert(0, new Cliente.ListarDes { idCliente = 0, cliente = "" });
            Win.CargarCombo(cboCliente, LClienteListarDes);

            var oEjecutivo = new Nivel_Personal();
            oEjecutivo.idEstado = "A";
            oEjecutivo.idNivel = "E";
            var LEjecutivoListarDes = oEjecutivo.ListarDes();
            LEjecutivoListarDes.Insert(0, new Nivel_Personal.ListarDes { idPersona = 0, Nombre = "" });
            Win.CargarCombo(cboEjecutivo, LEjecutivoListarDes);


            cboEstado.Items.Add("P - Pendiente");
            cboEstado.Items.Add("R - Rechazado");
            cboEstado.Items.Add("V - Enviado");
            cboEstado.Items.Add("A - Aprobado");

            cboEstado.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AsignarObjetoControl()
        {
            oDocumento_Cab.Obtener();
            txtCosto.Text = oDocumento_Cab.ccosto;
            txtDoc_Numero.Text = oDocumento_Cab.numero;
            txtAnioMes.Text = oDocumento_Cab.ej + "-" + oDocumento_Cab.mes;
            txtDescripcion.Text = oDocumento_Cab.descripcion;
            cboCliente.Text= oDocumento_Cab.cliente;
            cboEjecutivo.Text = oDocumento_Cab.ejecutivo;
            cboEncargado.SelectedValue = oDocumento_Cab.idPersona;
            txtTotalEgreso.Text = oDocumento_Cab.total.Value.ToString("0.00");
            cboEstado.SelectedValue = oDocumento_Cab.idEstado;

            var oDocumento_Lin = new Documento_Lin(oDocumento_Cab.ccosto, oDocumento_Cab.doc,oDocumento_Cab.numero, null);
            var LDocumento_Lin_LinListarUso = oDocumento_Lin.ListarUso();

            for (int i = 0; i <= LDocumento_Lin_LinListarUso.Count - 1; i++)
            {
                int Fila = dgvPartida.Rows.Add();
                dgvPartida.Rows[Fila].Cells[colPartida.Name].Value = LDocumento_Lin_LinListarUso[i].idPartida;
                dgvPartida.Rows[Fila].Cells[colDescripcion.Name].Value = LDocumento_Lin_LinListarUso[i].partida;
                dgvPartida.Rows[Fila].Cells[ColCantidad.Name].Value = LDocumento_Lin_LinListarUso[i].cantidad;
                dgvPartida.Rows[Fila].Cells[ColPrecioUnd.Name].Value = LDocumento_Lin_LinListarUso[i].precio;
                dgvPartida.Rows[Fila].Cells[colTotal.Name].Value = LDocumento_Lin_LinListarUso[i].  total;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Exige que se ingrese los datos antes de guardar
            if (!validarDatos())
            {
                return;
            }

            //Confirmacion para guardar
            if (MessageBox.Show("¿Desea guardar el Documento de Gasto?", Global.tituloPres, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


            var oCabecera = new Documento_Cab();
            var oLista = new List<Documento_Lin>();

            oCabecera.ccosto = txtCosto.Text;
            oCabecera.doc = "DG";
            oCabecera.idPersona = (int)cboEncargado.SelectedValue;
            oCabecera.idEstado = (string)cboEstado.SelectedValue;
            oCabecera.total = Convert.ToDecimal(txtTotalEgreso.Text);
            oCabecera.usr = Global._Usr;
            oCabecera.idEstado = cboEstado.Text.Substring(0, 1);

            for (int j = 0; j <= dgvPartida.Rows.Count - 1; j++)
            {
                var oDetalle = new Documento_Lin();
                oDetalle.idPartida = dgvPartida.Rows[j].Cells[colPartida.Name].Value.ToString();
                oDetalle.cantidad = Convert.ToInt16(dgvPartida.Rows[j].Cells[ColCantidad.Name].Value);
                oDetalle.precio = Convert.ToDecimal(dgvPartida.Rows[j].Cells[ColPrecioUnd.Name].Value);
                oDetalle.total = Convert.ToDecimal(dgvPartida.Rows[j].Cells[colTotal.Name].Value);
                oLista.Add(oDetalle);
            }

            if (Estado == 1)
            {
                oCabecera.Insertar(oLista);
                txtAnioMes.Text = oCabecera.ej + " - " + oCabecera.mes;
                txtDoc_Numero.Text = oCabecera.numero;
                DialogResult = DialogResult.OK;
                MessageBox.Show("El documento " + oCabecera.ccosto + "-" + oCabecera.numero + " se guardó satisfactoriamente.", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                oCabecera.ccosto = oDocumento_Cab.ccosto;
                oCabecera.doc = oDocumento_Cab.doc;
                oCabecera.numero = oDocumento_Cab.numero;
                oCabecera.Actualizar(oLista);
            }

           
            DialogResult = DialogResult.OK;
            MessageBox.Show("El documento " + oCabecera.ccosto + "-"+ oCabecera.numero+ " se modifico satisfactoriamente.", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private bool validarDatos()
        {
            //Variables para la validacion de ingreso de Datos
            string ccosto = txtCosto.Text;
            int indexEncargado = cboEncargado.SelectedIndex;
            int cantidadDetalle = dgvPartida.Rows.Count;
            decimal totalEgreso = Global.ConvertirDecimal(txtTotalEgreso.Text);

            if (ccosto.Equals(""))
            {
                MessageBox.Show("Debe ingresar el centro de costo al cual cargara la solicitud", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCosto.Focus();
                return false;
            }

            if (indexEncargado == 0)
            {
                MessageBox.Show("Debe seleccionar un Encargado de gasto", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboEncargado.Focus();
                return false;
            }

            if (cantidadDetalle == 0)
            {
                MessageBox.Show("Debe ingresar los consumos de la partida en el detalle", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPartidas.Focus();
                return false;
            }

            if (totalEgreso == 0)
            {
                MessageBox.Show("Verifique que el calculo del Total Egreso este correcto", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal cantidad = Global.ConvertirDecimal(txtCantidad.Text);
            decimal Precio = Global.ConvertirDecimal(txtMonto.Text);
            decimal Monto = 0;
            int i = cboPartidas.SelectedIndex;

            if (i == 0)
            {
                MessageBox.Show("Debe seleccionar una partida para agregar al detalle", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPartidas.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("Debe indicar una cantidad para la partida seleccionada", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }

            if (Precio <= 0)
            {
                MessageBox.Show("Debe indicar un precio para la partida seleccionada", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonto.Focus();
                return;
            }


            for (int j = 0; j <= dgvPartida.Rows.Count - 1; j++)
            {
                if (dgvPartida.Rows[j].Cells[colPartida.Name].Value.ToString() == cboPartidas.SelectedValue.ToString())
                {
                    MessageBox.Show("La partida seleccionada ya se encuentra registrada en el detalle, favor de verificar", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboPartidas.Focus();
                    return;
                }
            }


            //validar Saldo en la partida
            //codigo

            // ds

            Monto = cantidad * Precio;
            if (MessageBox.Show("¿Desea agregar el monto de "+Monto.ToString()+" en la partida "+cboPartidas.Text +" Documento de Gasto?", Global.tituloPres, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int index = dgvPartida.Rows.Add();
            dgvPartida.Rows[index].Cells[colPartida.Name].Value = cboPartidas.SelectedValue;
            dgvPartida.Rows[index].Cells[colDescripcion.Name].Value = cboPartidas.Text;
            dgvPartida.Rows[index].Cells[ColCantidad.Name].Value = cantidad;
            dgvPartida.Rows[index].Cells[ColPrecioUnd.Name].Value = Precio;
            dgvPartida.Rows[index].Cells[colTotal.Name].Value = Monto;

            txtMonto.Text = "0";
            txtCantidad.Text = "0";
            cboPartidas.SelectedIndex = 0;

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal MontoTotal = 0;
            for (int j = 0; j <= dgvPartida.Rows.Count - 1; j++)
            {
                MontoTotal = MontoTotal + (decimal)dgvPartida.Rows[j].Cells[colTotal.Name].Value;
            }
            txtTotalEgreso.Text = MontoTotal.ToString("0.00");
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCosto_Validated(object sender, EventArgs e)
        {
            var ccosto = txtCosto.Text;
            if (ccosto.Equals(""))
            {
                MessageBox.Show("Debe ingresar un centro de costo para realizar el documento, favor de verificar", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPartidas.Focus();
                txtCosto.Focus();
                return;
            }

            var oCentroCosto_Cab = new CentroCosto_Cab();
            oCentroCosto_Cab.ccosto = ccosto;
            oCentroCosto_Cab.Obtener();

            if (oCentroCosto_Cab.idEstado=="C")
            {
                MessageBox.Show("El Centro de Costo ingresado se encuentra cerrado, no podra realisar salidas, favor de verificar", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCosto.Focus();
                return;
            }

            CargarPartida(ccosto);

            if (cboPartidas.Items.Count == 1)
            {
                MessageBox.Show("El Centro de Costo ingresado no existe, no podra realisar salidas, favor de verificar", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCosto.Focus();
                return;
            }

            //Mostrando informacion del centro de costo
            txtDescripcion.Text = oCentroCosto_Cab.descripcion;
            cboCliente.SelectedValue = (int)oCentroCosto_Cab.idcliente;
            cboEjecutivo.SelectedValue = (int)oCentroCosto_Cab.idPersona;

        }

        private void CargarPartida(string ccosto)
        {
            //mostrar solo las partidas del centro de costo
            var oCentroCosto_Lin = new CentroCosto_Lin();
            oCentroCosto_Lin.ccosto = ccosto;
            var LoPartidaListarDes = oCentroCosto_Lin.Listar();
            LoPartidaListarDes.Insert(0, new CentroCosto_Lin.Listar { idPartida = "", partida = "-Seleccionar-" });
            Win.CargarCombo(cboPartidas, LoPartidaListarDes);
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarControles(true);
            CargarPartida(txtCosto.Text);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvPartida.CurrentCell == null)
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
    }
}
