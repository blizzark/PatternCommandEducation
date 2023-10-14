namespace PatternCommandEducation
{
    public class Washer
    {
        public void StartWash()
        {
            Console.WriteLine("Мойщик начал мыть посуду");
        }
        public void StopWash()
        {
            Console.WriteLine("Мойщик закончил мыть посуду");
        }

        public Washer RunInShop()
        {
            Console.WriteLine("Мойщик побежал в магазин");
            Console.WriteLine("Мойщик выбирает средство для мытья посуды");
           return this;
          
        }

        public void BuyChemistry()
        {
            Console.WriteLine("Мойщик покупает средство");
        }

        public void RunInRestoran()
        {
            Console.WriteLine("Мойщик бежит обратно");
            Console.WriteLine("Мойщик прибежал в магазин");
        }


    }
}
