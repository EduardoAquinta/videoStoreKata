using videoStoreKata.Code;

namespace videoStoreKata.Tests;

public class VideoStoreKataServiceTests
{
    
    [Theory]
    [InlineData(1,2)]
    [InlineData(2,2)]
    [InlineData(3, 3.5 )]
    [InlineData(4, 5)]
    public void RegularMovieRental_Input_Expected(int input, double expected)
    {
        var regularMovieRental = new VideoStore();
        double cost = regularMovieRental.RegularDayRate(input);
        Assert.Equal(expected, cost);
    }

    [Theory]
    [InlineData(1,3)]
    [InlineData(2,6)]
    [InlineData(7,21)]

    public void NewReleaseMovieRental_input_expected(int input, double expected)
    {
        var newReleaseMovie = new VideoStore();
        double cost = newReleaseMovie.NewMovieRate(input);
        Assert.Equal(expected, cost);
    }

    [Theory]
    [InlineData(1, 1.50)]
    [InlineData(2, 1.50)]
    [InlineData(3, 1.50)]
    [InlineData(4, 3.00)]
    [InlineData(5, 4.50)]
    [InlineData(10, 12.00)]
    public void ChildrensMovieRental_Input_Expected(int input, double expected)
    {
        var childrensMovieRental = new VideoStore();
        double cost = childrensMovieRental.ChildrensMovieRate(input);
        Assert.Equal(expected, cost);
    }

    [Theory]
    [InlineData( 1,  2)]
    [InlineData( 2,  3)]
    [InlineData( 3,  3)]
    [InlineData(12,3)]


    public void Frequent_Renter_Points_1_1(int input, int expected)
    {
        var frequentRenterPoints = new VideoStore();
        int amount = frequentRenterPoints.FrequentRentalPoints(input);
        Assert.Equal(expected, amount);
    }
}

public class VideoStoreReceiptTests
{

    [Fact]
    public void VideoStoreReceipts_Returns_Correct_String_Format()
    {
        var correctStringFormat = new VideoStoreReceipt();
        string receipt = correctStringFormat.Receipt();
        Assert.Equal();
    }
}