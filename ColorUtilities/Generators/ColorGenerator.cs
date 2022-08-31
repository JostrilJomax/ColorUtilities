using System;

namespace ColorUtilities
{
    public static class ColorGenerator
    {
        public static T GetRandomColor<T>() where T: Color<T>
        {
            return GetRandomColor<T>(new RgbRandomColorFilter());
        }

        public static T GetLightRandomColor<T>() where T : Color<T>
        {
            const byte minRangeValue = 170;

            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.minR = minRangeValue;
            filter.minG = minRangeValue;
            filter.minB = minRangeValue;

            return GetRandomColor<T>(filter);
        }

        public static T GetDarkRandomColor<T>() where T : Color<T>
        {
            const byte maxRangeValue = 80;

            RgbRandomColorFilter filter = new RgbRandomColorFilter();
            filter.maxR = maxRangeValue;
            filter.maxG = maxRangeValue;
            filter.maxB = maxRangeValue;

            return GetRandomColor<T>(filter);
        }

        private static T GetRandomColor<T>(RgbRandomColorFilter filter) where T : Color<T>
        {
            Random random = new Random(DateTime.Now.Millisecond);

            Rgb rgb = new Rgb(
                (byte)random.Next(filter.minR, filter.maxR),
                (byte)random.Next(filter.minG, filter.maxG),
                (byte)random.Next(filter.minB, filter.maxB));

            return rgb.ConvertTo<T>();
        }
    }
}
