namespace MA12.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    /// <summary>
    /// 使用者輸入的帳號
    /// </summary>
    public string Account { get; set; }
    /// <summary>
    /// 是否符合可以登入的狀態
    /// </summary>
    public bool CanLogin { get; set; } = false;
    public string Message { get; set; }
    public DelegateCommand LoginCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        // 對於 DelegateCommand 在建立此物件的時候，
        // 將會傳入兩個委派方法，第一個是執行這個命令要用到的委派方法
        // 第二個是這個按鈕是否可以啟用的委派方法
        LoginCommand = new DelegateCommand(() =>
        {
            Message = $"恭喜你已經登入成功了";
        }, ()=>CanLogin);
    }

    #region 該方法 會由 PropertyChanged.Fody 當指定屬性值有變動的時候來觸發
    void OnAccountChanged()
    {
        if (string.IsNullOrEmpty(Account) == false &&
            Account.Length >= 6)
            CanLogin = true;
        else
        {
            CanLogin = false;
            Message = "";
        }
        // 通知 命令 物件檢查是否可以啟用執行
        LoginCommand.RaiseCanExecuteChanged();
    }
    #endregion

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
