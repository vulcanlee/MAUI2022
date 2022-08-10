using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MA08
{
    public partial class MainPageViewModel : ObservableObject
    {
        // 可用於 Data Binding 中使用的命令物件
        [RelayCommand]
        void GenerateSayHello()
        {
            SayHello = $"你好 {LastName} {FirstName} {DateTime.Now}";
        }

        #region 姓氏 屬性
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string lastName;
        #endregion

        #region 名字 屬性
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        string firstName;
        #endregion

        #region 名字 屬性
        [ObservableProperty]
        string sayHello;
        #endregion

        #region 全名 屬性
        // 使用運算式主體定義來實作屬性 get 和 set 存取子
        public string FullName => $"{LastName} {FirstName}";
        #endregion
    }
}
