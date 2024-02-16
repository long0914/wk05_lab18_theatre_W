public struct Time{

    public int Hours{get;}
    public int Minutes{get;}

    public Time(int hours, int minutes =0){
        this.Hours = hours;
        this.Minutes = minutes;
    }

    public override string ToString()
    {
        return $"Time:{Hours:D2}:{Minutes:D2}";
    }
public static bool operator ==(Time lhs, Time rhs)
{
    int lhsMinutes = lhs.Hours * 60 + lhs.Minutes;
    int rhsMinutes = rhs.Hours * 60 + rhs.Minutes;

    return Math.Abs(lhsMinutes - rhsMinutes) <= 15;
}


public static bool operator!=(Time lhs, Time rhs){
    return !(lhs == rhs); 
}

public override bool Equals(object obj)
{
    if (obj is Time)
    {
        Time other = (Time)obj;
        return this == other;
    }
    return false;
}
}