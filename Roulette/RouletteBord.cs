using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roulette
{
    class RouletteBoard
    {
        public static Board[] rouletteBoard = new Board[38];
        public static Board[] CreateBoard()
        {
            for (int i = 0; i < rouletteBoard.Length; i++)
            {
                if (i == 38)
                {
                    rouletteBoard[i] = new Board(00, "Green");
                }
                else if (i == 0)
                {
                    rouletteBoard[i] = new Board(0, "Green");
                }
                else if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 ||
                         i == 12 || i == 14 || i == 16 || i == 18 || i == 19 ||
                         i == 21 || i == 23 || i == 25 || i == 27 || i == 30 ||
                         i == 32 || i == 34 || i == 36)
                {
                    rouletteBoard[i] = new Board(i, "Red");
                }
                else
                {
                    rouletteBoard[i] = new Board(i, "Black");
                }
            }
            return rouletteBoard;
        }
    }
}