using Avalonia.Controls;
using Avalonia.LogicalTree;
using Avalonia.Markup;
using Avalonia.Markup.Xaml;

namespace ControlCatalog.Pages
{
    public class CustomControlSamplePage : UserControl
    {
        public CustomControlSamplePage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
