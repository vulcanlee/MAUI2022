namespace MA16.ViewModels;

using System.ComponentModel;
using MA16.Services;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    private readonly WhichPlatformService whichPlatformService;

    public string Message { get; set; }
    public MainPageViewModel(INavigationService navigationService,
        WhichPlatformService whichPlatformService)
    {
        this.navigationService = navigationService;
        this.whichPlatformService = whichPlatformService;
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public async void OnNavigatedTo(INavigationParameters parameters)
    {
        string whichPlatform = await whichPlatformService.GetPlatformName();
        Message = $"你在 {whichPlatform} 平台";
    }

}
