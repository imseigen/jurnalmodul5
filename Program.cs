public class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic Max = a;
        if (b > Max) Max = b;
        if (c > Max) Max = c;
        return Max;

    }
    
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        int nilai = 10;
        int nilai2 = 20;
        int nilai3 = 30;
        data.DapatkanNilaiTerbesar(nilai, nilai2, nilai3);

        Console.WriteLine($"nilai Terbesar: {data.DapatkanNilaiTerbesar(nilai, nilai2, nilai3)}");
        
    }
}