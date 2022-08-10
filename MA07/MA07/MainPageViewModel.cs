using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MA07
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // 可用於 Data Binding 中使用的命令物件
        public ICommand SayHelloCommand { get; set; }
        public MainPageViewModel()
        {
            // 傳入委派方法，為這個命令物件做初始化設定
            SayHelloCommand = new Command(() =>
            {
                SayHello = $"你好 {LastName} {FirstName} {DateTime.Now}";
            });
        }

        #region 針對每個具有 PropertyChanged 的屬性，都需要有底下的程式碼設計方式

        #region 姓氏 屬性
        public string LastName { get; set; }
        #endregion

        #region 名字 屬性
        public string FirstName { get; set; }
        #endregion

        #region 問安文字 屬性
        public string SayHello { get; set; }
        #endregion
        #endregion

        #region 全名 屬性
        // 使用運算式主體定義來實作屬性 get 和 set 存取子
        public string FullName => $"{LastName} {FirstName}";
        #endregion
    }
}
