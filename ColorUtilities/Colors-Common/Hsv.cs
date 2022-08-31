namespace ColorUtilities {

/// <summary> HSV (hue, saturation, value) is the same as HSB (hue, saturation, brightness) </summary>
/// <remarks> https://en.wikipedia.org/wiki/HSL_and_HSV </remarks>
public class Hsv : Color<Hsv> {

    /// <summary> Hue. 0 - Red </summary>
    public int  H { get; set; }

    /// <summary> Saturation. </summary>
    public byte S { get; set; }

    /// <summary> Value (brightness). 0 - black </summary>
    public byte V { get; set; }

    static Hsv()
    {
        ColorTypeRegistrar<Hsv>
           .Register
           .DefaultRgbConversion(ColorConverter.ToHsv, ColorConverter.ToRgb)
           .ToString(x => $"{x.H}° {x.S}% {x.V}%")
           .EqualityByGetters(x => x.H, x => x.S, x => x.V);
    }

    public Hsv(int h, byte s, byte v)
    {
        H = h;
        S = s;
        V = v;
    }

}
}
