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
    using System.Data;
    using System.Linq.Expressions;
    using System.Text;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    namespace exam.Data
    {
        public class DataContext
        {
            public List<Product> Products { get; set; }
            public List<User> Users { get; set; }
            public List<Order> Orders { get; set; }
            
            private string connectionString;
            SqlConnection connection;
            
            public DataContext()
            {
                Products = new List<Product>();
                Users = new List<User>();
                Orders = new List<Order>();
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Пользователь\\Desktop\\C#\\exam\\Database\\Database.mdf;Integrated Security=True";
            }

            public async Task connect()
            {
                try
                {
                    // Открываем подключение
                    connection = new SqlConnection(connectionString);
                    await connection.OpenAsync();
                    Console.WriteLine("Подключение открыто");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            public async Task close()
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

            //Поиск пользователя по ID
            public User searchUserById(string id)
            {
                for(int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].ID == Guid.Parse(id))
                    {
                        return Users[i];
                    }
                }
                return null;
            }

            //Поиск продукта по ID
            public Product searchProductById(string id)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ID == Guid.Parse(id))
                    {
                        return Products[i];
                    }
                }
                return null;
            }
            //Получение пользователей из БД
            public async Task readUserDB()
            {
                using (SqlConnection connection = new SqlConnection(connectionString) ) {
                    await connection.OpenAsync();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Users";
                    cmd.Connection = connection;

                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync()) {
                                Guid id = Guid.Parse(reader.GetString(0));
                                String username = reader.GetString(1);
                                String password = reader.GetString(2);
                                String role = reader.GetString(3);

                                User user = new User(id, username, password, (User.RoleType)Enum.Parse(typeof(User.RoleType),role));//ЗАПОМНИТЬ
                                Users.Add(user);
                            }
                        }
                    }
                    
                }
            }
            //Добавление пользователя в БД
            public async Task addUserDb(User user)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"INSERT INTO Users(Id,userName,userPassword,userRole) VALUES('{user.ID.ToString()}','{user.UserName}','{user.Password}','{user.Role.ToString()}')";
                    MessageBox.Show($" VALUES('{user.ID.ToString()}','{user.UserName}','{user.Password}','{user.Role.ToString()}'");
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            //Получение продуктов из БД
            public async Task readProductDb()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Products";
                    cmd.Connection = connection;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                Guid id = Guid.Parse(reader.GetString(0));
                                String name = reader.GetString(1);
                                String description = reader.GetString(2);
                                String category = reader.GetString(3);
                                float price = reader.GetFloat(4);

                                Product product = new Product(id, name, description, category, price);
                                Products.Add(product);
                            } 
                        }
                    }

                }
            }

            //Добавление продукта в БД
            public async Task addProductDb(Product product)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"INSERT INTO Products(Id,Name,Description,Category,Price) VALUES ('{product.ID.ToString()}','{product.Name}','{product.Description}','{product.Category}','{product.Price}')";
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            //Получение заказов из БД
            public async Task readOrderDb()
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Orders";
                    cmd.Connection = connection;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (await reader.ReadAsync())
                            {
                                Guid id = Guid.Parse(reader.GetString(0));
                                User user = searchUserById(reader.GetString(1));
                                Product product = searchProductById(reader.GetString(2));

                                Order newOrder = new Order(id, user, product);
                                Orders.Add(newOrder);
                            }
                        }
                    }

                }
            }
            //Добавление заказа в бд
            public async Task addOrderDb(Order order)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"INSERT INTO Orders(Id,UserId,ProductId) VALUES('{order.Id.ToString()}','{order.User.ID.ToString()}','{order.Product.ID.ToString()}')";
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }

}

