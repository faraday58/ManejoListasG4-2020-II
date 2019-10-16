using System;
using PedidosComida;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaDeComida
{
    public partial class Form1 : Form
    {
        private Comida comida;
        private List<Comida> pedidosComida;
        private float costo;
        public Form1()
        {
            InitializeComponent();
            pedidosComida = new List<Comida>();
            comida = new Comida("TacosDeCanasta",7, 50, "De champions, frijol, papa y chicharrón ");
        }

        private void BtnComidaTortilla_Click(object sender, EventArgs e)
        {
            pedidosComida.Add(comida);
            lstPedido.Items.Add(pedidosComida[0].Nombre);
            lbComidaTortilla.Text = pedidosComida[0].Descripicion;
            lbComidaTortilla.Visible = true;
            costo += pedidosComida[0].Precio;// costo=costo+pedidosComida[0].precio;
            lbCosto.Text = "$" + costo.ToString();
            pedidosComida[0].Stock -= 1;                 

        }
    }
}
