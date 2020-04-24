using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Colecciones;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LISTA<int> lista = new LISTA<int>();


            for (int i = 0; i < 5; i++)
            {
                NODO<int> nodo = new NODO<int>();

                nodo.Valor = i;

                lista.AgregarUltimo(nodo);
            }
            Console.ReadLine();
        }
    }
}
