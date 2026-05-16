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
    public partial class Compras : Form
    {
        Conexion Con;
        public Compras(Conexion Con)
        {
            InitializeComponent();
            this.Con = Con;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtIDCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDCompra, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtIDMateriaPrima_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDMateriaPrima, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtIDProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDProveedor, "Ingrese solo Números");
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumerosyComas(e);
            if (!valida)
                erpError.SetError(txtPrecio, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtIDCompra.Text) && !string.IsNullOrEmpty(txtIDMateriaPrima.Text) && !string.IsNullOrEmpty(txtIDProveedor.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtPrecio.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
        }

        private void txtIDCompra_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtIDMateriaPrima_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtIDProveedor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void Clear()
        {
            txtCantidad.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtIDProveedor.Text = string.Empty;
            txtIDMateriaPrima.Text = string.Empty;
            txtIDCompra.Text = string.Empty;
        }

        private async void Compras_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvCompras.DataSource = await Con.MostrarCompras();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime();
                fecha = dtpFecha.Value;
               
            await Con.InsertarCompra(int.Parse(txtIDProveedor.Text), int.Parse(txtCantidad.Text), int.Parse(txtIDMateriaPrima.Text), int.Parse(txtPrecio.Text),fecha);
            dgvCompras.DataSource = await Con.MostrarCompras();
            Clear();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            dgvCompras.DataSource = await Con.MostrarCompras();
            Clear();
        }
    }
}
