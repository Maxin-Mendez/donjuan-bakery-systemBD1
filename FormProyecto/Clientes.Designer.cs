namespace FormProyecto
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            pContenedor = new Panel();
            btnDarBaja = new Button();
            btnCerrar = new PictureBox();
            txtIDMunicipio = new TextBox();
            label10 = new Label();
            label13 = new Label();
            txtDireccion = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtSegundoApellido = new TextBox();
            label7 = new Label();
            btnModificar = new Button();
            txtPrimerNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtPrimerApellido = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtSegundoNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            btnNuevo = new Button();
            label12 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvClientes = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnDarBaja);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(txtIDMunicipio);
            pContenedor.Controls.Add(label10);
            pContenedor.Controls.Add(label13);
            pContenedor.Controls.Add(txtDireccion);
            pContenedor.Controls.Add(label8);
            pContenedor.Controls.Add(label9);
            pContenedor.Controls.Add(txtSegundoApellido);
            pContenedor.Controls.Add(label7);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(txtPrimerNombre);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtPrimerApellido);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(txtSegundoNombre);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label11);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(label12);
            pContenedor.Controls.Add(label14);
            pContenedor.Dock = DockStyle.Right;
            pContenedor.Location = new Point(974, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(286, 760);
            pContenedor.TabIndex = 147;
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
            btnDarBaja.Location = new Point(62, 673);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(177, 52);
            btnDarBaja.TabIndex = 176;
            btnDarBaja.Text = "          Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
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
            btnCerrar.TabIndex = 153;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtIDMunicipio
            // 
            txtIDMunicipio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDMunicipio.Location = new Point(27, 494);
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
            label10.Location = new Point(166, 469);
            label10.Name = "label10";
            label10.Size = new Size(23, 21);
            label10.TabIndex = 174;
            label10.Text = "(*)";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(27, 466);
            label13.Name = "label13";
            label13.Size = new Size(144, 24);
            label13.TabIndex = 173;
            label13.Text = "ID del Municipio:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDireccion.Location = new Point(27, 416);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(236, 23);
            txtDireccion.TabIndex = 172;
            txtDireccion.TextChanged += txtDireccion_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(112, 391);
            label8.Name = "label8";
            label8.Size = new Size(23, 21);
            label8.TabIndex = 171;
            label8.Text = "(*)";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(27, 388);
            label9.Name = "label9";
            label9.Size = new Size(89, 24);
            label9.TabIndex = 170;
            label9.Text = "Direccion:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSegundoApellido.Location = new Point(27, 339);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(236, 23);
            txtSegundoApellido.TabIndex = 169;
            txtSegundoApellido.KeyPress += txtSegundoApellido_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(176, 175);
            label7.Name = "label7";
            label7.Size = new Size(23, 21);
            label7.TabIndex = 168;
            label7.Text = "(*)";
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
            btnModificar.Location = new Point(62, 615);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 167;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrimerNombre.Location = new Point(27, 133);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(236, 23);
            txtPrimerNombre.TabIndex = 166;
            txtPrimerNombre.TextChanged += txtPrimerNombre_TextChanged;
            txtPrimerNombre.KeyPress += txtPrimerNombre_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(175, 314);
            label5.Name = "label5";
            label5.Size = new Size(23, 21);
            label5.TabIndex = 165;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(27, 105);
            label6.Name = "label6";
            label6.Size = new Size(133, 24);
            label6.TabIndex = 164;
            label6.Text = "Primer Nombre:";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrimerApellido.Location = new Point(27, 271);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(236, 23);
            txtPrimerApellido.TabIndex = 163;
            txtPrimerApellido.TextChanged += txtPrimerApellido_TextChanged;
            txtPrimerApellido.KeyPress += txtPrimerApellido_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(156, 244);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 162;
            label3.Text = "(*)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 244);
            label4.Name = "label4";
            label4.Size = new Size(144, 24);
            label4.TabIndex = 161;
            label4.Text = "Primer Apellido:";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSegundoNombre.Location = new Point(27, 199);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(236, 23);
            txtSegundoNombre.TabIndex = 160;
            txtSegundoNombre.KeyPress += txtSegundoNombre_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(282, 170);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 159;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 172);
            label2.Name = "label2";
            label2.Size = new Size(171, 24);
            label2.TabIndex = 158;
            label2.Text = "Segundo Nombre:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-1, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(156, 108);
            label11.Name = "label11";
            label11.Size = new Size(23, 21);
            label11.TabIndex = 157;
            label11.Text = "(*)";
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
            btnNuevo.Location = new Point(62, 557);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(27, 311);
            label12.Name = "label12";
            label12.Size = new Size(152, 24);
            label12.TabIndex = 156;
            label12.Text = "Segundo Apellido:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(0, 122, 204);
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(39, 14);
            label14.Name = "label14";
            label14.Size = new Size(212, 62);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LOS CLIENTES";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(159, 69);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(668, 29);
            txtBuscar.TabIndex = 167;
            txtBuscar.Text = "Buscar...";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(448, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(97, 28);
            lblTitulo.TabIndex = 166;
            lblTitulo.Text = "CLIENTES";
            // 
            // dgvClientes
            // 
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClientes.BackgroundColor = Color.WhiteSmoke;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(34, 118);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(918, 607);
            dgvClientes.TabIndex = 165;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvClientes);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private Button btnModificar;
        private TextBox txtPrimerNombre;
        private Label label5;
        private Label label6;
        private TextBox txtPrimerApellido;
        private Label label3;
        private Label label4;
        private TextBox txtSegundoNombre;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label11;
        private Button btnNuevo;
        private Label label12;
        private Label label14;
        private Label label7;
        private TextBox txtSegundoApellido;
        private TextBox txtIDMunicipio;
        private Label label10;
        private Label label13;
        private TextBox txtDireccion;
        private Label label8;
        private Label label9;
        private PictureBox btnCerrar;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvClientes;
        private Button btnDarBaja;
        private ErrorProvider erpError;
    }
}