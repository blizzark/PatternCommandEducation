using PatternCommandEducation;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Работа на кухне");

        Washer washer = new Washer(); // создал мойщика. Может содержать кучу методов
        WasherCommand washerCommand = new(washer); // прослойка в виде того, что именно мойщик делает (собирает методы в 2 команды (старта и отмена)). Реализация интерфейса
        ChefInvoker chef = new ChefInvoker(); // создал Вызывателя команд
        chef.SetCommand(washerCommand); // установил команды
        chef.SendСommand(); // дал команду к исполнению


        Console.WriteLine("\nКонец рабочего дня\n");
        chef.CanselСommand(); // дал команду отмены исполнения
    }
}