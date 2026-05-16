namespace FormProyecto
{
    partial class Sucursal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursal));
            pContenedor = new Panel();
            btnCerrar = new PictureBox();
            btnDarBaja = new Button();
            label15 = new Label();
            label13 = new Label();
            txtEstadoSucursal = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtIDMunicipio = new TextBox();
            label8 = new Label();
            btnModificar = new Button();
            txtDireccion = new TextBox();
            label9 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            label2 = new Label();
            btnNuevo = new Button();
            txtNombreSucursal = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvSucursales = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(btnDarBaja);
            pContenedor.Controls.Add(label15);
            pContenedor.Controls.Add(label13);
            pContenedor.Controls.Add(txtEstadoSucursal);
            pContenedor.Controls.Add(label12);
            pContenedor.Controls.Add(label10);
            pContenedor.Controls.Add(label7);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtIDMunicipio);
            pContenedor.Controls.Add(label8);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(txtDireccion);
            pContenedor.Controls.Add(label9);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(txtTelefono);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(txtNombreSucursal);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label11);
            pContenedor.Controls.Add(label14);
            pContenedor.Dock = DockStyle.Right;
            pContenedor.Location = new Point(974, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(286, 760);
            pContenedor.TabIndex = 150;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(258, 8);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 201;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Anchor = AnchorStyles.Right;
            btnDarBaja.BackColor = Color.FromArgb(0, 122, 204);
            btnDarBaja.FlatAppearance.BorderSize = 0;
            btnDarBaja.FlatStyle = FlatStyle.Flat;
            btnDarBaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDarBaja.ForeColor = Color.Gainsboro;
            btnDarBaja.Image = (Image)resources.GetObject("btnDarBaja.Image");
            btnDarBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnDarBaja.Location = new Point(53, 603);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(177, 52);
            btnDarBaja.TabIndex = 200;
            btnDarBaja.Text = "          Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(194, 406);
            label15.Name = "label15";
            label15.Size = new Size(23, 21);
            label15.TabIndex = 199;
            label15.Text = "(*)";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(162, 335);
            label13.Name = "label13";
            label13.Size = new Size(23, 21);
            label13.TabIndex = 198;
            label13.Text = "(*)";
            // 
            // txtEstadoSucursal
            // 
            txtEstadoSucursal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEstadoSucursal.Location = new Point(26, 430);
            txtEstadoSucursal.Name = "txtEstadoSucursal";
            txtEstadoSucursal.Size = new Size(236, 23);
            txtEstadoSucursal.TabIndex = 197;
            txtEstadoSucursal.TextChanged += txtEstadoSucursal_TextChanged;
            txtEstadoSucursal.KeyPress += txtEstadoSucursal_KeyPress;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(26, 402);
            label12.Name = "label12";
            label12.Size = new Size(175, 24);
            label12.TabIndex = 196;
            label12.Text = "Estado de la Sucursal:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(102, 198);
            label10.Name = "label10";
            label10.Size = new Size(23, 21);
            label10.TabIndex = 197;
            label10.Text = "(*)";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(111, 267);
            label7.Name = "label7";
            label7.Size = new Size(23, 21);
            label7.TabIndex = 196;
            label7.Text = "(*)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(207, 131);
            label6.Name = "label6";
            label6.Size = new Size(23, 21);
            label6.TabIndex = 191;
            label6.Text = "(*)";
            // 
            // txtIDMunicipio
            // 
            txtIDMunicipio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDMunicipio.Location = new Point(26, 360);
            txtIDMunicipio.Name = "txtIDMunicipio";
            txtIDMunicipio.Size = new Size(236, 23);
            txtIDMunicipio.TabIndex = 195;
            txtIDMunicipio.TextChanged += txtIDMunicipio_TextChanged;
            txtIDMunicipio.KeyPress += txtIDMunicipio_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 332);
            label8.Name = "label8";
            label8.Size = new Size(142, 24);
            label8.TabIndex = 194;
            label8.Text = "ID del Municipio:";
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Right;
            btnModificar.BackColor = Color.FromArgb(0, 122, 204);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Gainsboro;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(59, 545);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 190;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDireccion.Location = new Point(26, 292);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(236, 23);
            txtDireccion.TabIndex = 193;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(26, 264);
            label9.Name = "label9";
            label9.Size = new Size(90, 24);
            label9.TabIndex = 192;
            label9.Text = "Direccion:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(288, 192);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 188;
            label3.Text = "(*)";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.Location = new Point(26, 223);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 23);
            txtTelefono.TabIndex = 187;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 195);
            label5.Name = "label5";
            label5.Size = new Size(83, 24);
            label5.TabIndex = 186;
            label5.Text = "Telefono:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(297, 124);
            label2.Name = "label2";
            label2.Size = new Size(23, 21);
            label2.TabIndex = 185;
            label2.Text = "(*)";
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(0, 122, 204);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.Gainsboro;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(59, 487);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 184;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombreSucursal
            // 
            txtNombreSucursal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombreSucursal.Location = new Point(26, 155);
            txtNombreSucursal.Name = "txtNombreSucursal";
            txtNombreSucursal.Size = new Size(236, 23);
            txtNombreSucursal.TabIndex = 166;
            txtNombreSucursal.TextChanged += txtNombreSucursal_TextChanged;
            txtNombreSucursal.KeyPress += txtNombreSucursal_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 127);
            label4.Name = "label4";
            label4.Size = new Size(189, 24);
            label4.TabIndex = 161;
            label4.Text = "Nombre de la Sucursal:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(540, 170);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 159;
            label1.Text = "(*)";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-4, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(417, 126);
            label11.Name = "label11";
            label11.Size = new Size(23, 21);
            label11.TabIndex = 157;
            label11.Text = "(*)";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(0, 122, 204);
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(45, 17);
            label14.Name = "label14";
            label14.Size = new Size(201, 60);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LAS SUCURSALES";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(156, 77);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(668, 29);
            txtBuscar.TabIndex = 176;
            txtBuscar.Text = "Buscar...";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(441, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 28);
            lblTitulo.TabIndex = 175;
            lblTitulo.Text = "SUCURSALES";
            // 
            // dgvSucursales
            // 
            dgvSucursales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSucursales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSucursales.BackgroundColor = Color.WhiteSmoke;
            dgvSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursales.Location = new Point(31, 126);
            dgvSucursales.MultiSelect = false;
            dgvSucursales.Name = "dgvSucursales";
            dgvSucursales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvSucursales.RowTemplate.Height = 25;
            dgvSucursales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursales.Size = new Size(918, 607);
            dgvSucursales.TabIndex = 174;
            dgvSucursales.CellClick += dgvSucursales_CellClick;
            dgvSucursales.CellDoubleClick += dgvSucursales_CellDoubleClick;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Sucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvSucursales);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sucursal";
            Text = "Sucursal";
            Load += Sucursal_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSucursales).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private Button btnModificar;
        private Label label3;
        private TextBox txtTelefono;
        private Label label5;
        private Label label2;
        private Button btnNuevo;
        private TextBox txtNombreSucursal;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private Label label14;
        private Label label10;
        private Label label7;
        private Label label6;
        private TextBox txtIDMunicipio;
        private Label label8;
        private TextBox txtDireccion;
        private Label label9;
        private Label label13;
        private TextBox txtEstadoSucursal;
        private Label label12;
        private Label label15;
        private Button btnDarBaja;
        private PictureBox btnCerrar;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvSucursales;
        private ErrorProvider erpError;
    }
}