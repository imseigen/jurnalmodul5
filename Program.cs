public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {this.storedData[i]} yang disimpan  pada waktu {this.inputDates[i]}");

        }
    }  
}

class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);

        database.PrintAllData();
    }  
}