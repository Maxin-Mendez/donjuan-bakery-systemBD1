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
    public partial class Sucursal : Form
    {
        Conexion Con;
        int renglon;
        public Sucursal(Conexion Con)
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

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
            }
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await Con.InsertarSucursal(txtNombreSucursal.Text, txtTelefono.Text, txtDireccion.Text, int.Parse(txtIDMunicipio.Text));
            dgvSucursales.DataSource = await Con.MostrarSucursal();
            Clear(this);
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int ids = int.Parse(dgvSucursales.Rows[renglon].Cells["ID"].Value.ToString());

            await Con.ModidficarSucursal(ids, txtNombreSucursal.Text, txtTelefono.Text, txtDireccion.Text, int.Parse(txtIDMunicipio.Text));
            dgvSucursales.DataSource = await Con.MostrarSucursal();
            Clear(this);

        }

        private async void Sucursal_Load(object sender, EventArgs e)
        {
            dgvSucursales.DataSource = await Con.MostrarSucursal();
            ValidarCampo();
        }

        private void dgvSucursales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvSucursales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Nombre, direccion, telefono, id;

            Nombre = dgvSucursales.Rows[renglon].Cells["Nombre"].Value.ToString();
            direccion = dgvSucursales.Rows[renglon].Cells["Direccion"].Value.ToString();
            telefono = dgvSucursales.Rows[renglon].Cells["Telefono"].Value.ToString();
            id = dgvSucursales.Rows[renglon].Cells["IDM"].Value.ToString();

            txtNombreSucursal.Text = Nombre;
            txtDireccion.Text = direccion;
            txtIDMunicipio.Text = id;
            txtTelefono.Text = telefono;

        }

        private async void btnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                int ids = int.Parse(dgvSucursales.Rows[renglon].Cells["ID"].Value.ToString());
                await Con.BajaSucursal(ids);
                dgvSucursales.DataSource = await Con.MostrarSucursal();
                Clear(this);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void txtNombreSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreSucursal, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDMunicipio, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIDMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDMunicipio, "Ingrese solo Números");
            else
                erpError.Clear();
        }

        private void txtEstadoSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDMunicipio, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombreSucursal.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtIDMunicipio.Text) && !string.IsNullOrEmpty(txtEstadoSucursal.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
            btnDarBaja.Enabled = vr;
        }

        private void txtNombreSucursal_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtIDMunicipio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtEstadoSucursal_TextChanged(object sender, EventArgs e)
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
    }
}
