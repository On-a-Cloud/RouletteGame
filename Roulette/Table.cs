using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Table
    {
      
      
            public int numOfCards = 52;
            public string[] cards = new string[13];
            public string[] playingCards = new string[52];
            public string[] cardsDealt = new string[52];
            Random r = new Random();
            int y = 0;

            public string NextCard()
            {
                string nextCard = "-";

                int x = 0;

                while (x < 1)
                {
                    nextCard = playingCards[r.Next(0, playingCards.Length)];

                    if (!cardsDealt.Contains(nextCard))
                    {
                        cardsDealt[y] = nextCard;
                        y++;
                        x++;
                    }
                    else
                    {
                        Console.WriteLine("Shuffling!");
                        x = 0;
                    }

                }
                return nextCard;
            }
        public void ConstructDeck()
        {
            // spade club heart diamond
            this.cards[0] = "A";
            this.cards[1] = "K";
            this.cards[2] = "Q";
            this.cards[3] = "J";
            this.cards[4] = "10";
            this.cards[5] = "9";
            this.cards[6] = "8";
            this.cards[7] = "7";
            this.cards[8] = "6";
            this.cards[9] = "5";
            this.cards[10] = "4";
            this.cards[11] = "3";
            this.cards[12] = "2";

            int x = 0;
            foreach (string card in this.cards)
            {

                this.playingCards[x] = card + "s";
                x++;
                this.playingCards[x] = card + "c";
                x++;
                this.playingCards[x] = card + "h";
                x++;
                this.playingCards[x] = card + "d";
                x++;
            }
        }

          

    

        class SpinTheWheel

        {

            Random rand = new Random();

            public int winningNumber;



            public void Spin(Random rand)

            {

                winningNumber = rand.Next(1, 37);

            }

        }

    }
}

