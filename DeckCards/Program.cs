using System;

namespace DeckCards
{
    class Program
    {
        static void Main(string[] args)  //main method
        {

            Console.WriteLine("Welcome to Deck Of Cards");
            Console.WriteLine("\n");
            Cards cards = new Cards(); //creating object to call cards()
            cards.CardsCreator();  //calling cards()

        }
    }
}