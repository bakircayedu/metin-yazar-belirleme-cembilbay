using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_ödev2
{
    public class Max_Heap
    {
        private readonly int[] elements;
        private int size;

        public Max_Heap(int size)
        {
            elements = new int[size];
        }

        private int GetLeftChildIndex(int elementIndex) => 2 * elementIndex + 1;
        private int GetRightChildIndex(int elementIndex) => 2 * elementIndex + 2;
        private int GetParentIndex(int elementIndex) => (elementIndex - 1) / 2;

        private bool HasLeftChild(int elementIndex) => GetLeftChildIndex(elementIndex) < size;
        private bool HasRightChild(int elementIndex) => GetRightChildIndex(elementIndex) < size;
        private bool IsRoot(int elementIndex) => elementIndex == 0;

        private int GetLeftChild(int elementIndex) => elements[GetLeftChildIndex(elementIndex)];
        private int GetRightChild(int elementIndex) => elements[GetRightChildIndex(elementIndex)];
        private int GetParent(int elementIndex) => elements[GetParentIndex(elementIndex)];

        private void Swap(int firstIndex, int secondIndex)
        {
            var temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int Peek()
        {
            if (size == 0)
                throw new IndexOutOfRangeException();

            return elements[0];
        }

        public int Pop()
        {
            if (size == 0)
                throw new IndexOutOfRangeException();

            var result = elements[0];
            elements[0] = elements[size - 1];
            size--;

            ReCalculateDown();

            return result;
        }

        public void Add(int element)
        {
            if (size == elements.Length)
                throw new IndexOutOfRangeException();

            elements[size] = element;
            size++;

            ReCalculateUp();
        }

        private void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (elements[biggerIndex] < elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        private void ReCalculateUp()
        {
            var index = size - 1;
            while (!IsRoot(index) && elements[index] > GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
        public int RemoveMax()
        {
            var root = elements[0];
            elements[0] = elements[--size];
            ReCalculateDown();
            return root;
        }
    }
}
