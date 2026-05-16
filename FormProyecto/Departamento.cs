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
    public partial class Departamento : Form
    {
        Conexion Con;
        int renglon = 0;
        public Departamento(Conexion Con)
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
            await Con.insertarDepartamento(txtNombreDepartamento.Text);
            dgvDepartamentos.DataSource = await Con.MostrarDepartamentos();
            Clear();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                int id;
                id = int.Parse(dgvDepartamentos.Rows[renglon].Cells["ID"].Value.ToString());
                await Con.ModificarDepartamento(id, txtNombreDepartamento.Text);
                dgvDepartamentos.DataSource = await Con.MostrarDepartamentos();
                Clear();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ArgumentOutOfRangeException ex) { MessageBox.Show(ex.Message); }

        }

        private async void btnVer_Click(object sender, EventArgs e)
        {
            dgvDepartamentos.DataSource = await Con.MostrarDepartamentos();
        }

        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Nombre = "";

            Nombre = dgvDepartamentos.Rows[renglon].Cells["Nombre"].Value.ToString();
            txtNombreDepartamento.Text = Nombre;
        }

        private void txtNombreDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = ValidarTextbox.ValidarLetras(e);
            if (!valida)
                erpError.SetError(txtNombreDepartamento, "Ingrese cadenas de solo texto");
            else
                erpError.Clear();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombreDepartamento.Text);
            btnNuevo.Enabled = vr;
            btnModificar.Enabled = vr;
        }

        private void txtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }
        private void Clear()
        {
            txtNombreDepartamento.Text=string.Empty;
        }

        private async void Departamento_Load(object sender, EventArgs e)
        {
            ValidarCampo();
            dgvDepartamentos.DataSource = await Con.MostrarDepartamentos();

        }
    }
}
