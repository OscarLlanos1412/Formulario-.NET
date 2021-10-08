using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos; //Otra forma de poder acceder a un namespace

namespace Ventanas_num5_POO
{
    public partial class Form1 : Form
    {
        //Productos.Celular iphone = new Productos.Celular(); //Seria una forma de llamar 
        //O crear un objeto de diferente namespace

        Celular iphone = new Celular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_llamar_Click(object sender, EventArgs e)
        {
            //iphone.Llamar();
            MessageBox.Show(iphone.MandarMensaje("Oscar", "Eh como jue patirusia"));
        }
    }
}
