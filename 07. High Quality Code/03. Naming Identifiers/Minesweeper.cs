using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Minesweeper
    {
        static void Main(string[] аргументи)
        {
            string command = string.Empty;
            char[,] gameField = CreatePlayingField();
            char[,] bombs = PlaceBombs();
            int counter = 0;
            bool loseCondition = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            const int MAX_CELLS = 35;
            bool winCondition = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Lets play Minesweeper. Try to find out the fields without mines. Command 'top' shows leaderboard, 'restart' starts new game, 'exit' exits the game!");
                    CreatePlayingField(gameField);
                    flag = false;
                }
                Console.Write("Enter row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        Leaderboard(champions);
                        break;
                    case "restart":
                        gameField = CreatePlayingField();
                        bombs = PlaceBombs();
                        CreatePlayingField(gameField);
                        loseCondition = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                YourMove(gameField, bombs, row, col);
                                counter++;
                            }
                            if (MAX_CELLS == counter)
                            {
                                winCondition = true;
                            }
                            else
                            {
                                CreatePlayingField(gameField);
                            }
                        }
                        else
                        {
                            loseCondition = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError, invalid command!\n");
                        break;
                }
                if (loseCondition)
                {
                    CreatePlayingField(bombs);
                    Console.Write("\nYou have died with {0} points. Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Points currentPlayerNicknameAndScore = new Points(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayerNicknameAndScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].PlayerPoints < currentPlayerNicknameAndScore.PlayerPoints)
                            {
                                champions.Insert(i, currentPlayerNicknameAndScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Points playerOne, Points playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    champions.Sort((Points playerOne, Points playerTwo) => playerTwo.PlayerPoints.CompareTo(playerOne.PlayerPoints));
                    Leaderboard(champions);

                    gameField = CreatePlayingField();
                    bombs = PlaceBombs();
                    counter = 0;
                    loseCondition = false;
                    flag = true;
                }
                if (winCondition)
                {
                    Console.WriteLine("\nCongratulations, you have found all fields without mines.");
                    CreatePlayingField(bombs);
                    Console.WriteLine("Enter your nickname: ");
                    string nickname = Console.ReadLine();
                    Points points = new Points(nickname, counter);
                    champions.Add(points);
                    Leaderboard(champions);
                    gameField = CreatePlayingField();
                    bombs = PlaceBombs();
                    counter = 0;
                    winCondition = false;
                    flag = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("Fostata.");
            Console.Read();
        }

        private static void Leaderboard(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, points[i].Name, points[i].PlayerPoints);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty leaderboard!\n");
            }
        }

        private static void YourMove(char[,] playingField, char[,] bombs, int row, int col)
        {
            char numberOfBombs = SurroundingBombsCount(bombs, row, col);
            bombs[row, col] = numberOfBombs;
            playingField[row, col] = numberOfBombs;
        }

        private static void CreatePlayingField(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> bombPlaces = new List<int>();
            while (bombPlaces.Count < 15)
            {
                Random random = new Random();
                int location = random.Next(50);
                if (!bombPlaces.Contains(location))
                {
                    bombPlaces.Add(location);
                }
            }

            foreach (int bomb in bombPlaces)
            {
                int col = (bomb / cols);
                int row = (bomb % cols);
                if (row == 0 && bomb != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        /* not used
         private static void SetMinesCount(char[,] playingField) 
         {
             int row = playingField.GetLength(1);
             int col = playingField.GetLength(0);
            
             for (int j = 0; j < row; j++)
             {
                 for (int i = 0; i < col; i++)
                 {
                     if (playingField[i, j] != '*')
                     {
                         char surroundingBombs = SurroundingBombsCount(playingField, i, j);
                         playingField[i, j] = surroundingBombs;
                     }
                 }
             }
         } 
         */

        private static char SurroundingBombsCount(char[,] playingField, int currentRow, int currentCol)
        {
            int bombsCoutner = 0;
            int rows = playingField.GetLength(0);
            int cols = playingField.GetLength(1);

            if (currentRow - 1 >= 0)
            {
                if (playingField[currentRow - 1, currentCol] == '*')
                {
                    bombsCoutner++;
                }
            }
            if (currentRow + 1 < rows)
            {
                if (playingField[currentRow + 1, currentCol] == '*')
                {
                    bombsCoutner++;
                }
            }
            if (currentCol - 1 >= 0)
            {
                if (playingField[currentRow, currentCol - 1] == '*')
                {
                    bombsCoutner++;
                }
            }
            if (currentCol + 1 < cols)
            {
                if (playingField[currentRow, currentCol + 1] == '*')
                {
                    bombsCoutner++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol - 1 >= 0))
            {
                if (playingField[currentRow - 1, currentCol - 1] == '*')
                {
                    bombsCoutner++;
                }
            }
            if ((currentRow - 1 >= 0) && (currentCol + 1 < cols))
            {
                if (playingField[currentRow - 1, currentCol + 1] == '*')
                {
                    bombsCoutner++;
                }
            }
            if ((currentRow + 1 < rows) && (currentCol - 1 >= 0))
            {
                if (playingField[currentRow + 1, currentCol - 1] == '*')
                {
                    bombsCoutner++;
                }
            }
            if ((currentRow + 1 < rows) && (currentCol + 1 < cols))
            {
                if (playingField[currentRow + 1, currentCol + 1] == '*')
                {
                    bombsCoutner++;
                }
            }
            return char.Parse(bombsCoutner.ToString());
        }
    }
}
