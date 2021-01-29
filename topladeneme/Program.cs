using System;

namespace topladeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();

            //int sayi1 = 20;
            //int sayi2 = 30;
            //int result2 = Add3(ref sayi1, sayi2);

            //int result1= Add2(20, 30);
            //Console.WriteLine(result1);
            //Console.WriteLine(sayi1);
            //Console.ReadLine();

            Console.WriteLine(Multifly(2, 4, 3));
            Console.WriteLine(Add4(1, 6, 7, 8));


        }

        static void Add()
        {
            Console.WriteLine("Added!");

        }
        static int Add2(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            return result;
        }
        static int Add3(ref int sayi1, int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }
        static int Multifly(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();

        }
    }


}
