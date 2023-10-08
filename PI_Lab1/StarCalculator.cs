// See https://aka.ms/new-console-template for more information



/// <summary>
/// Calculates distance and parallax of stars
/// </summary>
public static class StarCalculator
{
    private const double lightYear = 3.262;
    private const double minParallax = 0.00001;
    private const double maxParallax = 0.99999;
    private const double minDistance = 1;
    private const double maxDistance = 100000;

    public static void CheckValueInRange(double value, double min, double max)
    {
        if(value <= min || value >= max)
        {
            throw new ArgumentOutOfRangeException(nameof(value),"Value must be in range.");
        }
    }

    /// <summary>
    /// Calculates distance in light-years
    /// </summary>
    /// <param name="parallax">in arcsec</param>
    /// <returns>distance in light-years</returns>
    public static double GetDistanceInLightYears(double parallax)
    {
        CheckValueInRange(parallax, minParallax, maxParallax);
        var d = (1 / parallax) * lightYear;
        return Double.Parse(String.Format("\n{0:F2}", d));
    }

    /// <summary>
    /// Calculates distance in parsecs
    /// </summary>
    /// <param name="parallax">in arcsec</param>
    /// <returns>in parsecs</returns>
    public static double GetDistanceInParsecs(double parallax)
    {
        CheckValueInRange(parallax, minParallax, maxParallax);
        var d = (1 / parallax);
        return Double.Parse(String.Format("\n{0:F2}", d));

    }

    /// <summary>
    /// Calculates parallax in arcsec
    /// </summary>
    /// <param name="distance">in parsecs</param>
    /// <returns>in arcsec</returns>
    public static double GetParallaxInArcsec(double distance)
    {
       CheckValueInRange(distance, minDistance, maxDistance);

        var p = 1 / distance;

        return Double.Parse(String.Format("\n{0:F5}", p));

    }

    public static string GetStarNameByParallax(double parallax)
    {
        var stars = new Star[5];
        stars[0] = new Star("Achernar(α Eridani)", 0.02339, 42.75);
        stars[1] = new Star("Arcturus(α Boötis)", 0.08883, 11.26);
        stars[2] = new Star("Rigil(β Orionis)", 0.00378, 264.55);
        stars[3] = new Star("Vega (α Lyrae)", 0.13023, 7.68);
        stars[4] = new Star("Proxima Centauri(α Centauri C)", 0.7716, 1.30);

        foreach (var st in stars)
        {
            if (st.parallax == parallax)
            {
                return st.name;
            }
        }
        return "I haven't yet met a star with this parallax.";

    }
}
