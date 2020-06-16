using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node("Deep");
            Node node2 = new Node("Brown");
            Node node3 = new Node("Gomez");
            Node node4 = new Node("Cone");
            Node node5 = new Node("Fisher");
            Node node6 = new Node("Gross");
            Node node7 = new Node("White");

            MinHeap aHeap = new MinHeap(7);

            aHeap.Insert(node1);
            aHeap.Insert(node2);
            aHeap.Insert(node3);
            aHeap.Insert(node4);
            aHeap.Insert(node5);
            aHeap.Insert(node6);
            aHeap.Insert(node7);

            Console.WriteLine(aHeap.FindMin());
            aHeap.DisplayHeap();

            aHeap.RemoveMin();
            Console.WriteLine(aHeap.FindMin());
            aHeap.DisplayHeap();

            aHeap.Delete(node4);
            Console.WriteLine(aHeap.FindMin());
            aHeap.DisplayHeap();           
            Console.ReadKey();
        }
    }// End of Main class
}
