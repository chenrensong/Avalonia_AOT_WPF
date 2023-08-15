using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaAOT.ViewModels;
using AvaloniaAOT.Views;
using System.Runtime.InteropServices;

namespace AvaloniaAOT
{
    public partial class App : Application
    {

        static App()
        {
            //ComWrappers.RegisterForMarshalling(WinFormsComWrappers.Instance);
        }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
