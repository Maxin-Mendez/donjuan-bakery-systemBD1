namespace FormProyecto
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            pContenedor = new Panel();
            btnModificar = new Button();
            btnNuevo = new Button();
            btnCerrar = new PictureBox();
            label8 = new Label();
            dtpFecha = new DateTimePicker();
            label9 = new Label();
            txtIDProveedor = new TextBox();
            label10 = new Label();
            label13 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            txtIDCompra = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtIDMateriaPrima = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvCompras = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(label8);
            pContenedor.Controls.Add(dtpFecha);
            pContenedor.Controls.Add(label9);
            pContenedor.Controls.Add(txtIDProveedor);
            pContenedor.Controls.Add(label10);
            pContenedor.Controls.Add(label13);
            pContenedor.Controls.Add(txtPrecio);
            pContenedor.Controls.Add(label7);
            pContenedor.Controls.Add(txtIDCompra);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtCantidad);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(txtIDMateriaPrima);
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
            btnModificar.Location = new Point(52, 612);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 182;
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
            btnNuevo.Location = new Point(52, 554);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 181;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
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
            btnCerrar.TabIndex = 180;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(78, 443);
            label8.Name = "label8";
            label8.Size = new Size(23, 21);
            label8.TabIndex = 179;
            label8.Text = "(*)";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(26, 465);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(236, 23);
            dtpFecha.TabIndex = 177;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(26, 439);
            label9.Name = "label9";
            label9.Size = new Size(63, 24);
            label9.TabIndex = 178;
            label9.Text = "Fecha:";
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDProveedor.Location = new Point(26, 270);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(236, 23);
            txtIDProveedor.TabIndex = 175;
            txtIDProveedor.TextChanged += txtIDProveedor_TextChanged;
            txtIDProveedor.KeyPress += txtIDProveedor_KeyPress;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(161, 245);
            label10.Name = "label10";
            label10.Size = new Size(23, 21);
            label10.TabIndex = 174;
            label10.Text = "(*)";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(26, 242);
            label13.Name = "label13";
            label13.Size = new Size(143, 24);
            label13.TabIndex = 173;
            label13.Text = "ID de Proveedor:";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecio.Location = new Point(26, 398);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(236, 23);
            txtPrecio.TabIndex = 169;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(187, 177);
            label7.Name = "label7";
            label7.Size = new Size(23, 21);
            label7.TabIndex = 168;
            label7.Text = "(*)";
            // 
            // txtIDCompra
            // 
            txtIDCompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDCompra.Location = new Point(26, 134);
            txtIDCompra.Name = "txtIDCompra";
            txtIDCompra.Size = new Size(236, 23);
            txtIDCompra.TabIndex = 166;
            txtIDCompra.TextChanged += txtIDCompra_TextChanged;
            txtIDCompra.KeyPress += txtIDCompra_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(85, 374);
            label5.Name = "label5";
            label5.Size = new Size(23, 21);
            label5.TabIndex = 165;
            label5.Text = "(*)";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 107);
            label6.Name = "label6";
            label6.Size = new Size(123, 24);
            label6.TabIndex = 164;
            label6.Text = "ID de Compra:";
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidad.Location = new Point(26, 333);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(236, 23);
            txtCantidad.TabIndex = 163;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(107, 306);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 162;
            label3.Text = "(*)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 306);
            label4.Name = "label4";
            label4.Size = new Size(89, 24);
            label4.TabIndex = 161;
            label4.Text = "Cantidad:";
            // 
            // txtIDMateriaPrima
            // 
            txtIDMateriaPrima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDMateriaPrima.Location = new Point(26, 201);
            txtIDMateriaPrima.Name = "txtIDMateriaPrima";
            txtIDMateriaPrima.Size = new Size(236, 23);
            txtIDMateriaPrima.TabIndex = 160;
            txtIDMateriaPrima.TextChanged += txtIDMateriaPrima_TextChanged;
            txtIDMateriaPrima.KeyPress += txtIDMateriaPrima_KeyPress;
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
            label2.Location = new Point(26, 174);
            label2.Name = "label2";
            label2.Size = new Size(171, 24);
            label2.TabIndex = 158;
            label2.Text = "ID de Materia Prima:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-2, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(146, 110);
            label11.Name = "label11";
            label11.Size = new Size(23, 21);
            label11.TabIndex = 157;
            label11.Text = "(*)";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(26, 370);
            label12.Name = "label12";
            label12.Size = new Size(66, 24);
            label12.TabIndex = 156;
            label12.Text = "Precio:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(0, 122, 204);
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(38, 16);
            label14.Name = "label14";
            label14.Size = new Size(212, 62);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LAS COMPRAS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(154, 65);
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
            lblTitulo.Location = new Point(392, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(238, 28);
            lblTitulo.TabIndex = 166;
            lblTitulo.Text = "COMPRAS REGISTRADAS";
            // 
            // dgvCompras
            // 
            dgvCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCompras.BackgroundColor = Color.WhiteSmoke;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Location = new Point(21, 114);
            dgvCompras.MultiSelect = false;
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCompras.RowTemplate.Height = 25;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(934, 634);
            dgvCompras.TabIndex = 165;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvCompras);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "Compras";
            Load += Compras_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private TextBox txtIDProveedor;
        private Label label10;
        private Label label13;
        private TextBox txtPrecio;
        private Label label7;
        private TextBox txtIDCompra;
        private Label label5;
        private Label label6;
        private TextBox txtCantidad;
        private Label label3;
        private Label label4;
        private TextBox txtIDMateriaPrima;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label8;
        private DateTimePicker dtpFecha;
        private Label label9;
        private PictureBox btnCerrar;
        private Button btnModificar;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvCompras;
        private ErrorProvider erpError;
    }
}