using System;
using System.Threading;
namespace Slot_Game
{
    class Program
    {
        protected static int origRow;
        protected static int origCol;
        protected static void WriteAt(string s, int col, int row)
        {
            try
            {
                Console.SetCursorPosition(origCol + col, origRow + row);
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
            //WORK IN PROGRESS


        }

        private static void slots()
        {
            Random r = new Random();

            while (true)
            {
                String space = "Press Space to Spin.";

                String spinningText = "Spinning...         ";
                WriteAt(space, 0, 3);

                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Spacebar)
                {



                    WriteAt(spinningText, 0, 3);


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

                    for (int i = 0; i < 10; i++)
                    {
                        slotNumber = r.Next(1, 6);


                        slotRow[0] = slotNumber;
                        WriteAt(slotRow[0].ToString(), 0, 5);
                        Thread.Sleep(100);
                    }

                    for (int i = 0; i < 10; i++)
                    {

                        slotNumber4 = r.Next(1, 6);


                        slotRow2[0] = slotNumber4;
                        WriteAt(slotRow2[0].ToString(), 0, 6);
                        Thread.Sleep(100);
                    }

                    for (int i = 0; i < 10; i++)
                    {

                        slotNumber7 = r.Next(1, 6);


                        slotRow3[0] = slotNumber7;
                        WriteAt(slotRow3[0].ToString(), 0, 7);
                        Thread.Sleep(100);
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        slotNumber = r.Next(1, 6);
                        slotNumber2 = r.Next(1, 6);


                        slotRow[1] = slotNumber2;
                        WriteAt(slotRow[1].ToString(), 3, 5);
                        Thread.Sleep(100);
                    }
                    for (int i = 0; i < 10; i++)
                    { 
                        slotNumber5 = r.Next(1, 6);


                        slotRow2[1] = slotNumber5;
                        WriteAt(slotRow2[1].ToString(), 3, 6);
                        Thread.Sleep(100);
                    }
                    for (int i = 0; i < 10; i++)
                    {

                        slotNumber7 = r.Next(1, 6);


                        slotRow3[1] = slotNumber7;
                        WriteAt(slotRow3[1].ToString(), 3, 7);
                        Thread.Sleep(100);
                    }

                    for (int i = 0; i < 10; i++)
                    {

                        slotNumber3 = r.Next(1, 6);



                        slotRow[2] = slotNumber3;
                        WriteAt(slotRow[2].ToString(), 6, 5);
                        Thread.Sleep(100);
                    }
                    for (int i = 0; i < 10; i++)
                    {

                        slotNumber6 = r.Next(1, 6);


                        slotRow2[2] = slotNumber6;
                        WriteAt(slotRow2[2].ToString(), 6, 6);
                        Thread.Sleep(100);
                    }
                    for (int i = 0; i < 10; i++)
                    {

                        slotNumber9 = r.Next(1, 6);

                        slotRow3[2] = slotNumber9;
                        WriteAt(slotRow3[2].ToString(), 6, 7);
                        Thread.Sleep(100);
                    }
                    WinCondition(slotRow3, slotRow2, slotRow);
                }


            }
        }
        public static void WinMessage()
        {

            Console.WriteLine("You Win!");
        }
        public static void WinCondition(int[] slotRow, int[] slotRow2, int[] slotRow3)
        {
            //left column
            if (slotRow[0] == slotRow2[0] && slotRow2[0] == slotRow3[0])
            {
                WriteAt("You Win! You won in the left column!", 0, 9);
               
            }
            //middle column
            else if (slotRow[1] == slotRow2[1] && slotRow2[1] == slotRow3[1])
            {
                WriteAt("You Win! You won by the middle column!", 0, 9);
                
            }
            // right column
            else if (slotRow[2] == slotRow2[2] && slotRow2[2] == slotRow3[2])
            {
                WriteAt("You Win! You won by the right column!", 0, 9);
              
            }
            //middle row
            else if (slotRow2[0] == slotRow2[1] && slotRow2[1] == slotRow2[2])
            {
                WriteAt("You Win! You won by the middle row!", 0, 9);
               
            }
            //left diagonal
            else if (slotRow[2] == slotRow2[1] && slotRow2[1] == slotRow3[0])
            {
                WriteAt("You Win! You won by left diagonal!", 0, 9);
               
            }
            else if (slotRow[0] == slotRow2[1] && slotRow2[1] == slotRow3[2])
            {
                WriteAt("You Win! You won by right diagonal!", 0, 9);
                
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
       

    }
}

