using PatternCommandEducation;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Работа на кухне");
        Washer washer = new Washer(); // создал мойщика. Может содержать кучу методов
        List<ICommand> commands = new List<ICommand>() {
        new WasherCommand(washer), // прослойка в виде того, что именно мойщик делает (собирает методы в 2 команды (старта и отмена)). Реализация интерфейса
        new JuniorCookCommand("Stive"), // прослойка для младшего повара. Повар создаётся внутри (можно и снаружи)
        new JuniorCookCommand("Tom"),
        new JuniorCookCommand("Bob")
        };



        ChefInvoker chef = new ChefInvoker(); // создал Вызывателя команд
        chef.SetCommand(commands); // установил команды
        chef.SendСommand(); // дал команду всем к исполнению 


        Console.WriteLine("\nКонец рабочего дня\n");
        chef.CanselСommand(); // дал команду отмены исполнения
    }
}