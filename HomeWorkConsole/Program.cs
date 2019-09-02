using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkConsole
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Введите число ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            
            do
            {

                if (Num1 == 0)
                {
                    Console.WriteLine("Число не может быть 0 ");
                    Console.WriteLine("Введите коректное число ");
                    Num1 = Convert.ToInt32(Console.ReadLine());

                }

            }
            while (Num1!=0);
            
            
            Console.WriteLine("Введите  второе число ");

        }
        
    }
}







      
            
           

          


      

