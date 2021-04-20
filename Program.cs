using System;

namespace controlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            if(num == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if(num == 20)
            {
                Console.WriteLine("number is 20");
            }
            else if(num == 30)
            {
                Console.WriteLine("number is 30");
            }
            else
            {
                Console.WriteLine("type in a number");
            }

            int numb2 = 20;
            switch(numb2)
            {
                case 10:
                Console.WriteLine("Number is 10");
                break;
                case 20:
                Console.WriteLine("Number is 20");
                break;
                case 30:
                Console.WriteLine("number is 30");
                break;
                default:
                Console.WriteLine("Invalid Number");
                break;
            }

            //int a = 10;
            // while(a < 20)
            // {
            //     Console.WriteLine($"value of a : {a}");
            //     a++; //also a = a + 1
            // }
            
            
            // do{
            //     Console.WriteLine($"value of a : {a}");
            //     a++; //also a = a + 1
            // }
            // while(a > 20);

            for(int i =15; i > 0; i-= 5)
            {
                Console.WriteLine(i);
            }

            string[] cars = {"volvo", "bmw", "benz", "ford", "mazda"};
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
