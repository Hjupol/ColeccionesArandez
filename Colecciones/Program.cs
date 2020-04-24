using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LISTA<int> lista = new LISTA<int>();

            var poppedItem = stack.Pop();

            for (int i = 0; i < 5; i++)
            {
                Node<int> node = new Node<int>();

                node.Value = i;

                stack.Push(node);
            }

            poppedItem = stack.Pop();
        }
    }
}
