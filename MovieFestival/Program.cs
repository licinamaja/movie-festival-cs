namespace MovieFestival;

// FIXME: Rename file and class to App
class Program
{
    static void Main(string[] args)
    {
        Genre genre = new Genre("Action");
        Console.WriteLine(genre.GetData());
    }
}

