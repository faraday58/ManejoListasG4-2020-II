using System;
using System.Collections.Generic;

namespace ManejoDePilas
{
    class Program
    {
        static void Main()
        {
            List<string> autos = new List<string>();
            autos.Add("tsuru");
            autos.Add("Clio");
            autos.Add("chevy");
            autos.Add("smart");
            autos.Add("Vochito");
            autos.Add("March");
            autos.Add("Nissan 350z");


            Stack<string> pilaAutos = new Stack<string>();

            //pilaAutos.Push(autos[0]);

            foreach (string auto in autos)
            {
                pilaAutos.Push(auto);
                Console.WriteLine("Agregando a la pila: " + auto);
            }
            Console.WriteLine("******************************************");

            int tope = pilaAutos.Count;

            Console.WriteLine("Realizando PoP");
            for (int i = 0; i < tope; i++)
            {
                Console.WriteLine(pilaAutos.Pop());
            }

            Console.WriteLine(pilaAutos.Peek());


        }
    }
}
