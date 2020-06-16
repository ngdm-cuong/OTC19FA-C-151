using System;

namespace _6PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            
            PigLatin.Chopping("The strong yellow crystal and I had melted");
            Console.WriteLine();
            Console.WriteLine("Type something ...");
            sentence = Console.ReadLine();
            while (sentence.Length == 0)
            {
                Console.WriteLine("Please actually type something:");
                Console.WriteLine();
                sentence = Console.ReadLine();
            }
            Console.WriteLine();
            PigLatin.Chopping(sentence);


            //Console.Write(PigLatin.Latin("yellow"));
            Console.ReadKey();
        }
    }
}
