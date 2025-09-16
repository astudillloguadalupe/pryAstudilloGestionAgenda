namespace pryAstudilloGestionVentas
{
    partial class frmContactos
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
            lblNombre = new Label();
            btnAtras = new Button();
            btnSiguiente = new Button();
            btnAbrir = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(96, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(369, 123);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "-";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(88, 183);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "&Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(236, 183);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "&Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(401, 183);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 3;
            btnAbrir.Text = "&Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // frmContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 342);
            Controls.Add(btnAbrir);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(lblNombre);
            Name = "frmContactos";
            Text = "frmContactos";
            Load += frmContactos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Button btnAtras;
        private Button btnSiguiente;
        private Button btnAbrir;
    }
}