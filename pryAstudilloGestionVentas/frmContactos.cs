using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAstudilloGestionVentas
{
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        //declaracion de variables
        string[] vecNombre = new string[3];
        int indice = 0;


        private void frmContactos_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Goku";
            vecNombre[1] = "Barbie";
            vecNombre[2] = "Megatron";

            lblNombre.Text = vecNombre[0];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            indice++; //indice= indice + 1;
            lblNombre.Text = vecNombre[indice];

            if (vecNombre.Length <= (indice + 1))
            {
                btnSiguiente.Enabled = false;

            }


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            lblNombre.Text = vecNombre[indice];
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //llamar al formulario gestion
            frmAgendaContactos ventanagestion=new frmAgendaContactos(); ventanagestion.Show();
        }
    }
}