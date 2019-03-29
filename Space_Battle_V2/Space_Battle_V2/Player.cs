using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Battle_V2
{
    class Player
    {
        //One Random Generator

        #region Variables
        public static string playerCoordLetter;
        public static string playerCoordNumber;

        public static int CurrentX = 0;
        public static int CurrentY = 0;

        private static int x = 0;
        private static int y = 0;
        private static int x2 = 0;

        private static int enemyX = 0;
        private static int enemyX1 = 0;
        private static int enemyX2 = 0;
        private static int enemyX3 = 0;
        private static int enemyX4 = 0;

        private static bool xSunk = false;
        private static bool x1Sunk = false;
        private static bool x2Sunk = false;
        private static bool x3Sunk = false;
        private static bool x4Sunk = false;

        private static int enemyY = 0;
        private static int enemyY1 = 0;
        private static int enemyY2 = 0;
        private static int enemyY3 = 0;
        private static int enemyY4 = 0;

        private static bool ySunk = false;
        private static bool y1Sunk = false;
        private static bool y2Sunk = false;
        private static bool y3Sunk = false;
        private static bool y4Sunk = false;

        public static bool gameOver = false;

        public static bool pt_Sunk = false;
        public static bool subm_Sunk = false;
        public static bool dest_Sunk = false;
        public static bool batt_Sunk = false;
        public static bool carr_Sunk = false;

        private static bool shipHorizontal = false;
        private static bool shipVertical = false;

        private static Random rndA = new Random();
        private static Random rndB = new Random();

        private static Random rndC = new Random();
        #endregion

        public static void Movement(int x, int y)
        {
            while (true)
            {
                Console.SetCursorPosition(53, 6);
                Console.Write("  ");
                Console.SetCursorPosition(53, 7);
                Console.Write("  ");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(45, 5);
                Console.WriteLine("Guess:");
                Console.SetCursorPosition(45, 6);
                Console.Write("Letter: ");
                playerCoordLetter = Console.ReadLine();
                Console.SetCursorPosition(45, 7);
                Console.Write("Number: ");
                playerCoordNumber = Console.ReadLine();

                #region CoordLetter
                if (playerCoordLetter == "A" || playerCoordLetter == "a")
                    x = 1;

                if (playerCoordLetter == "B" || playerCoordLetter == "b")
                    x = 3;

                if (playerCoordLetter == "C" || playerCoordLetter == "c")
                    x = 5;

                if (playerCoordLetter == "D" || playerCoordLetter == "d")
                    x = 7;

                if (playerCoordLetter == "E" || playerCoordLetter == "e")
                    x = 9;

                if (playerCoordLetter == "F" || playerCoordLetter == "f")
                    x = 11;

                if (playerCoordLetter == "G" || playerCoordLetter == "g")
                    x = 13;

                if (playerCoordLetter == "H" || playerCoordLetter == "h")
                    x = 15;

                if (playerCoordLetter == "I" || playerCoordLetter == "i")
                    x = 17;

                if (playerCoordLetter == "J" || playerCoordLetter == "j")
                    x = 19;

                if (playerCoordLetter == "K" || playerCoordLetter == "k")
                    x = 21;

                if (playerCoordLetter == "L" || playerCoordLetter == "l")
                    x = 23;

                if (playerCoordLetter == "M" || playerCoordLetter == "m")
                    x = 25;

                if (playerCoordLetter == "N" || playerCoordLetter == "n")
                    x = 27;

                if (playerCoordLetter == "O" || playerCoordLetter == "o")
                    x = 29;

                if (playerCoordLetter == "P" || playerCoordLetter == "p")
                    x = 31;

                if (playerCoordLetter == "Q" || playerCoordLetter == "q")
                    x = 33;

                if (playerCoordLetter == "R" || playerCoordLetter == "r")
                    x = 35;

                if (playerCoordLetter == "S" || playerCoordLetter == "s")
                    x = 37;

                if (playerCoordLetter == "T" || playerCoordLetter == "t")
                    x = 39;
                #endregion

                #region CoordNumber
                if (playerCoordNumber == "1")
                    y = 2;

                if (playerCoordNumber == "2")
                    y = 4;

                if (playerCoordNumber == "3")
                    y = 6;

                if (playerCoordNumber == "4")
                    y = 8;

                if (playerCoordNumber == "5")
                    y = 10;

                if (playerCoordNumber == "6")
                    y = 12;

                if (playerCoordNumber == "7")
                    y = 14;

                if (playerCoordNumber == "8")
                    y = 16;

                if (playerCoordNumber == "9")
                    y = 18;

                if (playerCoordNumber == "10")
                    y = 20;
                #endregion

                CurrentX = x;
                CurrentY = y;
                break;
            }
        }


        public static void shipOrientation()
        {
            x2 = rndC.Next(0, 10);

            if (x2 == 0 || x2 == 1)
            {
                shipHorizontal = true;
                shipVertical = false;
            }
            else if (x2 == 2 || x2 == 3)
            {
                shipHorizontal = false;
                shipVertical = true;
            }
            else if (x2 >= 4)
                shipOrientation();
        }


        public static void enemyXRand(int ship_Length)
        {
            while (true)
            {
                x = rndA.Next(2, 39);
                if (x == 1 || x == 3 || x == 5 || x == 7 || x == 9 || x == 11 || x == 13 || x == 15 || x == 17 || x == 19 || x == 21 || x == 23 || x == 25 || x == 27 || x == 29 || x == 31 || x == 33 || x == 35 || x == 37 || x == 39)
                {
                    if (x == 0)
                        enemyXRand(ship_Length);

                    else if (x != 0)
                        enemyX2 = x;

                    if (shipHorizontal == true)
                    {
                        #region PT
                        if (ship_Length == 2)
                        {
                            if (enemyX2 == 1 || enemyX2 == 3)
                            {
                                enemyX2 = 3;

                                enemyX = enemyX2 - 2;
                                enemyX1 = enemyX2;
                            }

                            else if (enemyX2 == 37 || enemyX2 == 39)
                            {
                                enemyX2 = 37;

                                enemyX = enemyX2 + 2;
                                enemyX1 = enemyX2;
                            }

                            enemyX = enemyX2 - 2;
                            enemyX1 = enemyX2;
                            break;
                        }
                        #endregion

                        #region Sub and Destroyer
                        if (ship_Length == 3)
                        {
                            if (enemyX2 == 1 || enemyX2 == 3)
                            {
                                enemyX2 = 3;

                                enemyX = enemyX2 - 2;
                                enemyX1 = enemyX2 + 2;
                            }

                            else if (enemyX2 == 37 || enemyX2 == 39)
                            {
                                enemyX2 = 37;

                                enemyX = enemyX2 - 2;
                                enemyX1 = enemyX2 + 2;
                            }

                            enemyX = enemyX2 - 2;
                            enemyX1 = enemyX2 + 2;
                        }
                        #endregion

                        #region Battleship
                        if (ship_Length == 4)
                        {
                            if (enemyX2 == 1 || enemyX2 == 3)
                            {
                                enemyX1 = 3;
                                enemyX2 = 5;

                                enemyX = enemyX1 - 2;
                                enemyX3 = enemyX2 + 2;
                            }
                            else if (enemyX2 == 37 || enemyX2 == 39)
                            {
                                enemyX1 = 33;
                                enemyX2 = 35;

                                enemyX = enemyX1 - 2;
                                enemyX3 = enemyX2 + 2;
                            }

                            enemyX = enemyX1 - 2;
                            enemyX3 = enemyX2 + 2;
                        }
                        #endregion

                        #region Carrier
                        if (ship_Length == 5)
                        {
                            if (enemyX2 == 1 || enemyX2 == 3)
                                enemyX2 = 5;

                            else if (enemyX2 == 37 || enemyX2 == 39)
                                enemyX2 = 35;

                            enemyX = enemyX2 - 4;
                            enemyX1 = enemyX2 - 2;
                            // enemyX2 is the middle of ship.
                            enemyX3 = enemyX2 + 2;
                            enemyX4 = enemyX2 + 4;
                        }
                        #endregion
                    }
                    else
                    {
                        shipHorizontal = false;
                        enemyX = x;
                        enemyX1 = 0;
                        break;
                    }
                    break;
                }
                else if (x == 0)
                {
                    enemyXRand(ship_Length);
                    break;
                }
            }

        }

        public static void enemyYRand(int ship_Length)
        {
            while (true)
            {
                y = rndB.Next(3, 20);
                if (y == 2 || y == 4 || y == 6 || y == 8 || y == 10 || y == 12 || y == 14 || y == 16 || y == 18 || y == 20)
                {
                    if (y == 0)
                        enemyYRand(ship_Length);

                    else if (y != 0)
                        enemyY2 = y;

                    if (shipVertical == true)
                    {
                        #region PT
                        if (ship_Length == 2)
                        {
                            if (enemyY2 == 1 || enemyY2 == 3)
                            {
                                enemyY2 = 3;

                                enemyY = enemyY2 - 2;
                                enemyY1 = enemyY2;
                            }

                            else if (enemyY2 == 37 || enemyY2 == 39)
                            {
                                enemyY2 = 37;

                                enemyY = enemyY2 + 2;
                                enemyY1 = enemyY2;
                            }

                            enemyY = enemyY2 - 2;
                            enemyY1 = enemyY2;
                        }
                        #endregion

                        #region Sub and Destroyer
                        if (ship_Length == 3)
                        {
                            if (enemyY2 == 1 || enemyY2 == 3)
                            {
                                enemyY2 = 5;

                                enemyY = enemyY2 - 2;
                                enemyY1 = enemyY2 + 2;
                            }

                            else if (enemyY2 == 37 || enemyY2 == 39)
                            {
                                enemyY2 = 35;

                                enemyY = enemyY2 - 2;
                                enemyY1 = enemyY2 + 2;
                            }

                            enemyY = enemyY2 - 2;
                            enemyY1 = enemyY2 + 2;
                        }
                        #endregion

                        #region Battleship
                        if (ship_Length == 4)
                        {
                            if (enemyY2 == 1 || enemyY2 == 3)
                            {
                                enemyY1 = 3;
                                enemyY2 = 5;

                                enemyY = enemyY1 - 2;
                                enemyY3 = enemyY2 + 2;
                            }
                            else if (enemyY2 == 37 || enemyY2 == 39)
                            {
                                enemyY1 = 33;
                                enemyY2 = 35;

                                enemyY = enemyY1 - 2;
                                enemyY3 = enemyY2 + 2;
                            }

                            enemyY = enemyY1 - 2;
                            enemyY3 = enemyY2 + 2;
                        }
                        #endregion

                        #region Carrier
                        if (ship_Length == 5)
                        {
                            if (enemyY2 == 1 || enemyY2 == 3)
                                enemyY2 = 5;

                            else if (enemyY2 == 37 || enemyY2 == 39)
                                enemyY2 = 35;

                            enemyY = enemyY2 - 4;
                            enemyY1 = enemyY2 - 2;
                            // enemyX2 is the middle of ship.
                            enemyY3 = enemyY2 + 2;
                            enemyY4 = enemyY2 + 4;
                        }
                        #endregion
                    }
                    else
                    {
                        shipVertical = false;
                        enemyY = y;
                        enemyY1 = 0;

                        break;
                    }
                    break;
                }

                else if (y == 0)
                {
                    enemyYRand(ship_Length);
                    break;
                }
            }
        }

        public static void gameEnd()
        {
            #region shipHorizantal
            if (shipHorizontal == true)
            {
                if (CurrentX == enemyX && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(CurrentX, CurrentY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    xSunk = true;
                }
                if (CurrentX == enemyX1 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(CurrentX, CurrentY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    x1Sunk = true;
                }

                if (CurrentX == enemyX2 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(CurrentX, CurrentY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    x2Sunk = true;
                }

                if (CurrentX == enemyX3 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(CurrentX, CurrentY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    x3Sunk = true;
                }

                if (CurrentX == enemyX4 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(CurrentX, CurrentY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    x4Sunk = true;
                }



                for(int i = 0; i < 39; i += 2)
                {

                }

                #region Left checker
                if (CurrentX == enemyX - 2 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 2, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 4 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 4, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 6 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 6, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 8 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 8, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 10 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 10, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 12 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 12, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 14 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 14, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 16 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 16, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 18 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 18, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 20 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 20, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 22 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 22, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 24 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 24, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 26 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 26, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 28 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 28, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX - 30 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX - 30, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }
                #endregion

                #region Right checker
                if (CurrentX == enemyX4 + 2 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 2, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 4 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 4, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 6 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 6, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 8 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 8, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 10 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 10, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 12 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 12, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 14 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 14, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 16 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 16, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 18 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 18, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 20 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 20, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 22 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 22, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 24 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 24, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 26 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 26, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 28 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 28, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX4 + 30 && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX4 + 30, enemyY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }
                #endregion
            }
            #endregion

            #region shipvertical
            else if (shipVertical == true)
            {
                if (CurrentX == enemyX && CurrentY == enemyY)
                {
                    Console.SetCursorPosition(enemyX, enemyY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    ySunk = true;
                }

                #region Above checker
                if (CurrentX == enemyX && CurrentY == enemyY - 2)
                {
                    Console.SetCursorPosition(enemyX, enemyY - 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY - 4)
                {
                    Console.SetCursorPosition(enemyX, enemyY - 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY - 6)
                {
                    Console.SetCursorPosition(enemyX, enemyY - 6);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY - 8)
                {
                    Console.SetCursorPosition(enemyX, enemyY - 8);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY - 10)
                {
                    Console.SetCursorPosition(enemyX, enemyY - 10);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }
                #endregion

                if (CurrentX == enemyX && CurrentY == enemyY1)
                {
                    Console.SetCursorPosition(enemyX, enemyY1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    y1Sunk = true;
                }

                if (CurrentX == enemyX && CurrentY == enemyY2)
                {
                    Console.SetCursorPosition(enemyX, enemyY2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    y2Sunk = true;
                }

                if (CurrentX == enemyX && CurrentY == enemyY3)
                {
                    Console.SetCursorPosition(enemyX, enemyY3);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    y3Sunk = true;
                }

                if (CurrentX == enemyX && CurrentY == enemyY4)
                {
                    Console.SetCursorPosition(enemyX, enemyY4);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    y4Sunk = true;
                }

                #region Below checker
                if (CurrentX == enemyX && CurrentY == enemyY4 + 2)
                {
                    Console.SetCursorPosition(enemyX, enemyY4 + 2);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY4 + 4)
                {
                    Console.SetCursorPosition(enemyX, enemyY4 + 4);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY4 + 6)
                {
                    Console.SetCursorPosition(enemyX, enemyY4 + 6);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY4 + 8)
                {
                    Console.SetCursorPosition(enemyX, enemyY4 + 8);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }

                if (CurrentX == enemyX && CurrentY == enemyY4 + 10)
                {
                    Console.SetCursorPosition(enemyX, enemyY4 + 10);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                }
                #endregion

                if (ySunk == true && y1Sunk == true && y2Sunk == true && y3Sunk == true && y4Sunk == true)
                {
                    shipHorizontal = false;
                    shipVertical = false;

                    ySunk = false;
                    y1Sunk = false;
                    y2Sunk = false;
                    y3Sunk = false;
                    y4Sunk = false;

                    enemyShipDestroyed();
                }

                else if ((CurrentX != enemyX && CurrentY != enemyY) || (CurrentX != enemyX && CurrentY != enemyY1) || (CurrentX != enemyX && CurrentY != enemyY2) || (CurrentX != enemyX && CurrentY != enemyY3) || (CurrentX != enemyX && CurrentY != enemyY4))
                {
                    Console.SetCursorPosition(CurrentX, CurrentY);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("O");
                    gameOver = false;
                    Program.playerMechanics();
                }

            }
            #endregion
        }

        public static void enemyShipDestroyed()
        {
            Console.SetCursorPosition(25, 25);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enemy ship defeated!");
            gameOver = true;
        }

    }
}