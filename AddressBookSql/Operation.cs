using System.Data.SqlClient;

namespace AddressBookSql
{
    internal class Operation
    {
        public static Random R = new Random();
        private SqlConnection con;
        public void CreateDataBase()
        {
            con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master; integrated Security= true");
            try
            {
                string query = "Create Database AddressBook";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created ");
            }
            finally
            {
                con.Close();
            }
        }
        private void Connection()
        {
            string connectionstr = "data source = (localdb)\\MSSQLLocalDB; initial catalog = AddressBook; integrated security = true";
            con = new SqlConnection(connectionstr);
        }
        public void CreateTable()
        {
            try
            {
                Connection();
                string query = "create Table address_book(Id int primary key identity(1,1),FirstName varchar(max) not null,LastNames varchar(max) not null,Address varchar(max) not null,City varchar(max) not null,State varchar(max) not null,Zip varchar(max) not null,PhoneNumber varchar(max) not null,Email varchar(max) not null);";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Table is not created ");
            }
            finally
            {
                con.Close();
            }
        }
    }
}