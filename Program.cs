using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning of the phone app!");

            Galaxy s8 = new Galaxy("s8",100, "T-Mobile", "DOO do doo doooo");
            Nokia e1100 = new Nokia("e1100", 70, "Sprint", "Ring rang Rung");

            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

            e1100.DisplayInfo();
            System.Console.WriteLine(e1100.Ring());
            System.Console.WriteLine(e1100.Unlock());
            System.Console.WriteLine("");
        }
    }
}
