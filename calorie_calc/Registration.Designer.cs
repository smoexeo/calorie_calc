namespace calorie_calc
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.registrate = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.gender_female = new System.Windows.Forms.RadioButton();
            this.gender_male = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(136, 43);
            this.login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(126, 14);
            this.login.TabIndex = 2;
            this.login.Text = "Логин...";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(136, 97);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(126, 14);
            this.password.TabIndex = 4;
            this.password.Text = "Пароль...";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password1
            // 
            this.password1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password1.Location = new System.Drawing.Point(136, 149);
            this.password1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(126, 14);
            this.password1.TabIndex = 6;
            this.password1.Text = "Повторите пароль...";
            this.password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registrate
            // 
            this.registrate.BackColor = System.Drawing.Color.White;
            this.registrate.FlatAppearance.BorderSize = 0;
            this.registrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrate.ForeColor = System.Drawing.Color.DimGray;
            this.registrate.Location = new System.Drawing.Point(46, 192);
            this.registrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registrate.Name = "registrate";
            this.registrate.Size = new System.Drawing.Size(132, 32);
            this.registrate.TabIndex = 10;
            this.registrate.Text = "РЕГИСТРАЦИЯ";
            this.registrate.UseVisualStyleBackColor = false;
            this.registrate.Click += new System.EventHandler(this.registrate_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.ForeColor = System.Drawing.Color.DimGray;
            this.cancel.Location = new System.Drawing.Point(222, 192);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(132, 32);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "ОТМЕНА";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // gender_female
            // 
            this.gender_female.AutoSize = true;
            this.gender_female.BackColor = System.Drawing.Color.White;
            this.gender_female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gender_female.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gender_female.Location = new System.Drawing.Point(11, 18);
            this.gender_female.Margin = new System.Windows.Forms.Padding(2);
            this.gender_female.Name = "gender_female";
            this.gender_female.Size = new System.Drawing.Size(78, 18);
            this.gender_female.TabIndex = 14;
            this.gender_female.TabStop = true;
            this.gender_female.Text = "Женский";
            this.gender_female.UseVisualStyleBackColor = false;
            // 
            // gender_male
            // 
            this.gender_male.AutoSize = true;
            this.gender_male.BackColor = System.Drawing.Color.White;
            this.gender_male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gender_male.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gender_male.Location = new System.Drawing.Point(11, 40);
            this.gender_male.Margin = new System.Windows.Forms.Padding(2);
            this.gender_male.Name = "gender_male";
            this.gender_male.Size = new System.Drawing.Size(77, 18);
            this.gender_male.TabIndex = 13;
            this.gender_male.TabStop = true;
            this.gender_male.Text = "Мужской";
            this.gender_male.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gender_male);
            this.groupBox1.Controls.Add(this.gender_female);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(302, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(95, 69);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(398, 242);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.registrate);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Button registrate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.RadioButton gender_female;
        private System.Windows.Forms.RadioButton gender_male;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}