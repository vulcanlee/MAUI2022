namespace MA17.ViewModels;

using System.ComponentModel;
using System.Threading.Tasks;
using MA17.Services;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;

    public string Message { get; set; }

    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public async void OnNavigatedTo(INavigationParameters parameters)
    {
        WhichPlatformService whichPlatformService = new WhichPlatformService();

        string whichPlatform = await whichPlatformService.GetPlatformName();
        Message = $"你在 {whichPlatform} 平台";
    }
}
