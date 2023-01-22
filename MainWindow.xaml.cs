using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestApp.Forms;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        Color lightBlue = new Color();
        Color darkBlue = new Color();


        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            
            lightBlue = Color.FromRgb(10, 53, 61);  
            darkBlue = Color.FromRgb(7, 36, 41);
        }

        

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrderMenu orderMenu = new OrderMenu();
            orderMenu.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();    
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bdrClose.Background = Brushes.Black;
        }

        private void radExistingOrder_Checked(object sender, RoutedEventArgs e)
        {
           // this.Hide();
            WaitronSelector waitronWindow = new WaitronSelector();
            waitronWindow.Show();
            this.IsEnabled = false;
        }
    }
}
