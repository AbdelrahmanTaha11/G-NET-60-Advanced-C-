using System.ComponentModel;
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

        #region Question10

        //Q10: What is the interface constraint? Write an example.

        // The interface constraint specifies that the type argument must implement a particular interface.

        //public interface IRepository<T>
        //{
        //    void Add(T item);
        //    T Get(int id);
        //    void Remove(T item);
        //}

        //public class Repository<T> where T : IRepository<T>
        //{
        //    private List<T> items = new List<T>();
        //    public void Add(T item) => items.Add(item);
        //    public T Get(int id) => items[id];
        //    public void Remove(T item) => items.Remove(item);
        //}

        #endregion


        #region Question11

        //Q11: What is the base class constraint? Write an example.

        // The base class constraint specifies that the type argument must be or derive from a particular base class.

        //public class BaseEntity
        //{
        //    public int Id { get; set; }
        //}

        //public class Repository<T> where T : BaseEntity
        //{
        //    private List<T> items = new List<T>();
        //    public void Add(T item) => items.Add(item);
        //    public T Get(int id) => items.FirstOrDefault(item => item.Id == id);
        //    public void Remove(T item) => items.Remove(item);
        //}

        #endregion

        #region Question12

        //Q12: How do you apply multiple constraints? Write an example. 

        // Multiple constraints allow a generic type to satisfy
        // more than one condition at the same time.
        // Constraints are separated by commas     


        //    public class Repository<T> where T : class, IComparable<T> , new()
        //{
        //    public T Create()
        //    {
        //        return new T();
        //    }
        //}



        #endregion

        #region Question13

        //Q13: What does the 'default' keyword do in generics?

        // Q13: What does the 'default' keyword do in generics?

        // The 'default' keyword returns the default value of a generic type.
        // For value types: 0, false, '\0', etc.
        // For reference types: null.

        //public static T GetDefault<T>()
        //    {
        //        return default;
        //    }

        #endregion

        #region Question14

        //Q14: Write a SafeList<T> that returns default when the index is invalid.

        //public class SafeList<T>
        //{
        //    private List<T> items = new List<T>();
        //    public void Add(T item) => items.Add(item);
        //    public T Get(int index)
        //    {
        //        if (index < 0 || index >= items.Count)
        //        {
        //            return default;
        //        }
        //        return items[index];
        //    }
        //}

        #endregion

        #region Question15

        //Q15: What is covariance? Explain the 'out' keyword.

        // Q15: What is covariance? Explain the 'out' keyword.

        // Covariance allows using a more derived type
        // where a base type is expected.

        // The 'out' keyword makes a generic type parameter covariant.
        // It can only be used for output (return values), not input parameters.

        //public interface IProducer<out T>
        //    {
        //        T GetItem();
        //    }
        #endregion

        #region Question16

        //Q16: What is contravariance? Explain the 'in' keyword.



        // Contravariance allows using a base type
        // where a more derived type is expected.

        // The 'in' keyword makes a generic type parameter contravariant.
        // It can only be used for input parameters, not return values.

        //public interface IConsumer<in T>
        //    {
        //        void Process(T item);
        //    }


        #endregion

        #region Question17
        //Q17: What is the difference between covariance and contravariance?
        // Covariance allows a method to return a more derived type than originally specified.
        // Contravariance allows a method to accept parameters of a less derived type than originally specified.
        #endregion

        #region Question18

        //Q18: How do static members work in generic types?


        // Each closed generic type has its own copy of static members.
        // For example, Generic<int> and Generic<string>
        // have separate static fields.

        //public class GenericCounter<T>
        //    {
        //        public static int Count;

        //        public GenericCounter()
        //        {
        //            Count++;
        //        }
        //    }




        #endregion

        #region Question19

        //Q19: How can you inherit from a generic class?

        // You can inherit from a generic class by specifying the type parameter(s) in the derived class.


        #endregion




    }
}
