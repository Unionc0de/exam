//using exam.Models;
//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Text;

//public string connectionString = "Server=(localdb)\\mssqllocaldb;Database=adonetdb;Trusted_Connection=True;";

//async Task ReadFromDb()
//{
//    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
//    {
//        sqlConnection.OpenAsync();
//        SqlCommand sqlCommand = sqlConnection.CreateCommand();
//        sqlCommand.CommandText = "текст вашего запроса";
//        sqlCommand.Connection = sqlConnection;
//        sqlCommand.ExecuteNonQueryAsync(); //отправка запроса без чтения обратных данных
//        sqlCommand.ExecuteReaderAsync(); //отправка запроса с последующим чтением результата
//        using (SqlDataReader reader = await sqlCommand.ExecuteReaderAsync())
//        {
//            if (reader.HasRows) //проверка наличия строчек
//            {
//                while (await reader.ReadAsync()) //чтение результата построчно
//                {
//                    string name = reader.GetString(1); //В круглых скобках - номер столбца который читаем
//                    string category = reader.GetString(2);
//                    double price = reader.GetDouble(3);
//                    string description;

//                    Product a = new Product(name);
//                }
//            }
//        }
//    }
//}