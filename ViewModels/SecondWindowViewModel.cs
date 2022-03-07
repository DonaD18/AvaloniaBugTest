using AvaloniaBugTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaBugTest.ViewModels
{
    class SecondWindowViewModel : ViewModelBase
    {
        public SecondWindowViewModel()
        {
            SecondWindowView.Clicked += SecondWindowView_Clicked;
        }

        public event Action Clicked;

        private void SecondWindowView_Clicked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Clicked?.Invoke();
        }
    }
}
