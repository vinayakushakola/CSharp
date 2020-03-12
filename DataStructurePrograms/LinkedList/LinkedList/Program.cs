using System;
using System.IO;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("\n\n1.Unordered Linked List");
                    Console.WriteLine("\n\n2.Ordered Linked List");

                    Console.WriteLine("3.Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the file name: ");
                            string textFile = Console.ReadLine();
                            string path = @"C:\Users\User\source\repos\Vinayak\CSharp\DataStructurePrograms\LinkedList\LinkedList\" + textFile;
                            string[] lines = File.ReadAllLines(path);
                            LinkedList<string> llist = new LinkedList<string>();
                            foreach (string line in lines)
                            {
                                string[] words = line.Split(" ");
                                foreach (string word in words)
                                {
                                    llist.AddToEnd(word);
                                }
                            }
                            Console.Write("\nFile contents in the list is: ");
                            llist.ShowList();

                            Console.Write("\nEnter the word to be searched: ");
                            string wordSearch = Console.ReadLine();
                            if (llist.Search(wordSearch))
                            {
                                llist.DeleteNode(wordSearch);
                                Console.WriteLine("\nWord " + wordSearch + " found in the Linked List and deleted\n");
                            }
                            else
                            {
                                llist.AddToEnd(wordSearch);
                                Console.WriteLine("\nWord " + wordSearch + " not found in the Linked List\n");
                            }
                            string createText = llist.FileDisplay();
                            Console.WriteLine(createText);
                            StreamWriter writetext = new StreamWriter(path);
                            writetext.WriteLine(createText);
                            writetext.Close();
                            break;
                        case 2:
                            Console.Write("Enter the file name: ");
                            string textFile2 = Console.ReadLine();
                            string path2 = @"C:\Users\User\source\repos\Vinayak\CSharp\DataStructurePrograms\LinkedList\LinkedList\" + textFile2;
                            string[] lines2 = File.ReadAllLines(path2);
                            LinkedList<string> llist2 = new LinkedList<string>();
                            foreach (string line in lines2)
                            {
                                string[] words = line.Split(" ");
                                foreach (string word in words)
                                {
                                    llist2.AddToEnd(word);
                                }
                            }
                            Console.Write("\nFile contents in the list is: ");
                            llist2.ShowList();

                            Console.Write("\nEnter the number to be searched: ");
                            string numSearch = Console.ReadLine();
                            if (llist2.Search(numSearch))
                            {
                                llist2.DeleteNode(numSearch);
                                Console.WriteLine("\nNumber " + numSearch + " found in the Linked List and deleted\n");
                            }
                            else
                            {
                                llist2.AddToEnd(numSearch);
                                Console.WriteLine("\nNumber " + numSearch + " not found in the Linked List\n");
                            }
                            string createText2 = llist2.FileDisplay();
                            Console.WriteLine(createText2);
                            StreamWriter writetext2 = new StreamWriter(path2);
                            writetext2.WriteLine(createText2);
                            writetext2.Close();
                            break;
                        case 3:
                            flag = false;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
