namespace Мособлгаз
{
    partial class zakaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zakaz));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label9 = new Label();
            button5 = new Button();
            ПриложениеBtn = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            ТекущаяДолжностьtxt = new TextBox();
            ТипЗаявкиCb = new ComboBox();
            Отделtxt = new TextBox();
            ОписаниеЗаявкиtxt = new TextBox();
            ФИОtxt = new TextBox();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 74);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(226, 22);
            label3.Name = "label3";
            label3.Size = new Size(260, 31);
            label3.TabIndex = 20;
            label3.Text = "ДОБАВЛЕНИЕ ЗАЯВКИ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(ПриложениеBtn);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(ТекущаяДолжностьtxt);
            panel4.Controls.Add(ТипЗаявкиCb);
            panel4.Controls.Add(Отделtxt);
            panel4.Controls.Add(ОписаниеЗаявкиtxt);
            panel4.Controls.Add(ФИОtxt);
            panel4.Location = new Point(-1, 467);
            panel4.Name = "panel4";
            panel4.Size = new Size(724, 177);
            panel4.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(280, 15);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 22;
            label9.Text = "оформление заявки";
            label9.UseMnemonic = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.White;
            button5.Location = new Point(602, 137);
            button5.Name = "button5";
            button5.Size = new Size(109, 33);
            button5.TabIndex = 15;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ПриложениеBtn
            // 
            ПриложениеBtn.Location = new Point(428, 115);
            ПриложениеBtn.Name = "ПриложениеBtn";
            ПриложениеBtn.Size = new Size(117, 29);
            ПриложениеBtn.TabIndex = 15;
            ПриложениеBtn.Text = "Приложение:";
            ПриложениеBtn.UseVisualStyleBackColor = true;
            ПриложениеBtn.Click += ПриложениеBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(290, 119);
            label8.Name = "label8";
            label8.Size = new Size(30, 20);
            label8.TabIndex = 13;
            label8.Text = "по:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 114);
            label7.Name = "label7";
            label7.Size = new Size(19, 20);
            label7.TabIndex = 12;
            label7.Text = "с:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(525, 47);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 11;
            label6.Text = "Описание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 48);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 10;
            label5.Text = "Тип заявки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 48);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 9;
            label4.Text = "Должность";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 48);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Отдел";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 48);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 7;
            label1.Text = "ФИО";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(326, 114);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(77, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(77, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // ТекущаяДолжностьtxt
            // 
            ТекущаяДолжностьtxt.Location = new Point(293, 71);
            ТекущаяДолжностьtxt.Name = "ТекущаяДолжностьtxt";
            ТекущаяДолжностьtxt.Size = new Size(93, 27);
            ТекущаяДолжностьtxt.TabIndex = 4;
            // 
            // ТипЗаявкиCb
            // 
            ТипЗаявкиCb.DropDownStyle = ComboBoxStyle.DropDownList;
            ТипЗаявкиCb.FormattingEnabled = true;
            ТипЗаявкиCb.Items.AddRange(new object[] { "отпуск", "больничный лист", "командировка", "бонификация", "повышение заработной платы", "премия" });
            ТипЗаявкиCb.Location = new Point(392, 70);
            ТипЗаявкиCb.Name = "ТипЗаявкиCb";
            ТипЗаявкиCb.Size = new Size(121, 28);
            ТипЗаявкиCb.TabIndex = 3;
            ТипЗаявкиCb.SelectedIndexChanged += ТипЗаявкиCb_SelectedIndexChanged;
            // 
            // Отделtxt
            // 
            Отделtxt.Location = new Point(191, 71);
            Отделtxt.Name = "Отделtxt";
            Отделtxt.Size = new Size(93, 27);
            Отделtxt.TabIndex = 2;
            // 
            // ОписаниеЗаявкиtxt
            // 
            ОписаниеЗаявкиtxt.Location = new Point(519, 70);
            ОписаниеЗаявкиtxt.Name = "ОписаниеЗаявкиtxt";
            ОписаниеЗаявкиtxt.Size = new Size(99, 27);
            ОписаниеЗаявкиtxt.TabIndex = 1;
            // 
            // ФИОtxt
            // 
            ФИОtxt.Location = new Point(92, 71);
            ФИОtxt.Name = "ФИОtxt";
            ФИОtxt.Size = new Size(93, 27);
            ФИОtxt.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-1, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 51);
            panel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.GhostWhite;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(617, 7);
            button4.Name = "button4";
            button4.Size = new Size(83, 33);
            button4.TabIndex = 14;
            button4.Text = " Выход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(428, 7);
            button3.Name = "button3";
            button3.Size = new Size(109, 33);
            button3.TabIndex = 13;
            button3.Text = "отчет";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(280, 7);
            button2.Name = "button2";
            button2.Size = new Size(109, 33);
            button2.TabIndex = 12;
            button2.Text = "данные";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(131, 7);
            button1.Name = "button1";
            button1.Size = new Size(109, 33);
            button1.TabIndex = 11;
            button1.Text = "заявка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(-1, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(721, 390);
            panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(715, 384);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // zakaz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 693);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "zakaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "zakaz";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Panel panel4;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private TextBox ОписаниеЗаявкиtxt;
        private TextBox ФИОtxt;
        private ComboBox ТипЗаявкиCb;
        private TextBox Отделtxt;
        private TextBox ТекущаяДолжностьtxt;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button ПриложениеBtn;
        private Button button5;
        private Label label9;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
    }
}