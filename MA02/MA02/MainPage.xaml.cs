namespace MA02;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void btnGetDisplayInformation_Clicked(object sender, EventArgs e)
    {
        double designWidth =this.Width;
        double designHeight = this.Height;
        IDeviceDisplay display = DeviceDisplay.Current;
        labelDisplay.Text = $"螢幕轉向:{display.MainDisplayInfo.Orientation}{Environment.NewLine}" +
            $"螢幕寬畫素:{display.MainDisplayInfo.Width}{Environment.NewLine}" +
            $"螢幕高畫素:{display.MainDisplayInfo.Height}{Environment.NewLine}" +
            $"設計寬畫素:{designWidth}{Environment.NewLine}" +
            $"設計高畫素:{designHeight}{Environment.NewLine}" +
            $"螢幕密度:{display.MainDisplayInfo.Density}{Environment.NewLine}"+
            $"螢幕更新頻率:{display.MainDisplayInfo.RefreshRate}{Environment.NewLine}";
    }
}

