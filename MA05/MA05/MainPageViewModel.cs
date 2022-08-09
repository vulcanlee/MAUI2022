using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA05
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region 實作出 INotifyPropertyChanged 的程式碼
        // 在這個 INotifyPropertyChanged 介面內，只有宣告一個 event PropertyChangedEventHandler? PropertyChanged; 成員
        public event PropertyChangedEventHandler? PropertyChanged;
        // 設計底下的方法，是要方便可以觸發 PropertyChanged 這個事件
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region 使用 含有支援欄位的屬性 來設計需要綁定的屬性

        #region 姓氏 屬性
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null) return;
                if (value.Equals(lastName) == false)
                {
                    lastName = value;
                    // 發出本身屬性有發生屬性值異動，要產生通知事件
                    OnPropertyChanged("LastName");
                    // 同步發出該屬性也有發生變更的事件通知
                    OnPropertyChanged("SayHello");
                }
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
                if (value == null) return;
                if (value.Equals(firstName) == false)
                {
                    firstName = value;
                    // 發出本身屬性有發生屬性值異動，要產生通知事件
                    OnPropertyChanged("LastName");
                    // 同步發出該屬性也有發生變更的事件通知
                    OnPropertyChanged("SayHello");
                }
            }
        }
        #endregion

        #region 全名 屬性
        // 使用運算式主體定義來實作屬性 get 和 set 存取子
        public string SayHello => $"你好 {LastName} {FirstName}";
        #endregion
        #endregion

    }
}
