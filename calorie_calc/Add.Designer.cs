namespace calorie_calc
{
    partial class Add
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
            this.item = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new System.Drawing.Point(142, 52);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(109, 25);
            this.item.TabIndex = 0;
            this.item.Text = "Название";
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(45, 90);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(318, 50);
            this.count.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(127, 179);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(136, 41);
            this.button.TabIndex = 2;
            this.button.Text = "Добавить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 257);
            this.Controls.Add(this.button);
            this.Controls.Add(this.count);
            this.Controls.Add(this.item);
            this.Name = "Add";
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label item;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Button button;
    }
}