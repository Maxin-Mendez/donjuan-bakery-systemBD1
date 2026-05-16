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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FormProyecto.ClasesCrud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
using System.Data.SqlClient;

namespace FormProyecto
{
    public partial class LOGIN : Form
    {
        Conexion con;
        Menu menu;
        int cont = 3;
        string user;
        public LOGIN()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
            txtUsuario.ForeColor = Color.DimGray;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
            txtUsuario.ForeColor = Color.DimGray;
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
            }
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
            }
            txtContraseña.ForeColor = Color.DimGray;
            txtContraseña.UseSystemPasswordChar = false;
            if (txtContraseña.Text != "" && txtContraseña.Text != "CONTRASEÑA")
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            //txtUsuario.Text = "Dayron";

            //txtContraseña.Text = "Dllg";

            if (txtUsuario.Text.Equals("") || txtContraseña.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Alerta");
                Cursor.Current = Cursors.Default;
                return;
            }

            con = new Conexion(txtUsuario.Text, txtContraseña.Text);
            //con.Connect.Open();
            if (this.con.Connect.State == ConnectionState.Open)
            {
                user = txtUsuario.Text;
                menu= new Menu(con,user);
                menu.Show();
                this.Hide();



            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    btnLogin.Enabled = false;

                    Thread.Sleep(3000);
                    btnLogin.Enabled = true;


                }
            }
        }
    }
}
