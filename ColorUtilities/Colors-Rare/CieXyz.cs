namespace ColorUtilities {

/// <summary> https://en.wikipedia.org/wiki/CIE_1931_color_space </summary>
public class CieXyz : Color<CieXyz> {

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    static CieXyz()
    {
        ColorTypeRegistrar<CieXyz>
           .Register
           .DefaultRgbConversion(ColorConverter.ToCieXyz, ColorConverter.ToRgb)
           .ToString(x => $"{x.X} {x.Y} {x.Z}")
           .EqualityByGetters(x => x.X, x => x.Y, x => x.Z);
    }

    public CieXyz(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

}
}
