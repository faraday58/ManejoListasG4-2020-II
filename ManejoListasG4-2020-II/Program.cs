using System;
using System.Collections.Generic;

namespace ManejoListasG4_2020_II
{
    class Program
    {
        static void Main()
        {
            List<string> pedidosComida = new List<string>();
            pedidosComida.Add("TacosDeCanasta");
            pedidosComida.Add("TacosDeLengua");
            pedidosComida.Add("TacosDeSuadero");
            pedidosComida.Add("TacosDePollo");
            pedidosComida.Add("TortasDeTaco");
            pedidosComida.Add("ManteConcha");
            pedidosComida.Add("Alitas");
            pedidosComida.Add("Hamburguesa");
            pedidosComida.Add("Guajolota");


            foreach(string pedido in pedidosComida)
            {
                Console.WriteLine("A la carta: " + pedido);
            }

            Console.WriteLine("Escribe la orden que quieres ");
            string tupedido = Console.ReadLine();

            for(int i=0; i < pedidosComida.Count;i++)
            {
                if(tupedido == pedidosComida[i] )
                {
                    pedidosComida.RemoveAt(i);
                }
            }
            Console.Clear();
            foreach (string pedido in pedidosComida)
            {
                Console.WriteLine("A la carta: " + pedido);
            }
            Console.WriteLine("Escribe lo que falta");
            string loQueFalta = Console.ReadLine();
            int respuesta = 0;
            Console.WriteLine("Es de pan o tortilla? 0.- Tortilla 1.-Pan");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta == 0)
            {
                pedidosComida.Insert(2, loQueFalta);
            }
            else if(respuesta == 1)
            {
                pedidosComida.Insert(8, loQueFalta);
            }
            foreach (string pedido in pedidosComida)
            {
                Console.WriteLine("A la carta: " + pedido);
            }
        }
    }
}
