using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class BoardUtils
    {
        public static bool CheckForWinOrDraw(Tile[,] tileArray, int turn)
        {
            int[][] winPatterns =
            [
                // Rows
                [0, 0, 0, 1, 0, 2],
                [1, 0, 1, 1, 1, 2],
                [2, 0, 2, 1, 2, 2],
                // Columns
                [0, 0, 1, 0, 2, 0],
                [0, 1, 1, 1, 2, 1],
                [0, 2, 1, 2, 2, 2],
                // Diagonals
                [0, 0, 1, 1, 2, 2],
                [0, 2, 1, 1, 2, 0]
            ];

            foreach(var pattern in winPatterns)
            {
                var a = tileArray[pattern[0], pattern[1]].TileValue;
                var b = tileArray[pattern[2], pattern[3]].TileValue;
                var c = tileArray[pattern[4], pattern[5]].TileValue;

                if(a == b && b == c)
                {
                    BoardGUI.DisplayBoard(tileArray);
                    Player player = Game.PlayerArray.FirstOrDefault(p => p.Symbol == (PlayerSymbols)(int)a)!;
                    Console.WriteLine($"{player.PlayerName} wins!");
                    return true;
                }
                else if (turn == 9)
                {
                    Console.WriteLine("It's a draw!");
                    return true;
                }
            }

            return false;
        }
    }
}
