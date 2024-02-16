public class Movie{
    public int Length { get; }
    public int Year { get; }
    public string Title { get; }
    public Genre Genre { get; private set; }

    public List<string> Cast { get; }


public Movie( string title, int year, int length){
    this.Title = title;
    this.Year = year;
    this.Length = length;
    this.Cast = new List<string>();
}

public void AddActor(string actor){
this.Cast.Add(actor);

}

public void SetGenre(Genre genre){
this.Genre |= genre;    //ok as or operator
}

public override string ToString(){

 return $"{this.Title} ({this.Year}) {this.Length}mins ({this.Genre}) {string.Join(", ", this.Cast)}";

}


}