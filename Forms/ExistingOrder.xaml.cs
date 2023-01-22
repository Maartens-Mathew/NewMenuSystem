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

namespace TestApp.Forms
{
    /// <summary>
    /// Interaction logic for ExistingOrder.xaml
    /// </summary>
    public partial class ExistingOrder : Window
    {
        
        public ExistingOrder()
        {
            InitializeComponent();
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            MainWindow.Instance.Show();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            bdrClose.Background = Brushes.Black;
        }
    }
}
