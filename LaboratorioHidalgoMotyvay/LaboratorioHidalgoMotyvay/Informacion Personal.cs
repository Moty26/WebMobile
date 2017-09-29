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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            string MensajeDeVariablesPorRellenar = "";
            if (this.TextNombre.Text=="") {
                MensajeDeVariablesPorRellenar += " Falta Nombre\n";
            }
            if (this.textApellido.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Apellido\n";
            }
            if (this.textRut.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Rut\n";
            }
            if (this.textVerificador.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Digito Verificador\n";
            }
            if (this.textMail.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Mail\n";
            }
            if (this.textDireccion.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Direccion\n";
            }
            if (this.textCelular.Text == "")
            {
                MensajeDeVariablesPorRellenar += " Falta Celular\n";
            }
            MessageBox.Show(MensajeDeVariablesPorRellenar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            LaboratorioHidalgoMotyvay.DatosLaborales Ventana = new LaboratorioHidalgoMotyvay.DatosLaborales();
            this.Hide();
            Ventana.ShowDialog();
            this.Show();

        }
        
        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.TextNombre.Text = "";
            this.textApellido.Text = "";
            this.textMail.Text = "";
            this.textCelular.Text = "";
            this.textDireccion.Text = "";
            this.textFecha.Text = "";
            this.textRut.Text = "";
            this.textVerificador.Text = "";
        }
    }
}
