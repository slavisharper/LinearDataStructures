namespace DataStructures
{
    public class ListItem<T>
    {
        public ListItem(T value, ListItem<T> nextItem = null, ListItem<T> prevItem = null)
        {
            this.Value = value;
            this.NextItem = nextItem;
            this.PrevItem = prevItem;
        }

        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }

        public ListItem<T> PrevItem { get; set; }
    }
}
