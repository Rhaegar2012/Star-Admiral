using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Star_Admiral_V0._0
{   
    //Queue class for the A* algorithm
    class Queue
    {
        private ArrayList pqueue;
        public Queue()
        {
            pqueue = new ArrayList();
        }
        public void EnQueue(object item)
        {
            pqueue.Add(item);
        }
        public void DeQueue()
        {
            pqueue.RemoveAt(0);

        }
        public object Peek()
        {
            return pqueue[0];
        }
        public void ClearQueue()
        {
            pqueue.Clear();
        }
        public int Count()
        {
            return pqueue.Count;
        }
        
    }
}
