namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            VideoGame game1 = new VideoGame("Last of us", "M", 2014);
            VideoGame game2 = new VideoGame("CoD MW2", "M", 2009);
            VideoGame game3 = new VideoGame("MarioCart (original)", "E", 1998);
            VideoGame.Games.OrderBy(g => g.Name.Length).ToList().ForEach(x => Console.WriteLine(x.Name));
        }
    }
}
