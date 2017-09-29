using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioHidalgoMotyvay
{
    public partial class DatosLaborales : Form
    {
        public DatosLaborales()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.textNombreEmpresa.Text = "";
            this.textRutEmpresa.Text = "";
            this.textVerificador.Text = "";
            this.textDireccionLaboral.Text = "";
            this.textTelefonoLaboral.Text = "";
            this.textMailLaboral.Text = "";
        }
        private void Verificar_Click(object sender, EventArgs e)
        {
            string MensajeDeVariablesPorRellenar = "";
            if (this.textNombreEmpresa.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Nombre Empresa\n";
            }
            if (this.textRutEmpresa.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Rut Empresa\n";
            }
            if (this.textVerificador.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Digito Verificador\n";
            }
            if (this.textMailLaboral.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Mail Empresa \n";
            }
            if (this.textDireccionLaboral.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Direccion Empresa \n";
            }
            if (this.textTelefonoLaboral.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Celular\n";
            }
            MessageBox.Show(MensajeDeVariablesPorRellenar);
        }
    }
}
