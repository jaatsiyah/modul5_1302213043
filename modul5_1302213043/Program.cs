public class SimpleDataBase<T>
{
    private List<T> storedData;

    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        inputDates= new List<DateTime>();   
        storedData = new List<T>();
    }

    public void AddNewdata(T storedData)
    {
        this.storedData.Add(storedData);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllaData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi : " + storedData[i] + 
                ", yang disimpan pada waktu UTC: " + inputDates[i].ToString());
        }
    }
}

public class Program
{
    static void Main(string[] args)
    {

        SimpleDataBase<int> storedData = new SimpleDataBase<int>();
        storedData.AddNewdata(12);
        storedData.AddNewdata(34);
        storedData.AddNewdata(56);

        storedData.PrintAllaData();
    }
}