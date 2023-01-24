using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestApp.Forms.NavigationClasses
{
    public class ShowEnable
    {
        Window currentWindow;
        Window nextWindow;

        public ShowEnable(Window currentWindow, Window nextWindow )
        {
            this.currentWindow = currentWindow;
            this.nextWindow = nextWindow;
        }

        public void ChangeForms()
        {
            currentWindow.Close();
            nextWindow.Show();
            nextWindow.IsEnabled = true;
        }

        public void ChangeToMain()
        {
            currentWindow.Close();
            nextWindow.Show();
            nextWindow.IsEnabled = true;

        }

        public void ChangeFromMain()
        {
            currentWindow.Hide();
            nextWindow.Show();
        }

        public void ChangeFromMainVisible()
        {
            currentWindow.IsEnabled = false;
            nextWindow.Show();
        }
    }


}
