namespace Мособлгаз
{
    partial class Otchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otchet));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            button7 = new Button();
            label5 = new Label();
            ТипЗаявкиCb = new ComboBox();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            label3.Location = new Point(325, 22);
            label3.Name = "label3";
            label3.Size = new Size(84, 31);
            label3.TabIndex = 20;
            label3.Text = "ОТЧЕТ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(ТипЗаявкиCb);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(-1, 519);
            panel4.Name = "panel4";
            panel4.Size = new Size(724, 125);
            panel4.TabIndex = 7;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(627, 48);
            button7.Name = "button7";
            button7.Size = new Size(55, 51);
            button7.TabIndex = 29;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 39);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 28;
            label5.Text = "по типу заявки";
            // 
            // ТипЗаявкиCb
            // 
            ТипЗаявкиCb.DropDownStyle = ComboBoxStyle.DropDownList;
            ТипЗаявкиCb.FormattingEnabled = true;
            ТипЗаявкиCb.Items.AddRange(new object[] { "отпуск", "больничный лист", "командировка", "бонификация", "повышение заработной платы", "премия" });
            ТипЗаявкиCb.Location = new Point(494, 62);
            ТипЗаявкиCb.Name = "ТипЗаявкиCb";
            ТипЗаявкиCb.Size = new Size(127, 28);
            ТипЗаявкиCb.TabIndex = 27;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.ForeColor = Color.White;
            button5.Location = new Point(313, 85);
            button5.Name = "button5";
            button5.Size = new Size(88, 33);
            button5.TabIndex = 25;
            button5.Text = "PDF";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(326, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 22;
            label1.Text = "подготовка данных";
            label1.UseMnemonic = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(-1, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 51);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(461, 7);
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
            button2.Location = new Point(313, 7);
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
            button1.Location = new Point(164, 7);
            button1.Name = "button1";
            button1.Size = new Size(109, 33);
            button1.TabIndex = 14;
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
            panel3.Size = new Size(721, 442);
            panel3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(715, 405);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Otchet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 693);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Otchet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otchet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox3;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox ТипЗаявкиCb;
        private Button button7;
    }
}