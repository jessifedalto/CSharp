using System.IO;

// List<int> list = [1,2,3,4,5,6,7,8,9];
// var query =
//     from item in list
//     where item % 2 == 0
//     group item by item % 10 into g
//     where g.Count() > 1
//     select g;


// var query2 = 
//     list.Where(i => i % 2 == 0)
//     .GroupBy(i => i % 10)
//     .Where(g => g.Count() > 1);


// List<int> list = [1,2,3,4,5,6,7,8,9];
// var query =
//     from item in list
//     where item % 2 == 0
//     group item by item % 10 into g
//     where g.Count() > 1
//     select g;


// var query2 = 
//     list.Where(i => i % 2 == 0)
//     .GroupBy(i => i % 10)
//     .Where(g => g.Count() > 1);

var teste = new CovidAnalisys();

Console.WriteLine(teste.GetAnalisys());
public class CovidAnalisys
{
    public static IEnumerable<string> GetData()
    {
        using var reader = new StreamReader("C:\\Users\\disrct\\Downloads\\INFLUD21-01-05-2023.csv");

        string line;

        while((line = reader.ReadLine()) != null)
            yield return line;
    }

    public string GetAnalisys()
    {
        int countDeathAndVaccinated = 0;
        int countDeathAndNotVaccinated = 0;

        foreach (var line in GetData())
        {
            var column = line.Split(';');
            if (column[77] is "5" && column[79] is "2")
            {
                if (column[35] is "2")
                    countDeathAndNotVaccinated++;
                
                else if (column[35] is "1")
                    countDeathAndVaccinated++;
            }
        }

        if(countDeathAndVaccinated > countDeathAndNotVaccinated)
            return "Foi vacinado e morreu";
        else
            return "Não foi vacinado e morreu";
    }
}
