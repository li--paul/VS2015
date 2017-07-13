using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammingBlockchain.Chapters;
using NBitcoin;

namespace ProgrammingBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select the chapter here.
            var chapter = new Chapter1();
            //call the lesson here.
            chapter.Lesson1();
            chapter.Lesson2();
            chapter.Lesson3();
            chapter.Lesson4();

            BitcoinSecret paymentSecret = new BitcoinSecret("L2kB44pEZjMtnrNEjJwp3kvo5toGyu9Hmieq5v8xuXD1UPuXEPUp");

            //this will hold the window open for you to read the output.
            Console.WriteLine("\n\n\nPress enter to continue.");
            Console.ReadLine();
        }
    }
}
