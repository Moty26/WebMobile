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
        public LaboratorioHidalgoMotyvay.NucleoFamiliar NUCLEO;
        public DatosLaborales()
        {
            this.NUCLEO = new LaboratorioHidalgoMotyvay.NucleoFamiliar();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Limpiar_Click(object sender, EventArgs e)
        {

        }
        private void Verificar_Click(object sender, EventArgs e)
        {

        }
        public Boolean Validar_Rut()
        {/*DRJ V1.0*/
            Boolean respuesta = false;
            char[] charArray = this.textRutEmpresa.Text.ToCharArray();
            int _calculo = 0;
            int _contador = 2;
            Array.Reverse(charArray);
            try
            {
                for (int x = 0; x <= this.textRutEmpresa.Text.Length - 1; x++)
                {
                    _calculo += ((int)charArray[x] - 48) * _contador;
                    if (_contador == 7)
                    {
                        _contador = 2;
                    }
                    else
                    {
                        _contador = _contador + 1;
                    }
                }
                _calculo = _calculo %= 11;
                _calculo = 11 - _calculo;
            }
            catch
            {
                return respuesta;
            }
            if (_calculo <= 9)
            {
                if (_calculo.ToString() != this.textVerificador.Text.ToUpper())
                {
                    return respuesta;
                }
                return true;
            }
            else if (_calculo == 11)
            {
                if ("0" != this.textVerificador.Text.ToUpper())
                {
                    return respuesta;
                }
                return true;
            }
            else
            {
                if ("K" != this.textVerificador.Text.ToUpper())
                {
                    return respuesta;
                }
                return true;
            }
        }
        private void buttonVerificar_Click(object sender, EventArgs e)
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
            if (MensajeDeVariablesPorRellenar == "")
            {
                Boolean respuesta = Validar_Rut();
                if (!respuesta)
                {
                    MessageBox.Show("El Rut ingresado es incorrecto");
                }

            }
            else
            {
                MessageBox.Show(MensajeDeVariablesPorRellenar);
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textNombreEmpresa.Text = "";
            this.textRutEmpresa.Text = "";
            this.textVerificador.Text = "";
            this.textDireccionLaboral.Text = "";
            this.textTelefonoLaboral.Text = "";
            this.textMailLaboral.Text = "";
        }


    }
    }
    }
