using System;

namespace ColorUtilities {
public static partial class ColorConverter {

    // Hex -------------------------------------

    public static Rgb ToRgb(Hex hex)
    {
        int value = Convert.ToInt32(hex.Value, 16);
        return new Rgb(
            (byte) (value >> 16 & 255),
            (byte) (value >> 8  & 255),
            (byte) (value       & 255));
    }

    // Cmyk -------------------------------------

    public static Rgb ToRgb(Cmyk cmyk)
        => new Rgb(
            (byte) Math.Round(255 * (1 - cmyk.C * 0.01) * (1 - cmyk.K * 0.01)),
            (byte) Math.Round(255 * (1 - cmyk.M * 0.01) * (1 - cmyk.K * 0.01)),
            (byte) Math.Round(255 * (1 - cmyk.Y * 0.01) * (1 - cmyk.K * 0.01)));

    // Hsv -------------------------------------

    public static Rgb ToRgb(Hsv hsv) => ToRgb(HsvToHsl(hsv));

    // Hsl -------------------------------------

    public static Rgb ToRgb(Hsl hsl)
    {
        double r = 1, g = 1, b = 1, q, p;

        double modifiedH = hsl.H / 360.0;
        double modifiedS = hsl.S / 100.0;
        double modifiedL = hsl.L / 100.0;

        q = modifiedL < 0.5 ? modifiedL * (1 + modifiedS) : modifiedL + modifiedS - modifiedL * modifiedS;
        p = 2                           * modifiedL - q;

        if (modifiedL == 0) // if the lightness value is 0 it will always be black
        {
            r = 0;
            g = 0;
            b = 0;
        }
        else if (modifiedS != 0) {
            r = GetHue(p, q, modifiedH + 1.0 / 3);
            g = GetHue(p, q, modifiedH);
            b = GetHue(p, q, modifiedH - 1.0 / 3);
        }

        return new Rgb((byte) Math.Round(r * 255), (byte) Math.Round(g * 255), (byte) Math.Round(b * 255));

        static double GetHue(double p, double q, double t)
        {
            double value = p;

            if (t < 0) t++;
            if (t > 1) t--;

            if (t < 1.0 / 6) {
                value = p + (q - p) * 6 * t;
            }
            else if (t < 1.0 / 2) {
                value = q;
            }
            else if (t < 2.0 / 3) {
                value = p + (q - p) * (2.0 / 3 - t) * 6;
            }

            return value;
        }
    }

    // Xyz -------------------------------------

    public static Rgb ToRgb(CieXyz cieXyz)
    {
        double modifiedX = cieXyz.X / 100.0, modifiedY = cieXyz.Y / 100.0, modifiedZ = cieXyz.Z / 100.0;

        double[] rgb = new double[3];
        rgb[0] = modifiedX * 3.2410  + modifiedY * -1.5374 + modifiedZ * -0.4986;
        rgb[1] = modifiedX * -0.9692 + modifiedY * 1.8760  + modifiedZ * 0.0416;
        rgb[2] = modifiedX * 0.056   + modifiedY * -0.2040 + modifiedZ * 1.0570;

        for (int x = 0; x < rgb.Length; x++)
            rgb[x] = rgb[x] <= 0.0031308 ? 12.92 * rgb[x] : 1.055 * Math.Pow(rgb[x], 0.41666666666) - 0.055;

        return new Rgb((byte) Math.Round(rgb[0] * 255), (byte) Math.Round(rgb[1] * 255),
            (byte) Math.Round(rgb[2]            * 255));
    }

    // Yiq -------------------------------------

    public static Rgb ToRgb(Yiq yiq)
    {
        double[] rgb = new double[3];
        rgb[0] = yiq.Y                 + yiq.I * 0.956 + yiq.Q * 0.621;
        rgb[1] = yiq.Y                 - yiq.I * 0.272 - yiq.Q * 0.647;
        rgb[2] = yiq.Y - yiq.I * 1.106 + yiq.Q * 1.703;

        return new Rgb((byte) Math.Round(rgb[0] * 255), (byte) Math.Round(rgb[1] * 255),
            (byte) Math.Round(rgb[2]            * 255));
    }

    // Yuv -------------------------------------

    public static Rgb ToRgb(Yuv yuv)
    {
        double[] rgb = new double[3];
        rgb[0] = yuv.Y + yuv.V * 1.13983;
        rgb[1] = yuv.Y - yuv.U * 0.39465 - yuv.V * 0.58060;
        rgb[2] = yuv.Y + yuv.U * 2.03211;

        return new Rgb((byte) Math.Round(rgb[0] * 255), (byte) Math.Round(rgb[1] * 255),
            (byte) Math.Round(rgb[2]            * 255));
    }

}
}
