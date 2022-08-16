namespace MA23.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        this.Appearing += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine($"  -- 主頁面 ContentPage Appearing");
        };

        this.Disappearing += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine($"  -- 主頁面 ContentPage Disappearing");
        };
    }
}

