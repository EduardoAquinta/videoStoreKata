namespace videoStoreKata.Code;

public class VideoStore
{
    public double RegularDayRate(int day)
    {
        if (day > 2)
        {
            double costForDaysAfterTwo = (day - 2.0) * 1.5;
            return costForDaysAfterTwo + 2;
        }
        else
        {
            return 2;
        }
        
    }

    public double NewMovieRate(int day)
    {
        return day * 3;
    }

    public double ChildrensMovieRate(int day)
    {
        if (day > 3)
        {
            double extraDaysCost = (day - 3) * 1.50;
            return extraDaysCost + 1.50;
        }
        else
        {
            return 1.50;    
        }
        
    }
}
