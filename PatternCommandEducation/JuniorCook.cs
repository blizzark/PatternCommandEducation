namespace PatternCommandEducation
{
    public class JuniorCook
    {
        public string Name { get; }

        public JuniorCook(string name)
        {
            Name = name;
        }
        public void StartCooking()
        {
            Console.WriteLine($"Младший повар {Name} начал готовку");
        }
        public void StopCooking()
        {
            Console.WriteLine($"Младший повар {Name} закончил готовку");
        }
    }
}
