using System;

namespace ObjectOrientedProgramming.DeckOfCards
{
    class DeckOfCardsProgram
    {
        public static void DeckOfCards()
        {
            try
            {

                Console.WriteLine("\n-----------------Deck of Cards-----------------\n");

                string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
                string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

                string[] checkCards = new string[52];
                string[,] cards = new string[4, 9];

                Random random = new Random();
                int count = 0, cardsCount = 0;
                bool flag, inputFlag;

                for (int i = 0; i < 4; i++)
                {
                    cardsCount = 0;
                    for (int j = 0; j < 9; j++)
                    {
                        do
                        {
                            flag = false;
                            inputFlag = false;
                            // Generating 0 - 3 numbers
                            int suitsRandom = random.Next(0, 4);
                            // First position of suit e.g -> For Diamonds = D
                            char initial = suits[suitsRandom].ToCharArray()[0];

                            // Generating 0 - 12 numbers
                            int rankRandom = random.Next(0, 13);
                            // D(initial) + rank[7] e.g -> D8
                            string cardsForm = initial + rank[rankRandom];

                            if (count == 0)
                            {
                                checkCards[count] = cardsForm;
                                cards[i, cardsCount] = cardsForm;
                                count++;
                                cardsCount++;
                                flag = true;
                            }
                            else
                            {
                                for (int k = 0; k < count; k++)
                                {
                                    if (checkCards[k] == cardsForm)
                                    {
                                        flag = false;
                                        inputFlag = true;
                                        break;
                                    }
                                }
                                if (!inputFlag)
                                {
                                    checkCards[count] = cardsForm;
                                    cards[i, cardsCount] = cardsForm;
                                    count++;
                                    cardsCount++;
                                    flag = true;
                                }
                            }
                        } while (!flag);
                    }
                }
                for(int i=0;i<4;i++)
                {
                    for (int j = 0; j < 9; j++)
                        Console.Write(cards[i, j] + "\t");
                    Console.WriteLine();
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
