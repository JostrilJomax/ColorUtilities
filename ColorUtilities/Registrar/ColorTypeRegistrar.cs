using System;
using System.Linq;

namespace ColorUtilities {
/// <summary> This class maps the provided functionality to the provided color type.  </summary>
public class ColorTypeRegistrar<T>
    where T : Color<T>
{

    /// <summary>
    ///     Q: What is the point in such an intricate conversion registration?
    ///        Why not just make a virtual(s) function to override?
    /// <para/>
    ///     A: tl;dr: For flexibility
    /// <para/>
    ///     A: To be able to register more than one conversions.
    ///        Because currently all default conversions are made in 2 steps:
    ///        <br/> Hex → Rgb (default conversion type) → Cmyk <br/>
    ///        Conversion registration allows us to provide additional ways to
    ///        convert color types:
    ///        <br/> Hex → Cmyk <br/>
    /// </summary>
    public static ColorTypeRegistrar<T> Register => new ColorTypeRegistrar<T>();

    // Register conversion to/from other color type -------------------------------------

    /// <param name="convertFrom"> Receives Rgb, returns T </param>
    /// <param name="convertTo"> Receives T, returns Rgb </param>
    public ColorTypeRegistrar<T> DefaultRgbConversion(Func<Rgb, T> convertFrom, Func<T, Rgb> convertTo)
        => ConversionFrom(convertFrom)
           .ConversionTo(convertTo);

    // Register conversion to/from other color type -------------------------------------

    public ColorTypeRegistrar<T> ConversionTo<T2>(Func<T, T2> convertTo)
        where T2 : Color<T2>
        => SetFunc(ref ColorGenericDictionary<T, T2>.ConvertTo, convertTo);

    private ColorTypeRegistrar<T> ConversionFrom<T2>(Func<T2, T> convertFrom)
        where T2 : Color<T2>
        => SetFunc(ref ColorGenericDictionary<T, T2>.ConvertFrom, convertFrom);

    // Register conversion to string -------------------------------------

     public ColorTypeRegistrar<T> ToString(Func<T, string> toString)
        => SetFunc(ref ColorGenericDictionary<T>.ToString, toString);

     // Register Equality comparison of same color type -------------------------------------

    public ColorTypeRegistrar<T> Equality(Func<T, T, bool> equals)
        => SetFunc(ref ColorGenericDictionary<T>.Equals, equals);

    public ColorTypeRegistrar<T> EqualityByGetters(params Func<T, double>[] getters)
        => SetFunc(ref ColorGenericDictionary<T>.Equals,
            (x, y) => getters.All(getter => ApproxEquals(getter(x), getter(y))));

    public ColorTypeRegistrar<T> EqualityByGetters(params Func<T, float>[] getters)
        => SetFunc(ref ColorGenericDictionary<T>.Equals,
            (x, y) => getters.All(getter => ApproxEquals(getter(x), getter(y))));

    public ColorTypeRegistrar<T> EqualityByGetters(params Func<T, int>[] getters)
        => SetFunc(ref ColorGenericDictionary<T>.Equals,
            (x, y) => getters.All(getter => getter(x) == getter(y)));


    // Helpers -------------------------------------

    private ColorTypeRegistrar<T> SetFunc<TAny>(ref TAny self, TAny value)
    {
        if (self != null)
            throw new Exception("Duplicate registration.");
        self = value;
        return this;
    }

    private static bool ApproxEquals(double a, double b) => Math.Abs(a - b) < 0.999999999999998;

    private static bool ApproxEquals(float a, float b) => Math.Abs(a - b) < 0.998;
}
}
