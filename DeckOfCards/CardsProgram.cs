using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using DeckOfCards.DomainObjects;
using DeckOfCards.BusinessLogic;

namespace DeckOfCards
{
    ///<summary>
    /// Hi! This Git project should run after you restore the NUnit packages in Nuget, so please do that first.
    /// If you have trouble running the tests, go to Tests - Test Settings - Default Processor Architecture and select the right one for your machine. 
    /// That snagged me a few times because it defaults to x86.
    /// This could have been easily written quicker and dirtier but I tried to write it mostly in a way that would reflect how I'd write code that's part
    /// of a larger project.
    /// It's a console app to keep things simple so just run and play with it! If you have questions let me know. Thanks so much for your time and 
    /// consideration!
    /// </summary>
    ///<author>Megan DiVall</author>

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    
    public class CardsProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the card shuffler and sorter!");
            Console.WriteLine("Would you like to sort an out-of-order deck or shuffle a sorted deck? Enter \"sort\" or \"shuffle\" to choose.");
            var input = Console.ReadLine();
            while (!InputLogic.IsInputValid(input))
            {
                Console.WriteLine("Sorry, that's not a valid request, please try again.");
                input = Console.ReadLine();
            }
            
            while (InputLogic.IsInputValid(input))
            {
                var deckToProcess = InputLogic.RetrieveDeckToProcess(input);
                var output = InputLogic.Execute(input, deckToProcess);

                Console.WriteLine("Here's the initial deck:");
                CardLogic.DeckPrinter(deckToProcess);
                Console.WriteLine();
                Console.WriteLine("Here's the new deck:");
                CardLogic.DeckPrinter(output);

                Console.WriteLine("Would you like to see another deck? Enter \"sort\", \"shuffle\", or any value to exit.");
                input = Console.ReadLine();
            }
        }
    }
}
