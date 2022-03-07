using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace AvaloniaBugTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        FirstWindowViewModel FirstWindowView;
        SecondWindowViewModel SecondWindowView;
        private ViewModelBase content;

        public MainWindowViewModel()
        {
            this.FirstWindowView = new FirstWindowViewModel();
            this.SecondWindowView = new SecondWindowViewModel();

            FirstWindowView.Clicked += this.FirstWindowViewModel_Clicked;
            SecondWindowView.Clicked += this.SecondWindowViewModel_Clicked;

            this.Content = this.FirstWindowView;
        }

        public ViewModelBase Content
        {
            get => this.content;
            private set => this.RaiseAndSetIfChanged(ref this.content, value);
        }

        private void FirstWindowViewModel_Clicked()
        {
            this.Content = this.SecondWindowView;
        }

        private void SecondWindowViewModel_Clicked()
        {
            this.Content = this.FirstWindowView;
        }
    }
}
