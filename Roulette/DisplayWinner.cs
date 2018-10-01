using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class DisplayWinner
    {
        public void DisplayResult(SpinTheWheel wheel, Board[] rouletteBoard)
        {
            if (wheel.winningNumber == 38)
            {
                Console.WriteLine("The winner is: 00 Green");
            }
            else
            {
                Console.WriteLine($"The winner is {rouletteBoard[wheel.winningNumber].number} " +
                                  $"{rouletteBoard[wheel.winningNumber].color}");
            }
        }
    }
}
