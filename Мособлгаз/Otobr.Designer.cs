namespace Мособлгаз
{
    partial class Otobr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otobr));
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            СтатусCb = new ComboBox();
            panel4 = new Panel();
            label4 = new Label();
            button5 = new Button();
            label2 = new Label();
            ФИОtxt = new TextBox();
            label1 = new Label();
            label5 = new Label();
            ТипЗаявкиCb = new ComboBox();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 74);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(210, 20);
            label3.Name = "label3";
            label3.Size = new Size(285, 31);
            label3.TabIndex = 20;
            label3.Text = "ОТОБРАЖЕНИЕ ДАННЫХ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(721, 458);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(712, 448);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSkyBlue;
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.ForeColor = Color.DarkBlue;
            button6.Location = new Point(601, 50);
            button6.Name = "button6";
            button6.Size = new Size(109, 33);
            button6.TabIndex = 17;
            button6.Text = "Изменить";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // СтатусCb
            // 
            СтатусCb.FormattingEnabled = true;
            СтатусCb.Items.AddRange(new object[] { "ожидает", "одобрен", "не одобрен", "готов" });
            СтатусCb.Location = new Point(466, 55);
            СтатусCb.Name = "СтатусCb";
            СтатусCb.Size = new Size(129, 28);
            СтатусCb.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(ФИОtxt);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(ТипЗаявкиCb);
            panel4.Controls.Add(СтатусCb);
            panel4.Location = new Point(0, 537);
            panel4.Name = "panel4";
            panel4.Size = new Size(721, 109);
            panel4.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 32);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 25;
            label4.Text = "Статус";
            // 
            // button5
            // 
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(357, 41);
            button5.Name = "button5";
            button5.Size = new Size(64, 54);
            button5.TabIndex = 24;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 41);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 23;
            label2.Text = "по сотруднику:";
            // 
            // ФИОtxt
            // 
            ФИОtxt.Location = new Point(205, 64);
            ФИОtxt.Name = "ФИОtxt";
            ФИОtxt.Size = new Size(136, 27);
            ФИОtxt.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(267, 10);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 21;
            label1.Text = "поиск и фильттрация";
            label1.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 41);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 19;
            label5.Text = "по типу заявки";
            // 
            // ТипЗаявкиCb
            // 
            ТипЗаявкиCb.DropDownStyle = ComboBoxStyle.DropDownList;
            ТипЗаявкиCb.FormattingEnabled = true;
            ТипЗаявкиCb.Items.AddRange(new object[] { "отпуск", "больничный лист", "командировка", "бонификация", "повышение заработной платы", "премия" });
            ТипЗаявкиCb.Location = new Point(53, 64);
            ТипЗаявкиCb.Name = "ТипЗаявкиCb";
            ТипЗаявкиCb.Size = new Size(127, 28);
            ТипЗаявкиCb.TabIndex = 18;
            ТипЗаявкиCb.SelectedIndexChanged += ТипЗаявкиCb_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 645);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 51);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(450, 7);
            button3.Name = "button3";
            button3.Size = new Size(109, 33);
            button3.TabIndex = 16;
            button3.Text = "отчет";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.GhostWhite;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(627, 7);
            button4.Name = "button4";
            button4.Size = new Size(83, 33);
            button4.TabIndex = 14;
            button4.Text = " Выход";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(302, 7);
            button2.Name = "button2";
            button2.Size = new Size(109, 33);
            button2.TabIndex = 15;
            button2.Text = "данные";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(153, 7);
            button1.Name = "button1";
            button1.Size = new Size(109, 33);
            button1.TabIndex = 14;
            button1.Text = "заявка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Otobr
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 693);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Otobr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otobr";
            Load += Otobr_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button4;
        private ComboBox СтатусCb;
        private Button button6;
        private ComboBox ТипЗаявкиCb;
        private Label label5;
        private Label label1;
        private Label label2;
        private TextBox ФИОtxt;
        private Button button5;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}