using System;

namespace VSDateTimeVisualizer.Debugger
{
    internal class ExampleFormat
    {
        public readonly string Label;
        public readonly string Format;
        public readonly string Description;
        public readonly bool Render;

        public ExampleFormat(string format, string description, bool render = true) : this(format, format, description, render)
        {
        }

        public ExampleFormat(string label, string format, string description, bool render = true)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Format = format ?? throw new ArgumentNullException(nameof(format));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Render = render;
        }
    }
}
