namespace FormProyecto
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            dgvVentas = new DataGridView();
            lblTitulo = new Label();
            btnNuevo = new Button();
            pContenedor = new Panel();
            btnModificar = new Button();
            txtIDCliente = new TextBox();
            label6 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCodProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            btnCerrar = new PictureBox();
            label14 = new Label();
            txtBuscar = new TextBox();
            erpError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVentas.BackgroundColor = Color.WhiteSmoke;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(27, 131);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVentas.RowTemplate.Height = 25;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(918, 607);
            dgvVentas.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(370, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(217, 28);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "VENTAS REGISTRADAS";
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
            btnNuevo.Location = new Point(61, 343);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(txtIDCliente);
            pContenedor.Controls.Add(label6);
            pContenedor.Controls.Add(txtCantidad);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(txtCodProducto);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label11);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(label14);
            pContenedor.Dock = DockStyle.Right;
            pContenedor.Location = new Point(974, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(286, 760);
            pContenedor.TabIndex = 146;
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
            btnModificar.Location = new Point(61, 419);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 167;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDCliente.Location = new Point(28, 131);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(236, 23);
            txtIDCliente.TabIndex = 166;
            txtIDCliente.TextChanged += txtIDCliente_TextChanged;
            txtIDCliente.KeyPress += txtIDCliente_KeyPress;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 103);
            label6.Name = "label6";
            label6.Size = new Size(121, 24);
            label6.TabIndex = 164;
            label6.Text = "ID del Cliente:";
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantidad.Location = new Point(28, 269);
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
            label3.Location = new Point(110, 242);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 162;
            label3.Text = "(*)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 242);
            label4.Name = "label4";
            label4.Size = new Size(88, 24);
            label4.TabIndex = 161;
            label4.Text = "Cantidad:";
            // 
            // txtCodProducto
            // 
            txtCodProducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCodProducto.Location = new Point(28, 197);
            txtCodProducto.Name = "txtCodProducto";
            txtCodProducto.Size = new Size(236, 23);
            txtCodProducto.TabIndex = 160;
            txtCodProducto.TextChanged += txtCodProducto_TextChanged;
            txtCodProducto.KeyPress += txtCodProducto_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(196, 170);
            label1.Name = "label1";
            label1.Size = new Size(23, 21);
            label1.TabIndex = 159;
            label1.Text = "(*)";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 170);
            label2.Name = "label2";
            label2.Size = new Size(171, 24);
            label2.TabIndex = 158;
            label2.Text = "Codigo del Producto:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(146, 107);
            label11.Name = "label11";
            label11.Size = new Size(23, 21);
            label11.TabIndex = 157;
            label11.Text = "(*)";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(256, 9);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 152;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(0, 122, 204);
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(40, 30);
            label14.Name = "label14";
            label14.Size = new Size(212, 30);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LA VENTAS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(152, 82);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(668, 29);
            txtBuscar.TabIndex = 161;
            txtBuscar.Text = "Buscar...";
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(pContenedor);
            Controls.Add(lblTitulo);
            Controls.Add(dgvVentas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVentas;
        private Label lblTitulo;
        private Button btnNuevo;
        private Panel pContenedor;
        private Panel panel1;
        private Label label11;
        private PictureBox btnCerrar;
        private Label label14;
        private TextBox txtCodProducto;
        private Label label1;
        private Label label2;
        private Button btnModificar;
        private TextBox txtIDCliente;
        private Label label6;
        private TextBox txtCantidad;
        private Label label3;
        private Label label4;
        private TextBox txtBuscar;
        private ErrorProvider erpError;
    }
}