namespace Gasstation
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.butReg = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(72, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(94, 29);
            this.name.TabIndex = 0;
            this.name.Text = "Name*:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(30, 97);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(136, 29);
            this.password.TabIndex = 1;
            this.password.Text = "Password*:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(76, 155);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(90, 29);
            this.email.TabIndex = 2;
            this.email.Text = "Email*:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(186, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 35);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(186, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 35);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(186, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(348, 35);
            this.textBox3.TabIndex = 5;
            // 
            // butReg
            // 
            this.butReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReg.Location = new System.Drawing.Point(46, 339);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(163, 42);
            this.butReg.TabIndex = 6;
            this.butReg.Text = "Registration";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butClose.Location = new System.Drawing.Point(233, 339);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(111, 42);
            this.butClose.TabIndex = 7;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Required fields*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Label label1;
    }
}

