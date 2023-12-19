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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kafe
{
    /// <summary>
    /// Логика взаимодействия для AdminDobSot.xaml
    /// </summary>
    public partial class AdminDobSot : Page
    {
        public AdminDobSot()
        {
            InitializeComponent();
        }



        private void vozv_Click(object sender, RoutedEventArgs e)
        {
            Frameobj.frameMain.Navigate(new AdminG());
        }
    }
}
