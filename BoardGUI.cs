using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public static class BoardGUI
    {
        public static void DisplayBoard(Tile[,] tileArray)
        {
            string valueToShow;
            for(int i = 0; i < tileArray.GetLength(0); i++)
            {
                for(int j = 0; j < tileArray.GetLength(1); j++)
                {
                    if ((int)tileArray[i, j].TileValue < 10)
                    {
                        int tileValue = (int)tileArray[i, j].TileValue;
                        valueToShow = tileValue.ToString();
                    }
                    else
                    {
                        valueToShow = tileArray[i, j].TileValue.ToString();
                    }

                    if (j == 0)
                    {
                        Console.Write($" {valueToShow}");
                    }
                    else
                    {
                        Console.Write($" | {valueToShow}");
                    }
                }
                if (i < 2) Console.WriteLine("\n---+---+---");
            }
            Console.WriteLine();
        }
    }
}
