using Avalonia.Controls;

namespace AvaloniaAOT.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            EmbedSample embedSample = new EmbedSample();

            MyContentControl.Content = embedSample;
        }
    }
}
