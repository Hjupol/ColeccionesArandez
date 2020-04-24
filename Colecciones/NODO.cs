using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    public class NODO<T>
    {
        private int posicion;

        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        private T valor;

        public T Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private NODO<T> proximoNodo;

        public NODO<T> ProximoNodo
        {
            get { return proximoNodo; }
            set { proximoNodo = value; }
        }

    }
}
