using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class Game
    {
        public static Player[] PlayerArray { get; set; } = new Player[2];

        public static void Run()
        {
            Board newBoard = new();
            newBoard.SetTiles();

            SelectSymobls();
            int turn = 0;

            do
            {
                Player currPlayer = PlayerArray[turn % 2];
                BoardGUI.DisplayBoard(newBoard.BoardTiles);
                TakeTurn(currPlayer, newBoard);
                turn++;
                Console.Clear();

            } while (!BoardUtils.CheckForWinOrDraw(newBoard.BoardTiles, turn));

        }

        private static void SelectSymobls()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine($"Player 1, pick your symbol ({PlayerSymbols.O} or {PlayerSymbols.X}):");
                var input = Console.ReadLine();

                if (input != null && Enum.TryParse<PlayerSymbols>(input, true, out var symbol) && Enum.IsDefined(typeof(PlayerSymbols), symbol))
                {
                    PlayerArray[0] = new Player(symbol, "Player 1");
                    PlayerArray[1] = new Player(Player.GetOtherSymbol(symbol), "Player 2");
                    isValid = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"{input} is not a valid symbol. Try again.");
                }
            } while (!isValid);
        }

        private static void TakeTurn(Player player, Board board)
        {
            bool isValid = false;
            do
            {

               Console.WriteLine($"{player.PlayerName} please enter the tile number you'd like to put your {player.Symbol} in: ");
               var input = Console.ReadLine();

                if(input != null)
                {
                    if(int.TryParse(input, out int inputNum) && inputNum < 10 && inputNum > 0)
                    {
                        if(board.ChangeTile(inputNum, player.Symbol))
                        {
                            Console.WriteLine($"Tile number {inputNum} now changed to {player.Symbol}");
                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer between 1 and 9 that doesn't have a symbol.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer between 1 and 9.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid value.");
                }

            } while (!isValid);
        }
    }
}
