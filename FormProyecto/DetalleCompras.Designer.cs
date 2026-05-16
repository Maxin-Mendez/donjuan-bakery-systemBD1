namespace FormProyecto
{
    partial class DetalleCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleCompras));
            pContenedor = new Panel();
            btnCerrar = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvDetalleCompras = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label14);
            pContenedor.Dock = DockStyle.Right;
            pContenedor.Location = new Point(974, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(286, 760);
            pContenedor.TabIndex = 147;
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
            btnCerrar.TabIndex = 185;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(-3, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 153;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.BackColor = Color.FromArgb(0, 122, 204);
            label14.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(61, 9);
            label14.Name = "label14";
            label14.Size = new Size(179, 58);
            label14.TabIndex = 154;
            label14.Text = "DATOS DETALLES DE COMPRAS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(156, 60);
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
            lblTitulo.Location = new Point(387, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(229, 28);
            lblTitulo.TabIndex = 166;
            lblTitulo.Text = "DETALLES DE COMPRAS";
            // 
            // dgvDetalleCompras
            // 
            dgvDetalleCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalleCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleCompras.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetalleCompras.BackgroundColor = Color.WhiteSmoke;
            dgvDetalleCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompras.Location = new Point(31, 109);
            dgvDetalleCompras.MultiSelect = false;
            dgvDetalleCompras.Name = "dgvDetalleCompras";
            dgvDetalleCompras.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvDetalleCompras.RowTemplate.Height = 25;
            dgvDetalleCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleCompras.Size = new Size(918, 625);
            dgvDetalleCompras.TabIndex = 165;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // DetalleCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvDetalleCompras);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleCompras";
            Text = "DetalleCompras";
            Load += DetalleCompras_Load;
            pContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private Label label1;
        private Panel panel1;
        private Label label14;
        private PictureBox btnCerrar;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvDetalleCompras;
        private ErrorProvider erpError;
    }
}