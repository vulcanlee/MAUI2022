using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA13.ViewModels
{
    using System.ComponentModel;
    using MA13.Events;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        private readonly IEventAggregator eventAggregator;

        public string Message { get; set; }
        public DelegateCommand SendBackCommand { get; set; }
        public NextPageViewModel(INavigationService navigationService,
            IEventAggregator eventAggregator)
        {
            this.navigationService = navigationService;
            // 透過建構式注入方式，取得事件聚合器的物件
            this.eventAggregator = eventAggregator;
            SendBackCommand = new DelegateCommand(() =>
            {
                // 取得特定事件的物件，使用 Publish 發佈該事件
                eventAggregator.GetEvent<UserEchoEvent>()
                .Publish(new UserEchoPayload()
                {
                     EchoMessage = Message
                });

                // 導航回去上一個頁面
                navigationService.GoBackAsync();
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
