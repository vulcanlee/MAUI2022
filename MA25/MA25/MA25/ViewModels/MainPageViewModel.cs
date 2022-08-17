namespace MA25.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public DelegateCommand GoNextCommand { get; set; }
    public DelegateCommand GoLastCommand { get; set; }

    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        GoNextCommand = new DelegateCommand(async () =>
        {
            await navigationService.CreateBuilder()
            .AddSegment<Page1ViewModel>()
            .NavigateAsync();
        });

        GoLastCommand = new DelegateCommand(async () =>
        {
            await navigationService.CreateBuilder()
            .AddSegment("Page1/Page2/Page3")
            .NavigateAsync();
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
