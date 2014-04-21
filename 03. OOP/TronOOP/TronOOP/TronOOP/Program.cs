using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TronOOP
{
    public class Program
    {
        const int windowWidth = 100;
        const int windowHeight = 40;
        const char playerOneSymbol = '*';
        const char playerTwoSymbol = '*';

        static void Main()
        {

            Console.WindowWidth = windowWidth;
            Console.BufferWidth = windowWidth;

            Console.WindowHeight = windowHeight;
            Console.BufferHeight = windowHeight;

            var playerOne = new Player(1, windowHeight/2, playerOneSymbol,ConsoleKey.A, ConsoleKey.D, ConsoleKey.W, ConsoleKey.S);
            var playerTwo = new Player(windowWidth-1, windowHeight/2, playerTwoSymbol, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.UpArrow, ConsoleKey.DownArrow);

            while (true)
            {
                playerOne.Move(Console.ReadKey());
                playerOne.Draw();
                playerTwo.Move(Console.ReadKey());
                playerTwo.Draw();
                Thread.Sleep(50);
            }
        }
    }
}
