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
            InitializeComponent();
        }

        private void View()
        {
            Crud c = new Crud();
            DbContacts.DataContext = c.ViewTable();
            DbContacts.Items.Refresh();
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
