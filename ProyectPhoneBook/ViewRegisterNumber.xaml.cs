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
using ClassLibrary1;

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
            

             Class1 c = new Class1();
             if (c.IsValid(PlusContactnumber.Text))
             {
                 StreamWriter dbtxt = new StreamWriter("C:/Users/Angel/Desktop/listPhoneandAddress.txt", true);
                 dbtxt.WriteLine(ListRegionNumbers.Text + ";" + PlusContactnumber.Text + ";" + PlusAddress.Text);
                 dbtxt.Close();

                 StreamReader leertxt = new StreamReader("C:/Users/Angel/Desktop/listPhoneandAddress.txt");
             }
             else
             {
                 MessageBox.Show("Datos Incorrectos");
             }


        }
    }
}
