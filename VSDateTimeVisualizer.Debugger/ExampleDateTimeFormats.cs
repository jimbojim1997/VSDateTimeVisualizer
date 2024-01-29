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

        private static readonly ExampleFormat[] CustomFormats = new ExampleFormat[]
        {
            new ExampleFormat("d", "%d", "The day of the month, from 1 to 31"),
            new ExampleFormat("dd", "The day of the month, from 01 to 31"),
            new ExampleFormat("ddd", "The abbreviated name of the day of the week"),
            new ExampleFormat("dddd", "The full name of the day of the week"),
            new ExampleFormat("f", "%f", "The tenths of a second in a date and time value"),
            new ExampleFormat("ff", "The hundredths of a second in a date and time value"),
            new ExampleFormat("fff", "The milliseconds in a date and time value"),
            new ExampleFormat("ffff", "The ten thousandths of a second in a date and time value"),
            new ExampleFormat("fffff", "The hundred thousandths of a second in a date and time value"),
            new ExampleFormat("ffffff", "The millionths of a second in a date and time value"),
            new ExampleFormat("fffffff", "The ten millionths of a second in a date and time value"),
            new ExampleFormat("F", "%F", "If non-zero, the tenths of a second in a date and time value"),
            new ExampleFormat("FF", "If non-zero, the hundredths of a second in a date and time value"),
            new ExampleFormat("FFF", "If non-zero, the milliseconds in a date and time value"),
            new ExampleFormat("FFFF", "If non-zero, the ten thousandths of a second in a date and time value"),
            new ExampleFormat("FFFFF", "If non-zero, the hundred thousandths of a second in a date and time value"),
            new ExampleFormat("FFFFFF", "If non-zero, the millionths of a second in a date and time value"),
            new ExampleFormat("FFFFFFF", "If non-zero, the ten millionths of a second in a date and time value"),
            new ExampleFormat("g", "%g", "The period or era"),
            new ExampleFormat("gg", "The period or era"),
            new ExampleFormat("h", "%h", "The hour, using a 12-hour clock from 1 to 12"),
            new ExampleFormat("hh", "The hour, using a 12-hour clock from 01 to 12"),
            new ExampleFormat("H", "%H", "The hour, using a 24-hour clock from 0 to 23"),
            new ExampleFormat("HH", "The hour, using a 24-hour clock from 00 to 23"),
            new ExampleFormat("K", "%K", "Time zone information"),
            new ExampleFormat("m", "%m", "The minute, from 0 to 59"),
            new ExampleFormat("mm", "The minute, from 00 to 59"),
            new ExampleFormat("M", "%M", "The month, from 1 to 12"),
            new ExampleFormat("MM", "The month, from 01 to 12"),
            new ExampleFormat("MMM", "The abbreviated name of the month"),
            new ExampleFormat("MMMM", "The full name of the month"),
            new ExampleFormat("s", "%s", "The second, from 0 to 59"),
            new ExampleFormat("ss", "The second, from 00 to 59"),
            new ExampleFormat("t", "%t", "The first character of the AM/PM designator"),
            new ExampleFormat("tt", "The AM/PM designator"),
            new ExampleFormat("y", "%y", "The year, from 0 to 99"),
            new ExampleFormat("yy", "The year, from 00 to 99"),
            new ExampleFormat("yyy", "The year, with a minimum of three digits"),
            new ExampleFormat("yyyy", "The year as a four-digit number"),
            new ExampleFormat("yyyyy", "The year as a five-digit number"),
            new ExampleFormat("z", "%z", "Hours offset from UTC, with no leading zeros"),
            new ExampleFormat("zz", "Hours offset from UTC, with a leading zero for a single-digit value"),
            new ExampleFormat("zzz", "Hours and minutes offset from UTC"),
            new ExampleFormat(":", "%:", "The time separator"),
            new ExampleFormat("/", "%/", "The date separator"),
            new ExampleFormat("\"string\" 'string'", "Literal string delimiter"),
            new ExampleFormat("%", "Defines the following character as a custom format specifier", render: false),
            new ExampleFormat("\\", "The escape character", render: false),
            new ExampleFormat("Any other character", "The character is copied to the result string unchanged", render : false)
        };

        public static IReadOnlyCollection<ExampleFormat> GetStandardFormats()
        {
            return StandardFormats;
        }

        public static IReadOnlyCollection<ExampleFormat> GetCustomFormats()
        {
            return CustomFormats;
        }
    }
}
