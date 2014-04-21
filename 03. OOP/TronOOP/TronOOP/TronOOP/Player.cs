using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TronOOP
{
    public class Player
    {
        public Player(int x, int y, char symbol, ConsoleKey left, ConsoleKey right, ConsoleKey up, ConsoleKey down)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;
            this.Left = left;
            this.Right = right;
            this.Up = up;
            this.Down = down;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public char Symbol { get; set; }

        public ConsoleKey Left { get; set; }

        public ConsoleKey Right { get; set; }

        public ConsoleKey Up { get; set; }
        
        public ConsoleKey Down { get; set; }

        public void Move(ConsoleKeyInfo key)
        {
            if (key.Key == Left)
            {
                this.X--;
            }
            if (key.Key == Right)
            {
                this.X++;
            }
            if (key.Key == Up)
            {
                this.Y--;
            }
            if (key.Key == Down)
            {
                this.Y++;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.Symbol);
        }
    }
}
