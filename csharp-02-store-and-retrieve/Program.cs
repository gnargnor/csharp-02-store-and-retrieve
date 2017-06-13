using System;

namespace csharp02storeandretrieve
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey! What do you call yer band?");
            string name = Console.ReadLine();

            Console.WriteLine("How many fellas does yer band be made up of?");
            int numberOfMembers = int.Parse(Console.ReadLine());

            Console.WriteLine(name + " has " + numberOfMembers + " members.");
        }
    }
}
