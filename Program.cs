namespace sd_knowledge_check_2
{
    internal class Program
    {static void Main()
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine(String));

        var recordList = new List<Catfood>(Product); 

        for (int i = 0; i < numberOfRecords; i++)
        {
            var myClass = new CatFood(Product); 

            Console.WriteLine("Enter the value for myProperty:");
            myClass.myProperty = Console.ReadLine(String);

            recordList.Add(CatFood);
        }

        Console.WriteLine("Records added:");

        foreach (var record in recordList)
        {
            Console.WriteLine(record); 
    }
}
        }
    }
}