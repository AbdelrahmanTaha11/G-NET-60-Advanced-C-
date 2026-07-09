using System.Threading.Channels;

namespace G_NET_60_Advanced_C_;

internal class Program
{
    static void Main(string[] args)
    {

        #region Question01
        //Q1: What is a generic class? Why use generics?


        // A generic class is a class that works with different data types
        // by using a type parameter (such as <T>) instead of a fixed type.

        // Why use generics?
        // 1. Code Reusability: Write one class that works with many data types.
        // 2. Type Safety: Detect type errors at compile time.
        // 3. Better Performance: Avoid boxing and unboxing with value types.
        // 4. Cleaner Code: No need for casting when retrieving data.




        #endregion

        #region Question02
        //Q2: Write a generic class Container<T> with Add and Get methods.

        //Container<int> intContainer = new Container<int>();
        //intContainer.Add(42);
        //Console.WriteLine(intContainer.Get());




        #endregion

        #region Question03

        //Q3:What are multiple type parameters? Write Pair<TKey, TValue>
        // Q3: What are multiple type parameters?

        // Multiple type parameters allow a generic class or method
        // to work with more than one data type at the same time.
        // Example: <TKey, TValue>

        //public class Pair<TKey, TValue>
        //{
        //    public TKey Key { get; set; }
        //    public TValue Value { get; set; }

        //    public Pair(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //    }
        //}


        #endregion

        #region Question04
        //Q4: What is a generic method? Write Swap<T> method.



        // A generic method is a method that works with different data types
        // by using a type parameter (such as <T>) instead of a fixed type.

        //public static void Swap<T>(ref T first, ref T second)
        //    {
        //        T temp = first;
        //        first = second;
        //        second = temp;
        //    }

        #endregion

        #region Question05

        //Q5: Write a generic method FindMax<T> that finds maximum value
        //
        //public static T FindMax<T>(T first, T second) where T : IComparable<T>
        //     {
        //return first.CompareTo(second) > 0 ? first : second;
        //     }



        #endregion

        #region Question06

        //Q6: What is a generic interface? Write IRepository<T>. 

        // A generic interface is an interface that works with different data types
        // by using a type parameter (such as <T>) instead of a fixed type.

        //public interface IRepository<T>
        //{
        //    void Add(T item);
        //    T Get(int id);
        //    void Remove(T item);
        //}


        #endregion

        #region Question07
        //Q7: What is the 'struct' constraint? Write an example.
        // The 'struct' constraint specifies that the type argument must be a value type (struct).

        //public class ValueContainer<T> where T : struct
        //{
        //    private T value;
        //    public void SetValue(T value) => this.value = value;
        //    public T GetValue() => value;
        //}

        #endregion

        #region Question08
        //Q8: What is the 'class' constraint? Write an example.

        // The 'class' constraint specifies that the type argument must be a reference type (class).

        //public class ReferenceContainer<T> where T : class
        //{
        //    private T value;
        //    public void SetValue(T value) => this.value = value;
        //    public T GetValue() => value;
        //}

        #endregion

        #region Question09

        //Q9: What is the 'new()' constraint? Write an example.

        // The 'new()' constraint specifies that the type argument must have a public parameterless constructor.

        //public class Factory<T> where T : new()
        //{
        //    public T CreateInstance()
        //    {
        //        return new T();
        //    }
        //}

        #endregion



    }
}
