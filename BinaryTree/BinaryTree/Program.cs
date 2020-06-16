using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree root = new BTree();
            root.Letter = 'a';
            BTree branch1 = new BTree();
            branch1.Letter = 'b';
            BTree branch2 = new BTree();
            branch2.Letter = 'c';
            BTree branch3 = new BTree();
            branch3.Letter = 'd';

            root.Left = branch1;
            root.Right = branch2;
            branch2.Left = branch3;
            Console.WriteLine("Root:{0}",root);
            Console.WriteLine("branch1 = root.Left:{0}",root.Left);
            Console.WriteLine("branch2 = root.Right:{0}", root.Right);
            Console.WriteLine("branch3 = branch2.Left:{0}", branch2.Left);
            Console.ReadKey();
        }
    }// End of main Class
    class BTree
    {
        private char letter;
        private BTree left;
        private BTree right;

        public BTree()
        {
            letter = '\0';
            left = null;
            right = null;
        }

        public char Letter { get => letter; set => letter = value; }
        internal BTree Left { get => left; set => left = value; }
        internal BTree Right { get => right; set => right = value; }

        public override string ToString()
        {
            string output;
            output = letter.ToString();
            return output;
        }
    }// End of BTree Class
}
