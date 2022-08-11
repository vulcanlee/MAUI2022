namespace MA11.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public DelegateCommand<string> MyButtonCommand { get; set; }
    public string YourChoice { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        // 在這裡僅需要設計一個命令物件來提供綁定即可
        // 至於按下的是哪個按鈕，可以存參數中來比對
        MyButtonCommand = new DelegateCommand<string>(x =>
        {
            YourChoice = $"你按下的按鈕是 : {x}";
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
