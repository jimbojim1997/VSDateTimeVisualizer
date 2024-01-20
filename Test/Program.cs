using System;

using Microsoft.VisualStudio.DebuggerVisualizers;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            ShowVisualizer(date);
        }

        static void ShowVisualizer(DateTime date)
        {
            var host = new VisualizerDevelopmentHost(date, typeof(VSDateTimeVisualizer.Debugger.DateTimeDebuggerVisualizer));
            host.ShowVisualizer();
        }
    }
}
