namespace Gasstation
{
    partial class Registration
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
            this.labelNameReg = new System.Windows.Forms.Label();
            this.labelPasswordReg = new System.Windows.Forms.Label();
            this.labelEmailReg = new System.Windows.Forms.Label();
            this.textBoxNameReg = new System.Windows.Forms.TextBox();
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.textBoxEmailReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameReg
            // 
            this.labelNameReg.AutoSize = true;
            this.labelNameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameReg.Location = new System.Drawing.Point(30, 27);
            this.labelNameReg.Name = "labelNameReg";
            this.labelNameReg.Size = new System.Drawing.Size(145, 29);
            this.labelNameReg.TabIndex = 0;
            this.labelNameReg.Text = "Ваше имя*:";
            // 
            // labelPasswordReg
            // 
            this.labelPasswordReg.AutoSize = true;
            this.labelPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordReg.Location = new System.Drawing.Point(60, 91);
            this.labelPasswordReg.Name = "labelPasswordReg";
            this.labelPasswordReg.Size = new System.Drawing.Size(115, 29);
            this.labelPasswordReg.TabIndex = 1;
            this.labelPasswordReg.Text = "Пароль*:";
            // 
            // labelEmailReg
            // 
            this.labelEmailReg.AutoSize = true;
            this.labelEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmailReg.Location = new System.Drawing.Point(85, 155);
            this.labelEmailReg.Name = "labelEmailReg";
            this.labelEmailReg.Size = new System.Drawing.Size(90, 29);
            this.labelEmailReg.TabIndex = 2;
            this.labelEmailReg.Text = "Email*:";
            // 
            // textBoxNameReg
            // 
            this.textBoxNameReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameReg.Location = new System.Drawing.Point(186, 24);
            this.textBoxNameReg.Name = "textBoxNameReg";
            this.textBoxNameReg.Size = new System.Drawing.Size(348, 35);
            this.textBoxNameReg.TabIndex = 3;
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordReg.Location = new System.Drawing.Point(186, 91);
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(348, 35);
            this.textBoxPasswordReg.TabIndex = 4;
            this.textBoxPasswordReg.UseSystemPasswordChar = true;
            // 
            // textBoxEmailReg
            // 
            this.textBoxEmailReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmailReg.Location = new System.Drawing.Point(186, 152);
            this.textBoxEmailReg.Name = "textBoxEmailReg";
            this.textBoxEmailReg.Size = new System.Drawing.Size(348, 35);
            this.textBoxEmailReg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(147, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Обязательные поля*";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(106, 366);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(176, 58);
            this.buttonRegistration.TabIndex = 10;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignIn.Location = new System.Drawing.Point(288, 366);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(176, 58);
            this.buttonSignIn.TabIndex = 11;
            this.buttonSignIn.Text = "Вход";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmailReg);
            this.Controls.Add(this.textBoxPasswordReg);
            this.Controls.Add(this.textBoxNameReg);
            this.Controls.Add(this.labelEmailReg);
            this.Controls.Add(this.labelPasswordReg);
            this.Controls.Add(this.labelNameReg);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameReg;
        private System.Windows.Forms.Label labelPasswordReg;
        private System.Windows.Forms.Label labelEmailReg;
        private System.Windows.Forms.TextBox textBoxNameReg;
        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.TextBox textBoxEmailReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonSignIn;
    }
}

