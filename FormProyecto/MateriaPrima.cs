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
using System.Xml.Linq;

namespace FormProyecto
{
    public partial class MateriaPrima : Form
    {
        Conexion Con;
        public MateriaPrima(Conexion Con)
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

        private void txtNombreMateriaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreMateriaP, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtDescripcion, "Ingrese cadenas de solo texto");
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

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtEstado, "Ingrese solo Números");
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
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombreMateriaP.Text) && !string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtCantidad.Text) && !string.IsNullOrEmpty(txtEstado.Text) && !string.IsNullOrEmpty(txtIDProveedor.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
            btnDarBaja.Enabled = vr;
        }

        private void txtNombreMateriaP_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtIDProveedor_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void Clear()
        {
            txtIDProveedor.Text= string.Empty;
            txtEstado.Text= string.Empty;
            txtDescripcion.Text= string.Empty;
            txtCantidad.Text= string.Empty;
            txtNombreMateriaP.Text= string.Empty;
        }

        private async void MateriaPrima_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvMateriaPrima.DataSource = await Con.MostrarMateria();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await Con.InsertarMateria(txtNombreMateriaP.Text, txtDescripcion.Text, int.Parse(txtCantidad.Text), int.Parse(txtIDProveedor.Text));
            dgvMateriaPrima.DataSource = await Con.MostrarMateria();
            Clear();

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = int.Parse(dgvMateriaPrima.Rows[renglon].Cells["ID"].Value.ToString());
            await Con.ModificarMateria(id, txtNombreMateriaP.Text, txtDescripcion.Text, int.Parse(txtCantidad.Text), int.Parse(txtIDProveedor.Text));
            dgvMateriaPrima.DataSource = await Con.MostrarMateria();
            Clear();
        }

        private async void btnDarBaja_Click(object sender, EventArgs e)
        {

            dgvMateriaPrima.DataSource = await Con.MostrarMateria();
            Clear();
        }
        int renglon;
        private void dgvMateriaPrima_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvMateriaPrima_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Nombre, Descripcion, cantidad, idprov, Existencias;

            try
            {
                Nombre = dgvMateriaPrima.Rows[renglon].Cells["Nombre"].Value.ToString();
                Descripcion = dgvMateriaPrima.Rows[renglon].Cells["Descripcion"].Value.ToString();
                cantidad = dgvMateriaPrima.Rows[renglon].Cells["Existencias"].Value.ToString();
                idprov = dgvMateriaPrima.Rows[renglon].Cells["IdProvedor"].Value.ToString();
                txtNombreMateriaP.Text = Nombre;
                txtDescripcion.Text = Descripcion;
                txtCantidad.Text = cantidad;
                txtIDProveedor.Text = idprov;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
