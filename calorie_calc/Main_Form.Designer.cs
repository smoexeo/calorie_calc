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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Entry = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.delete_product = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // Entry
            // 
            this.Entry.FlatAppearance.BorderSize = 0;
            this.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entry.ForeColor = System.Drawing.Color.Gray;
            this.Entry.Location = new System.Drawing.Point(98, 60);
            this.Entry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(258, 67);
            this.Entry.TabIndex = 0;
            this.Entry.Text = "ВОЙТИ";
            this.Entry.UseVisualStyleBackColor = true;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // product
            // 
            this.product.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product.GridColor = System.Drawing.Color.White;
            this.product.Location = new System.Drawing.Point(62, 169);
            this.product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product.Name = "product";
            this.product.RowHeadersWidth = 82;
            this.product.RowTemplate.Height = 33;
            this.product.Size = new System.Drawing.Size(672, 429);
            this.product.TabIndex = 3;
            this.product.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.product_RowsAdded);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.White;
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.ForeColor = System.Drawing.Color.DimGray;
            this.Profile.Location = new System.Drawing.Point(98, 21);
            this.Profile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(258, 67);
            this.Profile.TabIndex = 22;
            this.Profile.Text = "ПРОФИЛЬ";
            this.Profile.UseVisualStyleBackColor = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // add_product
            // 
            this.add_product.BackColor = System.Drawing.Color.White;
            this.add_product.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_product.FlatAppearance.BorderSize = 0;
            this.add_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_product.ForeColor = System.Drawing.Color.DimGray;
            this.add_product.Location = new System.Drawing.Point(88, 673);
            this.add_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(268, 63);
            this.add_product.TabIndex = 18;
            this.add_product.Text = "ДОБАВИТЬ";
            this.add_product.UseVisualStyleBackColor = false;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // delete_product
            // 
            this.delete_product.BackColor = System.Drawing.Color.White;
            this.delete_product.FlatAppearance.BorderSize = 0;
            this.delete_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_product.ForeColor = System.Drawing.Color.DimGray;
            this.delete_product.Location = new System.Drawing.Point(442, 673);
            this.delete_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_product.Name = "delete_product";
            this.delete_product.Size = new System.Drawing.Size(268, 63);
            this.delete_product.TabIndex = 19;
            this.delete_product.Text = "УДАЛИТЬ";
            this.delete_product.UseVisualStyleBackColor = false;
            this.delete_product.Click += new System.EventHandler(this.delete_product_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(70, 602);
            this.result.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(121, 25);
            this.result.TabIndex = 23;
            this.result.Text = "Результат:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 73);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 37);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 769);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.delete_product);
            this.Controls.Add(this.add_product);
            this.Controls.Add(this.product);
            this.Controls.Add(this.Entry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_Form";
            this.Text = "Калькулятор калорий";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.DataGridView product;
        private System.Windows.Forms.Button Profile;
        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button delete_product;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

