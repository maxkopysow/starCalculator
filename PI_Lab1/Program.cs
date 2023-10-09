// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
  
        var TestParallax = 0.08883;
        var DistanceInLightYear = StarCalculator.GetDistanceInLightYears(TestParallax);
        Console.WriteLine($"distance in light years = {DistanceInLightYear}");
        Console.WriteLine($"star name is = {StarCalculator.GetStarNameByParallax(TestParallax)}");


    }

}

