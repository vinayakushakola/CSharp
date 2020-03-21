using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            School s = new School();

            Console.Write("Enter your id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            s.SetID(id);

            Console.Write("Enter your Name: ");
            s.Name = Console.ReadLine();

            string name2 = s.Name;
            int id2 = s.GetID();
            Console.WriteLine("Your id is: ",id2);
            Console.WriteLine("Your name is: ",name2);
            Console.WriteLine("Passing marks: {0}", s.PassMark);
        }
    }
}
