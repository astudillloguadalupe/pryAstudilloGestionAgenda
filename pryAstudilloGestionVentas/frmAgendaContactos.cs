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
    public partial class frmAgendaContactos : Form
    {
        public frmAgendaContactos()
        {
            InitializeComponent();
        }

        //DECLARACION DE VARIABLES GLOBALES
        string vContactos = "";
        string vNumero = "";
        int vContador = 0;
        DateTime vFecha = DateTime.Now;
        //DECLARO UN VECTOR CONTACTOS Y NUMEROS
        string[] vecContactos = new string[5];

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
            {
                mktNumero.Enabled = true;
            }
            else
            {
                mktNumero.Enabled = false;
            }
        }

        private void mktNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mktNumero.Text != "")
            {
                btnAgendar.Enabled = true;

            }
            else
            {
                btnAgendar.Enabled = false;
            }

        }
        int indice = 0;
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vContactos = txtContacto.Text;
            vNumero = mktNumero.Text;
            lstResultado.Items.Add("Contacto" + vContactos + "Numero:" + vNumero);
            //lIMPIAR CONTROLES
            txtContacto.Text = "";
            mktNumero.Text = "";
            vContador = vContador + 1;
            lblCantidad.Text = "Cantidad de contactos:" + vContactos;
            lblFechaHora.Text = "Fecha y Hora:" + vFecha;
            vecContactos[indice] = vContactos;
            indice++;

        }

        private void frmAgendaContactos_Load(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
