using System;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 print all cards of a standart deck.

            for (int paint = 1; paint <= 4; paint++) // loop through paints
            {
                for (int cards = 2; cards <= 14; cards++) // loop through cards
                {
                    switch (cards)
                    {
                        case 2: Console.Write("Two"); break;
                        case 3: Console.Write("Three"); break;
                        case 4: Console.Write("Four"); break;
                        case 5: Console.Write("Five"); break;
                        case 6: Console.Write("Six"); break;
                        case 7: Console.Write("Seven"); break;
                        case 8: Console.Write("Eight"); break;
                        case 9: Console.Write("Nine"); break;
                        case 10: Console.Write("Ten"); break;
                        case 11: Console.Write("Jack"); break;
                        case 12: Console.Write("Queen"); break;
                        case 13: Console.Write("King"); break;
                        case 14: Console.Write("Ace"); break;
                        default: Console.Write("Error!"); break;
                    }

                    switch (paint)
                    {
                        case 1: Console.WriteLine(" of Spades"); break;
                        case 2: Console.WriteLine(" of Hearts"); break;
                        case 3: Console.WriteLine(" of Clubs"); break;
                        case 4: Console.WriteLine(" of Diamonds"); break;
                        default: Console.WriteLine("Error"); break;
                    }

                }
            }
    }
}
