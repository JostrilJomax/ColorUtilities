namespace ColorUtilities {

// todo(decide): rare color
/// <summary> https://en.wikipedia.org/wiki/YUV </summary>
public class Yuv : Color<Yuv> {

    public double Y { get; set; }
    public double U { get; set; }
    public double V { get; set; }

    static Yuv()
    {
        ColorTypeRegistrar<Yuv>
           .Register
           .DefaultRgbConversion(ColorConverter.ToYuv, ColorConverter.ToRgb)
           .ToString(x => $"{x.Y} {x.U} {x.V}")
           .EqualityByGetters(x => x.Y, x => x.U, x => x.V);
    }

    public Yuv(double y, double u, double v)
    {
        Y = y;
        U = u;
        V = v;
    }

}
}
