using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Program
    {


        //Create an 2d array to use as the gameboard, all game pieces have been manually assigned. 1 = counter 0 = gameboard
        static int[,] gameBoard = new int[8, 8] { { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 },
                                                { 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0 },
                                                { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 } };

        static string[,] testGameBoard = new string[8, 8];
        static bool counter = false;
        static bool isGameRunning = true;

        static void Main(string[] args)
        {

            drawBoard();

            //Main Game Loop
            do
            {
                //
            }
            while (isGameRunning);
        }

        static void drawBoard()
        {

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {

                    if (gameBoard[i, j] == 1)
                    {
                        testGameBoard[i, j] = " |X| ";
                        counter = true;
                    }
                    else
                    {
                        testGameBoard[i, j] = " |#| ";
                    }

                    if (i <= 2 && counter)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (i <= 4)
                        Console.ForegroundColor = ConsoleColor.White;
                    else if (i > 4 && counter)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (i > 4 && !counter)
                        Console.ForegroundColor = ConsoleColor.White;
                    counter = false;

                    //Console.WriteLine("Position ({1},{2}): {0}",gameBoard[i,j],i,j);
                    Console.Write(testGameBoard[i, j]);
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
