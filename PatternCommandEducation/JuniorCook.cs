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
            Console.WriteLine($"Младший повар {Name} начал готовку блюда: {dish}");
            Thread.Sleep((new Random()).Next(1000, 3000));
            Console.WriteLine($"Младший повар {Name} закончил готовку блюда: {dish}");
        }
        public void StopCooking()
        {
            Console.WriteLine($"Младший повар {Name} закончил готовку");
        }
    }
}
