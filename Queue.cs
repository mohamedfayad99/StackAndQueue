using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day__2
{
    internal class Queue
    {
        private int count;
        private List<int> list;
        public Queue(int size)
        {
            count = 0;
            list = new List<int>(size);
        }

        public void Push(int val)
        {

            if (count == list.Capacity) throw new InvalidOperationException("Stack is Full");
            count++;
            list.Add(val);
        }

        public int Pop()
        {
            int value = list[list.Capacity - count];
            count--;
            return value;
        }

    }
}
