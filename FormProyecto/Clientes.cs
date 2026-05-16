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
    public partial class Clientes : Form
    {
        Conexion Con;
        int renglon;
        public Clientes(Conexion Con)
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

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtPrimerNombre, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtSegundoNombre, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtPrimerApellido, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtSegundoApellido, "Ingrese cadenas de solo texto");
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
            var vr = !string.IsNullOrEmpty(txtPrimerNombre.Text) && !string.IsNullOrEmpty(txtPrimerApellido.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !string.IsNullOrEmpty(txtIDMunicipio.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
            btnDarBaja.Enabled = vr;
        }

        public void Clear()
        {
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtIDMunicipio.Text = string.Empty;
        }
        //private void Clear(Form f)
        //{
        //    foreach (Control Controls in f.Controls)
        //    {
        //        if (Controls is TextBox)
        //        {
        //            Controls.Text = "";
        //        }

        //    }
        //}

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
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

        private async void Clientes_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvClientes.DataSource = await Con.MostrarCliente();

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;

        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string primerNombre, segundoNombre, primerAPellido, SegundoApellido, Direcion, Idmun;

            try
            {
                primerNombre = dgvClientes.Rows[renglon].Cells["PNC"].Value.ToString();
                segundoNombre = dgvClientes.Rows[renglon].Cells["SNC"].Value.ToString();
                primerAPellido = dgvClientes.Rows[renglon].Cells["PAC"].Value.ToString();
                SegundoApellido = dgvClientes.Rows[renglon].Cells["SAC"].Value.ToString();
                Direcion = dgvClientes.Rows[renglon].Cells["DirC"].Value.ToString();
                Idmun = dgvClientes.Rows[renglon].Cells["IdMunicipio"].Value.ToString();

                txtPrimerNombre.Text = primerNombre;
                txtSegundoNombre.Text = segundoNombre;
                txtPrimerApellido.Text = primerAPellido;
                txtSegundoApellido.Text = SegundoApellido;
                txtDireccion.Text = Direcion;
                txtIDMunicipio.Text = Idmun;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await Con.InsertarCliente(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtDireccion.Text, int.Parse(txtIDMunicipio.Text));
            dgvClientes.DataSource = await Con.MostrarCliente();
            Clear();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvClientes.Rows[renglon].Cells["IdCliente"].Value.ToString());

            await Con.ModidficarCliente(id, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtDireccion.Text, int.Parse(txtIDMunicipio.Text));
            dgvClientes.DataSource = await Con.MostrarCliente();
            Clear();
        }

        private async void btnDarBaja_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvClientes.Rows[renglon].Cells["IdCliente"].Value.ToString());
            await Con.BajaCliente(id);
            dgvClientes.DataSource = await Con.MostrarCliente();
            Clear();
        }
    }
}
