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
    public partial class Proveedores : Form
    {
        Conexion Con;
        int renglon = 0;
        public Proveedores(Conexion Con)
        {
            InitializeComponent();
            this.Con = Con;
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...")
            {
                txtBuscar.Text = "";
            }
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
            }
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Nombre, telefono, ruc, direccion, Idmun;

            Nombre = dgvProveedores.Rows[renglon].Cells["Nombre"].Value.ToString();
            telefono = dgvProveedores.Rows[renglon].Cells["Telefono"].Value.ToString();
            ruc = dgvProveedores.Rows[renglon].Cells["RUC"].Value.ToString();
            direccion = dgvProveedores.Rows[renglon].Cells["Direcion"].Value.ToString();
            Idmun = dgvProveedores.Rows[renglon].Cells["IDMunicipio"].Value.ToString();

            txtNombreProveedor.Text = Nombre;
            txtTelefono.Text = telefono;
            txrRUC.Text = ruc;
            txtIDMunicipio.Text = Idmun;
            txtDireccionProveedor.Text = direccion;

        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await Con.insertarProveedor(txrRUC.Text, txtNombreProveedor.Text, txtDireccionProveedor.Text, txtTelefono.Text, int.Parse(txtIDMunicipio.Text));

            dgvProveedores.DataSource = await Con.MostrarProveedores();
            Clear();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int idp = int.Parse(dgvProveedores.Rows[renglon].Cells["ID"].Value.ToString());
            await Con.ModificarProveedor(idp, txtNombreProveedor.Text, txtDireccionProveedor.Text, txtTelefono.Text, int.Parse(txtIDMunicipio.Text), txrRUC.Text);
            dgvProveedores.DataSource = await Con.MostrarProveedores();
            Clear();
        }

        private async void btnDarBaja_Click(object sender, EventArgs e)
        {
            int id = 0;


            try
            {
                id = int.Parse(dgvProveedores.Rows[renglon].Cells["ID"].Value.ToString());
                await Con.DardebajaProv(id);
                dgvProveedores.DataSource = await Con.MostrarProveedores();
                Clear();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message); }

        }

        private async void Proveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = await Con.MostrarProveedores();
            ValidarCampo();
        }

        private async void btnVer_Click(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = await Con.MostrarProveedores();
        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreProveedor, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtDireccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtTelefono, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txrRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreProveedor, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtIDMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDMunicipio, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombreProveedor.Text) && !string.IsNullOrEmpty(txtDireccionProveedor.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txrRUC.Text) && !string.IsNullOrEmpty(txtIDMunicipio.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
            btnDarBaja.Enabled = vr;
        }

        private void txtNombreProveedor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtDireccionProveedor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txrRUC_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtIDMunicipio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void Clear()
        {
            txtDireccionProveedor.Text = string.Empty;
            txtIDMunicipio.Text = string.Empty;
            txtNombreProveedor.Text= string.Empty;
            txtTelefono.Text = string.Empty;
            txrRUC.Text = string.Empty;
        }
    }
}
