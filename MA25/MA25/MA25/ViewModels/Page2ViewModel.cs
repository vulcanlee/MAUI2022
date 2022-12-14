using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA25.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class Page2ViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public DelegateCommand GoNextCommand { get; set; }

        public Page2ViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            GoNextCommand = new DelegateCommand(async () =>
            {
                await navigationService.CreateBuilder()
                .AddSegment<Page3ViewModel>()
                .NavigateAsync();
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
