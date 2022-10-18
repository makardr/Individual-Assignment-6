namespace Individual_Assignment_6
{
    partial class Form1
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
            this.paper_btn = new System.Windows.Forms.Button();
            this.scissors_btn = new System.Windows.Forms.Button();
            this.rock_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paper_btn
            // 
            this.paper_btn.Location = new System.Drawing.Point(351, 304);
            this.paper_btn.Name = "paper_btn";
            this.paper_btn.Size = new System.Drawing.Size(75, 23);
            this.paper_btn.TabIndex = 1;
            this.paper_btn.Text = "Paper";
            this.paper_btn.UseVisualStyleBackColor = true;
            this.paper_btn.Click += new System.EventHandler(this.paper_btn_Click);
            // 
            // scissors_btn
            // 
            this.scissors_btn.Location = new System.Drawing.Point(446, 304);
            this.scissors_btn.Name = "scissors_btn";
            this.scissors_btn.Size = new System.Drawing.Size(75, 23);
            this.scissors_btn.TabIndex = 2;
            this.scissors_btn.Text = "Scissors";
            this.scissors_btn.UseVisualStyleBackColor = true;
            this.scissors_btn.Click += new System.EventHandler(this.scissors_btn_Click);
            // 
            // rock_btn
            // 
            this.rock_btn.Location = new System.Drawing.Point(258, 304);
            this.rock_btn.Name = "rock_btn";
            this.rock_btn.Size = new System.Drawing.Size(75, 23);
            this.rock_btn.TabIndex = 3;
            this.rock_btn.Text = "Rock";
            this.rock_btn.UseVisualStyleBackColor = true;
            this.rock_btn.Click += new System.EventHandler(this.rock_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rock_btn);
            this.Controls.Add(this.scissors_btn);
            this.Controls.Add(this.paper_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button paper_btn;
        private System.Windows.Forms.Button scissors_btn;
        private System.Windows.Forms.Button rock_btn;
    }
}

