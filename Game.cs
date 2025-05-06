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
            BoardGUI.DisplayBoard(newBoard.BoardTiles);

            SelectSymobls();

            while (BoardUtils.CheckForWin(newBoard.BoardTiles) != null)
            {

            }
        }

        private static void SelectSymobls()
        {
            while (PlayerArray[1] == null)
            {
                Console.WriteLine();
            }
        }
    }
}
