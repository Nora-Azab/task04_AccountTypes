namespace ExceptionHandelingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            /*
                 1. Write a C# program that reads a list of integers from the user
                   and throws an exception 
                   if any numbers are duplicates.
                 */
            Console.WriteLine("Enter list of integers without doublication :)");
            int num;
            HashSet<int> set = new HashSet<int>();

            try
            {
                while (true)
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (!set.Add(num))//no adding -> there is doublication :)
                    {
                        throw new DuplicateException(num);
                    }
                }
            }
            catch (DuplicateException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            #endregion
        }
    }
}
