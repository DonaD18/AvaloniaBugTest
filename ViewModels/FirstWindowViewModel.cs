using AvaloniaBugTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaBugTest.ViewModels
{
    class FirstWindowViewModel : ViewModelBase
    {
        public FirstWindowViewModel()
        {
            FirstWindowView.Clicked += FirstWindowView_Clicked;
        }

        public event Action Clicked;

        private void FirstWindowView_Clicked(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.Clicked?.Invoke();
        }
    }
}
