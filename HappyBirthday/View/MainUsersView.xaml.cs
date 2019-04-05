
using System.Windows;
using HappyBirthday.ViewModel;

namespace HappyBirthday.View
{
    /// <summary>
    /// Interaction logic for MainUsersView.xaml
    /// </summary>
    public partial class MainUsersView : Window
    {
        public MainUsersView()
        {
           
            InitializeComponent();
            DataContext = new MainViewModel();
           
        }

       

        private void UserListView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void UserListView_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        //protected override void OnClosing(CancelEventArgs e)
        //{
        //    base.OnClosing(e);
        //    StationManager.CloseApp();
        //}
    }
}
