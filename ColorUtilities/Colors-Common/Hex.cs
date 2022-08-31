namespace ColorUtilities {

/// <summary> Hexadecimal </summary>
/// <remarks> https://en.wikipedia.org/wiki/Web_colors </remarks>
public class Hex : Color<Hex> {

    public string Value {
        get => _value;
        set => _value = value.IndexOf('#') == 0 ? value.Substring(1) : value;
    }

    private string _value;

    static Hex()
    {
        ColorTypeRegistrar<Hex>
           .Register
           .DefaultRgbConversion(ColorConverter.ToHex, ColorConverter.ToRgb)
           .ToString(x => $"{x.Value}")
           .Equality((x, y) => x.Value == y.Value);
    }

    public Hex(string value)
    {
        Value = value;
    }

}
}
