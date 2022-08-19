namespace MA31.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public DelegateCommand GoBackCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        GoBackCommand = new DelegateCommand(async () =>
        {
            await navigationService.GoBackAsync();
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
