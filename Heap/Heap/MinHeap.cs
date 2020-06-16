using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class MinHeap
    {
        Node[] arr;
        int arrSize;//size for the array container
        int heapSize;//keeps track of the number of elements
        #region     Constructors
        public MinHeap()
        {
            arrSize = 0;
            heapSize = 0;
            arr = new Node[arrSize];
        }
        //public MinHeap() { }
        public MinHeap(int size)
        {
            arr = new Node[size];
        }
        public void SetHeapSize(int size)
        {
            this.arrSize = size;
            arr = new Node[size];
        }
        #endregion
        public void RemoveMin()
        {
            if (heapSize == 0)
            {
                throw new Exception("Heap is empty!");
            }
            else
            {
                arr[0] = arr[heapSize - 1];
                heapSize--;
                if (heapSize > 0)
                {
                    SiftDown(0);
                }
            }
        }
        private void SiftUp(int index)
        {
            int parentIndex;
            //Node temp;
            if (index != 0)
            {
                parentIndex = GetParentIndex(index);
                if (arr[parentIndex].LastName != arr[index].LastName)
                {
                    if (string.Compare(arr[parentIndex].LastName, arr[index].LastName) == 1)
                    {
                        //temp = arr[parentIndex];
                        //arr[parentIndex] = arr[index];
                        //arr[index] = temp;
                        Swap(ref arr ,parentIndex, index);
                        SiftUp(parentIndex);
                    }
                }
                else
                {
                    if (arr[parentIndex].FirstName != arr[index].FirstName)
                    {
                        if (string.Compare(arr[parentIndex].FirstName, arr[index].FirstName) == 1)
                        {
                            Swap(ref arr, parentIndex, index);
                            SiftUp(parentIndex);
                        }
                    }
                    else
                    {
                        if (arr[parentIndex].IDnumber > arr[index].IDnumber)
                        {
                            Swap(ref arr, parentIndex, index);
                            SiftUp(parentIndex);
                        }
                    }
                }
               

            }
        }
        private void SiftDown(int nodeIndex)
        {
            int leftChildIndex, rightChildIndex, minIndex;
            //Node tmp;
            leftChildIndex = GetLeftChildIndex(nodeIndex);

            rightChildIndex = GetRightChildIndex(nodeIndex);

            if (rightChildIndex >= heapSize)
            {
                if (leftChildIndex >= heapSize)
                {
                    return;
                }
                else
                {
                    minIndex = leftChildIndex;
                }
            }
            else
            {
                if (string.Compare(arr[leftChildIndex].LastName, arr[rightChildIndex].LastName) == -1 || string.Compare(arr[leftChildIndex].LastName, arr[rightChildIndex].LastName) == 0)
                {
                    minIndex = leftChildIndex;
                }
                else
                {
                    minIndex = rightChildIndex;
                }
            }
            if (string.Compare(arr[nodeIndex].LastName, arr[minIndex].LastName) == 1)
            {
                //tmp = arr[minIndex];

                //arr[minIndex] = arr[nodeIndex];

                //arr[nodeIndex] = tmp;
                Swap(ref arr, minIndex, nodeIndex);

                SiftDown(minIndex);
            }
        }
        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }
        private int GetRightChildIndex(int nodeIndex)
        {
            return (2 * nodeIndex) + 2;
        }
        private int GetLeftChildIndex(int nodeIndex)
        {
            return (2 * nodeIndex) + 1;
        }
        public void DisplayHeap()
        {
            Console.WriteLine("Elements of the heap:");
            for (int i = 0; i < heapSize; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine("\n***********************************");
        }
        #region Reqired methods
        public void Insert(Node value)
        {

            if (heapSize == arr.Length)
            {
                throw new Exception("Heap is at full capacity!");
            }
            else
            {
                arr[heapSize] = value;
                heapSize++;
                SiftUp(heapSize - 1);
            }
        }
        public string FindMin()
        {
            return $"Min is {arr[0]}";
        }

        public void Delete(Node value)
        {
            for (int i = 0; i < heapSize - 1; i++)
            {
                if (arr[i] == value)
                {
                    arr[i] = arr[heapSize - 1];
                    heapSize--;
                    SiftDown(i);
                    break;
                }
            }
        }
        #endregion
        private void Swap(ref Node[] input, int a, int b)
        {
            Node temp = input[a];
            input[a] = input[b];
            input[b] = temp;
        }


    }
}
