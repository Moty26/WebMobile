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
        public LaboratorioHidalgoMotyvay.DatosLaborales EMPRESA;
        public Form1()
        {
            this.EMPRESA = new LaboratorioHidalgoMotyvay.DatosLaborales();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }
        public Boolean Validar_Rut() {/*DRJ V1.0*/
            Boolean respuesta = false;
            char[] charArray = this.textRut.Text.ToCharArray();
            int _calculo = 0;
            int _contador = 2;
            Array.Reverse(charArray);
            try
            {
                for (int x = 0; x <= this.textRut.Text.Length - 1; x++)
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


        private Boolean test() {
            string MensajeDeVariablesPorRellenar = "";
            if (this.TextNombre.Text == "")
            {
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
            if (MensajeDeVariablesPorRellenar == "")
            {
                Boolean respuesta = Validar_Rut();
                if (!respuesta)
                {
                    MessageBox.Show("El Rut ingresado es incorrecto");
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show(MensajeDeVariablesPorRellenar);
                return false;
            }
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            string MensajeDeVariablesPorRellenar = "";
            if (this.TextNombre.Text == "")
            {
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
            if (MensajeDeVariablesPorRellenar == "")
            {
                MessageBox.Show("Formulario completo");

            }
            else
            {
                MessageBox.Show(MensajeDeVariablesPorRellenar);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (this.test()) {
                this.Hide();
                this.EMPRESA.ShowDialog();
                this.Show();
            }

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

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void textCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
