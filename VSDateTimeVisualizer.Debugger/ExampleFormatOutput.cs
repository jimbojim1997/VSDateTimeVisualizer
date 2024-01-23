using System;
using System.Windows.Forms;

namespace VSDateTimeVisualizer.Debugger
{
    internal class ExampleFormatOutput
    {
        private readonly string Format;
        private readonly Label Label;

        public ExampleFormatOutput(string format, Label label)
        {
            Format = format ?? throw new ArgumentNullException(nameof(format));
            Label = label ?? throw new ArgumentNullException(nameof(label));
        }

        public void Update(DateTime dateTime)
        {
            Label.Text = dateTime.ToString(Format);
        }
    }
}
