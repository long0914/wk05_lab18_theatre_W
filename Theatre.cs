public class Theatre{

 private List<Show> shows; // to be initialized later
 public string Name {get;} 

public List<Show> Shows{ //capital letter  represents public, return private shows
    get{
        return shows;
    }
}


public Theatre(string name){
    this.Name = name;
    this.shows = new List<Show>(); //initialize the list
}

public void AddShow(Show show){
    this.shows.Add(show);
}

public void PrintShows(){
    Console.WriteLine($"{this.Name} will show:");
    Console.WriteLine("All shows:");
    Console.WriteLine("=============");
    for (int i = 0; i < this.shows.Count; i++)
    {
        Console.WriteLine($"{i+1}: {this.shows[i].ToString()}");
    }

}

public void PrintShows(Genre genre)
{
    int counter = 1;
    Console.WriteLine($"The show of {genre} has:");
    Console.WriteLine("=============");
    foreach (Show show in this.shows)
    {
        if (show.Movie.Genre == genre)
        {
            Console.WriteLine($"{counter}. {show.ToString()}");
            counter++;
        }
    }
}

public void PrintShows(DayEnum D)
{
    int counter = 1;
    Console.WriteLine($"The show of {D} has:");
    Console.WriteLine("=============");
    foreach (Show show in this.shows)
    {
        if (show.Day == D)
        {
            Console.WriteLine($"{counter}. {show.ToString()}");
            counter++;
        }
    }
}

public void PrintShows(Time time)
{
    int counter = 1;
    Console.WriteLine($"The show at {time} has:");
    Console.WriteLine("=============");
    foreach (Show show in this.shows)
    {
        if (show.Time == time)
        {
            Console.WriteLine($"{counter}. {show.ToString()}");
            counter++;
        }
    }
}

public void PrintShows(string actor)
{
    int counter = 1;
    Console.WriteLine($"The shows with actor {actor} are:");
    Console.WriteLine("=============");
    foreach (Show show in this.shows)
    {
        if (show.Movie.Cast.Contains(actor))
        {
            Console.WriteLine($"{counter}. {show.ToString()}");
            counter++;
        }
    }
}

public void PrintShows(DayEnum day, Time time)
{
    int counter = 1;
    Console.WriteLine($"The shows on {day} at {time} are:");
    Console.WriteLine("=============");
    foreach (Show show in this.shows)
    {
        if (show.Day == day && show.Time == time)
        {
            Console.WriteLine($"{counter}. {show.ToString()}");
            counter++;
        }
    }
}
}





