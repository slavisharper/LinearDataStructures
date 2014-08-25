namespace DataStructures
{
    using System;

    public class LinkedQueue<T>
    {
        private int count;
        private LinkedList<T> elements;

        public LinkedQueue()
        {
            this.elements = new LinkedList<T>();
        }

        public int Count 
        {
            get { return this.count; } 
        }

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
            this.count++;
        }

        public T Dequeue() 
        {
            ChechForEmptyQueue();

            T element = this.elements.RemoveFirst();
            this.count--;
            return element;
        }

        public T Peek()
        {
            ChechForEmptyQueue();

            T element = this.elements.First;
            return element;
        }

        public void Clear()
        {
            this.elements = new LinkedList<T>();
            this.count = 0;
        }

        public bool Contains(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Null element passed to the queue!");
            }

            if (this.count <= 0)
            {
                return false;
            }

            bool isElementInQueue = this.elements.Contains(element);
            return isElementInQueue;
        }

        private void ChechForEmptyQueue()
        {
            if (this.count <= 0)
            {
                throw new ArgumentNullException("Queue is empty!");
            }
        }
    }
}
