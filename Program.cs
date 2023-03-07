using System;
using Animals;




namespace KnowledgeCheck2

{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Cat>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var Bleu = new Cat();

                Console.WriteLine("Type your cat's name to view some of their attributes");
                Bleu.name = Console.ReadLine();

                Bleu.nightVision = Console.ReadLine();

                


                recordList.Add(Bleu);
            }

            foreach (var record in recordList)
            {
                Console.WriteLine("This cat's name is " + record.name );
                Console.WriteLine(" " + record.name + " has " + record.numberOfLegs + " legs");
                Console.WriteLine(" " + record.name + " has " + record.numberOfEyes + " eyes");
            }
        }

    }
}

// Print out the list of records using Console.WriteLine()