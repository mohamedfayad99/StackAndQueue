using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__2
{
    internal class Stack_1
    {

        private int tos;
        private int[] arr;

        public Stack_1(int size)
        {
            tos = 0;
            arr = new int[size];
        }

        public void Push(int val)
        {
            if (tos == arr.Length) throw new InvalidOperationException("Stack is Full");
            tos++;
            arr[tos - 1] = val;
        }
        public int Pop()
        {
            if (tos == 0) throw new InvalidOperationException("Stack is empty");
            int val = arr[tos - 1];
            tos--;
            return val;
        }
    }
}
