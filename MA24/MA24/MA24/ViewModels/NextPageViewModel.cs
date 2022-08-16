using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA24.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class NextPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        public string Account { get; set; }
        public string Password { get; set; }
        public DelegateCommand<string> GobackCommand { get; set; }

        public NextPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            GobackCommand = new DelegateCommand<string>(async x =>
            {
                NavigationParameters para = new NavigationParameters();
                para.Add("UserResponse", x);
                await navigationService.GoBackAsync(para);
            });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.ContainsKey(nameof(Account)))
                Account = parameters.GetValue<string>(nameof(Account));
            if (parameters.ContainsKey(nameof(Password)))
                Password = parameters.GetValue<string>(nameof(Password));
        }

    }
}
