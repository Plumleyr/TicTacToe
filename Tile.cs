using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Tile(TileValue value)
    {
        public TileValue TileValue { get; set; } = value;
    }

    public enum TileValue
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        O,
        X
    }
}
