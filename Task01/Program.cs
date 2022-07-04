// 1. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            Console.WriteLine("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int results = GetMultiplication(number);
            Console.WriteLine(results);
           
           
        }
        public static int GetMultiplication(int a)
        {
            int result = 1;
            for (int i = 1; i <= a; i++)
            {
                result = result*i;
            } 
            return result;
        }  
    }
}