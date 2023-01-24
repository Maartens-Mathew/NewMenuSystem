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
using TestApp.Forms.NavigationClasses;
using TestApp.MVVM.ViewModels;

namespace TestApp.Forms
{
    /// <summary>
    /// Interaction logic for OrderMenu.xaml
    /// </summary>
    /// Background="#0a353d"
    public partial class OrderMenu : Window
    {
        
        public static OrderMenu OrderWindow;
        public OrderMenu()
        {
            InitializeComponent();
            OrderWindow = this;
            
         
        }

       

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ShowEnable toMain = new ShowEnable(this,MainWindow.Instance);
            toMain.ChangeToMain();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bdrClose.Background = Brushes.Black;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DataContext = new DrinksViewModel();

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            DataContext = new FoodsViewModel();
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            DataContext = new BeveragesViewModel();
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            
            
        }
    }
}
