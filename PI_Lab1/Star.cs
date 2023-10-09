// See https://aka.ms/new-console-template for more information



public class Star
{
    public string name;
    public double parallax;
    public double distance;

    private const double minParallax = 0.00001;
    private const double maxParallax = 0.99999;
    private const double minDistance = 1;
    private const double maxDistance = 100000;

    public Star(string name, double parallax, double distance)
    {
        CheckValueInRange(parallax, minParallax, maxParallax);
        CheckValueInRange(distance, minDistance, maxDistance); 

        this.name = name;
        this.parallax = parallax;
        this.distance = distance;
    }

    public static void CheckValueInRange(double value, double min, double max)
    {
        if (value <= min || value >= max)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be in range.");
        }
    }

}