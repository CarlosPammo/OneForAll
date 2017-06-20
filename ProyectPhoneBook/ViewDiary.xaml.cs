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
using System.IO;

namespace ProyectPhoneBook
{
    /// <summary>
    /// Lógica de interacción para ViewDiary.xaml
    /// </summary>
    public partial class ViewDiary : Window
    {
       public List<Diary> contacts {get; set;}
       public Diary diary{get;set;}
        public ViewDiary()
        {
            contacts = new List<Diary>();/* { 
            new Diary
            {
                _ContactNumber="123123123",
                _Email="ejemplo@.com",
                _Address="AV. B",
                _Fax="123123123",
            
            },
            };*/
            InitializeComponent();

            DbContacts.DataContext = contacts;
            DbContacts.Items.Refresh();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x=0;

            StreamReader database = new StreamReader("C:/Users/Angel/Desktop/list.txt");
            while (!(database.EndOfStream) )
            {
                diary= new Diary();
                string texto = database.ReadLine();
                string [] leer = texto.Split(new char[] {';'});

                diary._ContactNumber=leer[0];
                diary._Email=leer[1];
                diary._Fax=leer[2];
                diary._Address=leer[3];

                contacts.Add(diary);
                DbContacts.DataContext=contacts;
                DbContacts.Items.Refresh();
            }

           

        }
        
        

       
    }
}
