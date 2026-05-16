namespace FormProyecto
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pMenuLateral = new Panel();
            btnCerrarSesion = new Button();
            pMenuDetallesEmpresa = new Panel();
            btnSucursal = new Button();
            btnMunicipio = new Button();
            btnDepartamento = new Button();
            btnDetallesEmpresa = new Button();
            pMenuAlmacen = new Panel();
            btnProductos = new Button();
            btnMateriaPrima = new Button();
            btnMenuAlmacen = new Button();
            pMenuCompras = new Panel();
            btnProveedores = new Button();
            btnDetalleCompras = new Button();
            btnCompras = new Button();
            btnMenuCompras = new Button();
            pMenuVentas = new Panel();
            btnClientes = new Button();
            btnDetalleVentas = new Button();
            btnVentas = new Button();
            btnMenuVentas = new Button();
            pLogo = new Panel();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            pBarraHerramientas = new Panel();
            btnMinimizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            pFormulario = new Panel();
            pLogoEmpresa = new PictureBox();
            pMenuLateral.SuspendLayout();
            pMenuDetallesEmpresa.SuspendLayout();
            pMenuAlmacen.SuspendLayout();
            pMenuCompras.SuspendLayout();
            pMenuVentas.SuspendLayout();
            pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pBarraHerramientas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            pFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pLogoEmpresa).BeginInit();
            SuspendLayout();
            // 
            // pMenuLateral
            // 
            pMenuLateral.AutoScroll = true;
            pMenuLateral.BackColor = Color.FromArgb(0, 122, 204);
            pMenuLateral.Controls.Add(btnCerrarSesion);
            pMenuLateral.Controls.Add(pMenuDetallesEmpresa);
            pMenuLateral.Controls.Add(btnDetallesEmpresa);
            pMenuLateral.Controls.Add(pMenuAlmacen);
            pMenuLateral.Controls.Add(btnMenuAlmacen);
            pMenuLateral.Controls.Add(pMenuCompras);
            pMenuLateral.Controls.Add(btnMenuCompras);
            pMenuLateral.Controls.Add(pMenuVentas);
            pMenuLateral.Controls.Add(btnMenuVentas);
            pMenuLateral.Controls.Add(pLogo);
            pMenuLateral.Dock = DockStyle.Left;
            pMenuLateral.Location = new Point(0, 0);
            pMenuLateral.Name = "pMenuLateral";
            pMenuLateral.Size = new Size(250, 760);
            pMenuLateral.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 800);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(233, 60);
            btnCerrarSesion.TabIndex = 9;
            btnCerrarSesion.Text = "             Salir";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // pMenuDetallesEmpresa
            // 
            pMenuDetallesEmpresa.BackColor = Color.FromArgb(0, 142, 204);
            pMenuDetallesEmpresa.Controls.Add(btnSucursal);
            pMenuDetallesEmpresa.Controls.Add(btnMunicipio);
            pMenuDetallesEmpresa.Controls.Add(btnDepartamento);
            pMenuDetallesEmpresa.Dock = DockStyle.Top;
            pMenuDetallesEmpresa.Location = new Point(0, 675);
            pMenuDetallesEmpresa.Name = "pMenuDetallesEmpresa";
            pMenuDetallesEmpresa.Size = new Size(233, 125);
            pMenuDetallesEmpresa.TabIndex = 8;
            // 
            // btnSucursal
            // 
            btnSucursal.Dock = DockStyle.Top;
            btnSucursal.FlatAppearance.BorderSize = 0;
            btnSucursal.FlatStyle = FlatStyle.Flat;
            btnSucursal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSucursal.ForeColor = Color.Gainsboro;
            btnSucursal.Location = new Point(0, 80);
            btnSucursal.Name = "btnSucursal";
            btnSucursal.Padding = new Padding(30, 0, 0, 0);
            btnSucursal.Size = new Size(233, 40);
            btnSucursal.TabIndex = 2;
            btnSucursal.Text = "Sucursal";
            btnSucursal.TextAlign = ContentAlignment.MiddleLeft;
            btnSucursal.UseVisualStyleBackColor = true;
            btnSucursal.Click += btnSucursal_Click;
            // 
            // btnMunicipio
            // 
            btnMunicipio.Dock = DockStyle.Top;
            btnMunicipio.FlatAppearance.BorderSize = 0;
            btnMunicipio.FlatStyle = FlatStyle.Flat;
            btnMunicipio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMunicipio.ForeColor = Color.Gainsboro;
            btnMunicipio.Location = new Point(0, 40);
            btnMunicipio.Name = "btnMunicipio";
            btnMunicipio.Padding = new Padding(30, 0, 0, 0);
            btnMunicipio.Size = new Size(233, 40);
            btnMunicipio.TabIndex = 1;
            btnMunicipio.Text = "Municipio";
            btnMunicipio.TextAlign = ContentAlignment.MiddleLeft;
            btnMunicipio.UseVisualStyleBackColor = true;
            btnMunicipio.Click += btnMunicipio_Click;
            // 
            // btnDepartamento
            // 
            btnDepartamento.Dock = DockStyle.Top;
            btnDepartamento.FlatAppearance.BorderSize = 0;
            btnDepartamento.FlatStyle = FlatStyle.Flat;
            btnDepartamento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepartamento.ForeColor = Color.Gainsboro;
            btnDepartamento.Location = new Point(0, 0);
            btnDepartamento.Name = "btnDepartamento";
            btnDepartamento.Padding = new Padding(30, 0, 0, 0);
            btnDepartamento.Size = new Size(233, 40);
            btnDepartamento.TabIndex = 0;
            btnDepartamento.Text = "Departamento";
            btnDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartamento.UseVisualStyleBackColor = true;
            btnDepartamento.Click += btnDepartamento_Click;
            // 
            // btnDetallesEmpresa
            // 
            btnDetallesEmpresa.Dock = DockStyle.Top;
            btnDetallesEmpresa.FlatAppearance.BorderSize = 0;
            btnDetallesEmpresa.FlatStyle = FlatStyle.Flat;
            btnDetallesEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetallesEmpresa.ForeColor = Color.Gainsboro;
            btnDetallesEmpresa.Image = (Image)resources.GetObject("btnDetallesEmpresa.Image");
            btnDetallesEmpresa.ImageAlign = ContentAlignment.MiddleLeft;
            btnDetallesEmpresa.Location = new Point(0, 615);
            btnDetallesEmpresa.Name = "btnDetallesEmpresa";
            btnDetallesEmpresa.Size = new Size(233, 60);
            btnDetallesEmpresa.TabIndex = 7;
            btnDetallesEmpresa.Text = "             Detalles de Empresa";
            btnDetallesEmpresa.TextAlign = ContentAlignment.MiddleLeft;
            btnDetallesEmpresa.UseVisualStyleBackColor = true;
            btnDetallesEmpresa.Click += btnDetallesEmpresa_Click;
            // 
            // pMenuAlmacen
            // 
            pMenuAlmacen.BackColor = Color.FromArgb(0, 142, 204);
            pMenuAlmacen.Controls.Add(btnProductos);
            pMenuAlmacen.Controls.Add(btnMateriaPrima);
            pMenuAlmacen.Dock = DockStyle.Top;
            pMenuAlmacen.Location = new Point(0, 530);
            pMenuAlmacen.Name = "pMenuAlmacen";
            pMenuAlmacen.Size = new Size(233, 85);
            pMenuAlmacen.TabIndex = 6;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.ForeColor = Color.Gainsboro;
            btnProductos.Location = new Point(0, 40);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(30, 0, 0, 0);
            btnProductos.Size = new Size(233, 40);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnInventario_Click;
            // 
            // btnMateriaPrima
            // 
            btnMateriaPrima.Dock = DockStyle.Top;
            btnMateriaPrima.FlatAppearance.BorderSize = 0;
            btnMateriaPrima.FlatStyle = FlatStyle.Flat;
            btnMateriaPrima.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMateriaPrima.ForeColor = Color.Gainsboro;
            btnMateriaPrima.Location = new Point(0, 0);
            btnMateriaPrima.Name = "btnMateriaPrima";
            btnMateriaPrima.Padding = new Padding(30, 0, 0, 0);
            btnMateriaPrima.Size = new Size(233, 40);
            btnMateriaPrima.TabIndex = 0;
            btnMateriaPrima.Text = "Materia Prima";
            btnMateriaPrima.TextAlign = ContentAlignment.MiddleLeft;
            btnMateriaPrima.UseVisualStyleBackColor = true;
            btnMateriaPrima.Click += btnMateriaPrima_Click;
            // 
            // btnMenuAlmacen
            // 
            btnMenuAlmacen.Dock = DockStyle.Top;
            btnMenuAlmacen.FlatAppearance.BorderSize = 0;
            btnMenuAlmacen.FlatStyle = FlatStyle.Flat;
            btnMenuAlmacen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuAlmacen.ForeColor = Color.Gainsboro;
            btnMenuAlmacen.Image = (Image)resources.GetObject("btnMenuAlmacen.Image");
            btnMenuAlmacen.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuAlmacen.Location = new Point(0, 470);
            btnMenuAlmacen.Name = "btnMenuAlmacen";
            btnMenuAlmacen.Size = new Size(233, 60);
            btnMenuAlmacen.TabIndex = 5;
            btnMenuAlmacen.Text = "          Almacen";
            btnMenuAlmacen.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAlmacen.UseVisualStyleBackColor = true;
            btnMenuAlmacen.Click += btnMenuAlmacen_Click;
            // 
            // pMenuCompras
            // 
            pMenuCompras.BackColor = Color.FromArgb(0, 142, 204);
            pMenuCompras.Controls.Add(btnProveedores);
            pMenuCompras.Controls.Add(btnDetalleCompras);
            pMenuCompras.Controls.Add(btnCompras);
            pMenuCompras.Dock = DockStyle.Top;
            pMenuCompras.Location = new Point(0, 345);
            pMenuCompras.Name = "pMenuCompras";
            pMenuCompras.Size = new Size(233, 125);
            pMenuCompras.TabIndex = 4;
            // 
            // btnProveedores
            // 
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedores.ForeColor = Color.Gainsboro;
            btnProveedores.Location = new Point(0, 80);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Padding = new Padding(30, 0, 0, 0);
            btnProveedores.Size = new Size(233, 40);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnDetalleCompras
            // 
            btnDetalleCompras.Dock = DockStyle.Top;
            btnDetalleCompras.FlatAppearance.BorderSize = 0;
            btnDetalleCompras.FlatStyle = FlatStyle.Flat;
            btnDetalleCompras.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetalleCompras.ForeColor = Color.Gainsboro;
            btnDetalleCompras.Location = new Point(0, 40);
            btnDetalleCompras.Name = "btnDetalleCompras";
            btnDetalleCompras.Padding = new Padding(30, 0, 0, 0);
            btnDetalleCompras.Size = new Size(233, 40);
            btnDetalleCompras.TabIndex = 1;
            btnDetalleCompras.Text = "Detalle de Compras";
            btnDetalleCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnDetalleCompras.UseVisualStyleBackColor = true;
            btnDetalleCompras.Click += btnDetalleCompras_Click;
            // 
            // btnCompras
            // 
            btnCompras.Dock = DockStyle.Top;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.Gainsboro;
            btnCompras.Location = new Point(0, 0);
            btnCompras.Name = "btnCompras";
            btnCompras.Padding = new Padding(30, 0, 0, 0);
            btnCompras.Size = new Size(233, 40);
            btnCompras.TabIndex = 0;
            btnCompras.Text = "Compras Registradas";
            btnCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnMenuCompras
            // 
            btnMenuCompras.Dock = DockStyle.Top;
            btnMenuCompras.FlatAppearance.BorderSize = 0;
            btnMenuCompras.FlatStyle = FlatStyle.Flat;
            btnMenuCompras.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuCompras.ForeColor = Color.Gainsboro;
            btnMenuCompras.Image = (Image)resources.GetObject("btnMenuCompras.Image");
            btnMenuCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuCompras.Location = new Point(0, 285);
            btnMenuCompras.Name = "btnMenuCompras";
            btnMenuCompras.Size = new Size(233, 60);
            btnMenuCompras.TabIndex = 3;
            btnMenuCompras.Text = "          Compras";
            btnMenuCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCompras.UseVisualStyleBackColor = true;
            btnMenuCompras.Click += btnMenuCompras_Click;
            // 
            // pMenuVentas
            // 
            pMenuVentas.BackColor = Color.FromArgb(0, 142, 204);
            pMenuVentas.Controls.Add(btnClientes);
            pMenuVentas.Controls.Add(btnDetalleVentas);
            pMenuVentas.Controls.Add(btnVentas);
            pMenuVentas.Dock = DockStyle.Top;
            pMenuVentas.Location = new Point(0, 160);
            pMenuVentas.Name = "pMenuVentas";
            pMenuVentas.Size = new Size(233, 125);
            pMenuVentas.TabIndex = 2;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.Gainsboro;
            btnClientes.Location = new Point(0, 80);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(30, 0, 0, 0);
            btnClientes.Size = new Size(233, 40);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDetalleVentas
            // 
            btnDetalleVentas.Dock = DockStyle.Top;
            btnDetalleVentas.FlatAppearance.BorderSize = 0;
            btnDetalleVentas.FlatStyle = FlatStyle.Flat;
            btnDetalleVentas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetalleVentas.ForeColor = Color.Gainsboro;
            btnDetalleVentas.Location = new Point(0, 40);
            btnDetalleVentas.Name = "btnDetalleVentas";
            btnDetalleVentas.Padding = new Padding(30, 0, 0, 0);
            btnDetalleVentas.Size = new Size(233, 40);
            btnDetalleVentas.TabIndex = 1;
            btnDetalleVentas.Text = "Detalle de Ventas";
            btnDetalleVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnDetalleVentas.UseVisualStyleBackColor = true;
            btnDetalleVentas.Click += btnDetalleVentas_Click;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.Gainsboro;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(0, 0);
            btnVentas.Name = "btnVentas";
            btnVentas.Padding = new Padding(30, 0, 0, 0);
            btnVentas.Size = new Size(233, 40);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas Registradas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnMenuVentas
            // 
            btnMenuVentas.Dock = DockStyle.Top;
            btnMenuVentas.FlatAppearance.BorderSize = 0;
            btnMenuVentas.FlatStyle = FlatStyle.Flat;
            btnMenuVentas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuVentas.ForeColor = Color.Gainsboro;
            btnMenuVentas.Image = (Image)resources.GetObject("btnMenuVentas.Image");
            btnMenuVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuVentas.Location = new Point(0, 100);
            btnMenuVentas.Name = "btnMenuVentas";
            btnMenuVentas.Size = new Size(233, 60);
            btnMenuVentas.TabIndex = 1;
            btnMenuVentas.Text = "          Ventas";
            btnMenuVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuVentas.UseVisualStyleBackColor = true;
            btnMenuVentas.Click += btnMenuVentas_Click;
            // 
            // pLogo
            // 
            pLogo.Controls.Add(lblUser);
            pLogo.Controls.Add(pictureBox1);
            pLogo.Dock = DockStyle.Top;
            pLogo.Location = new Point(0, 0);
            pLogo.Name = "pLogo";
            pLogo.Size = new Size(233, 100);
            pLogo.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(108, 18);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(48, 21);
            lblUser.TabIndex = 1;
            lblUser.Text = "User:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pBarraHerramientas
            // 
            pBarraHerramientas.BackColor = Color.Gainsboro;
            pBarraHerramientas.Controls.Add(btnMinimizar);
            pBarraHerramientas.Controls.Add(btnRestaurar);
            pBarraHerramientas.Controls.Add(btnMaximizar);
            pBarraHerramientas.Controls.Add(btnCerrar);
            pBarraHerramientas.Dock = DockStyle.Top;
            pBarraHerramientas.Location = new Point(250, 0);
            pBarraHerramientas.Name = "pBarraHerramientas";
            pBarraHerramientas.Size = new Size(1010, 39);
            pBarraHerramientas.TabIndex = 2;
            pBarraHerramientas.MouseDown += pBarraHerramientas_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(915, 7);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(946, 7);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 2;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(946, 7);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 1;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(977, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pFormulario
            // 
            pFormulario.BackColor = Color.Gainsboro;
            pFormulario.Controls.Add(pLogoEmpresa);
            pFormulario.Dock = DockStyle.Fill;
            pFormulario.Location = new Point(250, 39);
            pFormulario.Name = "pFormulario";
            pFormulario.Size = new Size(1010, 721);
            pFormulario.TabIndex = 4;
            // 
            // pLogoEmpresa
            // 
            pLogoEmpresa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pLogoEmpresa.Image = (Image)resources.GetObject("pLogoEmpresa.Image");
            pLogoEmpresa.Location = new Point(364, 201);
            pLogoEmpresa.Name = "pLogoEmpresa";
            pLogoEmpresa.Size = new Size(301, 276);
            pLogoEmpresa.SizeMode = PictureBoxSizeMode.Zoom;
            pLogoEmpresa.TabIndex = 0;
            pLogoEmpresa.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 760);
            Controls.Add(pFormulario);
            Controls.Add(pBarraHerramientas);
            Controls.Add(pMenuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            pMenuLateral.ResumeLayout(false);
            pMenuDetallesEmpresa.ResumeLayout(false);
            pMenuAlmacen.ResumeLayout(false);
            pMenuCompras.ResumeLayout(false);
            pMenuVentas.ResumeLayout(false);
            pLogo.ResumeLayout(false);
            pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pBarraHerramientas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            pFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pLogoEmpresa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pMenuLateral;
        private Panel pLogo;
        private Button btnMenuVentas;
        private Panel pMenuVentas;
        private Button btnClientes;
        private Button btnDetalleVentas;
        private Button btnVentas;
        private Panel pMenuCompras;
        private Button btnProveedores;
        private Button btnDetalleCompras;
        private Button btnCompras;
        private Button btnMenuCompras;
        private Panel pMenuAlmacen;
        private Button btnProductos;
        private Button btnMateriaPrima;
        private Button btnMenuAlmacen;
        private Panel pMenuDetallesEmpresa;
        private Button btnSucursal;
        private Button btnMunicipio;
        private Button btnDepartamento;
        private Button btnDetallesEmpresa;
        private PictureBox pictureBox1;
        private Button btnCerrarSesion;
        private Panel pBarraHerramientas;
        private PictureBox btnCerrar;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private Panel pFormulario;
        private PictureBox pLogoEmpresa;
        private Label lblUser;
    }
}