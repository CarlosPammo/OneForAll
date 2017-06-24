using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using PhoneBookModel;
using System.Data;

namespace PhoneBookController
{
    public class Crud 
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {   
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Arodri\Desktop\Git\OneForAll\PhoneBookController\bin\Debug\DBcontact.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Crud()
        {
            ConnectTo();
        }
        
        public void Insert(Contact c)
        {
            try
            {   
                command.CommandText = "INSERT INTO CONTACT_INFORMATION(ContactName, ContactLastName) VALUES('"+ c._Name+"','"+c._Lastname+"')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Contact> ViewTable()
        {
            try
            {
                List<Contact> contacts_list = new List<Contact>();
                command.CommandText = "SELECT * FROM CONTACT_INFORMATION";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Contact c = new Contact();
                    //c.number = Convert.ToInt32(["number"].ToString());
                    c._Name = reader["ContactName"].ToString();
                    c._Lastname = reader["ContactLastName"].ToString();
                    contacts_list.Add(c);
                }
                return contacts_list;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void Update(Contact c, Contact n)
        {
            try
            {
                command.CommandText = "UPDATE CONTACT_INFORMATION SET ContactName = '"+ n._Name + "',ContactLastName= '" + c._Lastname + "'";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
