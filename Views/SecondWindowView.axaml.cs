using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace AvaloniaBugTest.Views
{
    public partial class SecondWindowView : UserControl
    {
        public SecondWindowView()
        {
            InitializeComponent();
        }

        public static event EventHandler<RoutedEventArgs> Clicked;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void Click(object sender, RoutedEventArgs e) => SecondWindowView.Clicked?.Invoke(sender, e);
    }
}
