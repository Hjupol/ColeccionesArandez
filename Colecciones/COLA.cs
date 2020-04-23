using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    public class COLA
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

        //public int Contar()
        //{
        //    int cantidad=0;
        //    if ( = null)
        //    {

        //    }
        //    return cantidad;
        //}

        public void AgregarACola(COLECCIONABLE col)
        {
           //Antes se deberia comprobar si es null??Preguntar al profe
            if(coleccionables.Count() <= 0)
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

        //Volver a setear las posiciones de la cola para que funcione el count
        public COLECCIONABLE ExtraerDeCola()
        {
            COLECCIONABLE extraido = null;
            for(int i=0; i < coleccionables.Count(); i++)
            {
                if (coleccionables[i] == primero)
                {
                    extraido = primero;
                    coleccionables[i] = null;
                    primero = null;
                    for (int j = 0; j < coleccionables.Count(); j++)
                    {
                        if (coleccionables[j + 1] != null)
                        {
                            coleccionables[j] = coleccionables[j + 1];
                        }
                        else
                        {
                            coleccionables[j] = null;
                        }
                    }
                }
            }
            primero = coleccionables[0];
            return extraido;

        }
    }
}
