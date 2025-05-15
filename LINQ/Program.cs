using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>
            {
                "Minecraft", 
                "Fortnite", 
                "League of Legends", 
                "Call of Duty", 
                "Overwatch",
                "Apex Legends",
                "Valorant",
                "Counter-Strike",
                "Dota 2",
                "World of Warcraft",
                "Final Fantasy",
                "The Legend of Zelda",
                "Super Mario",
                "The Witcher",
                "Dark Souls",
                "Skyrim",
                "Red Dead Redemption",
                "Grand Theft Auto",
                "Assassin's Creed",
            };
            
            gameNames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
