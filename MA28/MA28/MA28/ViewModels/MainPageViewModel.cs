namespace MA28.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    private readonly IPageDialogService dialogService;
    public DelegateCommand<string> EchoCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService,
        IPageDialogService dialogService)
    {
        this.navigationService = navigationService;
        this.dialogService = dialogService;

        EchoCommand = new DelegateCommand<string>(async x =>
        {
            await dialogService.DisplayAlertAsync("通知", $"你點選了 {x}", "確定");
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
