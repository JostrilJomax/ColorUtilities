namespace ColorUtilities {

/// <summary> HSL (for hue, saturation, lightness). </summary>
/// <remarks> https://en.wikipedia.org/wiki/HSL_and_HSV </remarks>
public class Hsl : Color<Hsl> {

    /// <summary> Hue. </summary>
    public int  H { get; set; }

    /// <summary> Saturation. </summary>
    public byte S { get; set; }

    /// <summary> Lightness. </summary>
    public byte L { get; set; }

    static Hsl()
    {
        ColorTypeRegistrar<Hsl>
           .Register
           .DefaultRgbConversion(ColorConverter.ToHsl, ColorConverter.ToRgb)
           .ToString(x => $"{x.H}° {x.S}% {x.L}%")
           .EqualityByGetters(x => x.H, x => x.S, x => x.L);
    }

    public Hsl(int h, byte s, byte l)
    {
        H = h;
        S = s;
        L = l;
    }

}
}
