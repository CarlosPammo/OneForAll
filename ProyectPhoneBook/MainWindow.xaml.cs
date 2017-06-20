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

namespace ProyectPhoneBook
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOthers_Click(object sender, RoutedEventArgs e)
        {
            ViewRegisterNumber v = new ViewRegisterNumber();
            v.Show();
        }

        private void NumberContacts_Click(object sender, RoutedEventArgs e)
        {
            ViewDiary view = new ViewDiary();
            view.Show();
        }
    }
}
