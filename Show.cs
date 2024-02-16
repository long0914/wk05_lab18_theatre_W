public struct Show{

 public double Price{get;}
 public DayEnum Day{get;}

 public Movie Movie{get;}
 public Time Time{get;}

 public Show(Movie movie, Time time, DayEnum day, double price){
     this.Movie = movie;
     this.Time = time;
     this.Day = day;
     this.Price = price;
 }


    public override string ToString(){
        return $"{this.Day} {this.Time} {this.Movie.ToString()} {this.Price}";
        ;
    }



}