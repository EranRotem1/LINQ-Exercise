using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class VideoGame
    {
        public static List<VideoGame> Games = new List<VideoGame>();

        public string Name { get; set; }
        public string Rating { get; set; }
        public int ReleaseYear { get; set; }

        public VideoGame(string name, string rating, int year)
        {
            Name = name;
            Rating = rating;
            ReleaseYear = year;
            Games.Add(this);
        }

        public static void PrintDetails(VideoGame game)
        {
            Console.WriteLine($"{game.Name}\n{game.ReleaseYear}\nRated: {game.Rating}");
        }
    }
}
