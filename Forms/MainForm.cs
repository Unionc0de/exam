using exam.Data.exam.Data;
using exam.Models;

namespace exam
{
    public partial class MainForm : Form
    {
        private DataContext context;
        private User user;

        public MainForm(User user, DataContext context)
        {
            InitializeComponent();
            this.user = user;
            this.context = context;
        }

        //Изменение доступа
        private void changeAccess()
        {
            if (user.Role == User.RoleType.Admin)
            {
                //Показываем все, если пользователь админ эшнейн
                seachTextBox.Show();
                searchBtn.Show();
                manageOrders.Show();
                manageProduct.Show();
                sortByAsc.Show();
                sortByDesc.Show();
            }
            else if(user.Role == User.RoleType.Manager)
            {
                seachTextBox.Show();
                searchBtn.Show();
                manageOrders.Hide();
                manageProduct.Hide();
                sortByAsc.Show();
                sortByDesc.Show();
            }
            else
            {
                seachTextBox.Hide();
                searchBtn.Hide();
                manageOrders.Hide();
                manageProduct.Hide();
                sortByAsc.Hide();
                sortByDesc.Hide();
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await context.readProductDb();
            changeAccess();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
