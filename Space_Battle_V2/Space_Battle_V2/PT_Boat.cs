using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Battle_V2
{
    class PT_Boat
    {
        #region Variables

        public static int[] pt_X_Values;
        public static int[] pt_Y_Values;
        public static bool[] pt_X_Sunk_Bool;
        public static bool[] pt_Y_Sunk_Bool;

        private static int enemyX = 0;
        private static int enemyX1 = 0;

        private static int enemyY = 0;
        private static int enemyY1 = 0;

        private static bool xSunk = false;
        private static bool x1Sunk = false;

        private static bool ySunk = false;
        private static bool y1Sunk = false;

        private static bool shipHorizontal = false;
        private static bool shipVertical = false;

        private static Random rndA = new Random();

        private static int x = 0;
        #endregion

        private static int a = 1;

        public static void pt_Boat()
        {
            int[] pt_X_Values = new int[] { 0, 0 };
            int[] pt_Y_Values = new int[] { 0, 0 };
            bool[] pt_X_Sunk_Bool = new bool[] { false, false };
            bool[] pt_Y_Sunk_Bool = new bool[] { false, false };

            shipHorizontal = true;

            XRandomizer();
            XRandom();
        }

        private static void Orientation()
        {
            x = rndA.Next(0, 10);

            if (x == 0 || x == 1)
            {
                shipHorizontal = true;
                shipVertical = false;
            }
            else if (x == 2 || x == 3)
            {
                shipHorizontal = false;
                shipVertical = true;
            }
            else if (x >= 4)
                Orientation();
        }

        private static void XRandomizer()
        {
            if (a == 1)
            {
                while (true)
                {
                    x = rndA.Next(2, 39);
                    if (x == 1 || x == 3 || x == 5 || x == 7 || x == 9 || x == 11 || x == 13 || x == 15 || x == 17 || x == 19 || x == 21 || x == 23 || x == 25 || x == 27 || x == 29 || x == 31 || x == 33 || x == 35 || x == 37 || x == 39)
                    {
                        if (x == 0)
                            XRandom();

                        else if (x != 0)
                            enemyX1 = x;
                        break;
                    }
                    else
                        return;
                }
            }
        }

        private static void XRandom()
        {
            if (enemyX1 == 1 || enemyX1 == 3)
            {
                enemyX1 = 3;
                enemyX = enemyX1 - 2;
            }

            else if (enemyX1 == 37 || enemyX1 == 39)
            {
                enemyX1 = 37;
                enemyX = enemyX1 + 2;
            }

            enemyX = enemyX1 - 2;

            else
            {
                shipHorizontal = false;
                enemyX = x;
                enemyX1 = 0;
                YRandom();
            }
        }

        private static void YRandom()
        {

        } 

        private static void Update()
        {

        }

        private static void Draw_To_Screen()
        {

        }

        private static void Hit_Miss_Checker()
        {

        }
    }
}
