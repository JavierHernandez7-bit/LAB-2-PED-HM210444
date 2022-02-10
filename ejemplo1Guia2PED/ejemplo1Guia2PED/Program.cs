using System;

namespace ejemplo1Guia2PED
{
    class Program
    {
        static void Main(string[] args)
        {
            //agregar nodos a lista
            lista listanueva = new lista();
            listanueva.Insertari(40);
            listanueva.Insertari(30);
            listanueva.Insertari(20);
            listanueva.Insertari(10);
            //contenido dentro
            listanueva.mostrar();

            //posicion
            listanueva.InsertarP(220, 3);
            listanueva.mostrar();
            Console.ReadKey();
        }
    }
}