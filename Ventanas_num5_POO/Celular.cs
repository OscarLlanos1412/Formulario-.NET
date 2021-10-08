using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    class Celular
    {
        public string Marca;
        public string Color;
        public string Tipo;

        public Celular()
        {
            Marca = "Ipro";
            Color = "Gris";
            Tipo = "Tactil";
        }

        public Celular(string M)
        {
            Marca = M;
            Color = "Gris";
            Tipo = "Tactil";
        }

        public Celular(string M, string C, string T)
        {
            Marca = M;
            Color = C;
            Tipo = T;
        }

        public void Llamar()
        {
            System.Windows.Forms.MessageBox.Show("Marca: " + Marca + " Color: " + Color + " Tipo: " + Tipo);
        }

        public string MandarMensaje(string N, string Msj)
        {
            string Mensaje = Msj;
            string Nombre = N;

            string Enviar = "De: " + Nombre + " Mensaje: " + Mensaje;
            return Enviar;
        }
    }
}
