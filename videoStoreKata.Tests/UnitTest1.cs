using videoStoreKata.Code;

namespace videoStoreKata.Tests;

public class VideoStoreKataServiceTests
{
    [Fact]
    public void RegularMovieOneDayRental()
    {
        //arrange
        var regularMovieRental = new VideoStore();
        //act
        var cost = regularMovieRental.RegularDayRate(1);
        //assert
        Assert.Equal(2, cost);
    }
}