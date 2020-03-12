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
                    Console.WriteLine("\n\n1.Unoredered Linked List");
                    Console.WriteLine("2.Exit");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the file name: ");
                            string textFile = Console.ReadLine();
                            string path = @"C:\Users\User\source\repos\Vinayak\CSharp\LinkedList\LinkedList\" + textFile;
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
