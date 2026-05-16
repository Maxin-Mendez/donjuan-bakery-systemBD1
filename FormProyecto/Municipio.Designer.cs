namespace FormProyecto
{
    partial class Municipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Municipio));
            pContenedor = new Panel();
            btnModificar = new Button();
            btnCerrar = new PictureBox();
            label3 = new Label();
            txtIDDepartamento = new TextBox();
            label5 = new Label();
            label2 = new Label();
            btnNuevo = new Button();
            txtNombreMunicipio = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label14 = new Label();
            txtBuscar = new TextBox();
            lblTitulo = new Label();
            dgvMunicipios = new DataGridView();
            erpError = new ErrorProvider(components);
            pContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // pContenedor
            // 
            pContenedor.BackColor = Color.FromArgb(0, 122, 204);
            pContenedor.Controls.Add(btnModificar);
            pContenedor.Controls.Add(btnCerrar);
            pContenedor.Controls.Add(label3);
            pContenedor.Controls.Add(txtIDDepartamento);
            pContenedor.Controls.Add(label5);
            pContenedor.Controls.Add(label2);
            pContenedor.Controls.Add(btnNuevo);
            pContenedor.Controls.Add(txtNombreMunicipio);
            pContenedor.Controls.Add(label4);
            pContenedor.Controls.Add(label1);
            pContenedor.Controls.Add(panel1);
            pContenedor.Controls.Add(label11);
            pContenedor.Controls.Add(label14);
            pContenedor.Dock = DockStyle.Right;
            pContenedor.Location = new Point(974, 0);
            pContenedor.Name = "pContenedor";
            pContenedor.Size = new Size(286, 760);
            pContenedor.TabIndex = 149;
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
            btnModificar.Location = new Point(60, 361);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 52);
            btnModificar.TabIndex = 190;
            btnModificar.Text = "          Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
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
            btnCerrar.TabIndex = 189;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(202, 192);
            label3.Name = "label3";
            label3.Size = new Size(23, 21);
            label3.TabIndex = 188;
            label3.Text = "(*)";
            // 
            // txtIDDepartamento
            // 
            txtIDDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtIDDepartamento.Location = new Point(29, 217);
            txtIDDepartamento.Name = "txtIDDepartamento";
            txtIDDepartamento.Size = new Size(236, 23);
            txtIDDepartamento.TabIndex = 187;
            txtIDDepartamento.TextChanged += txtIDDepartamento_TextChanged;
            txtIDDepartamento.KeyPress += txtIDDepartamento_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 189);
            label5.Name = "label5";
            label5.Size = new Size(178, 24);
            label5.TabIndex = 186;
            label5.Text = "ID del Departamento:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(211, 124);
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
            btnNuevo.Location = new Point(60, 291);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(158, 52);
            btnNuevo.TabIndex = 184;
            btnNuevo.Text = "      Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombreMunicipio
            // 
            txtNombreMunicipio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNombreMunicipio.Location = new Point(29, 149);
            txtNombreMunicipio.Name = "txtNombreMunicipio";
            txtNombreMunicipio.Size = new Size(236, 23);
            txtNombreMunicipio.TabIndex = 166;
            txtNombreMunicipio.TextChanged += txtNombreMunicipio_TextChanged;
            txtNombreMunicipio.KeyPress += txtNombreMunicipio_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 121);
            label4.Name = "label4";
            label4.Size = new Size(189, 24);
            label4.TabIndex = 161;
            label4.Text = "Nombre del Municipio:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(454, 170);
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
            label11.Location = new Point(331, 126);
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
            label14.Location = new Point(48, 11);
            label14.Name = "label14";
            label14.Size = new Size(201, 60);
            label14.TabIndex = 154;
            label14.Text = "DATOS DE LOS MUNICIPIOS";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top;
            txtBuscar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Italic, GraphicsUnit.Point);
            txtBuscar.Location = new Point(153, 72);
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
            lblTitulo.Location = new Point(426, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(127, 28);
            lblTitulo.TabIndex = 172;
            lblTitulo.Text = "MUNICIPIOS";
            // 
            // dgvMunicipios
            // 
            dgvMunicipios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMunicipios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMunicipios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMunicipios.BackgroundColor = Color.WhiteSmoke;
            dgvMunicipios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMunicipios.Location = new Point(28, 121);
            dgvMunicipios.MultiSelect = false;
            dgvMunicipios.Name = "dgvMunicipios";
            dgvMunicipios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvMunicipios.RowTemplate.Height = 25;
            dgvMunicipios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMunicipios.Size = new Size(918, 607);
            dgvMunicipios.TabIndex = 171;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // Municipio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1260, 760);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvMunicipios);
            Controls.Add(pContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Municipio";
            Text = "Municipio";
            Load += Municipio_Load;
            pContenedor.ResumeLayout(false);
            pContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMunicipios).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pContenedor;
        private Button btnNuevo;
        private TextBox txtNombreMunicipio;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private Label label11;
        private Label label14;
        private Label label2;
        private Label label3;
        private TextBox txtIDDepartamento;
        private Label label5;
        private PictureBox btnCerrar;
        private TextBox txtBuscar;
        private Label lblTitulo;
        private DataGridView dgvMunicipios;
        private Button btnModificar;
        private ErrorProvider erpError;
    }
}