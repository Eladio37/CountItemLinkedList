using System;
using EstructurasDeDatos.ListaEnlazada;

namespace SearchItem
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.Write("Digite la cantidad de ITEMS: ");
            int cantidad = int.Parse(Console.ReadLine());
            int item, selected, counter = 0;

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Item #{ i + 1}: ");
                item = int.Parse(Console.ReadLine());
                linkedList.AddItemAtBeginning(item);
            }
            Console.Write("Digite el elemento que desea contabilizar: ");
            selected = int.Parse(Console.ReadLine());



            Node node = linkedList.Head;

            while (node != null)
            {
                Console.Write(node.Value + " -> ");
                node = node.Next;
            }
            Console.WriteLine("");
            LinkedList linkedList1 = new LinkedList();
            linkedList1.AddItemAtBeginning(selected);
            int x = 0;
            node = linkedList.Head;

            while (node != null)
            {
                if (node.Value == selected)
                {
                    x++;
                }

                node = node.Next;
            }

            Console.WriteLine($"Cantidad: {x}");
        }
    }
}
