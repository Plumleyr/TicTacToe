using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Player(PlayerSymbols chosenSymbol, string playerName)
    {
        public PlayerSymbols Symbol { get; init; } = chosenSymbol;
        public string PlayerName { get; init; } = playerName;

        public static PlayerSymbols GetOtherSymbol(PlayerSymbols symbol)
        {
            return symbol == PlayerSymbols.X ? PlayerSymbols.O : PlayerSymbols.X;
        }
    }

    public enum PlayerSymbols
    {
        O = TileValue.O,
        X = TileValue.X
    }
}
