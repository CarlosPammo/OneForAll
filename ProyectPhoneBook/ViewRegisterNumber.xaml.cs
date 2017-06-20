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
using System.IO;

namespace ProyectPhoneBook
{
    /// <summary>
    /// Lógica de interacción para ViewRegisterNumber.xaml
    /// </summary>
    public partial class ViewRegisterNumber : Window
    {
        public ViewRegisterNumber()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            StreamWriter dbtxt = new StreamWriter("C:/Users/Angel/Desktop/list.txt",true);
            dbtxt.WriteLine(_number.Text + ";" + _email.Text + ";" + _fax.Text + ";" + _Address.Text);
            dbtxt.Close();

        }
    }
}
