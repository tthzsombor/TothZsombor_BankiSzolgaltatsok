namespace BankiSzolgaltatasok
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tulajdonos t = new Tulajdonos("Test Elek");
            Console.WriteLine(t);
            Bank b=new Bank();
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}