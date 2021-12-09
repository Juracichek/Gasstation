namespace Gasstation.StartForm.Interface
{
    partial class FormProfile
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
            this.labelNameDB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameDB
            // 
            this.labelNameDB.AutoSize = true;
            this.labelNameDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameDB.Location = new System.Drawing.Point(222, 195);
            this.labelNameDB.Name = "labelNameDB";
            this.labelNameDB.Size = new System.Drawing.Size(92, 32);
            this.labelNameDB.TabIndex = 0;
            this.labelNameDB.Text = "label1";
            this.labelNameDB.Click += new System.EventHandler(this.labelNameDB_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNameDB);
            this.Name = "FormProfile";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameDB;
    }
}