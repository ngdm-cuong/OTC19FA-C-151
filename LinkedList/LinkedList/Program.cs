using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            LLNode ANode = new LLNode(4,null);
            LLNode BNode = new LLNode(1,null);
            LLNode CNode = new LLNode(7,null);
            //LLNode Temp = new LLNode(100);
            LinkedList testList = new LinkedList(ANode, BNode, CNode);
            //testList.SetCurrent(Temp);
            //For LinkedList
            //Console.WriteLine($"Front: {testList.GetFront().Data}\t\t Current: {testList.GetCurrent().Data}\t\t Back: {testList.GetBack().Data}");
            //Console.WriteLine($"Front: {testList.GetFront()}\t Current: {testList.GetCurrent()}\t Back: {testList.GetBack()}");
            //Console.WriteLine();
            //Console.WriteLine("ANode.Next: {0}", ANode.Next);
            //Console.WriteLine("BNode.Next: {0}", BNode.Next);
            //Console.WriteLine("testList.GetFront(){0}", testList.GetFront().Next);
            //Console.WriteLine("testList.GetCurrent(){0}", testList.GetCurrent().Next);
            //Console.ReadKey();


            ////For QUEUE
            LinkedQueue testQueue = new LinkedQueue(testList);
            testQueue.Dequeue();
            Console.WriteLine(testQueue);
            Console.WriteLine(testList);
            Console.ReadLine();
        }
    }
}
