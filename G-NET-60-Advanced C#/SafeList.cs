
namespace G_NET_60_Advanced_C_
{
    internal class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default;
            }
            return items[index];
        }
    }
}
