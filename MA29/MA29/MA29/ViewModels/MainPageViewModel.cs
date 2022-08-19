namespace MA29.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public DelegateCommand GoNextCommand { get; set; }
    public DelegateCommand ShowTitleViewCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        GoNextCommand = new DelegateCommand(async () =>
        {
            await navigationService.CreateBuilder()
            .AddSegment<NextPageViewModel>()
            .NavigateAsync();
        });

        ShowTitleViewCommand = new DelegateCommand(async () =>
        {
            await navigationService.CreateBuilder()
            .AddSegment<HasTitleViewViewModel>()
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
