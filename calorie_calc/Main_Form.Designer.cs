﻿namespace calorie_calc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Entry = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.DataGridView();
            this.Profile = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.SuspendLayout();
            // 
            // Entry
            // 
            this.Entry.FlatAppearance.BorderSize = 0;
            this.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entry.ForeColor = System.Drawing.Color.Gray;
            this.Entry.Location = new System.Drawing.Point(49, 31);
            this.Entry.Margin = new System.Windows.Forms.Padding(2);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(129, 35);
            this.Entry.TabIndex = 0;
            this.Entry.Text = "ВОЙТИ";
            this.Entry.UseVisualStyleBackColor = true;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // product
            // 
            this.product.AllowUserToAddRows = false;
            this.product.AllowUserToDeleteRows = false;
            this.product.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.product.BackgroundColor = System.Drawing.Color.White;
            this.product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.Product_name,
            this.Number,
            this.Kalories});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product.DefaultCellStyle = dataGridViewCellStyle3;
            this.product.GridColor = System.Drawing.Color.White;
            this.product.Location = new System.Drawing.Point(28, 88);
            this.product.Margin = new System.Windows.Forms.Padding(2);
            this.product.Name = "product";
            this.product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.product.RowHeadersVisible = false;
            this.product.RowHeadersWidth = 82;
            this.product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.product.RowTemplate.Height = 33;
            this.product.Size = new System.Drawing.Size(344, 223);
            this.product.TabIndex = 3;
            this.product.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.product_RowsAdded);
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.White;
            this.Profile.FlatAppearance.BorderSize = 0;
            this.Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile.ForeColor = System.Drawing.Color.DimGray;
            this.Profile.Location = new System.Drawing.Point(49, 31);
            this.Profile.Margin = new System.Windows.Forms.Padding(2);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(129, 35);
            this.Profile.TabIndex = 22;
            this.Profile.Text = "ПРОФИЛЬ";
            this.Profile.UseVisualStyleBackColor = false;
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.DimGray;
            this.add.Location = new System.Drawing.Point(44, 350);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(134, 33);
            this.add.TabIndex = 18;
            this.add.Text = "ДОБАВИТЬ";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_product_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.DimGray;
            this.delete.Location = new System.Drawing.Point(221, 350);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(134, 33);
            this.delete.TabIndex = 19;
            this.delete.Text = "УДАЛИТЬ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_product_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(35, 313);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(62, 13);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // product_id
            // 
            this.product_id.HeaderText = "Идентификатор";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // Product_name
            // 
            this.Product_name.HeaderText = "Название";
            this.Product_name.Name = "Product_name";
            // 
            // Number
            // 
            this.Number.HeaderText = "Количество";
            this.Number.Name = "Number";
            // 
            // Kalories
            // 
            this.Kalories.HeaderText = "Итого калорий";
            this.Kalories.Name = "Kalories";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(398, 399);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.product);
            this.Controls.Add(this.Entry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalories;
    }
}

