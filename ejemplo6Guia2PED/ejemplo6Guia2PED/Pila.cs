using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo6Guia2PED
{
    class Pila
    {
        public nodo tope;
        public Pila()
        {
            tope = null;
        }
        public void Push(char valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            // si no hay nada en la pila
            if (tope == null)

            {
                //se asigna el aux como el único nodo
                tope = aux;
                //como solo hay un dato en la pila el
                aux.sgte = null;
            }
            else
            {
                //si la pila no está vacía el dato se inserta arriba de la pila
                //es decir en el tope
                aux.sgte = tope;
                tope = aux;
            }
        }
        public void mostrar()
        {
            nodo puntero; puntero = tope;
            Console.WriteLine("{0}", puntero.info);
            //se recorre el puntero del tope a el fondo
            while (puntero.sgte != null)
            {
                puntero = puntero.sgte;
                Console.WriteLine("{0}", puntero.info);
            }
        }
        public char Pop()//Ni puta idea por que no sirve esta mierda
        {
            char valor = '';
            if (tope == null) ;
            Console.WriteLine("Pila vacia");

            else
            {
                valor = tope.info;
                tope = tope.sgte;
            }
            return valor;

        }

    }

    
}

        