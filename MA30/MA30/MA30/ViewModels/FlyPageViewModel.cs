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
    public class FlyPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        private readonly IEventAggregator eventAggregator;

        public DelegateCommand<string> GotoPageCommand { get; set; }
        public FlyPageViewModel(INavigationService navigationService,
            IEventAggregator eventAggregator)
        {
            this.navigationService = navigationService;
            this.eventAggregator = eventAggregator;

            GotoPageCommand = new DelegateCommand<string>(async x =>
            {
                eventAggregator.GetEvent<NavigateToPageEvent>().Publish(new NavigateToPagePayload()
                {
                    Url = x
                });

                //var result = await navigationService.NavigateAsync(x);

                //await navigationService.CreateBuilder()
                //.UseAbsoluteNavigation()
                //.AddSegment<FlyPageViewModel>()
                //.AddSegment("NavigationPage")
                //.AddSegment<New3PageViewModel>()
                //.NavigateAsync();
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
