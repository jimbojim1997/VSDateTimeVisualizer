using System;

using Microsoft.VisualStudio.DebuggerVisualizers;

namespace VSDateTimeVisualizer.Debugger
{
    public class DateTimeDebuggerVisualizer : DialogDebuggerVisualizer
    {
        public DateTimeDebuggerVisualizer(FormatterPolicy preferredFormatterPolicy) : base(preferredFormatterPolicy)
        {
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            throw new NotImplementedException();
        }
    }
}
