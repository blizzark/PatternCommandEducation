namespace PatternCommandEducation
{
    public class JuniorCook
    {
        public string Name { get; }

        public JuniorCook(string name)
        {
            Name = name;
        }
        public void StartCooking(string? dish)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // лучше в отдельный метод, т.к. может что-то прийти в момент исполнения, но не суть сейчас
            Console.WriteLine($"Младший повар {Name} начал готовку блюда: {dish}");
            Thread.Sleep((new Random()).Next(1000, 3000));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Младший повар {Name} закончил готовку блюда: {dish}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void StopCooking()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Младший повар {Name} закончил готовку");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
