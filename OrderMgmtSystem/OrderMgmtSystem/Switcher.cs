using System.Windows.Controls;

namespace OrderMgmtSystem
{
    public static class Switcher
    {
        public static MainWindow mainWindow;

        public static void Switch(UserControl newPage)
        {
            mainWindow.Navigate(newPage);
        }
    }
}
