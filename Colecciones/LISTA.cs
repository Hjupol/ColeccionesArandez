using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    public class LISTA<T>
    {
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private NODO<T> primerNodo;

        public NODO<T> PrimerNodo
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }

        private NODO<T> nodoActual;

        public NODO<T> NodoActual
        {
            get { return nodoActual; }
            set { nodoActual = value; }
        }


        private NODO<T> ultimoNodo;

        public NODO<T> UltimoNodo
        {
            get { return ultimoNodo; }
            set { ultimoNodo = value; }
        }


        public void AgregarPrimero(NODO<T> nuevoNodo)
        {
            if (cantidad <= 0)
            {
                nuevoNodo.ProximoNodo = null;
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
                cantidad++;
            }
            else
            {
                nuevoNodo.Posicion = primerNodo.Posicion;
                nuevoNodo.ProximoNodo = primerNodo;
                nodoActual = primerNodo;
                for(int i = 0; i < cantidad; i++)
                {
                    nodoActual.Posicion++;
                    if (nodoActual.ProximoNodo != null)
                    {
                        nodoActual = nodoActual.ProximoNodo;
                    }
                }
                primerNodo = nuevoNodo;
                cantidad++;

            }
            Console.WriteLine("Se ha agregado un nuevo nodo a la lista.\nCantidad: " + cantidad.ToString());
        }

        public void AgregarUltimo(NODO<T> nuevoNodo)
        {
            if (cantidad<=0)
            {
                nuevoNodo.ProximoNodo = null;
                nuevoNodo.Posicion = cantidad;
                primerNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
                cantidad++;
            }
            else
            {
                nuevoNodo.ProximoNodo = null;
                nuevoNodo.Posicion = cantidad;
                ultimoNodo.ProximoNodo = nuevoNodo;
                ultimoNodo = nuevoNodo;
                cantidad++;

            }
            Console.WriteLine("Se ha agregado un nuevo nodo a la lista.\nCantidad: " + cantidad.ToString());
        }

        

        public NODO<T> Obtener(int index)
        {
            NODO<T> nodoPedido=null;

            nodoActual = primerNodo;
            for (int i = 0; i < cantidad; i++)
            {
                if (nodoActual.Posicion == index)
                {
                    nodoPedido = nodoActual;
                    //return nodoPedido;
                }
                else
                {
                    nodoActual = nodoActual.ProximoNodo;
                }
            }
            if (nodoPedido == null)
            {
                Console.WriteLine("\nEl nodo pedido no existe.");
            }
            return nodoPedido;
        }

        public NODO<T> ObtenerPrimero(int index)
        {
            NODO<T> nodoPedido = null;
            if (primerNodo != null)
            {
                nodoPedido = primerNodo;
            }
            else
            {
                Console.WriteLine("\nLa lista no posee ningun nodo.");
            }
            return nodoPedido;
        }

        public NODO<T> ObtenerUltimo(int index)
        {
            NODO<T> nodoPedido = null;
            if (ultimoNodo != null)
            {
                nodoPedido = ultimoNodo;
            }
            else
            {
                Console.WriteLine("\nLa lista no posee ningun nodo.");
            }
            return nodoPedido;
        }

        public int Contar()
        {
            return cantidad;
        }
    }    
}
