using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FormProyecto.ClasesCrud;

namespace FormProyecto
{
    public partial class Menu : Form
    {
        private Form formActual = null;
        Conexion con;
        string user;
        public Menu(Conexion con, string user)
        {
            InitializeComponent();
            this.con = con;
            this.user = user;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void EscoderMenu()
        {
            pMenuVentas.Visible = false;
            pMenuCompras.Visible = false;
            pMenuAlmacen.Visible = false;
            pMenuDetallesEmpresa.Visible = false;
        }

        private void MostrarMenu(Panel pMenu)
        {
            if (pMenu.Visible == false)
            {
                EscoderMenu();
                pMenu.Visible = true;
            }
            else
            {
                pMenu.Visible = false;
            }

        }
        

        private void Menu_Load(object sender, EventArgs e)
        {
            EscoderMenu();
            lblUser.Text = "Usuario: " + user;
            if (user=="Diego") 
            {
                btnDetallesEmpresa.Enabled = false;
            }
        }

        private void btnMenuVentas_Click(object sender, EventArgs e)
        {
            MostrarMenu(pMenuVentas);
        }

        private void btnMenuCompras_Click(object sender, EventArgs e)
        {
            MostrarMenu(pMenuCompras);
        }

        private void btnMenuAlmacen_Click(object sender, EventArgs e)
        {
            MostrarMenu(pMenuAlmacen);


        }

        private void btnDetallesEmpresa_Click(object sender, EventArgs e)
        {
            MostrarMenu(pMenuDetallesEmpresa);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ventas(con));
            EscoderMenu();
        }

        private void btnDetalleVentas_Click(object sender, EventArgs e)
        {
            AbrirForm(new DetalleVentas(con));
            EscoderMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Clientes(con));
            EscoderMenu();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirForm(new Compras(con));
            EscoderMenu();
        }

        private void btnDetalleCompras_Click(object sender, EventArgs e)
        {
            AbrirForm(new DetalleCompras(con));
            EscoderMenu();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedores(con));
            EscoderMenu();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            AbrirForm(new MateriaPrima(con));
            EscoderMenu();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirForm(new Productos(con));
            EscoderMenu();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            AbrirForm(new Departamento(con));
            EscoderMenu();
        }

        private void btnMunicipio_Click(object sender, EventArgs e)
        {
            AbrirForm(new Municipio(con));
            EscoderMenu();
        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            AbrirForm(new Sucursal(con));
            EscoderMenu();
        }

        private void AbrirForm(object Form)
        {
            if (this.pFormulario.Controls.Count > 0)
            {
                this.pFormulario.Controls.RemoveAt(0);
            }
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.pFormulario.Controls.Add(frm);
            this.pFormulario.Tag = frm;
            frm.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pBarraHerramientas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
