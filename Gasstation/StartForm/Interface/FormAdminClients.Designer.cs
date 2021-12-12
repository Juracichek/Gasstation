namespace Gasstation.StartForm.Interface
{
    partial class FormAdminClients
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
            this.dgv_AdminClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AdminClient
            // 
            this.dgv_AdminClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AdminClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AdminClient.Location = new System.Drawing.Point(13, 13);
            this.dgv_AdminClient.Name = "dgv_AdminClient";
            this.dgv_AdminClient.RowHeadersWidth = 62;
            this.dgv_AdminClient.RowTemplate.Height = 28;
            this.dgv_AdminClient.Size = new System.Drawing.Size(953, 504);
            this.dgv_AdminClient.TabIndex = 0;
            // 
            // FormAdminClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 695);
            this.Controls.Add(this.dgv_AdminClient);
            this.Name = "FormAdminClients";
            this.Text = "Список клиентов";
            this.Load += new System.EventHandler(this.FormAdminClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AdminClient;
    }
}