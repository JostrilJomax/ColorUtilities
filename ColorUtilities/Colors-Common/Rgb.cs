using System;

namespace ColorUtilities {
public class Rgb : Color<Rgb> {

    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    // public override (int, int, int) ToTuple() => (R, G, B);

    static Rgb()
    {
        ColorTypeRegistrar<Rgb>
           .Register
           .DefaultRgbConversion(x => x, x => x)
           .ToString(x => $"rgb({x.R}, {x.G}, {x.B})")
           .EqualityByGetters(x => x.R, x => x.G, x => x.B);
    }

    public Rgb(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

}
}
