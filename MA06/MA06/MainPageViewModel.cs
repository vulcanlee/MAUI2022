using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA06
{
    public class MainPageViewModel : BindableBase
    {
        #region 針對每個具有 PropertyChanged 的屬性，都需要有底下的程式碼設計方式

        #region 姓氏 屬性
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                SetProperty(ref lastName, value);
                RaisePropertyChanged(nameof(SayHello));
            }
        }
        #endregion

        #region 名字 屬性
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                SetProperty(ref firstName, value);
                RaisePropertyChanged(nameof(SayHello));
            }
        }
        #endregion
        #endregion

        #region 全名 屬性
        // 使用運算式主體定義來實作屬性 get 和 set 存取子
        public string SayHello => $"你好 {LastName} {FirstName}";
        #endregion

    }
}
