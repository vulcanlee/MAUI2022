namespace MA22.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public DelegateCommand GoNextCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        GoNextCommand = new DelegateCommand(async () =>
        {
            await navigationService.CreateBuilder()
            .AddSegment<NextPageViewModel>()
            .NavigateAsync();
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
        System.Diagnostics.Debug.WriteLine($"  -- 主頁面 OnNavigatedFrom");
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        System.Diagnostics.Debug.WriteLine($"  -- 主頁面 OnNavigatedTo");
    }

}
