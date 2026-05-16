namespace FormProyecto
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            pContenedor = new Panel();
            btnProductos = new PictureBox();
            btnDarBaja = new Button();
            btnNuevo = new Button();
            txtExistencias = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtDescP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnModificar = new Button();
            txtName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvProductos = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnProductos);
            pContenedor.Controls.Add(btnDarBaja);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(txtExistencias);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtPrecio);
            pContenedor.Controls.Add(label7);
            pContenedor.Controls.Add(label8);
            pContenedor.Controls.Add(txtDescP);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(txtName);
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
            // btnProductos
            // 
            btnProductos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(257, 9);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(20, 20);
            btnProductos.SizeMode = PictureBoxSizeMode.Zoom;
            btnProductos.TabIndex = 184;
            btnProductos.TabStop = false;
            btnProductos.Click += btnProductos_Click;
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
            btnDarBaja.Location = new Point(74, 552);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(177, 52);
            btnDarBaja.TabIndex = 186;
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
            btnNuevo.Location = new Point(74, 436);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 185;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtExistencias
            // 
            txtExistencias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtExistencias.Location = new Point(32, 349);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(236, 23);
            txtExistencias.TabIndex = 178;
            txtExistencias.TextChanged += txtExistencias_TextChanged;
            txtExistencias.KeyPress += txtExistencias_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 321);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 177;
            label5.Text = "Existencia:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(119, 325);
            label6.Name = "label6";
            label6.Size = new Size(23, 21);
            label6.TabIndex = 176;
            label6.Text = "(*)";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecio.Location = new Point(32, 283);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(236, 23);
            txtPrecio.TabIndex = 175;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 255);
            label7.Name = "label7";
            label7.Size = new Size(65, 24);
            label7.TabIndex = 174;
            label7.Text = "Precio:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(93, 259);
            label8.Name = "label8";
            label8.Size = new Size(23, 21);
            label8.TabIndex = 173;
            label8.Text = "(*)";
            // 
            // txtDescP
            // 
            txtDescP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescP.Location = new Point(32, 215);
            txtDescP.Name = "txtDescP";
            txtDescP.Size = new Size(236, 23);
            txtDescP.TabIndex = 172;
            txtDescP.TextChanged += txtDescP_TextChanged;
            txtDescP.KeyPress += txtDescP_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 187);
            label2.Name = "label2";
            label2.Size = new Size(206, 24);
            label2.TabIndex = 171;
            label2.Text = "Descripcion del Producto:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(235, 191);
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
            btnModificar.Location = new Point(74, 494);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 168;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtName.Location = new Point(32, 150);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 23);
            txtName.TabIndex = 166;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtName_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 122);
            label4.Name = "label4";
            label4.Size = new Size(180, 24);
            label4.TabIndex = 161;
            label4.Text = "Nombre del Producto:";
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
            panel1.Location = new Point(2, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(209, 126);
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
            label14.Location = new Point(46, 20);
            label14.Name = "label14";
            label14.Size = new Size(201, 60);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LOS PRODUCTOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(155, 73);
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
            lblTitulo.Location = new Point(440, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(127, 28);
            lblTitulo.TabIndex = 166;
            lblTitulo.Text = "PRODUCTOS";
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.BackgroundColor = Color.WhiteSmoke;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(30, 122);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(918, 607);
            dgvProductos.TabIndex = 165;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Inventario";
            Load += Productos_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private TextBox txtExistencias;
        private Label label5;
        private Label label6;
        private TextBox txtPrecio;
        private Label label7;
        private Label label8;
        private TextBox txtDescP;
        private Label label2;
        private Label label3;
        private Button btnModificar;
        private TextBox txtName;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private Label label14;
        private PictureBox btnProductos;
        private Button btnDarBaja;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvProductos;
        private ErrorProvider erpError;
    }
}