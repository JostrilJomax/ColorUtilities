namespace ColorUtilities {

/// <summary> CMYK stands for: cyan, magenta, yellow, and key (black). </summary>
/// <remarks> https://en.wikipedia.org/wiki/CMYK_color_model </remarks>
public class Cmyk : Color<Cmyk> {

    public byte C { get; set; }
    public byte M { get; set; }
    public byte Y { get; set; }
    public byte K { get; set; }

    static Cmyk()
    {
        ColorTypeRegistrar<Cmyk>
            .Register
            .DefaultRgbConversion(ColorConverter.ToCmyk, ColorConverter.ToRgb)
            .ToString(x => $"{x.C}% {x.M}% {x.Y}% {x.K}%")
            .EqualityByGetters(x => x.C, x => x.M, x => x.Y, x => x.K);
    }

    public Cmyk(byte c, byte m, byte y, byte k)
    {
        C = c;
        M = m;
        Y = y;
        K = k;
    }

}
}
