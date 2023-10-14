using PatternCommandEducation;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Работа на кухне");

        Washer washer = new Washer(); 
        WasherCommand washerCommand = new(washer);
        ChefInvoker chef = new ChefInvoker();
        chef.SetCommand(washerCommand);
        chef.SendСommand();


        Console.WriteLine("\nКонец рабочего дня\n");
        chef.CanselСommand();
    }
}