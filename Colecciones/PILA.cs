using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    public class PILA<T>
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

        public void Apilar(NODO<T> nuevoNodo)
        {
            if (cantidad <= 0)
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
            Console.WriteLine("Se ha agregado un nuevo nodo a la pila.\nCantidad: " + cantidad.ToString());
        }

        public NODO<T> Desapilar()
        {
            NODO<T> nodoDesapilado;
            nodoDesapilado = ultimoNodo;
            
            for (int i = 0; i < cantidad; i++)
            {
                if (nodoActual.ProximoNodo == ultimoNodo)
                {
                    ultimoNodo = nodoActual;
                    nodoActual.ProximoNodo = null;
                    
                    cantidad--;
                }
                
            }
            return nodoDesapilado;
        }
    }
}
