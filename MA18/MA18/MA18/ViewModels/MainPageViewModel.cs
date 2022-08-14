namespace MA18.ViewModels;

using System.ComponentModel;
using MA18.Services;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    private readonly AddService addService;

    public string Message { get; set; }
    public DelegateCommand CallWebAPICommand { get; set; }
    public bool EnableButton { get; set; } = true;
    public MainPageViewModel(INavigationService navigationService,
        AddService addService)
    {
        this.navigationService = navigationService;
        this.addService = addService;
        CallWebAPICommand = new DelegateCommand(async () =>
        {
            EnableButton = false;
            Message = await addService.AddValues(8, 9);
            EnableButton = true;
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
