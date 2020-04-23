using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    public class PILA
    {
        private COLECCIONABLE[] coleccionables;

        public COLECCIONABLE[] Coleccionables
        {
            get { return coleccionables; }
            set { coleccionables = value; }
        }

        private COLECCIONABLE primero;

        public COLECCIONABLE Primero
        {
            get { return primero; }

        }

        private COLECCIONABLE ultimo;

        public COLECCIONABLE Ultimo
        {
            get { return ultimo; }

        }

        public void AgregarAPila(COLECCIONABLE col)
        {
            if (coleccionables.Count() <= 0)
            {
                coleccionables[0] = col;
                primero = col;
                ultimo = col;
            }
            else
            {
                coleccionables[coleccionables.Count()] = col;
                ultimo = col;
            }

        }

        public COLECCIONABLE ExtraerDePila()
        {
            COLECCIONABLE extraido = null;
            for (int i = 0; i < coleccionables.Count(); i++)
            {
                if (coleccionables[i] == ultimo)
                {
                    extraido = ultimo;
                    coleccionables[i] = null;
                    ultimo = coleccionables[i-1];
                }
            }
            return extraido;

        }
    }
}

