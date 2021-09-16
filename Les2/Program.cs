using System;
//Задачники file:///C:/Users/user/Downloads/ProblemBook.NET-ru.pdf 
// https://c-sharp.pro/?p=1781
namespace Les2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Перестановка 
            int a = 1;
            int b = 2;
            int c = 3;
            Console.WriteLine($"{a}\t{b}\t{c}");

            int tmp;
            tmp = b;
            b = c;
            c = a;
            a = tmp;
            Console.WriteLine();
            Console.WriteLine($"{a}\t{b}\t{c}");

            tmp = b;
            b = a;
            a = c;
            c = tmp;
            Console.WriteLine();
            Console.WriteLine($"{a}\t{b}\t{c}");

            //https://c-sharp.pro Умножение
            
            Console.WriteLine("Input X");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int res;

            //a
            int xx;
            xx = x * x ;
            res = xx * xx ;
            Console.WriteLine($"X в 4 степени {res}");
           
            //b
            int xx1;
            xx = x * x;
            xx1 = xx * xx;
            res = xx1 * xx;
            Console.WriteLine($"X в 6 степени { res}");
            
            //c
            int res1;
            xx = x * x;
            xx1 = xx * xx;
            res1 = xx1 * xx;
            res = res1 * x;
            Console.WriteLine($"X в 7 степени {res}");
            
            //d
            xx = x * x;
            xx1 = xx * xx;
            res = xx1 * xx1;
            Console.WriteLine($"X в 8 степени {res}");
            
            //e
            xx = x * x;
            xx1 = xx * xx;
            res1 = xx1 * xx1;
            res = res1 * x ;
            Console.WriteLine($"X в 9 степени {res}");
            
            //f
            xx = x * x;
            xx1 = xx * xx;
            res1 = xx1 * xx1;
            res = res1 * xx;
            Console.WriteLine($"X в 10 степени {res}");

            //https://c-sharp.pro S3.4

            //a
            int res3;
            int res10;
            xx = x * x;
            res3 = xx * x;
            res = res3 * xx;
            res10 = res * res;
            Console.WriteLine($"X в 3 и 10 степени {res3} и {res10}");

            //b
            int res20;
            int res4;
            xx = x * x;
            res4 = xx * xx;
            res1 = res4 * res4;
            res = res1 * xx;
            res20 = res * res;
            Console.WriteLine($"X в 4 и 20 степени {res4} и {res20}");
            
            //c
            int res5;
            int res13;
            xx = x * x;
            res = xx * xx;
            res5 = res * x;
            xx = res5 * res;
            res13 = xx * res;
            Console.WriteLine($"X в 5 и 13 степени {res5} и {res13}");
            
            //e
            int res19;
            int tmp1;
            xx = x * x;
            res = xx * xx;
            res5 = res * x;
            tmp1 = res5 * res;
            tmp = res5 * res5;
            res19 = tmp * tmp1 ;
            Console.WriteLine($"X в 5 и 19 степени {res5} и {res19}");

            //f
            int res2;
            int res17;
            res2 = x * x;
            res = res2 * res2;
            res5 = res * x;
            tmp = res * res;
            tmp1 = tmp * x;
            res17 = tmp*tmp1 ;
            Console.WriteLine($"X в 2,5 и 17 степени {res2},{res5} и {res17}");

        }
    }
}
