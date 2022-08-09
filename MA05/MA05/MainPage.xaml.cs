namespace MA05;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		#region ViewModel 的綁定，也可以在 Code Behind 來實作出來
		//this.BindingContext = new MainPageViewModel();
		#endregion
	}
}

