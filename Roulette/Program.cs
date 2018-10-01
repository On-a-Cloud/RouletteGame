using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var rouletteBoard = RouletteBoard.CreateBoard();
            NumberBet number = new NumberBet();
            EvenOdd evenOdd = new EvenOdd();        
            Colors color = new Colors();
            HighLow highLow = new HighLow();
            Dozens dozen = new Dozens();
            Columns column = new Columns();
            Streets street = new Streets();
            Random rand = new Random();
            DisplayWinner winner = new DisplayWinner();
            SpinTheWheel wheel = new SpinTheWheel();
            UserBet bet = new UserBet();
            DisplayBetOutcome result = new DisplayBetOutcome();
            bet.DisplayTypeOfBet();
            bet.TypeOfBet();
            if (bet.userSelect == 1)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.IndividualNumberWin(wheel, number, rouletteBoard);
            }
            else if (bet.userSelect == 2)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.EvenOddWin(wheel, evenOdd, rouletteBoard);
            }
            else if (bet.userSelect == 3)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.RedBlackWin(wheel, color, rouletteBoard);
            }
            else if (bet.userSelect == 4)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.LowHighWin(wheel, highLow, rouletteBoard);
            }
            else if (bet.userSelect == 5)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.DozensWin(wheel, dozen, rouletteBoard);
            }
            else if (bet.userSelect == 6)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.ColumnsWin(wheel, column, rouletteBoard);
            }
            else if (bet.userSelect == 7)
            {
                wheel.Spin(rand);
                winner.DisplayResult(wheel, rouletteBoard);
                result.StreetWin(wheel, street, rouletteBoard);
            }
        }
    }
}