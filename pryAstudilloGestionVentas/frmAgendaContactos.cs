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
        string[] vecTelofono = new string[5];
        // INDICE PARA EL VECTOR
        int Indice = 0;

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
            vecContactos[Indice] = txtContacto.Text;
            vecTelofono[Indice] = mktNumero.Text;

            lstResultado.Items.Add("Contacto:" + " " + vecContactos[Indice] + " - " + "Numero:" + " " + vecTelofono[Indice]);
            vContador = vContador + 1;
            lblCantidad.Text = "Cantidad de Contactos:" + " " + vContador;
            lblFechaHora.Text = "Fecha y Hora:" + " " + vFecha;
            txtContacto.Focus();
            
            Indice++;
            LimpiarControles();
        }

        private void frmAgendaContactos_Load(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarControles()
        {
            txtContacto.Clear();
            mktNumero.Clear();
            txtContacto.Focus();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarControles();

            }
        }

        private void lstResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
