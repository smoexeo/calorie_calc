namespace calorie_calc
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Entry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.DataGridView();
            this.history_product = new System.Windows.Forms.DataGridView();
            this.history_sport = new System.Windows.Forms.DataGridView();
            this.sport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_cal = new System.Windows.Forms.Label();
            this.sport_cal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Reset = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.delete_product = new System.Windows.Forms.Button();
            this.add_sport = new System.Windows.Forms.Button();
            this.delete_sport = new System.Windows.Forms.Button();
            this.Profile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_sport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sport)).BeginInit();
            this.SuspendLayout();
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(1443, 12);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(119, 36);
            this.Entry.TabIndex = 0;
            this.Entry.Text = "Войти";
            this.Entry.UseVisualStyleBackColor = true;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите блюдо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбранное блюдо";
            // 
            // product
            // 
            this.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product.Location = new System.Drawing.Point(16, 121);
            this.product.Name = "product";
            this.product.RowHeadersWidth = 82;
            this.product.RowTemplate.Height = 33;
            this.product.Size = new System.Drawing.Size(301, 530);
            this.product.TabIndex = 3;
            // 
            // history_product
            // 
            this.history_product.AllowUserToAddRows = false;
            this.history_product.AllowUserToDeleteRows = false;
            this.history_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history_product.Location = new System.Drawing.Point(382, 121);
            this.history_product.Name = "history_product";
            this.history_product.RowHeadersWidth = 82;
            this.history_product.RowTemplate.Height = 33;
            this.history_product.Size = new System.Drawing.Size(301, 530);
            this.history_product.TabIndex = 4;
            // 
            // history_sport
            // 
            this.history_sport.AllowUserToAddRows = false;
            this.history_sport.AllowUserToDeleteRows = false;
            this.history_sport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.history_sport.Location = new System.Drawing.Point(896, 121);
            this.history_sport.Name = "history_sport";
            this.history_sport.RowHeadersWidth = 82;
            this.history_sport.RowTemplate.Height = 33;
            this.history_sport.Size = new System.Drawing.Size(301, 530);
            this.history_sport.TabIndex = 5;
            // 
            // sport
            // 
            this.sport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sport.Location = new System.Drawing.Point(1261, 121);
            this.sport.Name = "sport";
            this.sport.RowHeadersWidth = 82;
            this.sport.RowTemplate.Height = 33;
            this.sport.Size = new System.Drawing.Size(301, 530);
            this.sport.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выбранная активность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1301, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите активность";
            // 
            // product_cal
            // 
            this.product_cal.AutoSize = true;
            this.product_cal.Location = new System.Drawing.Point(741, 191);
            this.product_cal.Name = "product_cal";
            this.product_cal.Size = new System.Drawing.Size(91, 25);
            this.product_cal.TabIndex = 9;
            this.product_cal.Text = "+N ккал";
            // 
            // sport_cal
            // 
            this.sport_cal.AutoSize = true;
            this.sport_cal.Location = new System.Drawing.Point(746, 241);
            this.sport_cal.Name = "sport_cal";
            this.sport_cal.Size = new System.Drawing.Size(86, 25);
            this.sport_cal.TabIndex = 10;
            this.sport_cal.Text = "-N ккал";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Итого:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(739, 355);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(88, 25);
            this.total.TabIndex = 12;
            this.total.Text = "+0 ккал";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(739, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Оценка:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(729, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Отлично!!!";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(690, 569);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(690, 606);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(200, 45);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // add_product
            // 
            this.add_product.Location = new System.Drawing.Point(324, 330);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(53, 43);
            this.add_product.TabIndex = 18;
            this.add_product.Text = ">";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // delete_product
            // 
            this.delete_product.Location = new System.Drawing.Point(324, 379);
            this.delete_product.Name = "delete_product";
            this.delete_product.Size = new System.Drawing.Size(53, 43);
            this.delete_product.TabIndex = 19;
            this.delete_product.Text = "<";
            this.delete_product.UseVisualStyleBackColor = true;
            this.delete_product.Click += new System.EventHandler(this.delete_product_Click);
            // 
            // add_sport
            // 
            this.add_sport.Location = new System.Drawing.Point(1203, 386);
            this.add_sport.Name = "add_sport";
            this.add_sport.Size = new System.Drawing.Size(53, 43);
            this.add_sport.TabIndex = 21;
            this.add_sport.Text = "<";
            this.add_sport.UseVisualStyleBackColor = true;
            this.add_sport.Click += new System.EventHandler(this.add_sport_Click);
            // 
            // delete_sport
            // 
            this.delete_sport.Location = new System.Drawing.Point(1203, 337);
            this.delete_sport.Name = "delete_sport";
            this.delete_sport.Size = new System.Drawing.Size(53, 43);
            this.delete_sport.TabIndex = 20;
            this.delete_sport.Text = ">";
            this.delete_sport.UseVisualStyleBackColor = true;
            this.delete_sport.Click += new System.EventHandler(this.delete_sport_Click);
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(1296, 12);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(119, 36);
            this.Profile.TabIndex = 22;
            this.Profile.Text = "Профиль";
            this.Profile.UseVisualStyleBackColor = true;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1574, 668);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.add_sport);
            this.Controls.Add(this.delete_sport);
            this.Controls.Add(this.delete_product);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sport_cal);
            this.Controls.Add(this.product_cal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sport);
            this.Controls.Add(this.history_sport);
            this.Controls.Add(this.history_product);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main_Form";
            this.Text = "Калькулятор калорий";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_sport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView product;
        private System.Windows.Forms.DataGridView history_product;
        private System.Windows.Forms.DataGridView history_sport;
        private System.Windows.Forms.DataGridView sport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label product_cal;
        private System.Windows.Forms.Label sport_cal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button delete_product;
        private System.Windows.Forms.Button add_sport;
        private System.Windows.Forms.Button delete_sport;
        private System.Windows.Forms.Button Profile;
    }
}

