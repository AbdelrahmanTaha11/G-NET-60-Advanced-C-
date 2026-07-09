
namespace G_NET_60_Advanced_C_
{
    internal class Container<T>
    {
        public T? item { get; set; }
         

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        {
            return item;
        }

    }
}
