// Func print = Console.WriteLine;

// Func <int, int, int> printe = minhaFunc; //func retorna algo, sempre o último parametro, nesse caso int

// Action<string, int> print = minhaFunc; //retorna void
// Func <int, int, int> teste = (a, b) => a + b;
// var print = (int a, int b) => a + b;

// var chamaNVezes = (Action func, int n) => 
// {
//     for (int i = 0; i < n; i++)
//         func();
// };

// chamaNVezes(() => Console.WriteLine("Olá mundo!"), 100);

// var valor = teste(6, 5);

// int minhaFunc(int s, int n) {
//     return s + n;
// }

// public delegate void Func(string s); //delegate definir tipo de alguma coisa;

// public delegate R Func<T, R>(Task obj);

// Func<int, Func<int, int>> func = (n) =>
// {
//     return (m) => n + m;
// };

// int[] valores = [1,2,3,4,5,6,7,8,9];

// Func<int[], int, Func<int, int[]>> paginacao = (dados, tamanho) =>
// {
//     return (pagina) =>
//     {
//         int[] paginaDados = new int[tamanho];
//         Array.Copy(
//             dados, tamanho*pagina, 
//             paginaDados, 0, 
//             tamanho
//         );
//         return paginaDados;
//     };

// };

// var paginas = paginacao(valores, 4);

// var dadosDaPagina = paginas(2);

// Func<Func<int>> closure = ()  => //definição: captura uma variável que está ali
// {
//     int count = 0;
//     return () => ++count;
//     // {
//     //     count++;
//     //     return count;
//     // };
// };

// var contador = closure();
// Console.WriteLine(contador());
// Console.WriteLine(contador());
// Console.WriteLine(contador());
// Console.WriteLine(contador());
// Console.WriteLine(contador());
// Console.WriteLine(contador());

// Func<object, (Func<dynamic> data, Action<object>)> useState = (object data) =>
// {
//     var value = data;
//     return (
//         () => value, 
//         (object newValue) => value = newValue
//     );
// };

// var (value, setValue) = useState(8);
// setValue(value() + 4);

// int[] lista = [1, 2, 3, 4, 5, 6, 7, 8, 9];
// // var acc = lista.Aggregate((a, b) => a + b, 3);

// var teste = lista.Any();

// Console.WriteLine(acc);

// var even = lista.Where((element) => element % 2 == 0).Where(x => x > 2).Select(x => x * x);
// // var odd = lista.Select(x => x * x);

// string[] list = ["1", "2", "3"];

// var teste = list.Select<string, int>(int.Parse);

// foreach (var item in even)
//     Console.WriteLine(item);

// foreach (var item in lista)
// {
//     if (item % 2 == 0)
//     {
//         if (item > 2)
//         {
//             //salva valor
//         }
//     }
// }

// foreach (var item in lista)
// {
//     if (item % 2 == 0)
//     {
//         // salva o valor
//     }
// }

// foreach (var item in lista)
// {
//     if (item > 2)
//     {
//         // salva o valor 
//     }
// }


string email = "fedaltojessica@gmail.com";

var test = email.Any((x) => x.Equals('@'));

int[] list = [1,2,3,4,5];

var query = 
    from item in list 
    where item % 2 ==0
    select item * item;

Console.WriteLine(test);
public static class Enumerable
{
    public static IEnumerable<T> Where<T>(
        IEnumerable<T> collection,
        Func<T, bool> filter
    )
    {
        foreach (var item in collection)
            if (filter(item))
                yield return item;

    }

    public static IEnumerable<R> Select<T, R>(
        this IEnumerable<T> collection,
        Func<T, R> mapper
    )
    {
        foreach (var item in collection)
            yield return mapper(item);
    }

    public static IEnumerable<T> TakeWhile<T>(
        this IEnumerable<T> collection,
        Func<T, bool> predicate
    )
    {
        foreach (var item in collection)
            if (predicate(item) is true)
                yield return item;
            else
                break;
    }

    public static IEnumerable<T> SkipWhile<T>(
        this IEnumerable<T> collection,
        Func<T, bool> predicate
    )
    {
        bool isSkipping = true;
        foreach (var item in collection)
        {
            if (predicate(item) is false)
                isSkipping = false;
            if(!isSkipping)
                yield return item;
        }

        // var it = collection.GetEnumerator();
        // while (it.MoveNext() && predicate(it.Current));

        // do yield return it.Current; while (it.MoveNext());
    }

    public static T MaxBy<T>(
        this IEnumerable<T> collection,
        Func<T, double> selector
    )
    {
        var max = collection.ElementAt(0);

        foreach (var item in collection)
            if (selector(item) > selector(max))
                max = item;

        return max;
    }
    public static R Aggregate<T, R>(
        this IEnumerable<T> collection,
        Func<T, R, R> acc,
        R seed
    ) 
    {
        foreach (var item in collection)
        {
            seed = acc(item, seed);
        }

        return seed;
    }

    public static bool Any<T>(
        this IEnumerable<T> collection,
        Func<T, bool> predicate
    )
    {
        foreach (var item in collection)
            if (predicate(item))
                return true;

        return false; 
    }
}