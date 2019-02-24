using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgoraVai
{
    public partial class Form1 : Form
    {
        Moto motoInstancia = new Moto();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            motoInstancia.marca = textMarca.Text;
            motoInstancia.modelo = textModelo.Text;
            motoInstancia.cor = textCor.Text;
            motoInstancia.marcha = Convert.ToInt32(textMarcha.Text);

            label9.Text = motoInstancia.marca;
            label10.Text = motoInstancia.modelo;
            label11.Text = motoInstancia.cor;
            label15.Text = Convert.ToString(motoInstancia.marcha);
     

        }

        private void aumentarMarcha_Click(object sender, EventArgs e)
        {
            motoInstancia.marchaAcima();
            label15.Text =  Convert.ToString(motoInstancia.marcha);

        }

        private void DiminuirMarcha_Click(object sender, EventArgs e)
        {
            motoInstancia.marchaAbaixo();
            label15.Text = Convert.ToString(motoInstancia.marcha);
        }

        private void ligar_Click(object sender, EventArgs e)
        {
            motoInstancia.ligar();
            if(motoInstancia.ligada == true)
            {
                label14.Text = "Sim";
            }
        }

        private void desligar_Click(object sender, EventArgs e)
        {
            motoInstancia.desligar();
            if (motoInstancia.ligada == false)
            {
                label14.Text = "Não";
            }
        }
    }
}
