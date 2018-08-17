using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        // inserts and removes nodes in first-in-first-out (FIFO) order //
        private List<Object> data = new List<Object>();

        public void Enqueue(Object toEnqueue)
        {
            data.Add(toEnqueue);
        }

        public void Enqueue(Object toEnqueue, bool isPriority)
        {
            if (!isPriority) { data.Add(toEnqueue); return; }

            data.Insert(0, toEnqueue);
        }

        public Object Dequeue()
        {
            if (this.GetSize() > 0)
            {
                Object firstInLine = data[0];
                data.RemoveAt(0);
                return firstInLine;
            }

            return null;
        }

        public Object PeekFirst()
        {
            if (this.GetSize() > 0)
            {
                Object firstInLine = data[0];
                return firstInLine;
            }

            return null;
        }

        public int GetSize()
        {
            return data.Count();
        }


        static void Main(string[] args)
        {


        }
    }
}
