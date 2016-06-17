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
    public partial class FrmPartida : Form
    {
        public FrmPartida()
        {
            InitializeComponent();
        }
        int tipo = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                guardar();
            }
            catch (Exception ex)
            {
                Utilidad.ImprimirError(ex, DateTime.Now);
            }
        }

        private void guardar()
        {
            string Descripcion = txtPartida.Text.Trim();
            if (Descripcion.Equals(""))
            {
                MessageBox.Show("Debe indicar una descripcion ", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPartida.Focus();
                txtPartida.SelectAll();
                return;
            }

            if (MessageBox.Show("¿Desea guardar el Regitro?", Global.tituloPres, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Partida oPartida = new Partida();
            oPartida.idPartida = txtIdPartida.Text;
            oPartida.partida = txtPartida.Text.Trim();
            oPartida.idEstado = "A";

            if (tipo == 1) //Esta insertando
            {    
                oPartida.Insertar();
            }
            else //Esta modificando
            {
                oPartida.Actualizar();
            }

            limpar();
            //al terminar los metodos habilitamos los controles
            habilitarControles(false);

            dgvPartida.DataSource = oPartida.Listar();
            int numFilas = dgvPartida.RowCount;

            if (tipo == 2) //Solo busco si esta modificando
            {
                for (int i = 0; i <= numFilas - 1; i++)
                {
                    if (dgvPartida.Rows[i].Cells[colPartida.Name].Value.ToString() == oPartida.idPartida)
                    {
                        dgvPartida.CurrentCell = dgvPartida.Rows[i].Cells[colPartida.Name];
                        return;
                    }
                }
            }        
        }

        private void limpar()
        {
            txtPartida.Text = "";
            txtIdPartida.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = 1;
            limpar();
            habilitarControles(true);
            txtPartida.Focus();
        }

        private void FrmPartida_Load(object sender, EventArgs e)
        {
            habilitarControles(false);
            mostar();
        }

        private void mostar()
        {
            var partida = new Partida(); 
            dgvPartida.DataSource = partida.Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                modificar();
                habilitarControles(true);
                txtPartida.Focus();
            }
            catch (Exception ex)
            {
                Utilidad.ImprimirError(ex, DateTime.Now);
            }
        }

        private void modificar()
        {
            int index = (dgvPartida.CurrentCell == null ? -1 : dgvPartida.CurrentCell.RowIndex);
            if (index == -1)
            {
                MessageBox.Show("Primero debe seleccionar una partida", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tipo = 2;
            Partida oPartida = new Partida();
            oPartida.idPartida = dgvPartida.Rows[index].Cells[colPartida.Name].Value.ToString();
            oPartida.Obtener();
            txtIdPartida.Text = oPartida.idPartida;
            txtPartida.Text = oPartida.partida.Trim();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarControles(false);
            limpar();
        }

        private void habilitarControles(bool habilitado)
        {
            btnCancelar.Visible= habilitado;
            btnGuardar.Visible = habilitado;

            btnNuevo.Visible = !habilitado;
            btnInactivar.Visible = !habilitado;
            btnModificar.Visible = !habilitado;

            txtPartida.Enabled = habilitado;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int index = (dgvPartida.CurrentCell == null ? -1 : dgvPartida.CurrentCell.RowIndex);
            if (index == -1)
            {
                MessageBox.Show("Primero debe seleccionar una partida", Global.tituloPres, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea inactivar la partida?", Global.tituloPres, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            var oPartida = new Partida();
            oPartida.idPartida = dgvPartida.Rows[index].Cells[colPartida.Name].Value.ToString();
            oPartida.Obtener();
            oPartida.idEstado = "I";
            oPartida.Actualizar();
            //Para actualizar la lista
            mostar();
        }
    }
}
