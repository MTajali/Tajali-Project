using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XO
{
    class Program
    {
        static void print(int[,] m)
        {
           
            Console.Clear();

            char[,] temp = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (m[i, j] == 0)
                        temp[i, j] = ' ';
                    if (m[i, j] == 1)
                        temp[i, j] = 'x';
                    if (m[i, j] == 2)
                        temp[i, j] = 'o';
                }

            }

            Console.WriteLine("┌───┬───┬───┐");
            Console.WriteLine("│ " + temp[0, 0] + " │ " + temp[0, 1] + " │ " + temp[0, 2] + " │");
            Console.WriteLine("├───┼───┼───┤");
            Console.WriteLine("│ " + temp[1, 0] + " │ " + temp[1, 1] + " │ " + temp[1, 2] + " │");
            Console.WriteLine("├───┼───┼───┤");
            Console.WriteLine("│ " + temp[2, 0] + " │ " + temp[2, 1] + " │ " + temp[2, 2] + " │"); ;
            Console.WriteLine("└───┴───┴───┘");
            

            ////////////checker bazi
            for (int i = 0; i < 3; i++)
            {
                if (m[i, 0] == 2 && m[i, 1] == 2 && m[i, 2] == 2)
                {
                    Console.WriteLine("***Player 2 win!***");
                    Console.ReadKey();

                }
                else if (m[i, 0] == 1 && m[i, 1] == 1 && m[i, 2] == 1)
                {
                    Console.WriteLine("***Player 1 win!***");
                    Console.ReadKey();
                                    Environment.Exit(2);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (m[0, i] == 2 && m[1, i] == 2 && m[2, i] == 2)
                {
                    Console.WriteLine("***Player 2 win!***");
                    Console.ReadKey();

                }
                else if (m[0, i] == 1 && m[1, i] == 1 && m[2, i] == 1)
                {
                    Console.WriteLine("***Player 1 win!***");
                    Console.ReadKey();            

                }
            }
            if (m[0, 0] == 2 && m[1, 1] == 2 && m[2, 2] == 2)
            {
                Console.WriteLine("***Player 2 win!***");
                Console.ReadKey();

            }
            else if (m[0, 0] == 1 && m[1, 1] == 1 && m[2, 2] == 1)
            {
                Console.WriteLine("***Player 1 win!***");
                Console.ReadKey();

            }
            if (m[0, 2] == 2 && m[1, 1] == 2 && m[2, 0] == 2)
            {
                Console.WriteLine("***Player 2 win!***");
                Console.ReadKey();

            }
            else if (m[0, 2] == 1 && m[1, 1] == 1 && m[2, 0] == 1)
            {
                Console.WriteLine("***Player 1 win!***");
                Console.ReadKey();

            }
            if (m[0, 0] != 0 && m[0, 1] != 0 && m[0, 2] != 0 && m[1, 0] != 0 && m[1, 1] != 0 && m[1, 2] != 0 && m[2, 0] != 0 && m[2, 1] != 0 && m[2, 2] != 0)
            {
                Console.WriteLine("No Winner!");
                Console.ReadKey();

            }
        }
        static void WriteWelcom()
        {
           
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("       __        __   _                            _____      __  _____      ____                      _ ");
            Console.WriteLine(@"      \ \      / ___| | ___ ___  _ __ ___   ___  |_   ____   \ \/ / _ \    / ___| __ _ _ __ ___   ___| |");
            Console.WriteLine(@"       \ \ /\ / / _ | |/ __/ _ \| '_ ` _ \ / _ \   | |/ _ \   \  | | | |  | |  _ / _` | '_ ` _ \ / _ | |");
            Console.WriteLine(@"        \ V  V |  __| | (_| (_) | | | | | |  __/   | | (_) |  /  | |_| |  | |_| | (_| | | | | | |  __|_|");
            Console.WriteLine(@"         \_/\_/ \___|_|\___\___/|_| |_| |_|\___|   |_|\___/  /_/\_\___/    \____|\__,_|_| |_| |_|\___(_)");
            Console.CursorVisible = false;
            Thread.Sleep(5000);
            Console.Clear();
        }
        static void Main(string[] args)
        {
            WriteWelcom();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            int[,] matris = new int[3, 3];
            int member = 0, x = 0, y = 0;
            for (int i = 0; i <= 9; i++)
            {
                print(matris);
                Console.Write("Player "+ ((i % 2) + 1) + " : ");
                member = Convert.ToInt32(Console.ReadLine());
                if (member > 9)
                {
                    Console.WriteLine("Is Not Allowed");
                    member = Convert.ToInt32(Console.ReadLine());
                }
                x = (member - 1) / 3;
                y = (member - 1) % 3;
                if (matris[x, y] == 0)
                {
                    matris[x, y] = (i % 2) + 1;
                }
                else
                {
                    Console.WriteLine("Please Enter Other Number");
                    Console.ReadKey();
                    i--;
                }
            }
            
            Console.ReadKey();
        } 
        
    }
    
}
