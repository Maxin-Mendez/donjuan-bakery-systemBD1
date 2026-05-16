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
    public partial class Municipio : Form
    {
        Conexion Con;
        public Municipio(Conexion Con)
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
            await Con.InsertarMunicipio(int.Parse(txtIDDepartamento.Text), txtNombreMunicipio.Text);
            dgvMunicipios.DataSource = await Con.MostrarMunicipios();
            Clear();

        }

        private async void btnVer_Click(object sender, EventArgs e)
        {
            dgvMunicipios.DataSource = await Con.MostrarMunicipios();
        }

        private void txtNombreMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreMunicipio, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtIDDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtIDDepartamento, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombreMunicipio.Text) && !string.IsNullOrEmpty(txtIDDepartamento.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
        }

        private void txtNombreMunicipio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtIDDepartamento_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void Clear()
        {
            txtIDDepartamento.Text = string.Empty;
            txtNombreMunicipio.Text = string.Empty;
        }

        private async void Municipio_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvMunicipios.DataSource = await Con.MostrarMunicipios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
