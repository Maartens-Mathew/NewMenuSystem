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

namespace TestApp.Forms
{
    /// <summary>
    /// Interaction logic for WaitronSelector.xaml
    /// </summary>
    public partial class WaitronSelector : Window
    {
        public static ExistingOrder ExistingWindow;
        public WaitronSelector()
        {
            InitializeComponent();
            this.Topmost= true;
            lbxWaitrons.Items.Add("Mathew");
            lbxWaitrons.Items.Add("Sithembiso");
            lbxWaitrons.Items.Add("Rubin");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock txtExit = (TextBlock)sender;
            txtExit.Foreground = Brushes.White;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock txtExit = (TextBlock)sender;
            txtExit.Foreground = Brushes.LightGray;
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {                  
            ShowEnable toMain = new ShowEnable(this, MainWindow.Instance);
            toMain.ChangeToMain();
        }

        private void Border_MouseUp(object sender, MouseButtonEventArgs e)
        {          
            ExistingWindow = new ExistingOrder();                      
            ShowEnable toExisting = new ShowEnable(this, ExistingWindow);
            toExisting.ChangeForms();

        }
    }
}
