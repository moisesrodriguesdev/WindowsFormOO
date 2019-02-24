using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgoraVai
{
    class Moto
    {
        public string marca;
        public string modelo;
        public string cor;
        public int marcha;
        public bool ligada;


        public void definir(string marca, string modelo, string cor, int marcha)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.marcha = marcha;
        }

        public void imprimir()
        {
            Console.WriteLine("***************** Especificaões da Moto *****************");
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Cor " + cor);
            switch (marcha)
            {
                case 0:
                    Console.WriteLine("Marcha está o Neutro");
                    break;
                case 1:
                    Console.WriteLine("Marcha está engatada na 1°");
                    break;
                case 2:
                    Console.WriteLine("Marcha está engatada na 2°");
                    break;
                case 3:
                    Console.WriteLine("Marcha está engatada na 3°");
                    break;
            }
            Console.WriteLine("Está ligada:" + ligada);
        }

        public void ligar()
        {
            ligada = true;
        }
        public void desligar()
        {
            ligada = false;
        }
        public void marchaAcima()
        {
            if (marcha >= 5)
            {
                Console.WriteLine("Limite maximo de marchas, troca por uma marcha abaixo");
            }
            else
            {
                marcha++;
            }
        }
        public void marchaAbaixo()
        {
            if (marcha <= 0)
            {
                Console.WriteLine("Limite minimo de marchas, troque por uma acima");
            }
            else
            {
                marcha--;
            }
        }
    }
}
