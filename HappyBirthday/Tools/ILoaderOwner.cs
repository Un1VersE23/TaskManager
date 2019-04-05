using System.ComponentModel;
using System.Windows;

namespace HappyBirthday.Tools
{

    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
