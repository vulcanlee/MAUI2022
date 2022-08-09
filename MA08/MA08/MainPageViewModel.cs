using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA08
{
    public partial class MainPageViewModel : ObservableObject
    {
        #region 姓氏 屬性
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(SayHello))]
        string lastName;
        #endregion

        #region 名字 屬性
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(SayHello))]
        string firstName;
        #endregion

        #region 全名 屬性
        // 使用運算式主體定義來實作屬性 get 和 set 存取子
        public string SayHello => $"你好 {LastName} {FirstName}";
        #endregion
    }
}
