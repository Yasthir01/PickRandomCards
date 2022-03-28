﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)  // void is used to tell c# that it doesnt return a value
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }
}
