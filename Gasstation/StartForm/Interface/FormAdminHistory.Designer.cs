namespace Gasstation.StartForm.Interface
{
    partial class FormAdminHistory
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
            this.dgv_AdminHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AdminHistory
            // 
            this.dgv_AdminHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AdminHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AdminHistory.Location = new System.Drawing.Point(13, 13);
            this.dgv_AdminHistory.Name = "dgv_AdminHistory";
            this.dgv_AdminHistory.RowHeadersWidth = 62;
            this.dgv_AdminHistory.RowTemplate.Height = 28;
            this.dgv_AdminHistory.Size = new System.Drawing.Size(1009, 688);
            this.dgv_AdminHistory.TabIndex = 0;
            // 
            // FormAdminHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 713);
            this.Controls.Add(this.dgv_AdminHistory);
            this.Name = "FormAdminHistory";
            this.Text = "История покупок";
            this.Load += new System.EventHandler(this.FormAdminHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AdminHistory;
    }
}