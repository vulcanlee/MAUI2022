using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA30.ViewModels
{
    using System.ComponentModel;
    using MA30.Events;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class NaviPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        private readonly IEventAggregator eventAggregator;

        public NaviPageViewModel(INavigationService navigationService,
            IEventAggregator eventAggregator)
        {
            this.navigationService = navigationService;
            this.eventAggregator = eventAggregator;

            eventAggregator.GetEvent<NavigateToPageEvent>().Subscribe(async x =>
            {
                await navigationService.NavigateAsync(x.Url);
            }, true);
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

    }
}
