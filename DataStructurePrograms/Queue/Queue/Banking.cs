using System;

namespace Queue
{
    public class Banking
    {
        public void CashCounter()
        {
            try
            {
                long bankBalance = 0;
                Console.WriteLine(".....Welcome.....");
                Console.WriteLine("To Banking Portal");
                Console.Write("\nEnter How Many Peoples You Want To Add In A Queue: ");
                int numberofpeople = Convert.ToInt32(Console.ReadLine());
                Queue queue = new Queue(numberofpeople);

                for (int i = 1; i <= numberofpeople; i++)
                {
                    Console.WriteLine("User " + i + ":");

                    queue.Enqueue(i);

                }

                if (numberofpeople > 0)
                {
                    for (int i = 1; i <= numberofpeople; i++)
                    {
                        Console.WriteLine("\nTransactions......");
                        Console.Write("\nPress Key : \n\t 1. Deposit \n\t 2. Withdraw:\n");
                        int key = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Transaction Of User" + i + ":");
                        queue.Dequeue();
                        if (key == 1)
                        {

                            Console.Write("\nEnter total amount do you want to deposit:");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            if (deposit > 0)
                            {
                                queue.Enqueue(deposit);
                                Console.WriteLine("Deposit Successfully....");
                                bankBalance = bankBalance + deposit;
                                Console.WriteLine("Total balance is:" + bankBalance);
                            }
                            else
                            {
                                Console.WriteLine("Please enter amount greater than 0");
                            }
                        }
                        else if (key == 2)
                        {
                            Console.WriteLine("Enter total amount do you want to withdrow");
                            int withdrow = Convert.ToInt32(Console.ReadLine());
                            if (bankBalance >= withdrow)
                            {
                                Console.WriteLine("Withdrow Successfully...");
                                bankBalance = bankBalance - withdrow;
                                Console.WriteLine("Toatal Balance is : " + bankBalance);
                                queue.QueueDisplay();
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Insure that you enter correct key");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Some Error Occured try again!");
            }
        }
    }
}
