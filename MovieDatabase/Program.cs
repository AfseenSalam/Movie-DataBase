// See https://aka.ms/new-console-template for more information
using MovieDatabase;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("======================");
Console.WriteLine("GC MOVIE DATABASE");
Console.WriteLine("======================");
bool IsValid = true;
List<Movie> movies = new()
{
     new Movie("21", "Drama", 60,1991), new Movie("Wolf on Wallstreet", "Drama",75,1993), new Movie("Chuck and Larry", "Comedy",45,2000),
    new Movie("Borderlands", "Action",80,2002), new Movie("Deadpool", "Action",60,2004), new Movie("If", "Comedy",45,2005),
    new Movie("The Fall Guy", "Drama",60,2006), new Movie("Scoop", "Drama",75,2008), new Movie("Overlord", "Horror",90,2010),
    new Movie("Smile", "Horror",30,2015), new Movie("Mouse Trap", "Horror",95,2014), new Movie("Batman", "Action",80,2020)

};

Console.WriteLine($"There are {movies.Count} movies in this list.");
while (IsValid)
{
    UserChoice(movies);
    Console.WriteLine("Do you want to continue?y/n");
    string? userInput = Console.ReadLine();
    if (userInput.ToLower() == "y")
    {
        IsValid = true;
    }
    else if (userInput.ToLower() == "n")
    {
        IsValid = false;
    }
    else
    {
        Console.WriteLine("Invalid Selection");

    }

}

static void UserChoice(List<Movie> movies)
{
    bool runProgram = true;
    
    
    while (runProgram)
    {
        List<string> category = new()
        {
            "Drama","Comedy","Action","Horror"
        };

        Console.WriteLine("What category are you interested in?");
        int index = 1;
        foreach (string s in category)
        {
            Console.WriteLine($"{index}.{s}");
            index++;
        }
        int choiceNum = int.Parse(Console.ReadLine());
        string choice = category.ElementAt(choiceNum -1);
        var selectedMovie = movies.Where(movies => movies.Category.Equals(choice, StringComparison.OrdinalIgnoreCase)).OrderBy(movies => movies.Title).ToList();
        if (selectedMovie.Any())
        {
            Console.WriteLine($"Movie category {choice} has {selectedMovie.Count}");
            foreach (Movie m in selectedMovie)
            {
                Console.WriteLine($"{m.Title.PadRight(16)}\t{m.Runtime}\t{m.Year}");
            }
            runProgram = false;
        }
        else
        {
            Console.WriteLine("Invalid input");
            runProgram = true;
        }


    }
  
    
}