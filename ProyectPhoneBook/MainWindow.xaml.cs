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
using PhoneBookController;
using PhoneBookModel;

namespace ProyectPhoneBook
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Crud crud = new Crud();
        private Contact Contact { get; set; }
        public delegate void GetContact(Contact contact);
        public event GetContact OnAccept;

        public MainWindow()
        {
            InitializeComponent();
            Contact = new Contact();
        }

        //Editar
        public MainWindow(Contact contact) : this()
        {
            Contact oldContact = new Contact();
            ViewDiary vd = new ViewDiary();

            oldContact = vd.DbContacts.SelectedItem as Contact;

            Contact._Name = _Name.Text;
            Contact._Lastname = _LastName.Text;
            Contact = contact;

            crud.Update(oldContact, contact);
            OnAccept(Contact);

            MessageBox.Show("contact listo para update");
        }

        //Add contact
        private void BtnOthers_Click(object sender, RoutedEventArgs e)
        {

            /*StreamWriter dbtxt = new StreamWriter("list.txt", true);
            dbtxt.WriteLine( boxTypeContact.Text + ";" + _Name.Text + ";" + _LastName.Text + ";" + _Birtday.Text + ";" + _Email.Text + ";" + _Fax.Text + ";" + _NumeroContacto.Text+";"+_Address.Text);
            dbtxt.Close();
            StreamWriter dbtxtnumbers = new StreamWriter("listPhoneandAddress.txt", true);
            dbtxtnumbers.WriteLine(ListRegionNumbers.Text+";"+_NumeroContacto.Text + ";" + _Address.Text );
            dbtxtnumbers.Close();*/
            //MessageBox.Show("Datos Guardados");
            
            Contact._Name = _Name.Text;
            Contact._Lastname = _LastName.Text;
            /*contact.Birthday = _Birtday.Text;
            contact._Email = _Email.Text;
            contact._Fax = _Fax.Text;*/

            crud.Insert(Contact);
            MessageBox.Show("create contact");
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
