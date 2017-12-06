using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPuzzlesAndGames
{
    public class TurtleDrawing
    {
        private static char[,] _board = new char[20, 20];
        private static int _penStatus = 1;
        private static int _moves;
        private static int _option;
        private static int _x1;
        private static int _y1;
        private static int _x2;
        private static int _y2;

        public enum Options
        {
            penUp = 1,
            penDown = 2,
            north = 3,
            south = 4,
            east = 5,
            west = 6,
            quit = 7
        }

    
        public static void InitBoard()
        {
            for(var row = 0; row < 20; row++)
            {
                for(var col = 0; col < 20; col++)
                {
                    _board[row, col] = '.';
                }
            }
            _board[0, 0] = 'X';
        }


        public static void DisplayBoard(char[,] board)
        {
            Console.WriteLine();
            for (var row = 0; row < 20; row++)
            {
                for (var col = 0; col < 20; col++)
                {
                    Console.Write(board[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void DrawBoard(char[,] gameBoard, int penStatus, Options direction, 
            int moves, int x1 , int y1, int x2, int y2)
        {
            if (_penStatus.Equals(1))
            {
                gameBoard[x2, y2] = 'X';
                gameBoard[x1, y1] = '.';
                _board = gameBoard;
            }
            else if(_penStatus.Equals(2) && direction.Equals(Options.north))
            {
                gameBoard[x2, y2] = 'X';
                for(var row = x1; row > x2; row--)
                {
                    gameBoard[row, y2] = 'O';
                }
                _board = gameBoard;
            }
            else if(_penStatus.Equals(2) && direction.Equals(Options.south))
            {
                gameBoard[x2, y2] = 'X';
                for (var row = x1; row < x2; row++)
                {
                    gameBoard[row, y2] = 'O';
                }
                _board = gameBoard;

            }
            else if(_penStatus.Equals(2) && direction.Equals(Options.east))
            {
                gameBoard[x2, y2] = 'X';
                for(var col = y1; col < y2; col++)
                {
                    gameBoard[x2, col] = 'O';
                }
                _board = gameBoard;
            }
            else 
            {
                gameBoard[x2, y2] = 'X';
                for (var col = y1; col > y2; col--)
                {
                    gameBoard[x2, col] = 'O';
                }
                _board = gameBoard;
            }
        }


        public static void DislpayInstructions()
        {
            Console.WriteLine("Type your commands to draw on the game board\n");
            Console.WriteLine("  1: Pen Up");
            Console.WriteLine("  2: Pen Down");
            Console.WriteLine("  3: Move North");
            Console.WriteLine("  4: Move South");
            Console.WriteLine("  5: Move East");
            Console.WriteLine("  6: Move West");
            Console.WriteLine("  7: Quit\n");

        }


        public static void DisplayPenStatus(int status)
        {
            if (status == 1)
            {
                Console.WriteLine("Pen is not drawing");
                SetPenStatus(status);
            }
            else
            {
                Console.WriteLine("Pen is drawing");
                SetPenStatus(status);
            }
        }
        

        public static void SetPenStatus(int status)
        {
            if (status == 1)
                _penStatus = 1;
            else _penStatus = 2;
        }


        public static void SelectOption()
        {
            Console.Write("Select your option: ");
            var input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6" && input != "7")
            {

                Console.Write("Invalid choice - please choose again: ");
                input = Console.ReadLine();

            }
            _option = Convert.ToInt32(input);

            if (_option.Equals(1) || _option.Equals(2))
            {
                SetPenStatus(_option);
                ExecuteOption(_option);
            }
            else if (_option.Equals(7))
            {
                Quit();
            }
            else
            {
                Console.WriteLine("Turtle is currently moving " + (Options)_option);
                Console.Write("Enter number of spaces to move: ");
                _moves = Convert.ToInt32(Console.ReadLine());
                ExecuteOption(_option);
            }
        }


        public static void ExecuteOption(int option)
        {
            switch (option)
            {
                case 1:
                    DisplayBoard(_board);
                    DislpayInstructions();
                    DisplayPenStatus(1);
                    SelectOption();
                    break;
                case 2:
                    DisplayBoard(_board);
                    DislpayInstructions();
                    DisplayPenStatus(2);
                    SelectOption();
                    break;
                case 3:
                    North(_board, _penStatus, (Options)option, _moves);
                    break;
                case 4:
                    South(_board, _penStatus, (Options)option, _moves);
                    break;
                case 5:
                    East(_board, _penStatus, (Options)option, _moves);
                    break;
                case 6:
                    West(_board, _penStatus, (Options)option, _moves);
                    break;
                case 7:
                    Quit();
                    break;
            }
        }


        public static void North(char[,] gameBoard, int penStatus, Options direction, int moves)
        {
            for(var row = 0; row < 20; row++)
            {
                for(var col = 0; col < 20; col++)
                {
                    if (gameBoard[row, col].Equals('X'))
                    {
                        _x1 = row;
                        _y1 = col;
                    }
                }
            }

            _x2 = _x1 - moves;
            if (_x2 < 0)
                InvalidMove();
            else DrawBoard(gameBoard, penStatus, direction, moves, _x1, _y1, _x2, _y2);

            }
        


        public static void South(char[,] gameBoard, int penStatus, Options direction, int moves)
        {
            for (var row = 0; row < 20; row++)
            {
                for (var col = 0; col < 20; col++)
                {
                    if (gameBoard[row, col].Equals('X'))
                    {
                        _x1 = row;
                        _y1 = col;
                    }
                }
            }

            _x2 = _x1 + moves;
            if (_x2 > 19)
                InvalidMove();
            else DrawBoard(gameBoard, penStatus, direction, moves, _x1, _y1, _x2, _y2);
        }


        public static void East(char[,] gameBoard, int penStatus, Options direction, int moves)
        {
            for (var row = 0; row < 20; row++)
            {
                for (var col = 0; col < 20; col++)
                {
                    if (gameBoard[row, col].Equals('X'))
                    {
                        _x1 = row;
                        _y1 = col;
                    }
                }
            }

            _y2 = _y1 + moves;
            if (_y2 > 19)
                InvalidMove();
            else DrawBoard(gameBoard, penStatus, direction, moves, _x1, _y1, _x2, _y2);
        }


        public static void West(char[,] gameBoard, int penStatus, Options direction, int moves)
        {
            for (var row = 0; row < 20; row++)
            {
                for (var col = 0; col < 20; col++)
                {
                    if (gameBoard[row, col].Equals('X'))
                    {
                        _x1 = row;
                        _y1 = col;
                    }
                }
            }

            _y2 = _y1 - moves;
            if (_y2 < 0)
                InvalidMove();
            else DrawBoard(gameBoard, penStatus, direction, moves, _x1, _y1, _x2, _y2);
        }


        public static void Quit()
        {
            Console.WriteLine("Thank you for playing!");
            Environment.Exit(0);
        }


        public static void InvalidMove()
        {
            Console.WriteLine("That is not a valid move. \n\n");
            PlayTurtle();
        }


        public static void PlayTurtle()
        {
            do
            {
                DisplayBoard(_board);
                DislpayInstructions();
                DisplayPenStatus(_penStatus);
                SelectOption();
            } while (_option != 7);

            Quit();
        }
    }
}
