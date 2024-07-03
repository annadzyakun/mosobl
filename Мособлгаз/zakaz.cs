using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;



namespace Мособлгаз
{
    public partial class zakaz : Form
    {
        private bool canAdd;
        private bool canView;
        public zakaz()
        {
            InitializeComponent();          
            Danno();
            canAdd = false;
            canView = false;
        }
        public void SetCanAdd(bool value)
        {
            canAdd = value; 
        }
        public void SetCanView(bool value)
        {
            canView = value;
            
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (CanNavigateToForm())
            {
                zakaz form = new zakaz();
                form.Show();
            }
            else
            {
                MessageBox.Show("У вас нет разрешений для доступа к этой форме.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;");
        SqlCommand cmd;
        private void button4_Click(object sender, EventArgs e)
        {
            Avtoriz avtorization = new Avtoriz();
            avtorization.Show();
            this.Hide();
        }
        private void Danno()
        {
            try
            {            
                using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;"))
                {            
                    string query = @"
                    SELECT id_заявки, ФИО, отдел, должность, тип_заявки, описание, дата_с, дата_по, файл,статус
                    FROM Заявки";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);  
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns.Contains("id_заявки"))
                        {
                            dataGridView1.Columns["id_заявки"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }
        private void ТипЗаявкиCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ТипЗаявкиCb.SelectedIndex >= 0)
            {
                string selectedValue = ТипЗаявкиCb.SelectedItem.ToString();
                // Видимость TextBox в зависимости от значения.
                if (selectedValue == "отпуск" || 
                    selectedValue == "больничный лист" ||
                    selectedValue == "командировка")
                {
                    dateTimePicker2.Visible = true;
                    dateTimePicker1.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    ПриложениеBtn.Visible = true;
                }
                else
                {
                    dateTimePicker2.Visible = false;
                    dateTimePicker1.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    ПриложениеBtn.Visible = false;
                }
            }
        }
      
        private string filePath;
        private void ПриложениеBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {             
                String sFileName = openFileDialog1.FileName;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение обязательных полей
            if (string.IsNullOrEmpty(ФИОtxt.Text) ||
                string.IsNullOrEmpty(Отделtxt.Text) ||
                string.IsNullOrEmpty(ТекущаяДолжностьtxt.Text) ||
                ТипЗаявкиCb.SelectedIndex == -1 ||
                string.IsNullOrEmpty(ОписаниеЗаявкиtxt.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }
            string selectedType = ТипЗаявкиCb.SelectedItem.ToString();
            if (dateTimePicker1.Visible && dateTimePicker2.Visible)
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("Дата начала не может быть позже даты окончания!");
                    return;
                }
            }
            using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;"))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Заявки (ФИО, отдел, должность, тип_заявки, описание, дата_с, дата_по, файл) " +
                "VALUES (@ФИО, @отдел, @Должность, @тип_заявки, @описание, @дата_с, @дата_по, @файл)", connection))
            {
                cmd.Parameters.Add(new SqlParameter("@ФИО", SqlDbType.NVarChar) { Value = ФИОtxt.Text });
                cmd.Parameters.Add(new SqlParameter("@отдел", SqlDbType.NVarChar) { Value = Отделtxt.Text });
                cmd.Parameters.Add(new SqlParameter("@Должность", SqlDbType.NVarChar) { Value = ТекущаяДолжностьtxt.Text });
                cmd.Parameters.Add(new SqlParameter("@тип_заявки", SqlDbType.NVarChar) { Value = selectedType });
                cmd.Parameters.Add(new SqlParameter("@описание", SqlDbType.Text) { Value = ОписаниеЗаявкиtxt.Text });

                if (dateTimePicker1.Visible && dateTimePicker2.Visible)
                {
                    cmd.Parameters.Add(new SqlParameter("@дата_с", SqlDbType.DateTime) { Value = dateTimePicker1.Value });
                    cmd.Parameters.Add(new SqlParameter("@дата_по", SqlDbType.DateTime) { Value = dateTimePicker2.Value });
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@дата_с", SqlDbType.DateTime) { Value = DBNull.Value });
                    cmd.Parameters.Add(new SqlParameter("@дата_по", SqlDbType.DateTime) { Value = DBNull.Value });
                }
                pictureBox1.Image = null;

                // Добавление файла
                if (!string.IsNullOrEmpty(openFileDialog1.FileName) && File.Exists(openFileDialog1.FileName))
                {
                    using (FileStream fileStream = File.OpenRead(openFileDialog1.FileName))
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            fileStream.CopyTo(memoryStream);
                            byte[] imageBytes = memoryStream.ToArray();
                            SqlParameter fileParameter = new SqlParameter("@файл", SqlDbType.VarBinary, imageBytes.Length);
                            fileParameter.Value = imageBytes;
                            cmd.Parameters.Add(fileParameter);
                        }
                    }
                }
                else
                {
                    SqlParameter fileParameter = new SqlParameter("@файл", SqlDbType.VarBinary);
                    fileParameter.Value = DBNull.Value;
                    cmd.Parameters.Add(fileParameter);
                }   
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены");
                    openFileDialog1.FileName = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
                }
                ФИОtxt.Text = "";
                Отделtxt.Text = "";
                ТекущаяДолжностьtxt.Text = "";
                ТипЗаявкиCb.SelectedIndex = -1;
                ОписаниеЗаявкиtxt.Text = "";
                if (dateTimePicker1.Visible && dateTimePicker2.Visible)
                {
                    dateTimePicker1.Value = DateTime.Now;
                    dateTimePicker2.Value = DateTime.Now;
                }
                Danno();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        { 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Otchet = new Otchet();
            this.Hide();
            Otchet.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
