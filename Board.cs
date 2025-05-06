using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public Tile[,] BoardTiles { get; set; } = new Tile[3, 3];

        public void SetTiles()
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int value = (2 - i) * 3 + j + 1;
                    BoardTiles[i, j] = new Tile((TileValue)value);
                }
            }
        }

        public Tile GetTile(int tileValue)
        {
            foreach (Tile tile in BoardTiles)
            {
                if(tile.TileInitValue == (TileValue)tileValue)
                {
                    return tile;
                }
            }
            throw new ArgumentException($"No tile with value ${(TileValue)tileValue} found");
        }

        public bool ChangeTile(int tileValue, PlayerSymbols playerSymbol)
        {
            Tile tile = GetTile(tileValue);

            if(tile.TileValue != TileValue.X && tile.TileValue != TileValue.O)
            {
                tile.TileValue = (TileValue)playerSymbol;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
