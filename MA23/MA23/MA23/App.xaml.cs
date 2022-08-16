namespace MA23;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        this.PageAppearing += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine($"  >> Application PageAppearing {e.Title} / {e.GetType().Name}");
        };

        this.PageDisappearing += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine($"  >> Application PageDisappearing {e.Title} / {e.GetType().Name}");
        };
    }
}
