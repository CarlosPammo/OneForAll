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
using PhoneBookModel;
using PhoneBookController;
using System.IO;
using System.Data;

namespace ProyectPhoneBook
{
    /// <summary>
    /// Lógica de interacción para ViewDiary.xaml
    /// </summary>
    public partial class ViewDiary : Window
    {
        public List<Contact> contacts {get; set;}

        public ViewDiary()
        {
            /*contacts = new List<Contact>();
            NumbersandAddress = new List<ContactNumber>();
            
            diary= new Contact();
            Numbers = new ContactNumber();*/
            
            InitializeComponent();
        }

        private void View()
        {
            Crud c = new Crud();
            DbContacts.DataContext = c.ViewTable();
            DbContacts.Items.Refresh();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)DbContacts.SelectedItem;
            MainWindow editor = new MainWindow(selected);
            editor.OnAccept += EditContact;

            editor.Show();
        }

        private void EditContact(Contact contact)
        {
            DbContacts.Items.Refresh();
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MostrarData();
            MessageBox.Show("Datos Cargados");
            View();
        }

       /* public void MostrarData()
        {
            StreamReader database = new StreamReader("list.txt");
            while (!(database.EndOfStream))
            {

                string texto = database.ReadLine();
                string[] leer = texto.Split(new char[] { ';' });
                diary._TypeContact = leer[0];
                diary._Name = leer[1];
                diary._Lastname = leer[2];
                diary.Birthday = leer[3];
                diary._Email = leer[4];
                diary._Fax = leer[5];

                contacts.Add(diary);
                DbContacts.DataContext = contacts;
                DbContacts.Items.Refresh();
            }
        }
        

        public void MostrarDataNumbers()
        {
            StreamReader databaseNumbers = new StreamReader("C:/Users/Angel/Desktop/listPhoneandAddress.txt");
            while (!databaseNumbers.EndOfStream)
            {
                string textNumbers = databaseNumbers.ReadLine();
                string[] leernew = textNumbers.Split(new char[] { ';' });
                Numbers._NumberRegion = leernew[0];
                Numbers._ContactNumber = leernew[1];
                Numbers._Address = leernew[2];

                NumbersandAddress.Add(Numbers);

            }    
        }

        public void Show_Date()
        {

            MostrarDataNumbers();

           /* NumbersandAddress.Where(c. el id.Contains(sea igual al codigo del contacto));
                );*/
            //actualizamos datagrid.items.refresh();
   //         ListContactsNumbers listanumbers = new ListContactsNumbers(NumbersandAddress);
    //        listanumbers.Show();
   //     }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_RbName.IsChecked == true  && txtsearch.Text != "")
            {
                MessageBox.Show("tienes el "+ _RbName.Content+" activado y tienes text "+ txtsearch.Text );
            }
                else if(_RbLastname.IsChecked ==true && txtsearch.Text !="")
            {
                MessageBox.Show("tienes el " + _RbLastname.Content + " activado y tienes text " + txtsearch.Text);
            }
                else if (_RbPhoneNumber.IsChecked == true && txtsearch.Text != "")
            {
                MessageBox.Show("tienes el " + _RbPhoneNumber.Content + " activado y tienes text " + txtsearch.Text);
            }
            else
            {
                MessageBox.Show("tu texto esta vacio");
            }

        }

        public void Search(string OptionTosearch,string text)
        {
            /* Realizar unas consulta para filtrar datos seguin a la opcion y buscar un texto */
        }
       
    }
}
