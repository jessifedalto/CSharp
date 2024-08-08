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

var dados = teste.GetAnalisys();

Console.WriteLine((float)dados.deathAndVaccinated / dados.vaccinated * 100);
Console.WriteLine((float)dados.deathAndNotVaccinated / dados.notVaccinated * 100);

public class CovidAnalisys
{
    public static IEnumerable<string> GetData()
    {
        using var reader = new StreamReader("C:\\Users\\disrct\\Downloads\\INFLUD21-01-05-2023.csv");

        string line;

        while((line = reader.ReadLine()) != null)
            yield return line;
    }

    public Data GetAnalisys()
    {
        int countDeathAndVaccinated = 0;
        int countDeathAndNotVaccinated = 0;

        int vaccinated = 0;
        int notVaccinated = 0;

        foreach (var line in GetData())
        {
            var column = line.Split(';');

            if (column[106] is "5") //pega todos os que morreram por covid
            {
                if (column[154] is "2"){
                    vaccinated++; //pega todos os que foram vacinados

                    if (column[109] is "2")
                    {
                        countDeathAndVaccinated++;
                    }
                } else {
                    notVaccinated++;
                    if (column[109] is "2")
                        countDeathAndNotVaccinated++;
                }
            } 
        }
        return new Data(vaccinated, notVaccinated, countDeathAndVaccinated, countDeathAndNotVaccinated);
    }
}
public record Data(int vaccinated, int notVaccinated, int deathAndVaccinated, int deathAndNotVaccinated);