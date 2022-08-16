namespace MA24.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public string Account { get; set; }
    public string Password { get; set; }
    public string UserResponse { get; set; }
    public DelegateCommand LoginCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;

        LoginCommand = new DelegateCommand(async () =>
        {
            NavigationParameters para = new NavigationParameters();
            para.Add(nameof(Account), Account);
            para.Add(nameof(Password), Password);

            await navigationService.CreateBuilder()
            .WithParameters(para)
            .AddSegment<NextPageViewModel>()
            .NavigateAsync();
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        UserResponse = "";
        if (parameters.GetNavigationMode() == NavigationMode.Back)
        {
            if (parameters.ContainsKey(nameof(UserResponse)))
            {
                UserResponse = parameters.GetValue<string>(nameof(UserResponse));
            }
        }
    }

}
