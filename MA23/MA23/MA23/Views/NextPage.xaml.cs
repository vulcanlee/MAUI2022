namespace MA23.Views;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();

        this.Appearing += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine($"  @@ �U�@�� ContentPage Appearing");
        };

        this.Disappearing += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine($"  @@ �U�@�� ContentPage Disappearing");
        };
    }
}
