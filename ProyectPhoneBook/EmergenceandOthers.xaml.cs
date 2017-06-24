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
    /// Lógica de interacción para Business.xaml
    /// </summary>
    public partial class Business : Window
    {
        public Business()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 c = new Class1();
            if (c.IsValid(Numero.Text))
            {
                StreamWriter dbtxt = new StreamWriter("C:/Users/Angel/Desktop/listPhoneandOthers.txt", true);
                dbtxt.WriteLine(Numero.Text + ";" + _Description.Text );
                dbtxt.Close();

                    //StreamReader leertxt = new StreamReader("C:/Users/Angel/Desktop/listPhoneandAddress.txt");
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }
    }
}
