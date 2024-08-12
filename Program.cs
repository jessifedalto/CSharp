namespace Aula8;

public class Program
{
    public static void Main(string[] args)
    {
        byte[] one = [1,2,3];
        byte[] two = [4,5,6];


        BigInt bigInt = new BigInt(one);
        BigInt bigInt2 = new BigInt(two);

        if (bigInt < bigInt2)
        {
            Console.WriteLine("AAAAA");
        }
    }
}