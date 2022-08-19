using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA31.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class New2PageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public DelegateCommand GoMainPageCommand { get; set; }
        public New2PageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            GoMainPageCommand = new DelegateCommand(async () =>
            {
                await navigationService.NavigateAsync("MainPage");
            });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

    }
}
