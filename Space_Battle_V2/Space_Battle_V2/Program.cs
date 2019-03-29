using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Battle_V2
//Version 2.1.1 Created by: Brennan Sprague 3/26/2019.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //DrawScreen();
            PT_Boat.pt_Boat();

            //playerMechanics();
            Console.Read();
        }

        public static void Horizontal(int x, int y, int interval, string wallV, int bottom, int end)
        {
            int NewY = y;

            while (true)
            {
                Console.SetCursorPosition(x, NewY);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(wallV);

                if (x >= end)
                {
                    Console.SetCursorPosition(x, NewY);
                    Console.WriteLine(" ");
                    break;
                }

                NewY++;
                if (NewY > bottom)
                {
                    x += interval;
                    NewY = y;
                }
            }
        }

        public static void Vertical(int x, int y, int interval, string wallH, int bottom, int end)
        {
            int NewX = x;

            while (true)
            {
                Console.SetCursorPosition(NewX, y);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(wallH);

                if (y >= bottom)
                {
                    Console.SetCursorPosition(NewX, y);
                    Console.WriteLine(" ");
                    break;
                }

                NewX++;
                if (NewX > end)
                {
                    y += interval;
                    NewX = x;
                }
            }
        }

        public static void Numbers()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(1, 0);
            Console.WriteLine("A B");
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("C D");
            Console.SetCursorPosition(9, 0);
            Console.WriteLine("E F");
            Console.SetCursorPosition(13, 0);
            Console.WriteLine("G H");
            Console.SetCursorPosition(17, 0);
            Console.WriteLine("I J");
            Console.SetCursorPosition(21, 0);
            Console.WriteLine("K L");
            Console.SetCursorPosition(25, 0);
            Console.WriteLine("M N");
            Console.SetCursorPosition(29, 0);
            Console.WriteLine("O P");
            Console.SetCursorPosition(33, 0);
            Console.WriteLine("Q R");
            Console.SetCursorPosition(37, 0);
            Console.WriteLine("S T");

            Console.SetCursorPosition(41, 2);
            Console.WriteLine("1");
            Console.SetCursorPosition(41, 4);
            Console.WriteLine("2");
            Console.SetCursorPosition(41, 6);
            Console.WriteLine("3");
            Console.SetCursorPosition(41, 8);
            Console.WriteLine("4");
            Console.SetCursorPosition(41, 10);
            Console.WriteLine("5");
            Console.SetCursorPosition(41, 12);
            Console.WriteLine("6");
            Console.SetCursorPosition(41, 14);
            Console.WriteLine("7");
            Console.SetCursorPosition(41, 16);
            Console.WriteLine("8");
            Console.SetCursorPosition(41, 18);
            Console.WriteLine("9");
            Console.SetCursorPosition(41, 20);
            Console.WriteLine("10");


        }


        public static void DrawScreen()
        {
            Horizontal(0, 0, 2, "|", 20, 41);
            Vertical(0, 1, 2, "-", 20, 41);
            Numbers();

            #region In-Game Info
            Console.SetCursorPosition(45, 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Battleship v.1.1.5");

            Console.SetCursorPosition(62, 5);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Key");

            //Boat Info
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(62, 6);
            Console.Write("PT Boat: " + "Status: Active");

            Console.SetCursorPosition(62, 7);
            Console.Write("Submarine: " + "Status: Active");

            Console.SetCursorPosition(62, 8);
            Console.Write("Destroyer: " + "Status: Active");

            Console.SetCursorPosition(62, 9);
            Console.Write("Battleship: " + "Status: Active");

            Console.SetCursorPosition(62, 10);
            Console.Write("Carrier: " + "Status: Active");
            #endregion
        }

        public static void playerMechanics()
        {
            Player.Movement(1, 20);
            Player.gameEnd();

            #region Ship Destroyed Checker
            //HUD

            //PT
            if(Player.pt_Sunk == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(62, 6);
                Console.Write("PT Boat: " + "Status: Destroyed");
            }

            //Sub
            if(Player.subm_Sunk == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(62, 7);
                Console.Write("Submarine: " + "Status: Destroyed");
            }

            //Destroyer
            if(Player.dest_Sunk == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(62, 8);
                Console.Write("Destroyer: " + "Status: Destroyed");
            }

            //Battleship
            if(Player.batt_Sunk == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(62, 9);
                Console.Write("Battleship: " + "Status: Destroyed");
            }

            //Carrier
            if (Player.carr_Sunk == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(62, 10);
                Console.Write("Carrier: " + "Status: Destroyed");
            }
            #endregion

            if (Player.gameOver == true)
                Console.Read();
            else if (Player.gameOver == false)
                playerMechanics();
        }
    }
}
