using System;
using System.Windows.Forms;

namespace FarmaciaUnir
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.quitarErrores();

            bool errores = false;

            string nombreMedicamento = this.txtNombreMedicamento.Text.Trim();
            int tipoMedicamento = this.cmbTipoMedicamento.SelectedIndex;
            string cantidad = this.txtCantidad.Text;
            int distribuidor = this.cmbDistribuidor.SelectedIndex;
            bool principal = this.chkPrincipal.Checked;
            bool secundaria = this.chkSecundaria.Checked;

            if(nombreMedicamento == "")
            {
                lblErrorNombre.Visible = true;
                errores = true;
            }

            if(tipoMedicamento == -1) {
                lblErrorTipo.Visible = true;
                errores = true;
            }

            int enteroPositivo;
            bool isNumber = int.TryParse(cantidad, out enteroPositivo);

            if(isNumber == false || enteroPositivo <=0)
            {
                lblErrorCantidad.Visible = true;
                errores = true;
            }

            if(distribuidor == -1)
            {
                lblErrorDistribuidor.Visible = true;
                errores = true;
            }

            if(principal == false && secundaria == false) { 
                lblErrorSucursal.Visible = true;
                errores = true;
            }

            if(!errores)
            {
                VentanaResumenPedido ventanaPedidoResumen = new VentanaResumenPedido(this.txtNombreMedicamento, this.cmbTipoMedicamento, this.txtCantidad, this.cmbDistribuidor, this.chkPrincipal, this.chkSecundaria, this);

                ventanaPedidoResumen.Show();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.quitarErrores();
            this.limpiarFormulario();

        }

        private void quitarErrores()
        {
            this.lblErrorCantidad.Visible = false;
            this.lblErrorDistribuidor.Visible = false;
            this.lblErrorNombre.Visible=false;
            this.lblErrorSucursal.Visible=false;
            this.lblErrorTipo.Visible=false;
        }

        private void limpiarFormulario()
        {
            this.txtNombreMedicamento.ResetText();
            this.cmbTipoMedicamento.SelectedIndex = -1;
            this.txtCantidad.ResetText();
            this.cmbDistribuidor.SelectedIndex = -1;
            this.chkPrincipal.Checked = false;
            this.chkSecundaria.Checked = false;
        }
    }
}
