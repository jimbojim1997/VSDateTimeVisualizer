using System;
using System.Windows.Forms;

using Microsoft.VisualStudio.DebuggerVisualizers;

namespace VSDateTimeVisualizer.Debugger
{
    //Documentation: https://learn.microsoft.com/en-us/visualstudio/debugger/create-custom-visualizers-of-data

    public class DateTimeDebuggerVisualizer : DialogDebuggerVisualizer
    {
        //Despite being obsolete this is required
        [Obsolete]
        public DateTimeDebuggerVisualizer()
        {
        }

        public DateTimeDebuggerVisualizer(FormatterPolicy preferredFormatterPolicy) : base(preferredFormatterPolicy)
        {
        }

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider originalObjectProvider)
        {
            var objectProvider = originalObjectProvider as IVisualizerObjectProvider3;
            if (objectProvider is null) return;

            var date = objectProvider.GetDeserializableObject().ToObject<DateTime>();

            windowService.ShowDialog(new DateTimeVisualizerForm(date));
        }
    }
}
