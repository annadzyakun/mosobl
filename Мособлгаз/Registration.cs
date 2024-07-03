using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мособлгаз
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            // Заполнение ComboBox доступными ролями
            comboBox1.DataSource = GetRoles(); 
            comboBox1.DisplayMember = "Название";
            comboBox1.ValueMember = "Id";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Avtoriz avtorization = new Avtoriz();
            avtorization.Show();
            this.Hide();
        }
        private bool IsPasswordValid(string password)
        {
            // Проверяем минимальную длину
            if (password.Length < 6)
                return false;
            // Проверяем наличие прописной буквы
            if (!password.Any(char.IsUpper))
                return false;
            // Проверяем наличие цифры
            if (!password.Any(char.IsDigit))
                return false;
            // Проверяем наличие специального символа
            char[] specialChars = new char[] { '!', '@', '#', '$', '%', '^' };
            if (!password.Any(p => specialChars.Contains(p)))
                return false;
                return true;
        }
        private int GetRoleIdByName(string roleName, SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Роли WHERE Название = @roleName", con))
            {
                cmd.Parameters.AddWithValue("@roleName", roleName);
                return (int)cmd.ExecuteScalar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            int roleId = Convert.ToInt32(comboBox1.SelectedValue);
            RegisterUser(login, password, roleId);
        }
        private DataTable GetRoles()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Название FROM Роли", con))
                {
                    DataTable rolesTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(rolesTable);
                    return rolesTable;
                }
            }
        }
        private void RegisterUser(string login, string password, int roleId)
        {
            // Проверяем пароль
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Пароль не соответствует требованиям безопасности.");
                return;
            }
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;"))
            {
                con.Open();
                using (SqlCommand checkUserExistsCommand = new SqlCommand("SELECT COUNT(*) FROM Пользователи WHERE Логин = @login", con))
                {
                    checkUserExistsCommand.Parameters.AddWithValue("@login", login);
                    int userExists = (int)checkUserExistsCommand.ExecuteScalar();
                    if (userExists > 0)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.");
                        return;
                    }
                }
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Пользователи (Логин, Пароль, РольId) VALUES (@login, @password, @roleId)", con))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password); 
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Пользователь успешно зарегистрирован.");
        }
    }
}
