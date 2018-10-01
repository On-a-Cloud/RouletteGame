using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Roulette.UserBet;

namespace Roulette
{
    class DisplayBetOutcome
    {
        public void IndividualNumberWin(SpinTheWheel spin, NumberBet bet, Board[] rouletteBoard)
        {
            if (rouletteBoard[spin.winningNumber].number == bet.numberChoice)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win.");
            }
        }
        public void EvenOddWin(SpinTheWheel spin, EvenOdd evenOdd, Board[] rouletteBoard)
        {
            if (rouletteBoard[spin.winningNumber].number == evenOdd.evenOddChoice)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win.");
            }
        }
        public void RedBlackWin(SpinTheWheel spin, Colors color, Board[] rouletteBoard)
        {
            if ((rouletteBoard[spin.winningNumber].number == 1 || rouletteBoard[spin.winningNumber].number == 3 || rouletteBoard[spin.winningNumber].number == 5 || rouletteBoard[spin.winningNumber].number == 7 || rouletteBoard[spin.winningNumber].number == 9 ||
                 rouletteBoard[spin.winningNumber].number == 12 || rouletteBoard[spin.winningNumber].number == 14 || rouletteBoard[spin.winningNumber].number == 16 || rouletteBoard[spin.winningNumber].number == 18 || rouletteBoard[spin.winningNumber].number == 19 ||
                 rouletteBoard[spin.winningNumber].number == 21 || rouletteBoard[spin.winningNumber].number == 23 || rouletteBoard[spin.winningNumber].number == 25 || rouletteBoard[spin.winningNumber].number == 27 || rouletteBoard[spin.winningNumber].number == 30 ||
                 rouletteBoard[spin.winningNumber].number == 32 || rouletteBoard[spin.winningNumber].number == 34 || rouletteBoard[spin.winningNumber].number == 36) && (color.colorChoice == 1))
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win.");
            }
        }
        public void LowHighWin(SpinTheWheel spin, HighLow lowHigh, Board[] rouletteBoard)
        {
            if ((rouletteBoard[spin.winningNumber].number <= 18) && (lowHigh.lowHighChioce == 1))
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win.");
            }
        }    
        public void DozensWin(SpinTheWheel spin, Dozens dozen, Board[] rouletteBoard)
        {
            if (((rouletteBoard[spin.winningNumber].number > 0) && (rouletteBoard[spin.winningNumber].number <= 12) && (dozen.dozenChoice == 1)))
            {
                Console.WriteLine("You Won!");
            }
            else if (((rouletteBoard[spin.winningNumber].number >= 13) && (rouletteBoard[spin.winningNumber].number <= 24) && (dozen.dozenChoice == 2)))
            {
                Console.WriteLine("You Won!");
            }
            else if (((rouletteBoard[spin.winningNumber].number >= 25) && (rouletteBoard[spin.winningNumber].number <= 36) && (dozen.dozenChoice == 3)))
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win.");
            }
        }
        public void ColumnsWin(SpinTheWheel spin, Columns column, Board[] rouletteBoard)
        {
            if ((rouletteBoard[spin.winningNumber].number == 1 || rouletteBoard[spin.winningNumber].number == 4 || rouletteBoard[spin.winningNumber].number == 7 ||
                rouletteBoard[spin.winningNumber].number == 10 || rouletteBoard[spin.winningNumber].number == 13 || rouletteBoard[spin.winningNumber].number == 16 ||
                rouletteBoard[spin.winningNumber].number == 19 || rouletteBoard[spin.winningNumber].number == 22 || rouletteBoard[spin.winningNumber].number == 25 ||
                rouletteBoard[spin.winningNumber].number == 28 || rouletteBoard[spin.winningNumber].number == 31 || rouletteBoard[spin.winningNumber].number == 34)
                && (column.columnChoice == 1))
            {
                Console.WriteLine("You Won!");
            }
            else if ((rouletteBoard[spin.winningNumber].number == 2 || rouletteBoard[spin.winningNumber].number == 5 || rouletteBoard[spin.winningNumber].number == 8 ||
                      rouletteBoard[spin.winningNumber].number == 11 || rouletteBoard[spin.winningNumber].number == 14 || rouletteBoard[spin.winningNumber].number == 17 ||
                      rouletteBoard[spin.winningNumber].number == 20 || rouletteBoard[spin.winningNumber].number == 23 || rouletteBoard[spin.winningNumber].number == 26 ||
                      rouletteBoard[spin.winningNumber].number == 29 || rouletteBoard[spin.winningNumber].number == 32 || rouletteBoard[spin.winningNumber].number == 35)
                      && (column.columnChoice == 2))
            {
                Console.WriteLine("You Won!");
            }
            else if ((rouletteBoard[spin.winningNumber].number == 3 || rouletteBoard[spin.winningNumber].number == 6 || rouletteBoard[spin.winningNumber].number == 9 ||
                      rouletteBoard[spin.winningNumber].number == 12 || rouletteBoard[spin.winningNumber].number == 15 || rouletteBoard[spin.winningNumber].number == 18 ||
                      rouletteBoard[spin.winningNumber].number == 21 || rouletteBoard[spin.winningNumber].number == 24 || rouletteBoard[spin.winningNumber].number == 27 ||
                      rouletteBoard[spin.winningNumber].number == 30 || rouletteBoard[spin.winningNumber].number == 33 || rouletteBoard[spin.winningNumber].number == 36)
                      && (column.columnChoice == 3))
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win");
            }
        }
        public void StreetWin(SpinTheWheel spin, Streets street, Board[] roulettBoard)
        {
            if ((roulettBoard[spin.winningNumber].number == 1 || roulettBoard[spin.winningNumber].number == 2 || roulettBoard[spin.winningNumber].number == 3) && (street.rowChoice == 1))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 4 || roulettBoard[spin.winningNumber].number == 5 || roulettBoard[spin.winningNumber].number == 6) && (street.rowChoice == 2))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 7 || roulettBoard[spin.winningNumber].number == 8 || roulettBoard[spin.winningNumber].number == 9) && (street.rowChoice == 3))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 10 || roulettBoard[spin.winningNumber].number == 11 || roulettBoard[spin.winningNumber].number == 12) && (street.rowChoice == 4))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 13 || roulettBoard[spin.winningNumber].number == 14 || roulettBoard[spin.winningNumber].number == 15) && (street.rowChoice == 5))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 16 || roulettBoard[spin.winningNumber].number == 17 || roulettBoard[spin.winningNumber].number == 18) && (street.rowChoice == 6))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 19 || roulettBoard[spin.winningNumber].number == 20 || roulettBoard[spin.winningNumber].number == 21) && (street.rowChoice == 7))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 22 || roulettBoard[spin.winningNumber].number == 23 || roulettBoard[spin.winningNumber].number == 24) && (street.rowChoice == 8))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 25 || roulettBoard[spin.winningNumber].number == 26 || roulettBoard[spin.winningNumber].number == 27) && (street.rowChoice == 9))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 28 || roulettBoard[spin.winningNumber].number == 29 || roulettBoard[spin.winningNumber].number == 30) && (street.rowChoice == 10))
            {
                Console.WriteLine("You Won!");
            }  
            else if ((roulettBoard[spin.winningNumber].number == 31 || roulettBoard[spin.winningNumber].number == 32 || roulettBoard[spin.winningNumber].number == 33) && (street.rowChoice == 11))
            {
                Console.WriteLine("You Won!");
            }
            else if ((roulettBoard[spin.winningNumber].number == 34 || roulettBoard[spin.winningNumber].number == 35 || roulettBoard[spin.winningNumber].number == 36) && (street.rowChoice == 2))
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You did not win.");
            }
        }
        public void SixNumberWin()
        {
        }
        public void SplitWin()
        {
        }
        public void CornerWin()
        {
        }
    }
}