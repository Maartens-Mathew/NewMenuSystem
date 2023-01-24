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
using TestApp.Forms.NavigationClasses;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance;
        public static WaitronSelector waitronWindow;
        



        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            

        }

        

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {           
            OrderMenu orderMenu = new OrderMenu();          
            ShowEnable toNewOrder = new ShowEnable(this, orderMenu);
            toNewOrder.ChangeFromMain();

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
           
            waitronWindow = new WaitronSelector();              
            ShowEnable toWaitron = new ShowEnable(this, waitronWindow);
            toWaitron.ChangeFromMainVisible();
        }



        
    }
}
