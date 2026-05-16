using FormProyecto.ClasesCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProyecto
{
    public partial class Ventas : Form
    {
        Conexion Con;
        public Ventas(Conexion Con)
        {
            InitializeComponent();
            this.Con = Con;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Ventas_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvVentas.DataSource = await Con.MostrarVenta();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
            }
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
            }
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void txtIDCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDCliente, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtCodProducto, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtCantidad, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtIDCliente.Text) && !string.IsNullOrEmpty(txtCodProducto.Text) && !string.IsNullOrEmpty(txtCantidad.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
        }

        private void txtIDCliente_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtCodProducto_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void Clear(Form f)
        {
            foreach (Control Controls in f.Controls)
            {
                if (Controls is TextBox)
                {
                    Controls.Text = "";
                }

            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {

            await Con.InsertarVentaDetVenta(int.Parse(txtCodProducto.Text), int.Parse(txtIDCliente.Text), int.Parse(txtCantidad.Text));
            dgvVentas.DataSource = await Con.MostrarVenta();
        }
    }
}
