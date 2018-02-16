using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type ISBN: ");
            string isbn = Console.ReadLine();
            //string isbn = Generate();
            //Console.WriteLine(isbn);
            if (Valid(isbn))
                Console.WriteLine("This ISBN is a valid ");
            else
                Console.WriteLine("This ISBN isn't valid");
            Console.ReadLine();
        }
        public static bool Valid(string isbn)
        {
            isbn = isbn.Replace("-", "");
            if (isbn.Length != 10) return false;
            int sum = 0;
            for (int i = 10; i>0; i--)
            {
                if (isbn[10-i] == 'X')
                {
                    sum += 10;
                }
                else
                {
                    sum += (Int32.Parse(isbn[10 - i]) * i);
                }
            }
            if (sum % 11 == 0) return true;
            else return false;
        }
            public static string Generate()
        {
            string isbn = "";
            int summ = 0;
            int a = 0;
            int b = 0;
            Random r = new Random();
            for (int i = 0; i<9; i++)
            {
                b = r.Next(0,9);
                summ += b * (10 - i);
                isbn += b.ToString();
            }
            a = 11 - (summ % 11); 
            if (a < 10)
            {
                isbn += a.ToString();
            }
            else
            {
                isbn += 'X';
            }
            return isbn;
        }

    }
    
}
