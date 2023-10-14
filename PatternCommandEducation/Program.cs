using PatternCommandEducation;

public class Program
{
    static void Main()
    {
        var _concreteOrder = new List<string> { "Карбонара", "Пицца", "Суши", "Бургер", "Шаверма", "Шаверма" };
        Queue<string> _order = new Queue<string>(_concreteOrder);
        Console.WriteLine("Начало рабочего дня на кухне");
        Washer washer = new Washer(); // создал мойщика. Может содержать кучу методов
        List<ICommand> commands = new List<ICommand>() {
        new WasherCommand(washer), // прослойка в виде того, что именно мойщик делает (собирает методы в 2 команды (старта и отмена)). Реализация интерфейса
        new JuniorCookCommand("Stive",_order), // прослойка для младшего повара. Повар создаётся внутри (можно и снаружи)
        new JuniorCookCommand("Tom", _order),
        new JuniorCookCommand("Bob", _order)
        };



        ChefInvoker chef = new ChefInvoker(); // создал Вызывателя команд
        chef.SetCommand(commands); // установил команды
        chef.SendСommand(); // дал команду всем к исполнению 


        Console.WriteLine("\nКонец рабочего дня\n");
        chef.CanselСommand(); // дал команду отмены исполнения
    }
}