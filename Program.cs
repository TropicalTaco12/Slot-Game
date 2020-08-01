using System;
using System.Threading;
namespace Slot_Game
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;
        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.WriteLine(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            origRow = 1;
            origCol = 0;
            Console.WriteLine("Welcome to the slot machine!");
            getplayerBet();
            slots();
        }


        private static void getplayerBet()
        {
            int totalChips = 100;

            Console.WriteLine("How much do you want to bet?");
            string x = Console.ReadLine();
            int currentBet = Convert.ToInt32(x);
            if (currentBet > 100 || currentBet <= 0)
            {
                Console.WriteLine("Invalid Chips, try again.");
            }

            totalChips = totalChips - currentBet;



        }

        private static void slots()
        {
            Random r = new Random();

            while (true)
            {


              

                Console.WriteLine("Press Space to spin.");

                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Spacebar)
                {
                    bool slotCheck = false;

                    int slotNumber = r.Next(1, 6);
                    int slotNumber2 = r.Next(1, 6);
                    int slotNumber3 = r.Next(1, 6);
                    int slotNumber4 = r.Next(1, 6);
                    int slotNumber5 = r.Next(1, 6);
                    int slotNumber6 = r.Next(1, 6);
                    int slotNumber7 = r.Next(1, 6);
                    int slotNumber8 = r.Next(1, 6);
                    int slotNumber9 = r.Next(1, 6);

                    int[] slotRow = new int[3];
                    int[] slotRow2 = new int[3];
                    int[] slotRow3 = new int[3];

                    slotRow[0] = slotNumber;
                    slotRow[1] = slotNumber2;
                    slotRow[2] = slotNumber3;

                    slotRow2[0] = slotNumber4;
                    slotRow2[1] = slotNumber5;
                    slotRow2[2] = slotNumber6;

                    slotRow3[0] = slotNumber7;
                    slotRow3[1] = slotNumber8;
                    slotRow3[2] = slotNumber9;

                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                         slotNumber3 = r.Next(1, 6);
                         slotNumber4 = r.Next(1, 6);
                         slotNumber5 = r.Next(1, 6);
                         slotNumber6 = r.Next(1, 6);
                         slotNumber7 = r.Next(1, 6);
                         slotNumber8 = r.Next(1, 6);
                         slotNumber9 = r.Next(1, 6);

                         slotRow = new int[3];
                         slotRow2 = new int[3];
                         slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow[0].ToString(), 0, 5);
                        Thread.Sleep(75);
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow2[0].ToString(), 0, 6);
                        Thread.Sleep(75);
                    }

                    for (int i = 0; i < 20; i++)
                    {

                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow3[0].ToString(), 0, 7);
                        Thread.Sleep(75);
                    }

                    for (int i = 0; i < 20; i++)
                    {

                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow[1].ToString(), 3, 5);
                        Thread.Sleep(75);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow2[1].ToString(), 3, 6);
                        Thread.Sleep(75);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow3[1].ToString(), 3, 7);
                        Thread.Sleep(75);
                    }

                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow[2].ToString(), 6, 5);
                        Thread.Sleep(75);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow2[2].ToString(), 6, 6);
                        Thread.Sleep(75);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        slotCheck = false;

                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);
                        slotNumber3 = r.Next(1, 6);
                        slotNumber4 = r.Next(1, 6);
                        slotNumber5 = r.Next(1, 6);
                        slotNumber6 = r.Next(1, 6);
                        slotNumber7 = r.Next(1, 6);
                        slotNumber8 = r.Next(1, 6);
                        slotNumber9 = r.Next(1, 6);

                        slotRow = new int[3];
                        slotRow2 = new int[3];
                        slotRow3 = new int[3];

                        slotRow[0] = slotNumber;
                        slotRow[1] = slotNumber2;
                        slotRow[2] = slotNumber3;

                        slotRow2[0] = slotNumber4;
                        slotRow2[1] = slotNumber5;
                        slotRow2[2] = slotNumber6;

                        slotRow3[0] = slotNumber7;
                        slotRow3[1] = slotNumber8;
                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow3[2].ToString(), 6, 7);
                        Thread.Sleep(75);
                    }

                    checkWin(slotRow, slotRow2, slotRow3, slotCheck);
                }
            }
        }

        private static void winMethod()
        {
            Console.WriteLine("Yay you win");
        }

        private static void checkWin(int[] slotRow, int[] slotRow2, int[] slotRow3, bool slotCheck)
        {
            while (slotCheck == true)
            {
                slotCheck = false;
            }
            if (slotRow[0] == slotRow2[0])
            {
                slotCheck = true;
            }
            if (slotCheck == true)
            {
                if (slotRow2[0] == slotRow3[0])
                {
                    winMethod();
                    getplayerBet();
                }
            }
            //middle vertical
            if (slotRow[1] == slotRow2[1])
            {
                slotCheck = true;
            }
            if (slotCheck == true)
            {
                if (slotRow2[1] == slotRow3[1])
                {
                    winMethod();
                    getplayerBet();
                }
            }
            //left vertical
            if (slotRow[2] == slotRow2[2])
            {
                slotCheck = true;
            }
            if (slotCheck == true)
            {
                if (slotRow2[2] == slotRow3[2])
                {
                    winMethod();
                    getplayerBet();
                }
            }
            //left diagonal
            if (slotRow[0] == slotRow2[1])
            {
                slotCheck = true;
            }
            if (slotCheck == true)
            {
                if (slotRow2[1] == slotRow3[2])
                {
                    winMethod();
                    getplayerBet();
                }
            }
            //right diagonal
            if (slotRow[2] == slotRow2[1])
            {
                slotCheck = true;
            }
            if (slotCheck == true)
            {
                if (slotRow2[1] == slotRow3[0])
                {
                    winMethod();
                    getplayerBet();
                }
            }
        }

        private static void loseCondition()
        {
            Console.WriteLine("AW, YOU LOST!!!!!!");
        }
    }
}
