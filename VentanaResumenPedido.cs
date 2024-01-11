using System.Windows.Forms;

namespace FarmaciaUnir
{
    public partial class VentanaResumenPedido : Form
    {
        public VentanaResumenPedido(TextBox nombre, ComboBox tipo, TextBox cantidad, ComboBox distribuidor, CheckBox principal, CheckBox secundaria, frmPedido ventanaPedido)
        {
            InitializeComponent();

            this.Text = "Pedido al distribuidor " + distribuidor.SelectedItem;

            this.lblTextoMedicamento.Text = cantidad.Text + " unidades del " + tipo.SelectedItem + " " + nombre.Text;

            if (principal.Checked && secundaria.Checked)
            {
                this.lblTextoDireccion.Text = "Para la farmacia situada en Calle de la Rosa n. 28 y para la situada en Calle Alcazabilla n.3";
            }

            else if (!principal.Checked)
            {
                this.lblTextoDireccion.Text = "Para la farmacia situada en Calle Alcazabilla n.3";
            }

            else
            {
                this.lblTextoDireccion.Text = "Para la farmacia situada en Calle de la Rosa n. 28";
            }
        }

        private void btnCancelarPedido_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarPedido_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Pedido Enviado");
        }
    }
}
