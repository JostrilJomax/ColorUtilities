namespace ColorUtilities {
public static partial class ColorConverter {

    public static TOut ChangeType<TIn, TOut>(TIn color)
        where TIn : Color<TIn>
        where TOut : Color<TOut>
    {
        if (color is Color<TOut>)
            return color as TOut;

        if (ColorGenericDictionary<TIn, TOut>.HasConversionTo)
            return ColorGenericDictionary<TIn, TOut>.ConvertTo(color);

        return PerformDefaultConversion<TIn, TOut>(color);
    }

    /// <summary> 2 step conversion: To Rgb, then to desired type </summary>
    private static TOut PerformDefaultConversion<TIn, TOut>(TIn obj)
        where TIn : Color<TIn>
        where TOut : Color<TOut>
        => ColorGenericDictionary<TOut, Rgb>.ConvertFrom(
            ColorGenericDictionary<TIn, Rgb>.ConvertTo(obj));

}
}
