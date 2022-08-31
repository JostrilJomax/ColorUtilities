using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ColorUtilities {

/// <summary> Base class for all colors. </summary>
/// <remarks> <see cref="Rgb"/> </remarks>
public abstract class Color<T> : IDefaultColors<T>, IEquatable<T>
    where T : Color<T>
{

    public T White   => new Rgb(255, 255, 255).ConvertTo<T>();
    public T Gray    => new Rgb(128, 128, 128).ConvertTo<T>();
    public T Black   => new Rgb(0  ,   0,   0).ConvertTo<T>();
    public T Red     => new Rgb(255,   0,   0).ConvertTo<T>();
    public T Orange  => new Rgb(255,  69,   0).ConvertTo<T>();
    public T Yellow  => new Rgb(255, 255,   0).ConvertTo<T>();
    public T Green   => new Rgb(  0, 128,   0).ConvertTo<T>();
    public T Brown   => new Rgb(  0, 128,  69).ConvertTo<T>();
    public T Lime    => new Rgb(  0, 255,   0).ConvertTo<T>();
    public T Teal    => new Rgb(  0, 128, 128).ConvertTo<T>();
    public T Cyan    => new Rgb(  0, 255, 255).ConvertTo<T>();
    public T Blue    => new Rgb(  0,   0, 255).ConvertTo<T>();
    public T Purple  => new Rgb(128,   0, 128).ConvertTo<T>();
    public T Pink    => new Rgb(255,   0, 128).ConvertTo<T>();
    public T Magenta => new Rgb(255,   0, 255).ConvertTo<T>();



    // public abstract override string ToString();
    //
    // public abstract (int, int, int) ToTuple();
    //
    // private static readonly Color<T> Instance = new Color<T>();
    //
    // public static ColorTypeRegistrar<T> Configf => Instance.Config;
    //
    // protected virtual ColorTypeRegistrar<T> Config { get; }

    // public static T operator + (T a, T b)                     => new T(a.r + b.r, a.g + b.g, a.b + b.b, a.a + b.a);
    // public static T operator - (T a, T b)                     => new T(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
    // public static T operator * (T a, T b)                     => new T(a.r     * b.r, a.g * b.g, a.b * b.b, a.a * b.a);
    // public static T operator * (T a, float b)                 => new Color(a.r * b, a.g   * b, a.b   * b, a.a   * b);
    // public static T operator * (float b, Color a)             => new Color(a.r * b, a.g   * b, a.b   * b, a.a   * b);
    // public static T operator / (UnityEngine.Color a, float b) => new Color(a.r / b, a.g   / b, a.b   / b, a.a   / b);

    public static bool operator ==(Color<T> x, T y) => x.Equals(y);
    public static bool operator !=(Color<T> x, T y) => !(x == y);

    public TOut ConvertTo<TOut>() where TOut : Color<TOut>
        => ColorConverter.ChangeType<T, TOut>(this as T);

    //public override int GetHashCode() => ;

    public override bool Equals(object other) => Equals(other);

    public bool Equals<TAny>(TAny other)
    {
        if (other is null)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (other is not T)
            return false;

        return Equals(other as T);
    }

    public bool Equals(T other) => ColorComparer.Equals(this as T, other);

    public override string ToString() => ColorGenericDictionary<T>.ToString(this as T);

}
}
