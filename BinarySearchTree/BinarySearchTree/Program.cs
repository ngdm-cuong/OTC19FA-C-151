using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BnarySearchTree testTree = new BnarySearchTree();
            testTree.Insert('j');
            testTree.Insert('a');
            testTree.Insert('v');
            testTree.Insert('k');
            testTree.Insert('c');
            testTree.Insert('b');
            testTree.Insert('c');
            testTree.Insert('k');
            testTree.Insert('d');
            testTree.Insert('a');
            testTree.Insert('b');
            testTree.Insert('c');
            testTree.Insert('x');
            Console.WriteLine("Inorder Traversal : ");
            testTree.Inorder(testTree.Root);
            Console.WriteLine(" ");
            Console.WriteLine(testTree.Search('k',testTree.Root));
            Console.WriteLine(testTree.Search('x', testTree.Root));
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
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
    class BnarySearchTree
    {
        private BTree root;
        private BTree current;

        internal BTree Root { get => root; set => root = value; }
        internal BTree Current { get => current; set => current = value; }
        
        public BnarySearchTree()
        {
            root = null;
            current = null;
        }

        public BTree ReturnRoot()
        {
            return root;
        }

        public void Insert(char value)
        {
            BTree newNode = new BTree();
            newNode.Letter = value;
            if (root == null)
                root = newNode;
            else
            {
                BTree current = root;
                BTree parent;
                while (true)
                {
                    parent = current;
                    if (value < current.Letter)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }// End of insert
        public void Inorder(BTree Root)
        {
            if (Root != null)
            {
                Inorder(Root.Left);
                Console.Write(Root.Letter + " ");
                Inorder(Root.Right);
            }
        }
        public string Search(char acharacter, BTree rootNode)

        {
            current = rootNode;
            if (current == null)

                return "Cannot find "+ acharacter;

            if (acharacter == current.Letter)

                return "Found "+ acharacter;

            if (acharacter < current.Letter)

                return this.Search(acharacter,current.Left);

            else

                return this.Search(acharacter,current.Right);

        }

    }
}
