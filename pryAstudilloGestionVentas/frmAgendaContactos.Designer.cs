namespace pryAstudilloGestionVentas
{
    partial class frmAgendaContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaContactos));
            lblNumero = new Label();
            lblContacto = new Label();
            lblTitulo = new Label();
            lblFechaHora = new Label();
            lblCantidad = new Label();
            btnAgendar = new Button();
            btnCancelar = new Button();
            btnListar = new Button();
            lstResultado = new ListBox();
            mktNumero = new MaskedTextBox();
            txtContacto = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(28, 174);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(28, 94);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(56, 15);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Footlight MT Light", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(184, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 22);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Agenda de contacto";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(337, 447);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(76, 15);
            lblFechaHora.TabIndex = 3;
            lblFechaHora.Text = "Fecha y Hora";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(85, 447);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            lblCantidad.Click += lblCantidad_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(124, 251);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(75, 23);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "&Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 251);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(417, 251);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 7;
            btnListar.Text = "&Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // lstResultado
            // 
            lstResultado.BorderStyle = BorderStyle.FixedSingle;
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(12, 318);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(494, 107);
            lstResultado.TabIndex = 8;
            lstResultado.SelectedIndexChanged += lstResultado_SelectedIndexChanged;
            // 
            // mktNumero
            // 
            mktNumero.Enabled = false;
            mktNumero.Location = new Point(179, 166);
            mktNumero.Mask = "(351)000-0000";
            mktNumero.Name = "mktNumero";
            mktNumero.Size = new Size(100, 23);
            mktNumero.TabIndex = 1;
            mktNumero.MaskInputRejected += mktNumero_MaskInputRejected;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(179, 91);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(100, 23);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // frmAgendaContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 482);
            Controls.Add(txtContacto);
            Controls.Add(mktNumero);
            Controls.Add(lstResultado);
            Controls.Add(btnListar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(lblCantidad);
            Controls.Add(lblFechaHora);
            Controls.Add(lblTitulo);
            Controls.Add(lblContacto);
            Controls.Add(lblNumero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgendaContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgendaContactos";
            Load += frmAgendaContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblContacto;
        private Label lblTitulo;
        private Label lblFechaHora;
        private Label lblCantidad;
        private Button btnAgendar;
        private Button btnCancelar;
        private Button btnListar;
        private ListBox lstResultado;
        private MaskedTextBox mktNumero;
        private TextBox txtContacto;
    }
}