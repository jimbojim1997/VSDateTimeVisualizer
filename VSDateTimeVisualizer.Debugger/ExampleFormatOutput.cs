using System;
using System.Windows.Forms;

namespace VSDateTimeVisualizer.Debugger
{
    internal class ExampleFormatOutput
    {
        private readonly string Format;
        private readonly Label Label;
        private readonly bool Render;

        public ExampleFormatOutput(string format, Label label, bool render = true)
        {
            Format = format ?? throw new ArgumentNullException(nameof(format));
            Label = label ?? throw new ArgumentNullException(nameof(label));
            Render = render;
        }

        public void Update(DateTime dateTime)
        {
            if(Render) Label.Text = dateTime.ToString(Format);
        }
    }
}
