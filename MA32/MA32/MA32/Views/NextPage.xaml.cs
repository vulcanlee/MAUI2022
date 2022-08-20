namespace MA32.Views;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
	}
    protected override bool OnBackButtonPressed()
    {
        //base.OnBackButtonPressed();
        return true;
    }
}
