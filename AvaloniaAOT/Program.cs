using Avalonia;
using Avalonia.Automation.Peers;
using Avalonia.Media;
using Avalonia.ReactiveUI;
using System;
using System.Runtime.InteropServices;

namespace AvaloniaAOT
{
    internal class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {

            ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);
            _ = BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            FontManagerOptions options = new();

            if (OperatingSystem.IsLinux())
            {
                options.DefaultFamilyName = "Arial";
            }

            return AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI()
                .With(options);
        }
    }
}
