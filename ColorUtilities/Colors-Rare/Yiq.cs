namespace ColorUtilities {

// todo(decide): rare color
/// <summary> https://en.wikipedia.org/wiki/YIQ </summary>
public class Yiq : Color<Yiq> {

    public double Y { get; set; }
    public double I { get; set; }
    public double Q { get; set; }

    static Yiq()
    {
        ColorTypeRegistrar<Yiq>
           .Register
           .DefaultRgbConversion(ColorConverter.ToYiq, ColorConverter.ToRgb)
           .ToString(x => $"{x.Y} {x.I} {x.Q}")
           .EqualityByGetters(x => x.Y, x => x.I, x => x.Q);
    }

    public Yiq(double y, double i, double q)
    {
        Y = y;
        I = i;
        Q = q;
    }

}
}
