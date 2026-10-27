using System.ComponentModel.Design;

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
            //Console.WriteLine("Enter list of integers without doublication :)");
            //int num;
            //HashSet<int> set = new HashSet<int>();

            //try
            //{
            //    while (true)
            //    {
            //        num = Convert.ToInt32(Console.ReadLine());
            //        if (!set.Add(num))//no adding -> there is doublication :)
            //        {
            //            throw new DuplicateException(num);
            //        }
            //    }
            //}
            //catch (DuplicateException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            /*
             2. Write a C# program to create a method that takes a string as input
                and throws an exception 
                if the string does not contain vowels.
             */
            Console.WriteLine("enter a string contain vowels:");
            string input = Console.ReadLine().ToLower();
            try
            {
                CheckString(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    Console.WriteLine("end");
            //}
            

        }
            #region Q02
            public static void CheckString(string input)
            {

                bool containVowels = false;
                for (int i = 0; i < input.Length; i++)
                    if (input[i] == 'a' || input[i] == 'i' || input[i] == 'o' || input[i] == 'e' || input[i] == 'u')
                    {
                        containVowels = true;
                        break;
                    }
                if (containVowels)
                    Console.WriteLine("this string contains vowels :)");

                else
                    throw new Exception("this string doesnot contain vowels :(");
            }

            #endregion
    }
}
