using exam.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace exam.Data
{
    using Microsoft.Data.SqlClient;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;

    namespace exam.Data
    {
        public class DataContext
        {
            public List<Product> Products { get; set; }
            public List<User> Users { get; set; }
            
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
            SqlConnection connection;
            
            async Task connect()
            {
                try
                {
                    // Открываем подключение
                    await connection.OpenAsync();
                    connection = new SqlConnection(connectionString);
                    Console.WriteLine("Подключение открыто");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            async Task close()
            {
                try
                {
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            async Task readUserDB()
            {
                using (var cmd = new SqlCommand(connectionString)) {
                   
                }
            }

        }
    }

}
