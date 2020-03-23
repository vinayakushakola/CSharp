using ObjectOrientedProgramming.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.DeckOfCards
{
    class DeckOfCardsQueueProgram
    {
        public static void DeckOfCardsQueue()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("-----------------Deck of Cards Using Queue Program-----------------");
                Console.WriteLine();

                string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
                string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

                QueueLinkedList player1 = new QueueLinkedList();
                QueueLinkedList player2 = new QueueLinkedList();
                QueueLinkedList player3 = new QueueLinkedList();
                QueueLinkedList player4 = new QueueLinkedList();

                player1 = Utility.DeckOfCard(suits, rank);
                player2 = Utility.DeckOfCard(suits, rank);
                player3 = Utility.DeckOfCard(suits, rank);
                player4 = Utility.DeckOfCard(suits, rank);


                while (player1.Size() != 0)
                    player1.Dequeue();

                Console.WriteLine();

                while (player2.Size() != 0)
                    player2.Dequeue();

                Console.WriteLine();

                while (player3.Size() != 0)
                    player3.Dequeue();

                Console.WriteLine();

                while (player4.Size() != 0)
                    player4.Dequeue();

                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
            }
        }
    }
}
