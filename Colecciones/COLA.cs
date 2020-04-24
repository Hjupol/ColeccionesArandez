using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    public class COLA<T>
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
    }
}
