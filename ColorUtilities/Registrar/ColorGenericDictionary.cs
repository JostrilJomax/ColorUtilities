using System;
using System.Collections.Generic;

namespace ColorUtilities {
internal static class ColorGenericDictionary<TKey>
    where TKey : Color<TKey>
{

    internal new static Func<TKey, string>     ToString;
    internal new static Func<TKey, TKey, bool> Equals;

}

internal static class ColorGenericDictionary<TKey, TValue>
    where TKey : Color<TKey>
    where TValue : Color<TValue>
{

    internal static bool HasConversionTo => ConvertTo is not null;

    internal static bool HasConversionFrom => ConvertFrom is not null;

    /// <summary> Receives <see cref="Rgb"/>, return <see cref="TKey"/> </summary>
    internal static Func<TValue, TKey> ConvertFrom;

    /// <summary> Receives <see cref="TKey"/>, return <see cref="Rgb"/> </summary>
    internal static Func<TKey, TValue> ConvertTo;

}
}
