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
using System.Data.OleDb;
using ClassLibrary1;
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
            //Instanciamos la clase ValidTextsMethods de el proyecto PhoneBookController
            ValidTextsMethods c = new ValidTextsMethods();

            //Usamos el metodo Isvalid que verifica si el campo de texto NumeroContacto es un texto numerico valido
            if (c.IsValid(_NumeroContacto.Text))
            {
               /* StreamWriter dbtxt = new StreamWriter("list.txt", true);
                dbtxt.WriteLine(boxTypeContact.Text + ";" + _Name.Text + ";" + _LastName.Text + ";" + _Birtday.Text + ";" + _Email.Text + ";" + _Fax.Text + ";" + _NumeroContacto.Text + ";" + _Address.Text);
                dbtxt.Close();
                StreamWriter dbtxtnumbers = new StreamWriter("listPhoneandAddress.txt", true);
                dbtxtnumbers.WriteLine(ListRegionNumbers.Text + ";" + _NumeroContacto.Text + ";" + _Address.Text);
                dbtxtnumbers.Close();

                MessageBox.Show("Datos Guardados");*/

                /*Realizamos conexion a la base de datos en acces*/
                System.Data.OleDb.OleDbConnection conn = new
                System.Data.OleDb.OleDbConnection();
                // TODO: Modify the connection string and include any
                // additional required properties for your database.
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                    @"Data source= bdcontacts.accdb;Persist Security Info=False";
                try
                {
                    conn.Open();
                    // Insert code to process data.
                    MessageBox.Show("Coneccion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to data source");
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
           
            

            
           
        }

       


        private void NumberContacts_Click(object sender, RoutedEventArgs e)
        {
            //instanciamos la vista ViewDiary y lo mostramos con el boton
            ViewDiary view = new ViewDiary();
            view.Show();
        }

        private void btnNumbers_Click(object sender, RoutedEventArgs e)
        {
            //Instanciamos la vista RegisterNumber y lo mostramos con este boton
            ViewRegisterNumber v = new ViewRegisterNumber();
            v.Show();

        }

        

       

       
    }
}
