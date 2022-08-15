namespace MA27.ViewModels;

using System.ComponentModel;
using MA27.Services;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public async void OnNavigatedTo(INavigationParameters parameters)
    {
        await Task.Yield();
        StatusBarService statusBarService = new StatusBarService();
        statusBarService.ChangeBackgroundColor(Colors.Red);
    }

}
