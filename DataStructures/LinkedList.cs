namespace DataStructures
{
    using System;
    //using System.Collections.Generic;

    public class LinkedList<T>
    {
        private int count;

        public LinkedList()
        {
            this.FirstItem = null;
            this.count = 0;
        }

        public T First
        {
            get { return this.FirstItem.Value; }
        }

        public T Last
        {
            get { return this.LastItem.Value; }
        }

        public int Count
        {
            get { return this.count; }
        }

        private ListItem<T> FirstItem { get; set; }

        private ListItem<T> LastItem { get; set; }

        public void AddFirst(T value)
        {
            if (this.FirstItem == null)
            {
                this.FirstItem = new ListItem<T>(value);
                this.LastItem = this.FirstItem;
            }
            else
            {
                var oldItem = this.FirstItem;
                this.FirstItem = new ListItem<T>(value, oldItem);
            }

            this.count++;
        }

        public void AddLast(T value)
        {
            if (this.LastItem == null)
            {
                this.LastItem = new ListItem<T>(value);
                
                if (this.FirstItem == null && this.count == 0)
                {
                    this.FirstItem = this.LastItem;
                }
            }
            else
            {
                var oldItem = this.LastItem;
                this.LastItem = new ListItem<T>(value, null, oldItem);
                oldItem.NextItem = this.LastItem;
            }

            this.count++;
        }

        public T RemoveFirst()
        {
            if (this.FirstItem == null)
            {
                throw new ArgumentNullException("Cannot remove from empty list!");
            }

            var oldItem = this.FirstItem;
            if (this.count == 1)
            {
                RemoveLastElement();
            }
            else
            {
                this.FirstItem = oldItem.NextItem;
                this.FirstItem.PrevItem = null;
                this.count--;
            }

            return oldItem.Value;
        }

        public T RemoveLast()
        {
            if (this.LastItem == null)
            {
                throw new ArgumentNullException("Cannot remove from empty list!");
            }

            var oldItem = this.LastItem;
            if (this.count == 1)
            {
                RemoveLastElement();
            }
            else 
            {
                this.LastItem = oldItem.PrevItem;
                this.LastItem.NextItem = null;
                this.count--;
            }
            
            return oldItem.Value;
        }

        private void RemoveLastElement()
        {
            this.FirstItem = null;
            this.count = 0;
        }

        public bool Contains(T value)
        {
            bool isContained = false;
            var currentElement = this.FirstItem;

            while (currentElement != null)
            {
                if (currentElement.Equals(value))
                {
                    isContained = true;
                    break;
                }

                currentElement = currentElement.NextItem;
            }

            return isContained;
        }

        public System.Collections.Generic.List<T> ToList()
        {
            var list = new System.Collections.Generic.List<T>();
            var currentElement = this.FirstItem;

            while (currentElement != null)
            {
                list.Add(currentElement.Value);
                currentElement = currentElement.NextItem;
            }

            return list;
        }
    }
}
