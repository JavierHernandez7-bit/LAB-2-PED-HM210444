using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3Guia2PED
{
    class cola
    {
        public nodo primero; //inicio de la cola
        public nodo ultimo; //final de la cola
        public cola()
        {
            primero = ultimo = null;
        }
        public void Encolar(int valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            if (primero == null) //en caso de que la cola
            {
                primero = ultimo = aux;
                aux.sgte = null;
            }
            else
            {
                ultimo.sgte = aux; //el último elemento va
                aux.sgte = null;
                ultimo = aux; //metemos el nodo a la cola 
            }


        }
        public void Desencolar()   
        {
            if (primero == null) Console.WriteLine("Cola Vacia");
            else primero=primero.sgte;
        }
        public int DesencolarValor() //desencola y me muestra valor
        {
            int valor = 0;
            if (primero == null) Console.WriteLine("Cola vacia");
            else
            {
                valor = primero.info;
                primero = primero.sgte;
            }
            return valor;
        }

        public void Mostrar()
        {
            if (primero == null) Console.WriteLine("Cola vacia");
            else
            {
                nodo puntero;
                puntero=primero;
                do
                {
                    Console.Write("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                }
                while (puntero != null);
            }
            Console.WriteLine("\n");

        }
        
    }
    //
    


    
}
