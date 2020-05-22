namespace calorie_calc
{
    partial class Profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(77, 332);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(424, 49);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Возраст";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(77, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(424, 49);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Рост";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(77, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(424, 49);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(389, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Рекомендуемое количество калорий:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "N ккал";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(362, 463);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 44);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(217, 463);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(139, 44);
            this.History.TabIndex = 16;
            this.History.Text = "История";
            this.History.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(77, 463);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(139, 44);
            this.Save.TabIndex = 15;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 540);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button Save;
    }
}