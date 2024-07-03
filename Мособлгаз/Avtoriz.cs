using System.Data.SqlClient;

namespace Мособлгаз
{
    
    public partial class Avtoriz : Form
    {
        private string connectionString = @"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;";
        public Avtoriz()
        {
            InitializeComponent();
        }
        public struct User
        {
            public string Login;
            public string Role;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text; 
            User? user = AuthenticateUser(login, password);
            if (user.HasValue)
            {
                OpenFormBasedOnRole(user.Value.Role);
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }
        private User? AuthenticateUser(string login, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT РольId FROM Пользователи WHERE Логин = @login AND Пароль = @password", con))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    object roleObj = cmd.ExecuteScalar();
                    if (roleObj != null)
                    {                    
                        using (SqlCommand roleCmd = new SqlCommand("SELECT Название FROM Роли WHERE Id = @roleId", con))
                        {
                            roleCmd.Parameters.AddWithValue("@roleId", roleObj);
                            string roleName = roleCmd.ExecuteScalar().ToString();
                            return new User { Login = login, Role = roleName };
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        private void OpenFormBasedOnRole(string role)
        {
            zakaz formZakaz = new zakaz();
            Otobr formOtobr = new Otobr();
            Otchet formOtchet = new Otchet();
            // начальные разрешения
            bool canAddZakaz = false;
            bool canViewZakaz = false;
            bool canViewOtobr = false;
            switch (role)
            {
                case "Персонал":
                    // Персонал имеет полный доступ ко всем формам
                    canAddZakaz = true;
                    canViewZakaz = true;
                    canViewOtobr = true;
                    break;
                case "IT":
                case "Юридический":
                case "Бухгалтерия":
                case "Газовик":
                case "Аудит":
                case "Финансы":
                    // Остальные роли имеют разрешение на добавление в zakaz и просмотр в otobr
                    canAddZakaz = true;
                    canViewZakaz = false; 
                    canViewOtobr = true;  
                    break;
                default:
                    MessageBox.Show("Неизвестная роль.");
                    return;
            }
            //  разрешения для формы zakaz
            formZakaz.SetCanAdd(canAddZakaz);
            formZakaz.SetCanView(canViewZakaz);

            formOtobr.SetCanView(canViewOtobr);
            if (canAddZakaz || canViewZakaz)
            {
                formZakaz.ShowDialog();
            }
            if (canViewOtobr)
            {
                formOtobr.ShowDialog();
            }
            if (role == "Персонал")
            {
                formOtchet.SetCanAdd(true);
                formOtchet.SetCanView(true);
                formOtchet.ShowDialog();
            }
            else
            {
                // Если роль не "Персонал", доступ к форме otchet запрещён
                formOtchet.SetCanAdd(false);
                formOtchet.SetCanView(false);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }


    }
}
