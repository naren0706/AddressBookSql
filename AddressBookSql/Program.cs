using System.Collections.Generic;

namespace AddressBookSql
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.CreateTable();
        }
    }
}