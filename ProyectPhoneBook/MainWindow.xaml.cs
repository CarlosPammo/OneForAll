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
using System.IO;

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
           
            StreamWriter dbtxt = new StreamWriter("C:/Users/Angel/Desktop/list.txt", true);
            dbtxt.WriteLine( boxTypeContact.Text + ";" + _Name.Text + ";" + _LastName.Text + ";" + _Birtday.Text + ";" + _Email.Text + ";" + _Fax.Text + ";" + _NumeroContacto.Text+";"+_Address.Text);
            dbtxt.Close();
            StreamWriter dbtxtnumbers = new StreamWriter("C:/Users/Angel/Desktop/listPhoneandAddress.txt", true);
            dbtxtnumbers.WriteLine(ListRegionNumbers.Text+";"+_NumeroContacto.Text + ";" + _Address.Text );
            dbtxtnumbers.Close();

            MessageBox.Show("Datos Guardados");
           
        }

        private void NumberContacts_Click(object sender, RoutedEventArgs e)
        {
            ViewDiary view = new ViewDiary();
            view.Show();
        }

        private void btnNumbers_Click(object sender, RoutedEventArgs e)
        {
            ViewRegisterNumber v = new ViewRegisterNumber();
            v.Show();

        }

        private void _NumeroContacto_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Estas en la caja numero");
        }

       

       
    }
}
