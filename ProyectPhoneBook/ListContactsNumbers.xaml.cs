using PhoneBookModel;
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


namespace ProyectPhoneBook
{
    /// <summary>
    /// Lógica de interacción para ListContactsNumbers.xaml
    /// </summary>
    public partial class ListContactsNumbers : Window
    {
        private List<ContactNumber> _Contact { get; set; }
        public delegate void GetContact(Contact contact);
        public event GetContact click;

        public ListContactsNumbers(List<ContactNumber> listNumbers)
        {
            _Contact = new List< ContactNumber>();
            _Contact = listNumbers;
            InitializeComponent();
        }

        private void ListN_Activated(object sender, EventArgs e)
        {
            BDlistNumbers.DataContext = _Contact;
        }

       
        
    }
}
