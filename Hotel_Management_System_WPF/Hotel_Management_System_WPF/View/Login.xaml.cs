using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Hotel_Management_System_WPF.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void showPassword()
        {

        }

        private void TabablzControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnShowPW_Checked(object sender, RoutedEventArgs e)
        {
            tbShowPassword.Text = tbPassword.Password.ToString();
            tbShowPassword.Visibility = Visibility.Visible;
        }

        private void btnShowPW_Unchecked(object sender, RoutedEventArgs e)
        {
           
            tbShowPassword.Visibility = Visibility.Hidden;
        }
    }
}
