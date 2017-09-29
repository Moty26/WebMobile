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
    public partial class NucleoFamiliar : Form
    {
        public NucleoFamiliar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private GroupBox GenerarPantallaDinamica() {
            GroupBox groupBox1 = new System.Windows.Forms.GroupBox();
            TextBox textBox5 = new System.Windows.Forms.TextBox();
            TextBox textBox4 = new System.Windows.Forms.TextBox();
            TextBox textBox3 = new System.Windows.Forms.TextBox();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            TextBox  textBox1 = new System.Windows.Forms.TextBox();
            Label label4 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(680, 102);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nucleo Familiar";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(523, 56);
            textBox5.Name = "textBox5";
            textBox5.Size = new System.Drawing.Size(34, 20);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(298, 56);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(132, 20);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(201, 56);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(22, 20);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(55, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(132, 20);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(122, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(522, 20);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(479, 59);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 8;
            label4.Text = "Edad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(244, 59);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 13);
            label3.TabIndex = 7;
            label3.Text = "Genero :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 13);
            label2.TabIndex = 6;
            label2.Text = "Rut :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(96, 13);
            label1.TabIndex = 5;
            label1.Text = "Nombre completo :";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonVolver
            // 
            // 
            // NucleoFamiliar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(705, 444);
            return groupBox1;

        }

        private void buttonContinuar_Click(object sender, EventArgs e)/*Nuevo*/
        {
            GroupBox caja = GenerarPantallaDinamica();
            Panel.Controls.Add(caja);
        }
    }
}
