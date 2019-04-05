using System.Windows.Controls;
using HappyBirthday.ViewModel;

namespace HappyBirthday.View
{
    /// <summary>
    /// Interaction logic for UserListView.xaml
    /// </summary>
    public partial class UserListView : UserControl
    {
        public UserListView()
        {
            InitializeComponent();
            DataContext = new ProcessListViewModel();
        }
    }
}
