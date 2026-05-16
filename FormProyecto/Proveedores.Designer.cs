namespace FormProyecto
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            pContenedor = new Panel();
            btnCerrar = new PictureBox();
            btnDarBaja = new Button();
            btnModificar = new Button();
            btnNuevo = new Button();
            txtIDMunicipio = new TextBox();
            label10 = new Label();
            label13 = new Label();
            txrRUC = new TextBox();
            label7 = new Label();
            txtNombreProveedor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDireccionProveedor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvProveedores = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(btnDarBaja);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(txtIDMunicipio);
            pContenedor.Controls.Add(label10);
            pContenedor.Controls.Add(label13);
            pContenedor.Controls.Add(txrRUC);
            pContenedor.Controls.Add(label7);
            pContenedor.Controls.Add(txtNombreProveedor);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtTelefono);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(txtDireccionProveedor);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label11);
            pContenedor.Controls.Add(label12);
            pContenedor.Controls.Add(label14);
            pContenedor.Dock = DockStyle.Right;
            pContenedor.Location = new Point(974, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(286, 760);
            pContenedor.TabIndex = 148;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(257, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 171;
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
            btnDarBaja.Location = new Point(65, 594);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(177, 52);
            btnDarBaja.TabIndex = 179;
            btnDarBaja.Text = "          Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
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
            btnModificar.Location = new Point(65, 536);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 178;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            btnNuevo.Location = new Point(65, 478);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 177;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtIDMunicipio
            // 
            txtIDMunicipio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDMunicipio.Location = new Point(27, 420);
            txtIDMunicipio.Name = "txtIDMunicipio";
            txtIDMunicipio.Size = new Size(236, 23);
            txtIDMunicipio.TabIndex = 175;
            txtIDMunicipio.TextChanged += txtIDMunicipio_TextChanged;
            txtIDMunicipio.KeyPress += txtIDMunicipio_KeyPress;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(166, 395);
            label10.Name = "label10";
            label10.Size = new Size(23, 21);
            label10.TabIndex = 174;
            label10.Text = "(*)";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(27, 392);
            label13.Name = "label13";
            label13.Size = new Size(144, 24);
            label13.TabIndex = 173;
            label13.Text = "ID del Municipio:";
            // 
            // txrRUC
            // 
            txrRUC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txrRUC.Location = new Point(27, 342);
            txrRUC.Name = "txrRUC";
            txrRUC.Size = new Size(236, 23);
            txrRUC.TabIndex = 169;
            txrRUC.TextChanged += txrRUC_TextChanged;
            txrRUC.KeyPress += txrRUC_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(224, 178);
            label7.Name = "label7";
            label7.Size = new Size(23, 21);
            label7.TabIndex = 168;
            label7.Text = "(*)";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombreProveedor.Location = new Point(27, 136);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(236, 23);
            txtNombreProveedor.TabIndex = 166;
            txtNombreProveedor.TextChanged += txtNombreProveedor_TextChanged;
            txtNombreProveedor.KeyPress += txtNombreProveedor_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(75, 314);
            label5.Name = "label5";
            label5.Size = new Size(23, 21);
            label5.TabIndex = 165;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 108);
            label6.Name = "label6";
            label6.Size = new Size(189, 24);
            label6.TabIndex = 164;
            label6.Text = "Nombre del Proveedor:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTelefono.Location = new Point(27, 274);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(236, 23);
            txtTelefono.TabIndex = 163;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(102, 250);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 162;
            label3.Text = "(*)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 247);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 161;
            label4.Text = "Telefono:";
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDireccionProveedor.Location = new Point(27, 202);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(236, 23);
            txtDireccionProveedor.TabIndex = 160;
            txtDireccionProveedor.TextChanged += txtDireccionProveedor_TextChanged;
            txtDireccionProveedor.KeyPress += txtDireccionProveedor_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(368, 170);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 159;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 175);
            label2.Name = "label2";
            label2.Size = new Size(209, 24);
            label2.TabIndex = 158;
            label2.Text = "Direccion del Proveedor:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-1, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(213, 111);
            label11.Name = "label11";
            label11.Size = new Size(23, 21);
            label11.TabIndex = 157;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(27, 314);
            label12.Name = "label12";
            label12.Size = new Size(177, 24);
            label12.TabIndex = 156;
            label12.Text = "RUC:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(0, 122, 204);
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(39, 17);
            label14.Name = "label14";
            label14.Size = new Size(212, 62);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LOS PROVEEDORES";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(154, 81);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(668, 29);
            txtBuscar.TabIndex = 170;
            txtBuscar.Text = "Buscar...";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(426, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(146, 28);
            lblTitulo.TabIndex = 169;
            lblTitulo.Text = "PROVEEDORES";
            // 
            // dgvProveedores
            // 
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.BackgroundColor = Color.WhiteSmoke;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(29, 130);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProveedores.RowTemplate.Height = 25;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(918, 607);
            dgvProveedores.TabIndex = 168;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            dgvProveedores.CellDoubleClick += dgvProveedores_CellDoubleClick;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProveedores);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private TextBox txtIDMunicipio;
        private Label label10;
        private Label label13;
        private TextBox txrRUC;
        private Label label7;
        private TextBox txtNombreProveedor;
        private Label label5;
        private Label label6;
        private TextBox txtTelefono;
        private Label label3;
        private Label label4;
        private TextBox txtDireccionProveedor;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label11;
        private Label label12;
        private Label label14;
        private Button btnDarBaja;
        private Button btnModificar;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvProveedores;
        private PictureBox btnCerrar;
        private ErrorProvider erpError;
    }
}