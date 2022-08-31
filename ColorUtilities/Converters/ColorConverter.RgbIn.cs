using System;

namespace ColorUtilities {
public static partial class ColorConverter {

    // Hsv -------------------------------------

    public static Hsv ToHsv(Rgb rgb) => HslToHsv(ToHsl(rgb));

    // Hex -------------------------------------

    public static Hex ToHex(Rgb rgb) => new Hex($"{rgb.R:X2}{rgb.G:X2}{rgb.B:X2}");

    // Cmyk -------------------------------------

    public static Cmyk ToCmyk(Rgb rgb)
    {
        double modifiedR = rgb.R / 255.0;
        double modifiedG = rgb.G / 255.0;
        double modifiedB = rgb.B / 255.0;

        double k = 1 - Max(modifiedR, modifiedG, modifiedB);
        double c = (1 - modifiedR - k) / (1 - k);
        double m = (1 - modifiedG - k) / (1 - k);
        double y = (1 - modifiedB - k) / (1 - k);

        return new Cmyk(
            (byte) Math.Round(c * 100),
            (byte) Math.Round(m * 100),
            (byte) Math.Round(y * 100),
            (byte) Math.Round(k * 100));

    }

    // Hsl -------------------------------------

    public static Hsl ToHsl(Rgb rgb)
    {
        double h, s;

        double modifiedR = rgb.R / 255.0;
        double modifiedG = rgb.G / 255.0;
        double modifiedB = rgb.B / 255.0;

        double min = Min(modifiedR, modifiedG, modifiedB);
        double max = Max(modifiedR, modifiedG, modifiedB);
        double delta = max - min;
        double l = (min + max) / 2;

        if (delta == 0) {
            h = 0;
            s = 0;
        }
        else {
            s = l <= 0.5 ? delta / (min + max) : delta / (2 - max - min);

            if (modifiedR == max) {
                h = (modifiedG - modifiedB) / 6 / delta;
            }
            else if (modifiedG == max) {
                h = 1.0 / 3 + (modifiedB - modifiedR) / 6 / delta;
            }
            else {
                h = 2.0 / 3 + (modifiedR - modifiedG) / 6 / delta;
            }

            h = h < 0 ? ++h : h;
            h = h > 1 ? --h : h;
        }

        return new Hsl(
            (int) Math.Round(h  * 360),
            (byte) Math.Round(s * 100),
            (byte) Math.Round(l * 100));
    }

    // Xyz -------------------------------------

    public static CieXyz ToCieXyz(Rgb rgb)
    {
        double[] modifiedRGB = { rgb.R / 255.0, rgb.G / 255.0, rgb.B / 255.0 };

        for (int x = 0; x < modifiedRGB.Length; x++) {
            modifiedRGB[x] =
                modifiedRGB[x] > 0.04045 ? Math.Pow((modifiedRGB[x] + 0.055) / 1.055, 2.4) : modifiedRGB[x] / 12.92;

            modifiedRGB[x] *= 100;
        }

        return new CieXyz(
            modifiedRGB[0] * 0.4124 + modifiedRGB[1] * 0.3576 + modifiedRGB[2] * 0.1805,
            modifiedRGB[0] * 0.2126 + modifiedRGB[1] * 0.7152 + modifiedRGB[2] * 0.0722,
            modifiedRGB[0] * 0.0193 + modifiedRGB[1] * 0.1192 + modifiedRGB[2] * 0.9505
        );
    }

    // Yiq -------------------------------------

    public static Yiq ToYiq(Rgb rgb)
    {
        double[] modifiedRGB = { rgb.R / 255.0, rgb.G / 255.0, rgb.B / 255.0 };

        return new Yiq(
            modifiedRGB[0] * 0.299 + modifiedRGB[1] * 0.587 + modifiedRGB[2] * 0.114,
            modifiedRGB[0] * 0.596 - modifiedRGB[1] * 0.274 - modifiedRGB[2] * 0.322,
            modifiedRGB[0] * 0.211 - modifiedRGB[1] * 0.522 + modifiedRGB[2] * 0.311
        );
    }

    // Yuv -------------------------------------

    public static Yuv ToYuv(Rgb rgb)
    {
        double[] modifiedRGB = { rgb.R / 255.0, rgb.G / 255.0, rgb.B / 255.0 };

        return new Yuv(
            modifiedRGB[0] * 0.299    + modifiedRGB[1] * 0.587   + modifiedRGB[2] * 0.114,
            modifiedRGB[0] * -0.14713 - modifiedRGB[1] * 0.28886 + modifiedRGB[2] * 0.436,
            modifiedRGB[0] * 0.615    - modifiedRGB[1] * 0.51499 - modifiedRGB[2] * 0.10001
        );
    }

    // Hsl -------------------------------------

    public static Hsl HsvToHsl(Hsv hsv)
    {
        double modifiedS = hsv.S / 100.0;
        double modifiedV = hsv.V / 100.0;

        double hslL = modifiedV * (1 - modifiedS / 2);
        double hslS = hslL == 0 || hslL == 1 ? 0 : (modifiedV - hslL) / Math.Min(hslL, 1 - hslL);

        return new Hsl(hsv.H, (byte) Math.Round(hslS * 100), (byte) Math.Round(hslL * 100));
    }

    // Hsv -------------------------------------

    public static Hsv HslToHsv(Hsl hsl)
    {
        double modifiedS = hsl.S / 100.0;
        double modifiedL = hsl.L / 100.0;

        double hsvV = modifiedL + modifiedS * Math.Min(modifiedL, 1 - modifiedL);

        double hsvS = hsvV == 0 ? 0 : 2 * (1 - modifiedL / hsvV);

        return new Hsv(hsl.H, (byte) Math.Round(hsvS * 100), (byte) Math.Round(hsvV * 100));
    }


    // Helpers -------------------------------------

    private static double Max(double a, double b, double c) => Math.Max(Math.Max(a, b), c);
    private static double Min(double a, double b, double c) => Math.Min(Math.Min(a, b), c);


}
}
