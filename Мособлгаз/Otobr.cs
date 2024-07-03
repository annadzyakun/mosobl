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
    public partial class Otobr : Form
    {
        private bool canAdd;
        private bool canView;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Otobr()
        {
            InitializeComponent();
            Danno();
            canAdd = false;
            canView = false;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;");
        public void SetCanAdd(bool value)
        {
            canAdd = value;
        }
        public void SetCanView(bool value)
        {
            canView = value;

        }
        private void Danno()
        {
            {
                try
                {
                    Con.Open();
                    string query = @" SELECT id_заявки, ФИО, отдел, должность, тип_заявки, описание, дата_с, дата_по, файл, статус 
                                      FROM Заявки
                                      WHERE 1=1 ";
                    if (!string.IsNullOrEmpty(ТипЗаявкиCb.Text))
                    {
                        query += " AND тип_заявки = @тип_заявки ";
                    }
                    if (!string.IsNullOrEmpty(ФИОtxt.Text))
                    {
                        query += " AND ФИО LIKE @ФИО ";
                    }
                    cmd = new SqlCommand(query, Con);
                    if (!string.IsNullOrEmpty(ТипЗаявкиCb.Text))
                    {
                        cmd.Parameters.AddWithValue("@тип_заявки", ТипЗаявкиCb.Text);
                    }
                    if (!string.IsNullOrEmpty(ФИОtxt.Text))
                    {
                        cmd.Parameters.AddWithValue("@ФИО", "%" + ФИОtxt.Text + "%");
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("id_заявки"))
                    {
                        dataGridView1.Columns["id_заявки"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

            private void button5_Click(object sender, EventArgs e)
        {
            Danno();
        }
        private void UpdateTaskStatus(int taskId, string newStatus)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;"))
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE Заявки SET статус = @статус WHERE id_заявки = @id_заявки", con);
                    cmd.Parameters.AddWithValue("@id_заявки", taskId);
                    cmd.Parameters.AddWithValue("@статус", newStatus);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса задания: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите задание для изменения статуса!");
                return;
            }
            try
            {
                int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string newStatus = СтатусCb.SelectedItem.ToString();
                UpdateTaskStatus(taskId, newStatus);
                MessageBox.Show("Статус изменен!");
                Danno();
                СтатусCb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса: " + ex.Message);
            }
        }
        private void UpdateAnswer(int taskId, string newAnswer)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Ответы SET ответ = @ответ WHERE id_задания = @id_задания", con);
                cmd.Parameters.AddWithValue("@id_задания", taskId);
                cmd.Parameters.AddWithValue("@ответ", newAnswer);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении ответа: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && e.ColumnIndex == 4)
            {
                int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string newAnswer = dataGridView1.SelectedRows[0].Cells[e.ColumnIndex].Value.ToString();
                UpdateAnswer(taskId, newAnswer);
                Danno();
            }
        }
        public bool CanNavigateToForm()
        {
            // Проверка есть ли у пользователя хотя бы одно разрешение
            if (canAdd || canView)
            {
                return true; // Есть разрешение, можно переходить на форму
            }
            else
            {
                return false; // Нет разрешений, переход на форму не разрешен
            }
        }
        private void ТипЗаявкиCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Avtoriz avtorization = new Avtoriz();
            avtorization.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
           Otobr otobr = new Otobr();
            otobr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CanNavigateToForm())
            {
                // Создаем и отображаем форму zakaz
                Otchet form = new Otchet();
                form.Show();
            }
            else
            {
                // Отображаем сообщение об ошибке
                MessageBox.Show("У вас нет разрешений для доступа к этой форме.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
        private void Otobr_Load(object sender, EventArgs e)
        {

        }
    }
}

