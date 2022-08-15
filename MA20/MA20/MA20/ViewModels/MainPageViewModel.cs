using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;

namespace MA20.ViewModels;

public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    private readonly IPageDialogService dialogService;

    public DelegateCommand GoNextCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService,
        IPageDialogService dialogService)
    {
        this.navigationService = navigationService;
        this.dialogService = dialogService;
        GoNextCommand = new DelegateCommand(async () =>
        {
            #region 舊的做法
            //var result = await navigationService.NavigateAsync("NextPage");

            //#region 若對於 NextPage 頁面尚未註冊到 Prism 內，體驗這裡的程式碼效果
            ////if (result.Success == false)
            ////{
            ////    await dialogService.DisplayAlertAsync("錯誤", "頁面導航失敗", "知道了");
            ////    if (result.Exception != null)
            ////    {
            ////        await dialogService.DisplayAlertAsync("導航失敗",
            ////            $"例外:{result.Exception.Message}", "知道了");
            ////    }
            ////}
            //#endregion
            #endregion

            #region 使用新的 Navigation Builder 作法
            var result = await navigationService.CreateBuilder()
             // 這裡指定 ViewModel 名稱作為要導航到的頁面目的地
             .AddSegment<NextPageViewModel>()
             .NavigateAsync();
            #endregion
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
