using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA23.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware, IPageLifecycleAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public DelegateCommand GoBackCommand { get; set; }
        public NextPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            GoBackCommand = new DelegateCommand(async () =>
            {
                await navigationService.GoBackAsync();
            });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            System.Diagnostics.Debug.WriteLine($"  @@ 下一頁 OnNavigatedFrom");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            System.Diagnostics.Debug.WriteLine($"  @@ 下一頁 OnNavigatedTo");
        }

        public void OnAppearing()
        {
            System.Diagnostics.Debug.WriteLine($"  @@ 下一頁 OnAppearing");
        }

        public void OnDisappearing()
        {
            System.Diagnostics.Debug.WriteLine($"  @@ 下一頁 OnDisappearing");
        }
    }
}
