using System;

namespace VSDateTimeVisualizer.Debugger
{
    internal class ExampleFormat
    {
        public readonly string Format;
        public readonly string Description;

        public ExampleFormat(string format, string description)
        {
            Format = format ?? throw new ArgumentNullException(nameof(format));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }
}
