using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace PhpneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size:");
            var count = int.Parse(Console.ReadLine());
            Console.Clear();
            var names = new string[count];
            var families = new string[count];
            var phones = new string[count];

            bool isPhoneValid = true;

            for (int x = 0; true;)
            {

            

               if (!isPhoneValid)
                  {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Phone number is not valid!");
                Console.CursorVisible = false;
                isPhoneValid = true;
                Thread.Sleep(3000);
                  }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = true;
            Console.Clear();

            for (int i = 0; i < count; i++)
            {
                if (names[0] != null)
                    Console.WriteLine($"{names[i]}\t{families[i]}\t{phones[i]}");
            }
            Console.WriteLine("__________________________________________");
                if (x < count)
                {
                    Console.Write("Name:");
                    names[x] = Console.ReadLine();
                    Console.WriteLine("Family:");
                    families[x] = Console.ReadLine();
                    Console.Write("Phones:");
                    var phone = Console.ReadLine();
                    if (Regex.IsMatch(phone, @"^09\d{9}$"))
                    {
                        phones[x] = phone;
                        x++;
                    }
                    else
                    {
                        names[x] = null;
                        families[x] = null;
                        isPhoneValid = false;

                    }
                }
                else
                {
                    Console.WriteLine("Phone Book is full!");
                    Console.ReadKey();
                }
            
            

            

            }
        }
    }
}
