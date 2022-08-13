namespace MA15.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    private readonly IPageDialogService dialogService;

    public string Message { get; set; }
    public DelegateCommand DisplayAlertCommand { get; set; }
    public DelegateCommand DisplayActionSheetCommand { get; set; }
    public DelegateCommand DisplayPromptCommand { get; set; }

    public MainPageViewModel(INavigationService navigationService,
        IPageDialogService dialogService)
    {
        this.navigationService = navigationService;
        this.dialogService = dialogService;

        DisplayAlertCommand = new DelegateCommand(async () =>
        {
            await dialogService.DisplayAlertAsync("警告", "現在無法連上網路", "確定");
        });

        DisplayActionSheetCommand = new DelegateCommand(async () =>
        {
            string result = await dialogService.DisplayActionSheetAsync("你喜歡哪個水果", "取消", null,
                 "蘋果", "香蕉", "西瓜");
            Message = result;
        });

        DisplayPromptCommand = new DelegateCommand(async () =>
        {
            string result = await dialogService.DisplayPromptAsync("請問你的大名?", "請輸入你的名字", "確定", "取消");
            Message = result;
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
