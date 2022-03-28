using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        // create a random number generator
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            // create a list of strings
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();  // we want the value of the picked card
            }
            return pickedCards; 
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";

            return value.ToString();  // value is an int type but method returns string type so we need to convert it

        }

        private static string RandomSuit()
        {
            // get a random value from 1 to 4 (note that 5 is not included)
            int value = random.Next(1, 5);

            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            // if we havn't returned anything by this point then return diamonds
            return "Diamonds";
        }

     
    }

}
