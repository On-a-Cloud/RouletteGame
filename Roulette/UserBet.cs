using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public struct NumberBet
    {
        public int numberChoice { get; set; }
    }
    public struct EvenOdd
    {
        public int evenOddChoice { get; set; }
    }
    public struct Colors
    {
        public int colorChoice { get; set; }
    }
    public struct HighLow
    {
        public int lowHighChioce { get; set; }
    }
    public struct Dozens
    {
        public int dozenChoice { get; set; }
    }
    public struct Columns
    {
        public int columnChoice { get; set; }
    }
    public struct Streets
    {
        public int rowChoice { get; set; }
    }
    public struct SixNum
    {
        public int doubleRowChoice { get; set; }
        public int doubleRowChoice2 { get; set; }
    }
    public struct Splits
    {
    }
    public struct Corners
    {
    }
    class UserBet
    {
        public int userSelect = 0;
        public void DisplayTypeOfBet()
        {
            Console.WriteLine("What would you like to bet on?");
            Console.WriteLine("Type 1 for a Number Bet (pick a single number)");
            Console.WriteLine("Type 2 for a Even or Odd Bet (pick all evens or all odds)");
            Console.WriteLine("Type 3 for a Color Bet (pick reds or blacks)");
            Console.WriteLine("Type 4 for a Lows or Highs Bet (lows(1-18) highs(19-38)");
            Console.WriteLine("Type 5 for a Dozens Bet (1-12, 13-24 or 25-36)");
            Console.WriteLine("Type 6 for a Columns Bet (first, second or third column)");
            Console.WriteLine("Type 7 for a Street Bet (rows. ex: 1/2/3 or 22/23/24)");
            Console.WriteLine("Type 8 for a 6 Number Bet (double rows. ex: 1/2/3/4/5/6)");
            Console.WriteLine("Type 9 for a Split Bet (the edge of any two contiguous numbers. ex: 1/2 or 11/14)");
            Console.WriteLine("Type 10 for a Corner Bet (the intersection of any four contiguous numbers ex: 1/2/4/5");
        }
        public void TypeOfBet()
        {
            while (userSelect == 0)
            {
                Console.WriteLine("What kind of bet would you like to make?");
                userSelect = int.Parse(Console.ReadLine());
                if (userSelect == 1)
                {
                    IndividualNumberBet();
                }
                else if (userSelect == 2)
                {
                    EvenOddBet();
                }
                else if (userSelect == 3)
                {
                    ColorBet();
                }
                else if (userSelect == 4)
                {
                    LowHighBet();
                }
                else if (userSelect == 5)
                {
                    DozenBet();
                }
                else if (userSelect == 6)
                {
                    ColumnBet();
                }
                else if (userSelect == 7)
                {
                    StreetBet();
                }
                else if (userSelect == 8)
                {
                    SixNumberBet();
                }
                else if (userSelect == 9)
                {
                    SplitBet();
                }
                else if (userSelect == 10)
                {
                    CornerBet();
                }
                else
                {
                    Console.WriteLine("Please make a valid Selection");
                }
            }
        }
        public int IndividualNumberBet()
        {
            int numberChoice = 0;
            try
            {
                Console.WriteLine("You chose a number bet. Select which number you want. (enter 37 for 0 and 38 for 00 )");
                numberChoice = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid choice");
            }
            return numberChoice;
        }
        public int EvenOddBet()
        {
            int evenOddChoice = 0;
            Console.WriteLine("You chose to bet on Evens or Odds. Enter 1 for Evens and 2 for Odds");
            evenOddChoice = int.Parse(Console.ReadLine());
            return evenOddChoice;
        }
        public int ColorBet()
        {
            int colorChoice = 0;
            while (colorChoice < 1 || colorChoice > 2)
            {
                Console.WriteLine("You chose to bet on a Color. Enter 1 for Reds and 2 for Blacks");
                colorChoice = int.Parse(Console.ReadLine());
            } 
            return colorChoice;

        }
        public int LowHighBet()
        {
            int lowHighChoice = 0;
            while (lowHighChoice <= 0 || lowHighChoice > 2)
            {
                Console.WriteLine("You chose to be on Highs or Lows. Enter 1 for Lows or 2 for Highs.");
                lowHighChoice = int.Parse(Console.ReadLine());
            }
            return lowHighChoice;
        }
        public int DozenBet()
        {
            int dozenChoice = 0;
            while (dozenChoice <= 0 || dozenChoice > 3)
            {
                Console.WriteLine("You chose to bet on Dozens. Ender 1 for 1-12, 2 for 13-24 or 3 for 25-36.");
                dozenChoice = int.Parse(Console.ReadLine());
            }
            return dozenChoice;
        }
        public int ColumnBet()
        {
            int columnChoice = 0;
            while (columnChoice <= 0 || columnChoice > 3)
            {
                Console.WriteLine("You chose to bet on a Column. Enter 1 for the first column, 2 for the second column or 3 for the third column.");
                columnChoice = int.Parse(Console.ReadLine());
            }
            return columnChoice;

        }

        public int StreetBet()
        {
            int rowChoice = 0;
            while (rowChoice <= 0 || rowChoice > 12)
            {
                Console.WriteLine("You chose to bet on a Street(row). Enter which row you want (1-12)");
                rowChoice = int.Parse(Console.ReadLine());
            }
            return rowChoice;
        }
        public int SixNumberBet()
        {
            int doubleRowChoice = 0;
            int doubleRowChoice2 = 12;
            do
            {
                Console.WriteLine("You chose a 6 number bet. Enter the first row you want (1-12)");
                doubleRowChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second row you want (1-12)");
                doubleRowChoice2 = int.Parse(Console.ReadLine());
            }
            while (((doubleRowChoice <= 0 || doubleRowChoice > 12) && (doubleRowChoice2 <= 0 || doubleRowChoice2 > 12) && (doubleRowChoice != doubleRowChoice2)));
            return (doubleRowChoice) + (doubleRowChoice2);
        }
        public void SplitBet()
        {
        }
        public void CornerBet()
        {
        }
    }
}