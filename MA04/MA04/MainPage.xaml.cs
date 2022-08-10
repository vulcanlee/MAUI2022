namespace MA04;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnSayHello_Clicked(object sender, EventArgs e)
	{
		#region 進行資料完整性檢查
		if (string.IsNullOrEmpty(entry姓氏.Text))
		{
			DisplayAlert("警告", "必須要輸入 姓氏", "了解");
			return;
		}
		if (string.IsNullOrEmpty(entry名字.Text))
		{
			DisplayAlert("警告", "必須要輸入 名字", "了解");
			return ;
		}
		#endregion

		#region 執行觸發這個按鈕要執行的工作
		// 取得 UI 中使用者輸入文字的屬性內容
		var 姓氏 = entry姓氏.Text;
        // 取得 UI 中使用者輸入文字的屬性內容
        var 名字 = entry名字.Text;
        // 設定 文字標籤 UI 要顯示的新文字內容
        labelSayHello.Text = $"你好 {姓氏} {名字} {DateTime.Now}";
		#endregion
    }

	private void entry姓氏_TextChanged(object sender, TextChangedEventArgs e)
	{
		labelFullName.Text = $"{entry姓氏.Text} {entry名字.Text}";
    }

	private void entry名字_TextChanged(object sender, TextChangedEventArgs e)
	{
        labelFullName.Text = $"{entry姓氏.Text} {entry名字.Text}";
    }
}

