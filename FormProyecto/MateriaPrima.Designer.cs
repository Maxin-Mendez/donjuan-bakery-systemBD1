namespace FormProyecto
{
    partial class MateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaPrima));
            pContenedor = new Panel();
            btnCerrar = new PictureBox();
            btnDarBaja = new Button();
            btnNuevo = new Button();
            txtIDProveedor = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtCantidad = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnModificar = new Button();
            txtNombreMateriaP = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvMateriaPrima = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriaPrima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(btnDarBaja);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(txtIDProveedor);
            pContenedor.Controls.Add(label9);
            pContenedor.Controls.Add(label10);
            pContenedor.Controls.Add(txtEstado);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtCantidad);
            pContenedor.Controls.Add(label7);
            pContenedor.Controls.Add(label8);
            pContenedor.Controls.Add(txtDescripcion);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(txtNombreMateriaP);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label11);
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
            btnCerrar.TabIndex = 174;
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
            btnDarBaja.Location = new Point(65, 601);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(177, 52);
            btnDarBaja.TabIndex = 183;
            btnDarBaja.Text = "          Dar de Baja";
            btnDarBaja.UseVisualStyleBackColor = false;
            btnDarBaja.Click += btnDarBaja_Click;
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
            btnNuevo.Location = new Point(65, 485);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 182;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDProveedor.Location = new Point(27, 426);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(236, 23);
            txtIDProveedor.TabIndex = 181;
            txtIDProveedor.TextChanged += txtIDProveedor_TextChanged;
            txtIDProveedor.KeyPress += txtIDProveedor_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(27, 398);
            label9.Name = "label9";
            label9.Size = new Size(145, 24);
            label9.TabIndex = 180;
            label9.Text = "ID del Proveedor:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(169, 402);
            label10.Name = "label10";
            label10.Size = new Size(23, 21);
            label10.TabIndex = 179;
            label10.Text = "(*)";
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEstado.Location = new Point(27, 360);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(236, 23);
            txtEstado.TabIndex = 178;
            txtEstado.TextChanged += txtEstado_TextChanged;
            txtEstado.KeyPress += txtEstado_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 332);
            label5.Name = "label5";
            label5.Size = new Size(218, 24);
            label5.TabIndex = 177;
            label5.Text = "Estado de la Materia Prima:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(241, 336);
            label6.Name = "label6";
            label6.Size = new Size(23, 21);
            label6.TabIndex = 176;
            label6.Text = "(*)";
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidad.Location = new Point(27, 291);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(236, 23);
            txtCantidad.TabIndex = 175;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(27, 263);
            label7.Name = "label7";
            label7.Size = new Size(88, 24);
            label7.TabIndex = 174;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(111, 267);
            label8.Name = "label8";
            label8.Size = new Size(23, 21);
            label8.TabIndex = 173;
            label8.Text = "(*)";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescripcion.Location = new Point(27, 219);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(236, 23);
            txtDescripcion.TabIndex = 172;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            txtDescripcion.KeyPress += txtDescripcion_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 191);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 171;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(132, 195);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 170;
            label3.Text = "(*)";
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
            btnModificar.Location = new Point(65, 543);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 168;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNombreMateriaP
            // 
            txtNombreMateriaP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombreMateriaP.Location = new Point(27, 150);
            txtNombreMateriaP.Name = "txtNombreMateriaP";
            txtNombreMateriaP.Size = new Size(236, 23);
            txtNombreMateriaP.TabIndex = 166;
            txtNombreMateriaP.TextChanged += txtNombreMateriaP_TextChanged;
            txtNombreMateriaP.KeyPress += txtNombreMateriaP_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 122);
            label4.Name = "label4";
            label4.Size = new Size(215, 24);
            label4.TabIndex = 161;
            label4.Text = "Nombre de Materia Prima:";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-3, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(237, 126);
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
            label14.Location = new Point(41, 20);
            label14.Name = "label14";
            label14.Size = new Size(191, 60);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LA MATERIA PRIMA";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(156, 73);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(668, 29);
            txtBuscar.TabIndex = 173;
            txtBuscar.Text = "Buscar...";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(428, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 28);
            lblTitulo.TabIndex = 172;
            lblTitulo.Text = "MATERIA PRIMA";
            // 
            // dgvMateriaPrima
            // 
            dgvMateriaPrima.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMateriaPrima.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMateriaPrima.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMateriaPrima.BackgroundColor = Color.WhiteSmoke;
            dgvMateriaPrima.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriaPrima.Location = new Point(31, 122);
            dgvMateriaPrima.Name = "dgvMateriaPrima";
            dgvMateriaPrima.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMateriaPrima.RowTemplate.Height = 25;
            dgvMateriaPrima.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMateriaPrima.Size = new Size(918, 607);
            dgvMateriaPrima.TabIndex = 171;
            dgvMateriaPrima.CellClick += dgvMateriaPrima_CellClick;
            dgvMateriaPrima.CellDoubleClick += dgvMateriaPrima_CellDoubleClick;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // MateriaPrima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvMateriaPrima);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MateriaPrima";
            Text = "MateriaPrima";
            Load += MateriaPrima_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriaPrima).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private Button btnModificar;
        private TextBox txtNombreMateriaP;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private Label label14;
        private TextBox txtEstado;
        private Label label5;
        private Label label6;
        private TextBox txtCantidad;
        private Label label7;
        private Label label8;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private TextBox txtIDProveedor;
        private Label label9;
        private Label label10;
        private Button btnDarBaja;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvMateriaPrima;
        private PictureBox btnCerrar;
        private ErrorProvider erpError;
    }
}