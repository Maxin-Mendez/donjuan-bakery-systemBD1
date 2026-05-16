using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormProyecto.ClasesCrud;

namespace FormProyecto
{
    public partial class Productos : Form
    {
        Conexion Con;
        int renglon;
        public Productos(Conexion Con)
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

        private void btnProductos_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {


            await Con.insertarProducto(txtName.Text, txtDescP.Text, float.Parse(txtPrecio.Text), int.Parse(txtExistencias.Text));
            dgvProductos.DataSource = await Con.MostrarProductos();
            Clear(this);
        }

        private async void btnVER_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = await Con.MostrarProductos();

        }

        private async void btnDarBaja_Click(object sender, EventArgs e)
        {
            int id = 0;


            try
            {
                id = int.Parse(dgvProductos.Rows[renglon].Cells["ID"].Value.ToString());
                await Con.BajaProductos(id);
                dgvProductos.DataSource = await Con.MostrarProductos();
                Clear(this);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message); }


        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string descripcion, Nombre = "";
            string existencias;
            string precio = "";


            Nombre = dgvProductos.Rows[renglon].Cells["Nombre"].Value.ToString();
            precio = dgvProductos.Rows[renglon].Cells["Precio"].Value.ToString();
            descripcion = dgvProductos.Rows[renglon].Cells["Descripcion"].Value.ToString();
            existencias = dgvProductos.Rows[renglon].Cells["Existencias"].Value.ToString();
            txtName.Text = Nombre;
            txtDescP.Text = descripcion;
            txtPrecio.Text = precio;
            txtExistencias.Text = existencias;


        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                id = int.Parse(dgvProductos.Rows[renglon].Cells["ID"].Value.ToString());
                await Con.ModificarProdutos(id, txtName.Text, txtDescP.Text, float.Parse(txtPrecio.Text), int.Parse(txtExistencias.Text));
                dgvProductos.DataSource = await Con.MostrarProductos();
                //Clear(this);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message); }


        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtName, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }

        private void txtDescP_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtDescP, "Ingrese cadenas de solo texto");
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

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarNumeros(e);
            if (!valida)
                erpError.SetError(txtPrecio, "Ingrese solo Números");
            else
                erpError.Clear();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtDescP.Text) && !string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtExistencias.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
            btnDarBaja.Enabled = vr;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtDescP_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtExistencias_TextChanged(object sender, EventArgs e)
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

        private async void Productos_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvProductos.DataSource = await Con.MostrarProductos();
        }
    }
}
