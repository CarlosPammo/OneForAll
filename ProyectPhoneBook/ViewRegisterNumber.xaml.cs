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
using ClassLibrary1;//Realizamos la importacion del proyecto PhoneBookController
/*Pero antes realizamos la referencia de ese proyecto */

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
            
            //Instanciacion de la clase Validtextsmethods de nuestro diccionario de clases
             ValidTextsMethods c = new ValidTextsMethods();
             if (c.IsValid(PlusContactnumber.Text))
             {
                 //Creamos un archivo .txt simulando una base de datos y luego escribimos en el 3 atributos
                 StreamWriter dbtxt = new StreamWriter("listPhoneandAddress.txt", true);
                 dbtxt.WriteLine(ListRegionNumbers.Text + ";" + PlusContactnumber.Text + ";" + PlusAddress.Text);
                 dbtxt.Close();
                 //leemos los datos de nuestro archivo txt creado anteriormente
                 StreamReader leertxt = new StreamReader("listPhoneandAddress.txt");
             }
             else
             {
                 MessageBox.Show("Datos Incorrectos");
             }


        }
    }
}
