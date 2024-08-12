using System.Data;

namespace Aula8;

public class BigInt
{
    public byte[] data { get; set; }

    public BigInt(byte[] array)
    {
        data = array;
    }

    public static bool operator >(BigInt a, BigInt b) 
    {
        if (a.data.Length > b.data.Length)
            return true;
        
        else if (a.data.Length < b.data.Length)
            return false;

        for (int i = 0; i < a.data.Length; i++)
            if (a.data[i] > b.data[i])
                return true;
    
        return false;
    }

    public static bool operator <(BigInt a, BigInt b) 
    {
        if (a.data.Length < b.data.Length)
            return true;
        
        else if (a.data.Length > b.data.Length)
            return false;

        for (int i = 0; i < a.data.Length; i++)
            if (a.data[i] < b.data.Length)
                return true;
            
        return false;
    }

    public static bool operator ==(BigInt a, BigInt b) 
    {
        if (a.data.Length != b.data.Length)
            return false;

        for (int i = 0; i < a.data.Length; i++)
            if (a.data[i] != b.data[i])
                return false;

        return true;
    }

    public static bool operator !=(BigInt a, BigInt b) 
    {
        return !(a == b);
    }

    public static List<BigInt> ParallelMergeSort(List<BigInt> array)
    {
        if (array.Count <= 1)
            return array;

        int middle = array.Count / 2;

        var left = array.GetRange(0, middle);
        var right = array.GetRange(middle, array.Count - middle);

        Parallel.Invoke(
            () => left = ParallelMergeSort(left),
            () => right = ParallelMergeSort(right)
        );

        return Merge(left, right);
    }

    private static List<BigInt> Merge(List<BigInt> left, List<BigInt> right)
    {
        List<BigInt> result = new List<BigInt>();

        while(left.Count > 0 && right.Count > 0)
        {
            if (left[0] < right[0])
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        result.AddRange(left);
        result.AddRange(right);

        return result;
    }

    public static List<BigInt> GetRandom(int size, int numberOfDigits)
    {
        Random random = new Random();
        List<BigInt> randomList = new List<BigInt>();

            for (int i = 0; i < size; i++)
            {
                byte[] bytes = new byte[numberOfDigits];
                random.NextBytes(bytes);
                randomList.Add(new BigInt(bytes));
            }

            return randomList;
    }

}