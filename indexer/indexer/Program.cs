using indexer.Models;
using System;

namespace indexer
{
    internal class Program
    {
        static void Main(string[] args, Hotel hotel)
        {
            string word = "Hotels";
            Room room1 = new Room("No_11");
            new Hotel(4).room[0] = room1;
            Console.WriteLine(new Hotel(4)[0]);
        }
    }
}
