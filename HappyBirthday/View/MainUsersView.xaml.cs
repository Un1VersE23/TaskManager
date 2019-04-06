
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

       

       
    }
}
