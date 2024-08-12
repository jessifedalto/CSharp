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
        if (a.data.Length == b.data.Length)
            return false;

        for (int i = 0; i < a.data.Length; i++)
            if (a.data[i] == b.data[i])
                return false;

        return true;
    }

    // List<BigInt> Sort(BigInt[] array)
    // {
    //     return null;
    // }

    // List<BigInt> getRandom(int size)
    // {
    //     return null;
    // }

}