using System.Collections.Generic;

namespace VSDateTimeVisualizer.Debugger
{
    internal static class ExampleDateTimeFormats
    {
        private static readonly ExampleFormat[] StandardFormats = new ExampleFormat[]
        {
            new ExampleFormat("d", "Short date pattern"),
            new ExampleFormat("D", "Long date pattern"),
            new ExampleFormat("f", "Full date/time pattern (short time)"),
            new ExampleFormat("F", "Full date/time pattern (long time)"),
            new ExampleFormat("g", "General date/time pattern (short time)"),
            new ExampleFormat("G", "General date/time pattern (long time)"),
            new ExampleFormat("m", "Month/day pattern"),
            new ExampleFormat("M", "Month/day pattern"),
            new ExampleFormat("o", "Rond-trip date/time pattern"),
            new ExampleFormat("O", "Round-trip date/time pattern"),
            new ExampleFormat("r", "RFC1123 pattern."),
            new ExampleFormat("R", "RFC1123 pattern."),
            new ExampleFormat("s", "sortable date/time pattern"),
            new ExampleFormat("t", "short time pattern"),
            new ExampleFormat("T", "Long time pattern"),
            new ExampleFormat("u", "Universal sortable date/time pattern"),
            new ExampleFormat("U", "Universal full date/time pattern"),
            new ExampleFormat("y", "Year/month pattern"),
            new ExampleFormat("Y", "Year/month pattern")
        };

        public static IReadOnlyCollection<ExampleFormat> GetStandardFormats()
        {
            return StandardFormats;
        }
    }
}
