using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkanoidMain
{
	class Arkanoid
	{
		#region DefineGlobalVariables
		const int left = 0;
		const int right = 1;
		static int fieldHeight = 35;
		static int fieldWidth = 90;
		static int sidebar = 15;

		//Pad
		static int padDirection = right;
		static int padSize = 22;
		static string padSymbol = "\u2588";
		static int padRow = 0;
		static int padCol = 0;
		static int padEnd = 0;
		static ConsoleColor padColor = ConsoleColor.Blue;
		static int padValue = 100;

		//Ball
		static string ballSymbol = "\u0001"; //"\u25CF"
		static int ballRow = 0;
		static int ballCol = 0;

		//Ball horizontal and vertical direction
		static bool goRight = true; //true - right, false - left
		static bool goUp = true; // true - up, false - down
		static int previousBallRow = ballRow;
		static int previousBallCol = ballCol;
		static ConsoleColor ballColor = ConsoleColor.White;

		//Bricks
		static int[,] bricksNPads;
		static string brickSymbol = "\u25A0";
		static int firstBrickRow = 4;
		static int lastBrickRow = 12;
		static int firstBrickCol = 5;
		static int lastBrickCol = 84;
        static int bricksDestroyed = 0;
        static int totalBricks;

		//Game info
		static int lives = 3;
		static int score = 0;
		static int chosenLevel;
		static int threadSpeed = 0;
		static int playerSpeed = 0;
		static bool gameOver = false;
        static bool levelFinished = false;
		static bool resumeGame = false;
		static Stopwatch stopwatch = new Stopwatch ();
        static int position = 0;
        static string playerName = "";
		//Bonuses
		static char[] bonuses = { '-', '+', '♥', 'X', 'F', 'S' };
		// + get longer , - get shorter, L - new life, X - kills, F - faster ball, S - slower ball, 
		static ConsoleColor[] colors = // each color coresponds to a bonus item
        {
        ConsoleColor.Green,
        ConsoleColor.Yellow,
        ConsoleColor.Red,
        ConsoleColor.Magenta,
        ConsoleColor.Blue,
        ConsoleColor.Cyan,
        };
		static int[, ,] powerUp = new int[fieldWidth - padRow, fieldHeight, 2];
		static int bonusCount = 0;
		static int maxBonusCount = 4;
		static Random generator = new Random ();
		#endregion

		static void Main ( string[] args )
        {
			SetFieldSize ();
			Console.ReadKey();  //uncomment if you want to wait for a key to start the game

            //using (SoundPlayer intro = new SoundPlayer ( "../../External Files/introY.wav" ))
            //{
            //    intro.PlayLooping ();
            //    Thread.Sleep(1400);
				PrintStartScreen ();
				ChooseLevel ();
				ChooseSpeed ();
                ChooseName();
            //    intro.Stop ();
            //}

			CreateField();

			using (SoundPlayer gameSound = new SoundPlayer ( "../../External Files/game.wav" ))
			{
				gameSound.PlayLooping ();
				WaitForStart ();
				stopwatch.Start ();

				while (true)
				{
                    ReadKey();
                   
					DrawScoreBoard ();

					//Move
					MovePad ();
					MoveBall ();
					MovePowerUps ();

					ReadKey (); // Implements In-Game Menu

					//Print                  
					PrintBall ();
					PrintPowerUps ();
					PrintPad ();

					//Checks
					BouncePad ();
					BounceWalls ();
					BreakBricks ();
					GetBonusCheck ();

					CheckEndOfGame ();
                    CheckEndOfLevel();
                    if (gameOver || levelFinished) { break; }
                  
					Thread.Sleep ( threadSpeed );

				}
				gameSound.Stop ();
				stopwatch.Stop ();
			}
			EndGameScreen ();
		}

		#region StartGame
		static void SetFieldSize ()
		{
            try
            {
                Console.WindowHeight = fieldHeight;
                Console.BufferHeight = fieldHeight;
                Console.WindowWidth = fieldWidth + sidebar;
                Console.BufferWidth = fieldWidth + sidebar;
            }
            catch (ArgumentOutOfRangeException)
            {
                WriteOnPosition(10, fieldWidth / 2 - sidebar / 2 - 10, "Please set your font to Lucida Colsole and size to 20", ConsoleColor.Yellow);
            }
		}
		static void CreateField ()
		{
			Console.Clear ();
			Console.OutputEncoding = Encoding.Unicode;
			Console.CursorVisible = false;
			bricksNPads = new int[fieldHeight, fieldWidth];
			PrintStartBoard ();
			ResetPadAndBallPosition ();
			CreateBricks ();
			PrintBricks ();
		}
		static void PrintStartScreen ()
		{
			Thread.Sleep ( 600 );
			Console.Clear ();
			Console.CursorVisible = false;
			Console.ForegroundColor = ConsoleColor.Blue;
			string[] teamLogo = new string[7];
			teamLogo[0] = @" ____    ___                        ____                   __    ___                              ";
			teamLogo[1] = @"/\  _`\ /\_ \                      /\  _`\                /\ \__/\_ \                             ";
			teamLogo[2] = @"\ \ \L\ \//\ \    __  __     __    \ \ \L\ \     __     __\ \ ,_\//\ \      __                    ";
			teamLogo[3] = @" \ \  _ <'\ \ \  /\ \/\ \  /'__`\   \ \  _ <'  /'__`\ /'__`\ \ \/ \ \ \   /'__`\                  ";
			teamLogo[4] = @"  \ \ \L\ \\_\ \_\ \ \_\ \/\  __/    \ \ \L\ \/\  __//\  __/\ \ \_ \_\ \_/\  __/                  ";
			teamLogo[5] = @"   \ \____//\____\\ \____/\ \____\    \ \____/\ \____\ \____\\ \__\/\____\ \____\                 ";
			teamLogo[6] = @"    \/___/ \/____/ \/___/  \/____/     \/___/  \/____/\/____/ \/__/\/____/\/____/                 ";

			int length = fieldWidth - 2;
			int heighStart = fieldHeight / 2 - 3;
			int finalStartPosition = length - (length - teamLogo[0].Length) / 2 - 3;

			for (int i = 0; i < finalStartPosition; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					Console.SetCursorPosition ( Console.WindowWidth - i - 1, heighStart + j );

					for (int k = 0; k < Math.Min ( i, teamLogo[j].Length ); k++)
					{
						Console.Write ( teamLogo[j][k] );
					}
				}
				Thread.Sleep ( 8 );
			}

			Thread.Sleep ( 600 );

			Console.ResetColor ();

			for (int i = 0; i < finalStartPosition; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					Console.SetCursorPosition ( Console.WindowWidth - i - 1, heighStart + j );

					for (int k = 0; k < Math.Min ( i, teamLogo[j].Length ); k++)
					{
						Console.Write ( " " );
					}
				}
				Thread.Sleep ( 4 );
			}

			Console.ResetColor ();
			Console.ForegroundColor = ConsoleColor.Yellow;
			string[] arkanoidLogo = new string[6];
			arkanoidLogo[0] = @"               _                     _     _                                      ";
			arkanoidLogo[1] = @"    /\        | |                   (_)   | |                                     ";
			arkanoidLogo[2] = @"   /  \   _ __| | ____ _ _ __   ___  _  __| |                                     ";
			arkanoidLogo[3] = @"  / /\ \ | '__| |/ / _` | '_ \ / _ \| |/ _` |                                     ";
			arkanoidLogo[4] = @" / ____ \| |  |   < (_| | | | | (_) | | (_| |                                     ";
			arkanoidLogo[5] = @"/_/    \_\_|  |_|\_\__,_|_| |_|\___/|_|\__,_|                                     ";

			heighStart = 9;
			finalStartPosition = 61;
			for (int i = 0; i < finalStartPosition + sidebar; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					Console.SetCursorPosition ( Console.WindowWidth - i - 1, heighStart + j );

					for (int k = 0; k < Math.Min ( i, arkanoidLogo[j].Length ); k++)
					{
						Console.Write ( arkanoidLogo[j][k] );
					}
				}
				Thread.Sleep ( 10 );
			}
			Console.ForegroundColor = ConsoleColor.White;
			while (true)
			{
				Console.SetCursorPosition ( (fieldWidth / 2) - 5, 16 );
				Console.Write ( "PRESS SPACE TO CONTINUE" );
				Thread.Sleep ( 660 );
				Console.SetCursorPosition ( (fieldWidth / 2) - 5, 16 );
				Console.Write ( "                                " );
				Thread.Sleep ( 180 );
				if (Console.KeyAvailable == true)
				{
					ConsoleKeyInfo keyInfo = Console.ReadKey ();
					if (keyInfo.Key == ConsoleKey.Spacebar)
					{
						break;
					}
				}
			}
			Console.Clear ();
		}
		static void PrintStartBoard ()
		{
			for (int i = 0; i < Console.WindowHeight; i++)
			{
				WriteOnPosition ( i, Console.WindowWidth - sidebar, "|", ConsoleColor.White );
			}
			WriteOnPosition ( 1, Console.WindowWidth - sidebar + 2, "Score:", ConsoleColor.White );
			WriteOnPosition ( 3, Console.WindowWidth - sidebar + 2, "Speed: " + playerSpeed.ToString (), ConsoleColor.White );
			WriteOnPosition ( 5, Console.WindowWidth - sidebar + 2, "Lives: " + lives, ConsoleColor.White );
			WriteOnPosition ( 7, Console.WindowWidth - sidebar + 2, "Time: 0:00:00", ConsoleColor.White );
            WriteOnPosition(10, Console.WindowWidth - sidebar + 2, "Press H", ConsoleColor.Yellow);
            WriteOnPosition(11, Console.WindowWidth - sidebar + 2, "for help menu", ConsoleColor.Yellow);
		}
		static void PrintBricks ()
		{
			for (int i = 0; i < fieldHeight; i++)
			{
				for (int j = 0; j < fieldWidth; j++)
				{
					if (bricksNPads[i, j] != 0 && bricksNPads[i, j] != 100)
					{
						if (bricksNPads[i, j] == 1)
						{
							WriteOnPosition ( i, j, brickSymbol, ConsoleColor.Green );
						}
						if (bricksNPads[i, j] == 7)
						{
							WriteOnPosition ( i, j, brickSymbol, ConsoleColor.Red );
						}
						if (bricksNPads[i, j] == 12)
						{
							WriteOnPosition ( i, j, brickSymbol, ConsoleColor.Yellow );
						}
                        if (bricksNPads[i, j] > 12)
                        {
                            WriteOnPosition(i, j, brickSymbol, ConsoleColor.DarkGray);
                        }
					}
				}
			}
		}
		static void WaitForContinue ()
		{
			WriteOnPosition ( fieldHeight / 2, (fieldWidth - sidebar) / 2, "Press Enter to start!", ConsoleColor.Green );
			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo keyInfo = Console.ReadKey ();
					if (keyInfo.Key == ConsoleKey.RightArrow)
					{
						padDirection = right;
						if (ballCol < fieldWidth - padSize / 2)
						{
							ballCol++;
						}
						PrintBall ();
						MovePad ();
						PrintPad ();
					}
					else if (keyInfo.Key == ConsoleKey.LeftArrow)
					{
						padDirection = left;
						if (ballCol > 0 + padSize / 2)
						{
							ballCol--;
						}
						PrintBall ();
						MovePad ();
						PrintPad ();
					}
					else if (keyInfo.Key == ConsoleKey.Enter)
					{
						break;
					}
					else
					{
						WaitForContinue ();
						break;
					}
				}
			}
			//Deleting PRESS SPACE TO START
			WriteOnPosition ( 15, 35, "                            ", ConsoleColor.White );
		}
		static void WaitForStart ()
		{
			WriteOnPosition ( 15, 35, "PRESS SPACE TO START", ConsoleColor.White );
			while (true)
			{
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo keyInfo = Console.ReadKey ();
					if (keyInfo.Key == ConsoleKey.RightArrow)
					{
						padDirection = right;
						if (ballCol < fieldWidth - padSize / 2)
						{
							ballCol++;
						}
						PrintBall ();
						MovePad ();
						PrintPad ();
					}
					else if (keyInfo.Key == ConsoleKey.LeftArrow)
					{
						padDirection = left;
						if (ballCol > 0 + padSize / 2)
						{
							ballCol--;
						}
						PrintBall ();
						MovePad ();
						PrintPad ();
					}
					else if (keyInfo.Key == ConsoleKey.Spacebar)
					{
						break;
					}
					else
					{
						WaitForStart ();
						break;
					}
				}
			}
			//Deleting PRESS SPACE TO START
			WriteOnPosition ( 15, 35, "                            ", ConsoleColor.White );
		}
        static void ChooseName()
        {
            Console.Clear();
            string name = "Your name:";

            WriteOnPosition(9, (fieldWidth / 2) - (name.Length / 2) + (sidebar / 2), name, ConsoleColor.White);
            Console.SetCursorPosition((fieldWidth / 2) - (name.Length / 2) + (sidebar / 2) + 11, 9);
            playerName = Console.ReadLine();
        }
		static void ChooseLevel ()
		{
			Console.Clear ();
			string choose = "Choose level:";
			string easy = "1: Easy";
			string medium = "2: Medium";
			string hard = "3: Hard";
			WriteOnPosition ( 9, (fieldWidth / 2) - (choose.Length / 2) + (sidebar / 2), choose, ConsoleColor.White );
			WriteOnPosition ( 10, (fieldWidth / 2) - (easy.Length / 2) + (sidebar / 2), easy, ConsoleColor.White );
			WriteOnPosition ( 11, (fieldWidth / 2) - (medium.Length / 2) + (sidebar / 2) + 1, medium, ConsoleColor.White );
			WriteOnPosition ( 12, (fieldWidth / 2) - (hard.Length / 2) + (sidebar / 2), hard, ConsoleColor.White );
			Console.SetCursorPosition ( (fieldWidth / 2) - (choose.Length / 2) + (sidebar / 2) + choose.Length + 1, 9 );
			try
			{
				chosenLevel = int.Parse ( Console.ReadLine ().ToLower ().Trim () );
				switch (chosenLevel)
				{
					case 1:
                        totalBricks = 160;
						for (int i = 0; i < 8; i++)
						{
							Thread.Sleep ( 90 );
							WriteOnPosition ( 10, (fieldWidth / 2) - (easy.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.White );
							WriteOnPosition ( 10, (fieldWidth / 2) - (easy.Length / 2) + (sidebar / 2), easy, ConsoleColor.White );
							Thread.Sleep ( 90 );
							WriteOnPosition ( 10, (fieldWidth / 2) - (easy.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.Yellow );
							WriteOnPosition ( 10, (fieldWidth / 2) - (easy.Length / 2) + (sidebar / 2), easy, ConsoleColor.Yellow );
						}
						break;
					case 2:
                        totalBricks = 160;
						for (int i = 0; i < 8; i++)
						{
							Thread.Sleep ( 90 );
							WriteOnPosition ( 11, (fieldWidth / 2) - (medium.Length / 2) + (sidebar / 2) + 1 - 2, "\u2192", ConsoleColor.White );
							WriteOnPosition ( 11, (fieldWidth / 2) - (medium.Length / 2) + (sidebar / 2) + 1, medium, ConsoleColor.White );
							Thread.Sleep ( 90 );
							WriteOnPosition ( 11, (fieldWidth / 2) - (medium.Length / 2) + (sidebar / 2) + 1 - 2, "\u2192", ConsoleColor.Yellow );
							WriteOnPosition ( 11, (fieldWidth / 2) - (medium.Length / 2) + (sidebar / 2) + 1, medium, ConsoleColor.Yellow );
						}
						break;
					case 3:
                        totalBricks = 120;
						for (int i = 0; i < 8; i++)
						{
							Thread.Sleep ( 90 );
							WriteOnPosition ( 12, (fieldWidth / 2) - (hard.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.White );
							WriteOnPosition ( 12, (fieldWidth / 2) - (hard.Length / 2) + (sidebar / 2), hard, ConsoleColor.White );
							Thread.Sleep ( 90 );
							WriteOnPosition ( 12, (fieldWidth / 2) - (hard.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.Yellow );
							WriteOnPosition ( 12, (fieldWidth / 2) - (hard.Length / 2) + (sidebar / 2), hard, ConsoleColor.Yellow );
						}
						break;
					default:
						WriteOnPosition ( 13, fieldWidth / 2 - sidebar / 2, "Please enter valid level.", ConsoleColor.Yellow );
						Thread.Sleep ( 400 );
						ChooseLevel ();
						break;
				}
			}
			catch (FormatException)
			{
				WriteOnPosition ( 13, fieldWidth / 2 - sidebar / 2, "Please enter valid level.", ConsoleColor.Yellow );
				Thread.Sleep ( 400 );
				ChooseLevel ();
			}
			catch (OverflowException)
			{
				WriteOnPosition ( 13, fieldWidth / 2 - sidebar / 2, "Please enter valid level.", ConsoleColor.Yellow );
				Thread.Sleep ( 400 );
				ChooseLevel ();
			}
			Console.Clear ();
		}
		static void ChooseSpeed ()
		{
			Console.Clear ();
			string requireSpeed = "Enter ball speed:";
			string normal = "10: Normal";
			string fast = "20: Fast";
			string faster = "30: Faster";

			WriteOnPosition ( 9, (fieldWidth / 2) - (requireSpeed.Length / 2) + (sidebar / 2), requireSpeed, ConsoleColor.White );
			WriteOnPosition ( 10, (fieldWidth / 2) - (normal.Length / 2) + (sidebar / 2), normal, ConsoleColor.White );
			WriteOnPosition ( 11, (fieldWidth / 2) - (fast.Length / 2) + (sidebar / 2) + 1 - 2, fast, ConsoleColor.White );
			WriteOnPosition ( 12, (fieldWidth / 2) - (faster.Length / 2) + (sidebar / 2), faster, ConsoleColor.White );
			Console.SetCursorPosition ( (fieldWidth / 2) - (requireSpeed.Length / 2) + (sidebar / 2) + requireSpeed.Length + 1, 9 );

			try
			{
				threadSpeed = int.Parse ( Console.ReadLine ().ToLower ().Trim () );
				switch (threadSpeed)
				{
					case 10:
						playerSpeed = 10;
						threadSpeed = 45;
						for (int i = 0; i < 8; i++)
						{
							Thread.Sleep ( 90 );
							WriteOnPosition ( 10, (fieldWidth / 2) - (normal.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.White );
							WriteOnPosition ( 10, (fieldWidth / 2) - (normal.Length / 2) + (sidebar / 2), normal, ConsoleColor.White );
							Thread.Sleep ( 90 );
							WriteOnPosition ( 10, (fieldWidth / 2) - (normal.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.Yellow );
							WriteOnPosition ( 10, (fieldWidth / 2) - (normal.Length / 2) + (sidebar / 2), normal, ConsoleColor.Yellow );
						}
						break;
					case 20:
						playerSpeed = 20;
						threadSpeed = 38;
						for (int i = 0; i < 8; i++)
						{
							Thread.Sleep ( 90 );
							WriteOnPosition ( 11, (fieldWidth / 2) - (fast.Length / 2) + (sidebar / 2) + 1 - 4, "\u2192", ConsoleColor.White );
							WriteOnPosition ( 11, (fieldWidth / 2) - (fast.Length / 2) + (sidebar / 2) + 1 - 2, fast, ConsoleColor.White );
							Thread.Sleep ( 90 );
							WriteOnPosition ( 11, (fieldWidth / 2) - (fast.Length / 2) + (sidebar / 2) + 1 - 4, "\u2192", ConsoleColor.Yellow );
							WriteOnPosition ( 11, (fieldWidth / 2) - (fast.Length / 2) + (sidebar / 2) + 1 - 2, fast, ConsoleColor.Yellow );
						}
						break;
					case 30:
						playerSpeed = 30;
						threadSpeed = 30;
						for (int i = 0; i < 8; i++)
						{
							Thread.Sleep ( 90 );
							WriteOnPosition ( 12, (fieldWidth / 2) - (faster.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.White );
							WriteOnPosition ( 12, (fieldWidth / 2) - (faster.Length / 2) + (sidebar / 2), faster, ConsoleColor.White );
							Thread.Sleep ( 90 );
							WriteOnPosition ( 12, (fieldWidth / 2) - (faster.Length / 2) + (sidebar / 2) - 2, "\u2192", ConsoleColor.Yellow );
							WriteOnPosition ( 12, (fieldWidth / 2) - (faster.Length / 2) + (sidebar / 2), faster, ConsoleColor.Yellow );
						}
						break;
					default:
						WriteOnPosition ( 13, fieldWidth / 2 - sidebar / 2, "Please enter valid speed.", ConsoleColor.Yellow );
						Thread.Sleep ( 400 );
						ChooseSpeed ();
						break;
				}
			}
			catch (FormatException)
			{
				WriteOnPosition ( 13, (fieldWidth / 2) - (sidebar / 2), "Please enter valid speed.", ConsoleColor.Yellow );
				Thread.Sleep ( 400 );
				ChooseSpeed ();
			}
			catch (OverflowException)
			{
				WriteOnPosition ( 13, (fieldWidth / 2) - (sidebar / 2), "Please enter valid speed.", ConsoleColor.Yellow );
				Thread.Sleep ( 400 );
				ChooseSpeed ();
			}
			Console.Clear ();
		}
		#endregion

		#region GameOptions

		static string CalulateTime ( TimeSpan ts )
		{
			StringBuilder timeElapsed = new StringBuilder ();
			timeElapsed.Append ( ts.Minutes );
			timeElapsed.Append ( ":" );
			if (ts.Seconds < 10)
			{
				timeElapsed.Append ( "0" + ts.Seconds );
			}
			else
			{
				timeElapsed.Append ( ts.Seconds );
			}
			timeElapsed.Append ( ":" );
			timeElapsed.Append ( ts.Milliseconds );
			timeElapsed.Remove ( timeElapsed.Length - 1, 1 );
			return timeElapsed.ToString ();
		}
		static void DrawScoreBoard ()  // draws a basic scoreboard
		{
			int scoreWidth = Console.WindowWidth - sidebar + 9;
			int speedWidth = Console.WindowWidth - sidebar + 9;
			int livesWidth = Console.WindowWidth - sidebar + 9;
			int helpWidth = Console.WindowWidth - sidebar + 2;
			WriteOnPosition ( 1, scoreWidth, score.ToString (), ConsoleColor.White );
			WriteOnPosition ( 3, speedWidth, playerSpeed.ToString (), ConsoleColor.White );
			WriteOnPosition ( 5, livesWidth, lives.ToString (), ConsoleColor.White );

			TimeSpan ts = stopwatch.Elapsed;
			WriteOnPosition ( 7, Console.WindowWidth - sidebar + 8, CalulateTime ( ts ).ToString (), ConsoleColor.White );
		}
		static void ResetPadAndBallPosition ()
		{
			ClearPad ();
			Console.ForegroundColor = padColor;
			padCol = fieldWidth / 2 - padSize / 2; // set pad in start position
			padEnd = padCol + padSize - 1;
			padRow = fieldHeight - 6;
			for (int i = 0; i < padSize && padCol + i < fieldWidth; i++)
			{
				bricksNPads[padRow, padCol + i] = padValue;
				WriteOnPosition ( padRow, padCol + i, padSymbol, padColor );
			}
			DeleteAtPosition ( ballRow, ballCol );
			ballCol = fieldWidth / 2;  // set ball in start position
			ballRow = fieldHeight - 7;
			previousBallRow = ballRow;
			previousBallCol = ballCol;
			DeleteAtPosition ( previousBallRow, previousBallCol );
			WriteOnPosition ( ballRow, ballCol, ballSymbol, ballColor );
		}
		static void ReadKey ()
		{
			if (Console.KeyAvailable)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey ();
				if (keyInfo.Key == ConsoleKey.RightArrow)
				{
					padDirection = right;
				}
				else if (keyInfo.Key == ConsoleKey.LeftArrow)
				{
					padDirection = left;
				}
                if (keyInfo.Key == ConsoleKey.H)
                {
                    System.Windows.Forms.MessageBox.Show(@" Press space to enter the game.
															You can move the pad with left arrow and right arrow.
															Your goal is to break all of the bricks.
															You can choose between 3 levels of difficulty 
															and 3 ball speeds
															You can pause the game by pressing Esc button 
															and start it by pressing p button.
															Trough the game you have different bonuses:
																+ - your pad gets longer
																- - your pad gets shorter
																♥ - gives you a life
																X - kills you
																F - faster ball
																S - slower ball
															With H button you can call help men.u
															At the end of each game you have to choose wheher 
															you want a new game or not by pressing y - for yes and n - for no.");
                }
				else if (keyInfo.Key == ConsoleKey.Escape)
				{
					Console.SetCursorPosition ( fieldWidth / 2 - sidebar, fieldHeight / 2 - 1 );
					Console.WriteLine ( "Game Paused. Press p to resume." );
					resumeGame = true;
					NewGame ();
				}
			}
		}
        static void CheckEndOfLevel()
        {
            if (bricksDestroyed == totalBricks)
            {
                levelFinished = true;
            }
        }
		static void CheckEndOfGame ()
		{
			if (ballRow == fieldHeight - 1 || lives < 0)
			{
                
				if (lives > 0)
				{
					lives--;
					goUp = true;
					ResetPadAndBallPosition ();
					WaitForContinue ();
					for (int i = 0; i < fieldWidth; i++)
					{
						DeleteAtPosition ( fieldHeight / 2, i );
					}
				}
				else
				{
					goUp = true;
					NewGame ();
				}
			}
		}
		static void RestartGame ()
		{
			Console.Clear ();
			Array.Clear ( bricksNPads, 0, bricksNPads.Length );
			lives = 3;
			score = 0;
			padSize = 22;
			bonusCount = 0;
			stopwatch.Reset ();
			stopwatch.Start ();
			goUp = true;
			goRight = true;
			padDirection = right;
			ResetPadAndBallPosition ();
			ClearPowerUps ();
			CreateField ();
		}
		static void NewGame ()
		{
			WriteOnPosition ( fieldHeight / 2, fieldWidth / 2 - sidebar, "Do you want a new game (y / n): ", ConsoleColor.Red );
			ConsoleKeyInfo pressed = Console.ReadKey ();
			if (pressed.KeyChar == 'n')
			{
				gameOver = true;
				return;
			}
			else if ((pressed.KeyChar == 'p' || pressed.Key == ConsoleKey.Escape) && resumeGame)
			{
				resumeGame = false;
				for (int i = 0; i < fieldWidth; i++)
				{
					DeleteAtPosition ( fieldHeight / 2, i );
					DeleteAtPosition ( fieldHeight / 2 - 1, i );
				}
				return;
			}
			else if (pressed.KeyChar == 'y')
			{
				RestartGame ();
			}
			else if ((pressed.KeyChar == 'p' || pressed.Key == ConsoleKey.Escape) && !resumeGame)
			{
				NewGame ();
			}
			else
			{
				NewGame ();
			}
			return;
		}
		#endregion

		#region Pad
		static void ClearPad ()
		{
			for (int cols = 0; cols < bricksNPads.GetLength ( 1 ); cols++)
			{
				DeleteAtPosition ( padRow, cols );
				bricksNPads[padRow, cols] = 0;
			}
		}
		static void RedrawPad () // Draws the pad after taking '+' or '-'
		{
			ClearPad ();
			for (int i = padCol; i <= padEnd; i++)
			{
				bricksNPads[padRow, i] = padValue;
				WriteOnPosition ( padRow, i, padSymbol, padColor );
			}
		}
		static void PrintPad ()
		{
			//Write on the required side and delete last
			if (padDirection == left && padCol > 0 && padEnd < fieldWidth - 1)
			{
				WriteOnPosition ( padRow, padCol + 1, padSymbol, padColor );
				WriteOnPosition ( padRow, padCol, padSymbol, padColor );
				bricksNPads[padRow, padCol] = padValue;
				DeleteAtPosition ( padRow, padEnd + 1 );
				bricksNPads[padRow, padEnd + 1] = 0;
			}
			if (padDirection == right && padEnd < fieldWidth)
			{
				WriteOnPosition ( padRow, padEnd, padSymbol, padColor );
				bricksNPads[padRow, padEnd] = padValue;
				if (padCol > 0)
				{
					DeleteAtPosition ( padRow, padCol - 1 );
					bricksNPads[padRow, padCol - 1] = 0;
				}
			}
		}
		static void MovePad ()
		{
			if (padDirection == left && padCol > 0)  // Move pad left, if possible
			{
				padCol--;
				padEnd--;
			}
			if (padDirection == right && padEnd < fieldWidth - 2)  // move pad right if possible
			{
				padCol++;
				padEnd++;
			}
		}
		#endregion

		#region  Ball
		static void MoveBall ()
		{

			if (goUp == true)
			{
				MoveBallUp ();
			}
			else
			{
				MoveBallDown ();
			}
		}
		static void MoveBallUp ()
		{
			if (goRight == true)
			{
				ballRow--;
				ballCol++;
			}
			if (goRight == false)
			{
				ballRow--;
				ballCol--;
			}
		}
		static void MoveBallDown ()
		{
			if (goRight == true)
			{
				ballRow++;
				ballCol++;
			}
			if (goRight == false)
			{
				ballRow++;
				ballCol--;
			}
		}
		static void BounceWalls ()
		{
			if (ballRow == 0)
			{
				goUp = !goUp;
			}
			if (ballCol == 0 || ballCol == fieldWidth - 1)
			{
				goRight = !goRight;
			}
		}
		static void BouncePad ()  // ball is going left if it hits left side of the pad or vise versa 
		{
			if (!goUp && ballRow + 1 < fieldHeight && bricksNPads[ballRow + 1, ballCol] == padValue)
			{
				goUp = true;
				if (ballCol <= padCol + padSize / 2 - 1)
				{
					goRight = false;
				}
				else
				{
					goRight = true;
				}
			}
		}
		static void PrintBall ()
		{
			//Delete previous and print current ball
			DeleteAtPosition ( previousBallRow, previousBallCol );
			WriteOnPosition ( ballRow, ballCol, ballSymbol, ballColor );
			previousBallRow = ballRow;
			previousBallCol = ballCol;
		}
		#endregion

		#region Bricks
		static void BreakBricks ()
		{
			//No point in reading this, I don't understand it either, but it works
			if (goUp && ballRow > 0 && bricksNPads[ballRow - 1, ballCol] != 0 && bricksNPads[ballRow - 1, ballCol] != padValue)
			{
				DestoyBrick ( ballRow - 1, ballCol );
				goUp = false;
			}
			else if (goUp && ballRow > 0 && bricksNPads[ballRow - 1, ballCol] == 0 && bricksNPads[ballRow - 1, ballCol] != padValue)
			{
				if (goRight)
				{
					if (ballCol < fieldWidth - 1 && bricksNPads[ballRow - 1, ballCol + 1] != 0)
					{
						DestoyBrick ( ballRow - 1, ballCol + 1 );
						goUp = false;
					}
				}
				if (!goRight)
				{
					if (ballCol - 1 > 0 && bricksNPads[ballRow - 1, ballCol - 1] != 0)
					{
						DestoyBrick ( ballRow - 1, ballCol - 1 );
						goUp = false;
					}
				}
			}
			if (!goUp && ballRow + 1 < fieldHeight && bricksNPads[ballRow + 1, ballCol] != 0 && bricksNPads[ballRow + 1, ballCol] != padValue)
			{
				DestoyBrick ( ballRow + 1, ballCol );
				goUp = true;
			}
			else if (!goUp && ballRow + 1 < fieldHeight && bricksNPads[ballRow + 1, ballCol] == 0 && bricksNPads[ballRow + 1, ballCol] != padValue)
			{
				if (goRight)
				{
					if (bricksNPads[ballRow + 1, ballCol + 1] != 0 && ballCol < fieldWidth - 1)
					{
						DestoyBrick ( ballRow + 1, ballCol + 1 );
						goUp = true;
					}
				}
				if (!goRight)
				{
					if (bricksNPads[ballRow + 1, ballCol - 1] != 0 && ballCol > 0)
					{
						DestoyBrick ( ballRow + 1, ballCol - 1 );
						goUp = true;
					}
				}
			}
			if (goRight && ballCol + 1 < fieldWidth && bricksNPads[ballRow, ballCol + 1] != 0 && bricksNPads[ballRow, ballCol + 1] != padValue)
			{
				DestoyBrick ( ballRow, ballCol + 1 );
				goRight = false;
			}
			if (!goRight && ballCol - 1 > 0 && bricksNPads[ballRow, ballCol - 1] != 0 && bricksNPads[ballRow, ballCol - 1] != padValue)
			{
				DestoyBrick ( ballRow, ballCol - 1 );
				goRight = true;
			}
		}
		static void DestoyBrick ( int row, int col )
		{
			bricksNPads[row, col]--;
			if (bricksNPads[row, col] <= 0)
			{
				DeleteWholeBrick ( row, col );
				return;
			}
			if (bricksNPads[row, col] == 5)
			{
				DeleteWholeBrick ( row, col );
				return;
			}
			if (bricksNPads[row, col] == 6)
			{
				SetWholeBrick ( row, col, ConsoleColor.DarkRed );
				return;
			}
			if (bricksNPads[row, col] == 11)
			{
				SetWholeBrick ( row, col, ConsoleColor.DarkYellow );
				return;
			}
			if (bricksNPads[row, col] == 10)
			{
				DeleteWholeBrick ( row, col );
				return;
			}
            if(bricksNPads[row, col] > 12)
            {
                SetWholeBrick ( row, col, ConsoleColor.DarkGray );
				return;
            }
            
		}
		static void SetWholeBrick ( int row, int col, ConsoleColor color )
		{
			if (bricksNPads[row, col + 1] != 0 && bricksNPads[row, col - 1] != 0)
			{
				WriteOnPosition ( row, col, brickSymbol, color );
				WriteOnPosition ( row, col + 1, brickSymbol, color );
				WriteOnPosition ( row, col - 1, brickSymbol, color );

				bricksNPads[row, col + 1] = bricksNPads[row, col];
				bricksNPads[row, col - 1] = bricksNPads[row, col];
			}

			if (bricksNPads[row, col + 1] == 0 && bricksNPads[row, col - 1] != 0)
			{
				WriteOnPosition ( row, col, brickSymbol, color );
				WriteOnPosition ( row, col - 1, brickSymbol, color );
				WriteOnPosition ( row, col - 2, brickSymbol, color );

				bricksNPads[row, col - 1] = bricksNPads[row, col];
				bricksNPads[row, col - 2] = bricksNPads[row, col];
			}

			if (bricksNPads[row, col - 1] == 0 && bricksNPads[row, col + 1] != 0)
			{
				WriteOnPosition ( row, col, brickSymbol, color );
				WriteOnPosition ( row, col + 1, brickSymbol, color );
				WriteOnPosition ( row, col + 2, brickSymbol, color );

				bricksNPads[row, col + 1] = bricksNPads[row, col];
				bricksNPads[row, col + 2] = bricksNPads[row, col];
			}
		}
		static void DeleteWholeBrick ( int row, int col )
		{
			score += chosenLevel * (50 - threadSpeed);
            bricksDestroyed++;
			GeneratePowerUp ();
			if (bricksNPads[row, col + 1] != 0 && bricksNPads[row, col - 1] != 0)
			{
				DeleteAtPosition ( row, col );
				DeleteAtPosition ( row, col + 1 );
				DeleteAtPosition ( row, col - 1 );
				bricksNPads[row, col] = 0;
				bricksNPads[row, col + 1] = 0;
				bricksNPads[row, col - 1] = 0;
				return;
			}
			if (bricksNPads[row, col + 1] == 0)
			{
				DeleteAtPosition ( row, col );
				DeleteAtPosition ( row, col - 1 );
				DeleteAtPosition ( row, col - 2 );
				bricksNPads[row, col] = 0;
				bricksNPads[row, col - 1] = 0;
				bricksNPads[row, col - 2] = 0;
				return;
			}
			if (bricksNPads[row, col - 1] == 0)
			{
				DeleteAtPosition ( row, col );
				DeleteAtPosition ( row, col + 1 );
				DeleteAtPosition ( row, col + 2 );
				bricksNPads[row, col] = 0;
				bricksNPads[row, col + 1] = 0;
				bricksNPads[row, col + 2] = 0;
				return;
			}
		}
		static void CreateBricks ()
		{
			//Insert colors values
			if (chosenLevel == 1)
			{
				for (int i = firstBrickRow; i < lastBrickRow; i++)
				{
					for (int j = firstBrickCol; j < lastBrickCol; j++)
					{
						bricksNPads[i, j] = 1;
					}
				}
			}
			else if (chosenLevel == 2)			{

				for (int i = firstBrickRow; i < lastBrickRow; i++)
				{
					for (int j = firstBrickCol; j < lastBrickCol ; j++)
					{
						if (i % 2 == 0)
						{
							bricksNPads[i, j] = 7;
						}

						else
                        {
                            bricksNPads[i, j] = 1;
                        }

						if (i % 3 == 0)
						{
							bricksNPads[i, j] = 12;
						}
                        
					}

				}
			}
			else if (chosenLevel == 3)
			{
                firstBrickRow += 3;
                lastBrickRow += 3;
                firstBrickCol = 2;
                lastBrickCol = 87;
                int counter = 0;

                for (int i = firstBrickRow; i < lastBrickRow; i++)
                {
                    for (int j = firstBrickCol + 3; j < lastBrickCol - 3; j++)
                    {
                        if (i % 2 == 0)
                        {
                            bricksNPads[i, j] = 7;
                        }
                        else
                        {
                            bricksNPads[i, j] = 12;
                        }

                        if (j % 4 == 0 && counter % 2 == 0)
                        {                           
                            bricksNPads[i, j] = 1000000;
                            bricksNPads[i, j + 1] = 1000000;
                            bricksNPads[i, j + 2] = 1000000;
                            bricksNPads[i, j + 3] = 1000000;
                            j += 4;
                        }
                    }
                    counter++;
                }
            }
			//Create blocks
			for (int i = firstBrickCol; i <= lastBrickCol; i++)
			{
				for (int j = firstBrickRow; j <= lastBrickRow; j++)
				{
					if (i % 4 == 0 || i == 0)
					{
						bricksNPads[j, i] = 0;
					}
				}
			}
		}
		#endregion

		#region Power-Ups
		static void GeneratePowerUp ()
		{
			if (bonusCount < maxBonusCount)
			{
				if (generator.Next ( 1, 4 ) == 2)  // generate bonus
				{
					int bonus = generator.Next ( bonuses.Length );
					powerUp[ballCol, ballRow, 0] = (int) bonuses[bonus];
					powerUp[ballCol, ballRow, 1] = bonus;
					bonusCount++;
				}
			}
		}
		static void ClearPowerUps ()
		{
			for (int cols = 0; cols < powerUp.GetLength ( 0 ); cols++)
			{
				for (int rows = 0; rows < powerUp.GetLength ( 1 ); rows++)
				{
					powerUp[cols, rows, 0] = 0;
				}
			}
		}
		static void MovePowerUps ()
		{
			for (int cols = 0; cols < powerUp.GetLength ( 0 ); cols++)
			{
				for (int rows = padRow + 1; rows > 0; rows--)
				{
					if (powerUp[cols, rows - 1, 0] != 0)
					{
						powerUp[cols, rows, 0] = powerUp[cols, rows - 1, 0];
						powerUp[cols, rows - 1, 0] = 0;
						powerUp[cols, rows, 1] = powerUp[cols, rows - 1, 1];
					}
				}
			}
		}
		static void PrintPowerUps ()
		{
			for (int cols = 0; cols < powerUp.GetLength ( 0 ); cols++)
			{
				for (int rows = 0; rows < padRow + 1; rows++)
				{
					if (powerUp[cols, rows, 0] != 0)
					{
						if (bricksNPads[rows, cols] == 0)
						{
							WriteOnPosition ( rows, cols, ((char) powerUp[cols, rows, 0]).ToString (), colors[powerUp[cols, rows, 1]] );
						}
						if (bricksNPads[rows - 1, cols] == 0)
						{
							DeleteAtPosition ( rows - 1, cols );
						}
					}
				}
			}
		}
		static void GetBonusCheck ()
		{
			for (int cols = 0; cols < powerUp.GetLength ( 0 ); cols++)
			{
				if (powerUp[cols, padRow, 0] != 0)
				{
					if (cols >= padCol && cols <= padEnd)
					{
						char hitted = (char) powerUp[cols, padRow, 0];
						switch (hitted)
						{
							case '+':
								ClearPad ();
								if (padSize < 28)
								{
									padSize += 3;
									if (padCol + padSize > fieldWidth - 1)
									{
										padEnd = fieldWidth - 1;
										padCol = fieldWidth - 1 - padSize;
									}
									else
									{
										padEnd += 3;
									}
								}
								RedrawPad ();
								break;
							case '-':
								if (padSize > 12)
								{
									DecreasePadSize ();
								}
								break;
							case '♥':
								lives++;
								break;
							case 'X':
								lives--;
								break;
							case 'F':
								if (playerSpeed + 3 <= 30)
								{
									threadSpeed -= 3;
									playerSpeed += 3;
								}
								break;
							case 'S':
								if (playerSpeed - 3 >= 10)
								{
									threadSpeed += 3;
									playerSpeed -= 3;
								}
								break;
						}
					}
					else
					{
						DeleteAtPosition ( padRow, cols );
					}
					powerUp[cols, padRow, 0] = 0;
					bonusCount--;
				}
			}
		}
		static void DecreasePadSize ()
		{
			int decreaseValue = 1;
			padCol = padCol + decreaseValue;
			padEnd = padEnd - decreaseValue;
			padSize -= decreaseValue * 2;
			if (padCol - 1 >= 0)
			{
				for (int i = padCol - 1; i > padCol + decreaseValue - 10; i--)
				{
					if (i >= 0)
					{
						DeleteAtPosition ( padRow, i );
						bricksNPads[padRow, i] = 0;
					}
					else
					{
						break;
					}

				}
			}
			if (padEnd + 1 < fieldWidth)
			{
				for (int i = padEnd + 1; i < padEnd + decreaseValue + 10; i++)
				{
					if (i < fieldWidth)
					{
						DeleteAtPosition ( padRow, i );
						bricksNPads[padRow, i] = 0;
					}
					else
					{
						break;
					}
				}
			}
		}
		#endregion

        #region EndGame
        public static void PrintHighscore()
        {
            string[] highscores = ReadHighScoresFromFile();
            int row = 24;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition( fieldWidth / 2 - fieldWidth * 5 / 100, fieldHeight / 2 + 5); 
            Console.WriteLine("High scores:");
            int placeCounter = 1;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < highscores.Length - 1; i += 2)
            {

                string rankingPlace = Convert.ToString(placeCounter);
                Console.SetCursorPosition(fieldWidth / 2 - fieldWidth * 5 / 100, row);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(rankingPlace + ". ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(highscores[i + 1] + ": " + highscores[i] + " points");
                row++;
                placeCounter++;
            }

        }
        static String[] ReadHighScoresFromFile()
        {
            String[] highScores;

            using (StreamReader reader = new StreamReader("../../External Files/highscores.txt"))
            {
                String highScoresFile = reader.ReadToEnd();
                highScores = highScoresFile.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
            // TODO: catch exception for highscores.txt

            return highScores;
        }
        static int ReturnPositonToInsert(string[] currentHighscore, int playerScore)
        {
            int position = -1;
            for (int i = 0; i < currentHighscore.Length; i += 2)
            {
                if (playerScore >= int.Parse(currentHighscore[i]))
                {
                    position = i;
                    return position;
                }
            }
            return position;
        }
        static List<string> ChangeHighscore(string[] highscore, string playerName, int playerScore, int position)
        {
            List<string> result = new List<string>(highscore);
            result.Insert(position, playerScore.ToString());
            result.Insert(position + 1, playerName);
            result.RemoveAt(result.Count - 1);
            result.RemoveAt(result.Count - 1);
            return result;
        }
        static void WriteNewHighscoreToFile(List<string> newHighScore)
        {
            using (StreamWriter writer = new StreamWriter("../../External Files/highscores.txt", false))
            {
                string result = string.Join(",", newHighScore);
                writer.Write(result);
            }
        }
        public static void RecordScore()
        {

            string[] highscores = ReadHighScoresFromFile();
            position = ReturnPositonToInsert(highscores, score);
            if (position != -1)
            {
                List<string> newHighscore = ChangeHighscore(highscores, playerName, score, position);
                WriteNewHighscoreToFile(newHighscore);
            }

        }
		static void EndGameScreen ()
		{
			using (SoundPlayer outro = new SoundPlayer ( "../../External Files/outro.wav" ))
			{
				outro.PlayLooping ();
				Console.Clear ();
				string[] gameOverLogo = new string[9];

				gameOverLogo[0] = @"  ____     _    __  __ _____ ";
				gameOverLogo[1] = @" / ___|   / \  |  \/  | ____|";
				gameOverLogo[2] = @" | |  _  / _ \ | |\/| |  _|  ";
				gameOverLogo[3] = @" | |_| |/ ___ \| |  | | |___ ";
				gameOverLogo[4] = @" \_____/_/   \_\_|__|_|_____|";
				gameOverLogo[5] = @"  / _ \ \   / / ____|  _ \";
				gameOverLogo[6] = @" | | | \ \ / /|  _| | |_) |";
				gameOverLogo[7] = @" | |_| |\ V / | |___|  _ <  ";
				gameOverLogo[8] = @"  \___/  \_/  |_____|_| \_\ ";

				for (int i = 0; i < gameOverLogo.Length; i++)
				{
					WriteOnPosition ( fieldHeight / 2 - 10 + i, fieldWidth / 2 - 10, gameOverLogo[i], ConsoleColor.Yellow );
				}


				TimeSpan time = new TimeSpan ();
				time = stopwatch.Elapsed;

				WriteOnPosition ( fieldHeight / 2 + 1, fieldWidth / 2 - fieldWidth * 5 / 100, "Final Score: ", ConsoleColor.Yellow );
				WriteOnPosition ( fieldHeight / 2 + 1, fieldWidth / 2 - fieldWidth * 5 / 100 + 13, score.ToString (), ConsoleColor.White );
				WriteOnPosition ( fieldHeight / 2 + 3, fieldWidth / 2 - fieldWidth * 5 / 100, "Your Time: ", ConsoleColor.Yellow );
				WriteOnPosition ( fieldHeight / 2 + 3, fieldWidth / 2 - fieldWidth * 5 / 100 + 13, CalulateTime ( time ), ConsoleColor.White );

                RecordScore();
                PrintHighscore();

				WriteOnPosition ( fieldHeight / 2 + 14, fieldWidth / 2 - fieldWidth * 5 / 100 - 4, "Press any key to exit.. ", ConsoleColor.Red );
				Console.ReadKey ();
				outro.Stop ();
			}
        }
        #endregion

        static void WriteOnPosition(int row, int col, string symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.Write(symbol);
        }
        static void DeleteAtPosition(int row, int col)
        {
            //Print with black
            WriteOnPosition(row, col, "\u2588", ConsoleColor.Black);
        }

    }
}