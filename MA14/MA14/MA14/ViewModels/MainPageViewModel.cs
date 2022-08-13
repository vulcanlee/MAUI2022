namespace MA14.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public double CurrentValue { get; set; }
    public double CurrentRotation { get; set; } = 0;
    public string Message { get; set; }
    public DelegateCommand ValueChangedCommand { get; set; }
    // 這裡需要宣告該泛型型別必須要能夠為空值
    public DelegateCommand<double?> ValueChangedWithArgementCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        #region 只要 Slider 數值有變化，變化觸發此命令
        ValueChangedCommand = new DelegateCommand(() =>
        {
            Message = $"現在數值:{CurrentValue}";
        });
        #endregion

        #region [進階挑戰] 題目：只要 Slider 變化觸發此命令，會傳入當時事件的指定參數值
        ValueChangedWithArgementCommand = new DelegateCommand<double?>(x =>
        {
            CurrentRotation = x.Value;
        });
        #endregion
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
