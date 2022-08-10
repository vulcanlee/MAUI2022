namespace MA09.ViewModels;

using System.ComponentModel;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
{
    public event PropertyChangedEventHandler PropertyChanged;

    private readonly INavigationService navigationService;
    public Color Color { get; set; }
    public double R { get; set; }
    public double G { get; set; }
    public double B { get; set; }
    public int R255 { get; set; }
    public int G255 { get; set; }
    public int B255 { get; set; }
    public DelegateCommand RefreshColorCommand { get; set; }
    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
        RefreshColorCommand = new DelegateCommand(() =>
        {
            R255 = (int)(R * 255);
            G255 = (int)(G * 255);
            B255 = (int)(B * 255);
            Color = Color.FromRgb(R, G, B);
        });
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
    }

}
