using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class lista
    {//Se agrega el costructor
        public nodo inicio;
        public lista()
        { inicio = null; }

        //Método insertar en la vola de la lista
        public void InsertarF(int item)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }


        }
        //Metodo insertar al inicio
        public void Insertari(int item)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                inicio = auxiliar;
                inicio.siguiente = puntero;
            }
        }
        //Metodo para eliminar nodo en cabeza
        public void EliminarI()
        {
            if (inicio == null)
            { Console.WriteLine("Lista vacia, no se puede eliminar elemento"); }
            else
            {
                nodo punteroant, punteropost;
                punteroant = inicio;
                punteropost = inicio;
                while (punteropost.siguiente != null)
                {
                    punteroant = punteropost;
                    punteropost = punteropost.siguiente;

                }
            }
        }
        //Metodo Insertar en posicion especifica
        public void InsertarP(int item, int pos)
        {
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                Console.WriteLine("La lista esá vacia, por lo tanto seva  insertar  n la 1a posicion");
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; 1 < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }
                    nodo punteronext;
                    punteronext = puntero.siguiente;
                    puntero.siguiente = auxiliar;
                    auxiliar.siguiente = punteronext;
                }
            }
        }
        //Método mostrar contenido lista
        public void mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacia");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                Console.WriteLine("{0}->\t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0}->\t", puntero.dato);
                }
            }
            Console.WriteLine();
        }
    }

}             