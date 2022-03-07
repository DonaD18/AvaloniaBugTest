using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace AvaloniaBugTest.Views
{
    public partial class FirstWindowView : UserControl
    {
        public FirstWindowView()
        {
            InitializeComponent();
        }

        public static event EventHandler<RoutedEventArgs> Clicked;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void Click(object sender, RoutedEventArgs e) => FirstWindowView.Clicked?.Invoke(sender, e);
    }
}
