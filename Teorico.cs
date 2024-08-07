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
// var acc = lista.Aggregate((a, b) => a + b, 3);

// var teste = lista.Any();

// Console.WriteLine(acc);

// var even = lista.Where((element) => element % 2 == 0).Where(x => x > 2).Select(x => x * x);
// // var odd = lista.Select(x => x * x);

// string[] list = ["1", "2", "3"];

// // var teste = list.Select<string, int>(int.Parse);

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