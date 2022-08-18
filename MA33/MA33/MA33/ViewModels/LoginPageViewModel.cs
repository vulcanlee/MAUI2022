using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA33.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class LoginPageViewModel : INotifyPropertyChanged, INavigationAware, IConfirmNavigation
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogService;

        public string Account { get; set; }
        public string Password { get; set; }
        public bool ForceCancel { get; set; } = false;
        public DelegateCommand OKCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        public LoginPageViewModel(INavigationService navigationService,
            IPageDialogService dialogService)
        {
            this.navigationService = navigationService;
            this.dialogService = dialogService;

            OKCommand = new DelegateCommand(async () =>
            {
                if (string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(Password))
                {
                    await dialogService.DisplayAlertAsync("警告", "帳號與密碼欄位必須要先輸入", "知道了");
                }
                else
                {
                    await navigationService.GoBackAsync();
                }
            });
            CancelCommand = new DelegateCommand(() =>
            { ForceCancel = true; navigationService.GoBackAsync(); });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            if (ForceCancel == false)
                if (string.IsNullOrEmpty(Account) || string.IsNullOrEmpty(Password))
                {
                    dialogService.DisplayAlertAsync("警告", "尚未輸入完成帳號與密碼，不可直接返回", "知道了");
                    return false;
                }
            return true;
        }
    }
}
