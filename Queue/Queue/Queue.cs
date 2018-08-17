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
            if (isPriority) data.Insert(0, toEnqueue);
            else { data.Add(toEnqueue); return; }
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
                System.Console.WriteLine("Peeking: " + firstInLine);
                return firstInLine;
            }

            return null;
        }

        public int GetSize()
        {
            return data.Count();
        }


        //static void Main(string[] args)
        //{
        //    Queue testQueue = new Queue();
        //    Console.WriteLine("Initial size: " + testQueue.GetSize());
        //    Object firstDequeue = testQueue.Dequeue();
        //    Console.WriteLine("Dequeue from empty queue: " + firstDequeue + " Size = " + testQueue.GetSize());
        //    testQueue.Enqueue("Hello");
        //    Console.WriteLine("After 1 enqueue... size: " + testQueue.GetSize());
        //    Object secondDequeue = testQueue.Dequeue();
        //    Console.WriteLine("Dequeue item: " + secondDequeue + " Size = " + testQueue.GetSize());
        //    testQueue.Enqueue("ABCD");
        //    testQueue.Enqueue("EFGH");
        //    testQueue.Enqueue("IJK");
        //    testQueue.Enqueue("MLNO");
        //    testQueue.PeekFirst();
        //    testQueue.Enqueue("PQRS");
        //    testQueue.Enqueue("TUV");
        //    testQueue.Enqueue("WXYZ", true);
        //    Console.WriteLine("Dequeue item: " + testQueue.Dequeue() + " Size = " + testQueue.GetSize());
        //    testQueue.PeekFirst();
            

        //    System.Threading.Thread.Sleep(20000);
        //}
    }
}
