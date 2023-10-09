// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        var distance = StarCalculator.GetDistanceInLightYears(0.08883);
        var dis = StarCalculator.GetDistanceInParsecs(0.08883);
        var parallax = StarCalculator.GetParallaxInArcsec(dis);

        Console.WriteLine($"parallax = {parallax}");


    /*    Console.WriteLine(String.Format("\n{0:F3}", distance));
        Console.WriteLine(String.Format("\n{0:F3}", dis));
        Console.WriteLine(String.Format("\n{0:F3}", parallax));
        Console.WriteLine(Double.Parse(String.Format("\n{0:F3}", parallax)));
*/
    }

}

