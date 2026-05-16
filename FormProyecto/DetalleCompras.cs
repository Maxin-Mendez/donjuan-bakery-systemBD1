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
    public partial class DetalleCompras : Form
    {
        Conexion Con;
        public DetalleCompras(Conexion Con)
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

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ValidarCampo()
        {
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
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

        private async void DetalleCompras_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvDetalleCompras.DataSource = await Con.MostrarDetCompra();
        }
    }
}
