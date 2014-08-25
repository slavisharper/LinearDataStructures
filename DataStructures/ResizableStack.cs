namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ResizableStack<T>
    {
        private const int InitialSize = 4;
        private const int IncreasmentStep = 2;

        private T[] stack;
        private int count;

        public ResizableStack() : this(InitialSize)
        {
        }

        public ResizableStack(int size)
        {
            this.stack = new T[size];
            this.count = 0;
        }

        public ResizableStack(ICollection<T> collection) 
            : this(collection.Count)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Empty or null collection is passed!");
            }

            if (collection.Count < 5)
            {
                this.stack = new T[InitialSize];
            }

            collection.CopyTo(this.stack, 0);
            this.count = collection.Count;
        }

        public int Count 
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.stack.Length; }
        }

        public void Push(T element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("Empty or null element cannot be added!");
            }

            if (this.stack.Length == this.count)
            {
                IncreaseSize();
            }

            this.stack[this.count] = element;
            count++;

            if (this.stack.Length == this.count)
            {
                IncreaseSize();
            }
        }

        public T Pop()
        {
            if (this.count == 0)
	        {
		        throw new ArgumentException("Stack is empty!");
	        }

            this.count--;
            T element = this.stack[this.count];
            this.stack[this.count] = default(T);
            return element;
        }

        public T Peek()
        {
            if (this.count == 0)
	        {
		        throw new ArgumentException("Stack is empty!");
	        }

            T element = this.stack[this.count - 1];
            return element;
        }

        public void Clear()
        {
            this.count = 0;
            this.stack = new T[this.stack.Length];
        }

        public bool Contains(T element)
        {
            bool isInStack = false;
            if (this.stack.Contains(element))
            {
                isInStack = true;
            }

            return isInStack;
        }

        public T[] ToArray() 
        {
            var array = this.Trim();
            return array;
        }

        public void TrimExcess() 
        {
            this.stack = this.Trim();
        }

        private void IncreaseSize()
        {
            var largerStack = new T[this.stack.Length * IncreasmentStep];
            this.stack.CopyTo(largerStack, 0);
            this.stack = largerStack;
        }

        private T[] Trim() 
        {
            var trimmedStack = new T[this.count];

            for (int i = 0; i < this.count; i++)
            {
                trimmedStack[i] = this.stack[i];
            }

            return trimmedStack;
        }
    }
}
