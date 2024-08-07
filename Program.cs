// IEnumerable<int> range(int start, int end, int step)
// {
//     for (int i = start; i < end; i += step)
//         yield return i;
// }

// var str = "8";

// var num = str.ToInt(2);
// public static class MyExtnsion
// {
//     public static int ToInt(this string text, int sum) 
//     {
//         var value = int.Parse(text);
//         return value+=sum;
//     }
// }

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

List<int> list = [0, 1, 2, 3, 4, 5];

var query = list
    .Chunk(2);

foreach (var item in query)
{
    Console.WriteLine(item);
}

// Console.WriteLine(list.IsEmpty());
public static class Enumerable
{
    public static IEnumerable<T> Skip<T>(
        this IEnumerable<T> collection,
        int count)
    {
        var it = collection.GetEnumerator();
        for (int i = 0; i < count; i++)
            it.MoveNext();

        while (it.MoveNext())
            yield return it.Current;
    }

    public static IEnumerable<T> Take<T>(
        this IEnumerable<T> collection,
        int count)
    {
        var it = collection.GetEnumerator();
        for (int i = 0; i < count && it.MoveNext(); i++)
            yield return it.Current;
    }

    public static int Count<T>(this IEnumerable<T> collection)
    {
        var it = collection.GetEnumerator();
        var count = 0;
        while (it.MoveNext()) count++;

        return count;
    }

    public static T[] ToArray<T>(this IEnumerable<T> collection)
    {
        T[] a = new T[collection.Count()];

        for (int i = 0; i < collection.Count(); i++)
            a[i] = collection.ElementAt(i);

        return a;
    }

    public static bool IsEmpty<T>(this IEnumerable<T> collection)
    {
        return collection.Count() == 0 ? true : false;
    }

    public static IEnumerable<T> Prepend<T>(
        this IEnumerable<T> collection,
        T value
    )
    {
        yield return value;

        var aux = collection.GetEnumerator();
        while (aux.MoveNext())
        {
            yield return aux.Current;
        }
    }

    public static IEnumerable<T[]> Chunk<T>(
        this IEnumerable<T> collection,
        int size
    )
    {

        var a = 0;
        var b = size;
        var it = collection.GetEnumerator();
        T[] list1 = new T[size];
        for (int i = 0; it.MoveNext(); i++)
        {
            list1[i] = it.Current;

            if(i % size == 0)
                yield return list1;

            if(list1.Count() == size)
                list1 = new T[size];
        }


        a += size;
        b += size;

    }

    public static IEnumerable<(T, R)> Zip<T, R>(
        this IEnumerable<T> collection,
        IEnumerable<R> other
    ) {
        var it = collection.GetEnumerator();
        var it2 = other.GetEnumerator();

        while (it.MoveNext() && it2.MoveNext())
        {
            (T, R) tupla = (it.Current, it2.Current);
            yield return tupla;      
        }
    }
}
