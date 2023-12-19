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
    /// Логика взаимодействия для AdminG.xaml
    /// </summary>
    public partial class AdminG : Page
    {
        public AdminG()
        {
            InitializeComponent();
        }

        private void dob_sot_Click(object sender, RoutedEventArgs e)
        {
            Frameobj.frameMain.Navigate(new AdminDobSot());
        }
    }
}
