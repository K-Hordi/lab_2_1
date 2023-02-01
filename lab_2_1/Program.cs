using System;
using System.Data;
using System.Data.SqlClient;
namespace lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KO6M9Q1\\ARTSYLPRODUCTS10;Initial Catalog=UniversityDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



            Console.WriteLine("Select an option from the list below");
            Console.WriteLine("0 - Get all tables");
            Console.WriteLine("1 - Select Table");
            Console.WriteLine("2 - Insert Value to Table [SUBJECT]");
            int swt = Convert.ToInt32(Console.ReadLine());
            switch (swt)
            {
                case 0:
                    {
                        Selects sel = new Selects(conn);
                        sel.GetTables();
                        break;
                    }
                case 1:
                    {
                        Selects sel = new Selects(conn);
                        Console.WriteLine("Enter tablename:");
                        string tbln = Console.ReadLine();
                        sel.SelectAllItems(tbln);
                        break;
                    }
                case 2:
                    {
                        Insert ins = new Insert(conn);
                        Console.WriteLine("Enter tablename:");
                        string val = Console.ReadLine();
                        ins.InsertSubject(val);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Close Program");
                        break;
                    }
            }

        }

    }
}