namespace AccountTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            //Console.WriteLine(account);
            Saving saving = new Saving("nour" , 1000 , 5.0);
            //Console.WriteLine(saving);
            Checking checking = new Checking("Curly2", 5000);
            //Console.WriteLine(checking);
            Trust trust = new Trust("Batman2", 2000);
            Console.WriteLine(trust);
        }
    }
}
