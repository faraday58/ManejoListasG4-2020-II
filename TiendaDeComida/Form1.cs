using System;
using PedidosComida;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaDeComida
{
    public partial class Form1 : Form
    {
        
        private List<Comida> pedidosComida;
        private float costo;
        private short index;
        public Form1()
        {
            InitializeComponent();
            pedidosComida = new List<Comida>();            
        }

        private void BtnComidaTortilla_Click(object sender, EventArgs e)
        {

            seleccionado(sender);
        }

        private void seleccionado(object sender)
        {
            Button botonPresionado = (Button)sender;

            switch(botonPresionado.Name)
            {
                case "btnComidaTortilla":
                    pedidosComida.Add(new Comida("TacosDeCanasta", 7, 50, "De champions, frijol, papa y chicharrón "));
                    lstPedido.Items.Add(pedidosComida[index].Nombre);
                    lbComidaTortilla.Text = pedidosComida[index].Descripicion;
                    lbComidaTortilla.Visible = true;
                    costo += pedidosComida[index].Precio;// costo=costo+pedidosComida[0].precio;
                    lbCosto.Text = "$" + costo.ToString();
                    pedidosComida[index].Stock -= 1;
                    index++;
                    break;

                case "btnComidaPan":
                    pedidosComida.Add(new Comida("Comida con pan",20,30,"tienen pan"));
                    lstPedido.Items.Add(pedidosComida[index].Nombre);
                    lbComidaPan.Text = pedidosComida[index].Descripicion;
                    lbComidaPan.Visible = true;
                    costo += pedidosComida[index].Precio;
                    lbCosto.Text = "$" + costo.ToString();
                    pedidosComida[index].Stock -= 1;
                    index++;
                    break;

                case "btnComida":
                    pedidosComida.Add(new Comida("Guisados", 15, 25, "Comida de diferentes guisados"));
                    lstPedido.Items.Add(pedidosComida[index].Nombre);
                    lbComidaPan.Text = pedidosComida[index].Descripicion;
                    lbComidaPan.Visible = true;
                    costo += pedidosComida[index].Precio;
                    lbCosto.Text = "$" + costo.ToString();
                    pedidosComida[index].Stock -= 1;
                    index++;
                    break;


            }



            


        }
    }
}
