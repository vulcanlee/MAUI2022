using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MA06
{
    public class BindableBase : INotifyPropertyChanged
    {
        #region 實作出 INotifyPropertyChanged 的程式碼
        public event PropertyChangedEventHandler PropertyChanged;

        // 使用表示式的方式來設計
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args) 
            => PropertyChanged?.Invoke(this, args);
        #endregion

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            // 先比對新舊的物件值是否相同，若不同，才會觸發 屬性變更 的通知事件
            if (EqualityComparer<T>.Default.Equals(storage, value)) return false;

            // 將此次設定的物件值，指派給該欄位
            storage = value;
            // 觸發 屬性變更 的通知事件
            RaisePropertyChanged(propertyName);

            return true;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}
