// 2. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

namespace GB  

{
    class Task2
    {
        static void Main(string[] args)
        {
        
            Console.Clear();
            int[] array = new int[8];
            FillArray(array);
            PrintArray(array);


            // void FillArray(int[] col)   // так все тоже работает
            // {
            //     for (int i = 0; i < col.Length; i++)
            //     {
            //         col[i] = new Random().Next(0,2);
            //     }
            // }

            // void PrintArray (int[] col)
            // {
            //     for (int i = 0; i < col.Length; i++)
            //     {
            //         Console.WriteLine(col[i]);
            //     }
            // }
           
           
        } 
        static void FillArray(int[] col)  //без static не работает, без public все работает, видимо по умолчанию стоит public
            {
                for (int i = 0; i < col.Length; i++)
                {
                    col[i] = new Random().Next(0,2);
                }
            }

        static void PrintArray (int[] col)   // c private тоже все работает
            {
                for (int i = 0; i < col.Length; i++)
                {
                    Console.WriteLine(col[i]);
                }
            } 
    }
}
