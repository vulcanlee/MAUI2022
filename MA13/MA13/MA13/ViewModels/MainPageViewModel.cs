namespace MA13.ViewModels;

using System.ComponentModel;
using MA13.Events;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    private readonly IEventAggregator eventAggregator;

    public string Answer { get; set; }
    public DelegateCommand GoNextCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService,
        IEventAggregator eventAggregator)
    {
        this.navigationService = navigationService;
        // 透過建構式注入方式，取得事件聚合器的物件
        this.eventAggregator = eventAggregator;

        // 取得特定事件的物件，使用 Subscribe 訂閱事件
        // 當此事件被 Publish 觸發後，將會執行這裡的委派方法
        eventAggregator.GetEvent<UserEchoEvent>()
            .Subscribe(x =>
            {
                Answer = x.EchoMessage;
            });

        GoNextCommand = new DelegateCommand(() =>
        {
            // 在這裡採用指定 ViewModel 型別作為導航的目的
            navigationService.CreateBuilder()
            .AddNavigationSegment<NextPageViewModel>()
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
