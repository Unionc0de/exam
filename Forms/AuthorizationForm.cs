using exam.Data.exam.Data;
using exam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace exam.Forms
{
    public partial class AuthorizationForm : Form
    {
        private DataContext context;

        public AuthorizationForm()
        {
            InitializeComponent();
            context = new DataContext();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Логика регистрации
        private async void button_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (userName == "" || password == "") 
            {
                MessageBox.Show("Username or password can`t be empty!");
                return;
            }
            
            User.RoleType role = User.RoleType.User;
            //Проверка на существование такого пользователя
            bool flag = false;
            for (int i = 0; i < context.Users.Count; i++)
            {
                if (context.Users[i].UserName == userName)
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                //Создание пользователя и отправка в бд
                User newUser = new User(userName, password, role);
                context.Users.Add(newUser);
                await context.addUserDb(newUser);
                //открытие главного экрана
                MainForm frm = new MainForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show($"User with username {userName} already exists!");
                return;
            }
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            if (userName == "" || password == "")
            {
                MessageBox.Show("Username or password can`t be empty!");
                return;
            }
            bool flag = false;
            for (int i = 0; i < context.Users.Count; i++)
            {
                if (context.Users[i].UserName == userName && context.Users[i].Password == password)
                {
                    flag = true;
                    break;
                }
            }
            //Доделять
            if (!flag)
            {

            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                return;
            }
        }
    }
}
