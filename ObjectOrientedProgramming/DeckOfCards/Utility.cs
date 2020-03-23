using ObjectOrientedProgramming.DataStructure;
using System;

namespace ObjectOrientedProgramming.DeckOfCards
{
    class Utility
    {
        private static int initial = 0;
        private static int end = 0;
        private static string[] checkCards = new string[52];

        public static void SortDeckOfCards()
        {
            for (int i = initial; i < end; i++)
            {
                for (int j = initial; j < end; j++)
                {
                    Console.WriteLine("{0} {1}",checkCards[i],checkCards[j]);
                    int result = checkCards[i].CompareTo(checkCards[j]);
                    Console.WriteLine("Sort:{0}", result);

                    if (result < 0)
                    {
                        string temp = checkCards[i];
                        checkCards[i] = checkCards[j];
                        checkCards[j] = temp;
                    }

                }
            }
        }
        public static QueueLinkedList DeckOfCard(string[] suits, string[] rank)
        {
            try
            {
                QueueLinkedList queueLinkedList = new QueueLinkedList();

                Random random = new Random();

                bool flag, inputFlag;

                for (int j = 0; j < 9; j++)
                {
                    do
                    {
                        inputFlag = false;
                        flag = false;
                        int suitsRandom = random.Next(0, 4);
                        char initial = suits[suitsRandom].ToCharArray()[0];

                        int rankRandom = random.Next(0, 13);
                        string cardsForm = rank[rankRandom] + initial;

                        if (end == 0)
                        {
                            checkCards[end] = cardsForm;
                            end++;
                            flag = true;
                        }
                        else
                        {
                            for (int k = 0; k < end; k++)
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
                                checkCards[end] = cardsForm;
                                end++;
                                flag = true;
                            }
                        }
                    } while (!flag);
                }
                SortDeckOfCards();

                for (int i = initial; i < end; i++)
                    queueLinkedList.Enqueue(checkCards[i]);

                initial = end;

                return queueLinkedList;
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                return null;
            }
        }
    }
}
