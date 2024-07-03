using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Мособлгаз
{
    public partial class Otchet : Form
    {
        private bool canAdd;
        private bool canView;
        public Otchet()
        {
            InitializeComponent();
            DannoOtchet();
            canAdd = false;
            canView = false;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=""Мособлгаз"";Integrated Security=True;");
        SqlCommand cmd;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CanNavigateToForm())
            {          
                Otchet form = new Otchet();
                form.Show();
            }
            else
            {        
                MessageBox.Show("У вас нет разрешений для доступа к этой форме.", "Ошибка доступа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DannoOtchet();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void DannoOtchet()
        {
            try
            {
                Con.Open();
                string Query = @"
                SELECT id_заявки, ФИО, отдел, должность, тип_заявки, описание, дата_с, дата_по, статус
                FROM Заявки
                WHERE статус IN ('одобрен', 'не одобрен', 'готов')";
                if (!string.IsNullOrEmpty(ТипЗаявкиCb.Text))
                {
                    Query += " AND тип_заявки = @тип_заявки ";
                }
                cmd = new SqlCommand(Query, Con);
                if (!string.IsNullOrEmpty(ТипЗаявкиCb.Text))
                {
                    cmd.Parameters.AddWithValue("@тип_заявки", ТипЗаявкиCb.Text);
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


        private void button5_Click(object sender, EventArgs e)
        {       
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF файлы (*.pdf)|*.pdf";
                saveFileDialog.Title = "Сохранить в PDF";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Document document = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));               
                        document.Open();
                        BaseFont bf = BaseFont.CreateFont("c:/windows/fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);
                        PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                        table.WidthPercentage = 100;
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(cell);
                        }
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {                               
                                string cellValue = cell.Value != null ? Convert.ToString(cell.Value) : string.Empty;

                                // Добавляем значение в ячейку таблицы
                                table.AddCell(new Phrase(cellValue, font));
                            }
                        }
                        document.Add(table);
                        document.Close();
                        MessageBox.Show("Данные успешно экспортированы в PDF!", "Экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при экспорте данных в PDF: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            public DataTable queryReturnData(string query, DataTable dataTable)
        {
            try
            {
                Con.Open();
                SqlDataAdapter SDA = new SqlDataAdapter(query, Con);
                SDA.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return dataTable;
        }
    
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
