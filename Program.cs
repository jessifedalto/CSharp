// patternMatching vou escrever mais rápido, mais fácil de expressar, programação mais entendível

List<int> list = new List<int>();

// if (obj.GetType() == typeof(List<int>))
// {
//     List<int> list1 = (List<int>)obj;
// }

// if(obj is List<int> list)
// {
//     foreach (var item in list)
//     {
//         Console.WriteLine("oui");
//     }
// }

for (int i = 0; i < 10; i++)
{
    list.Add(i);
}

if(list is [>10 and <20, 2 or 3, .., _])
{

}

int Count(IEnumerable<int> collection)
    => collection switch
    {
        ICollection<int> coll => coll.Count,
        null => 0,
        _ => collection.Count()
    };
