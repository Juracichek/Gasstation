namespace Gasstation.StartForm
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelAdminMenu = new System.Windows.Forms.Panel();
            this.buttonAdminHistory = new System.Windows.Forms.Button();
            this.buttonAdminOrder = new System.Windows.Forms.Button();
            this.buttonAdminClients = new System.Windows.Forms.Button();
            this.buttonAdminInfo = new System.Windows.Forms.Button();
            this.panelAdminLogo = new System.Windows.Forms.Panel();
            this.labelAdminCompName = new System.Windows.Forms.Label();
            this.panelAdminTitle = new System.Windows.Forms.Panel();
            this.labelAdminTitle = new System.Windows.Forms.Label();
            this.panelAdminDesktop = new System.Windows.Forms.Panel();
            this.panelAdminMenu.SuspendLayout();
            this.panelAdminLogo.SuspendLayout();
            this.panelAdminTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdminMenu
            // 
            this.panelAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelAdminMenu.Controls.Add(this.buttonAdminHistory);
            this.panelAdminMenu.Controls.Add(this.buttonAdminOrder);
            this.panelAdminMenu.Controls.Add(this.buttonAdminClients);
            this.panelAdminMenu.Controls.Add(this.buttonAdminInfo);
            this.panelAdminMenu.Controls.Add(this.panelAdminLogo);
            this.panelAdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelAdminMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAdminMenu.Name = "panelAdminMenu";
            this.panelAdminMenu.Size = new System.Drawing.Size(220, 544);
            this.panelAdminMenu.TabIndex = 0;
            // 
            // buttonAdminHistory
            // 
            this.buttonAdminHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdminHistory.FlatAppearance.BorderSize = 0;
            this.buttonAdminHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminHistory.Image")));
            this.buttonAdminHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminHistory.Location = new System.Drawing.Point(0, 350);
            this.buttonAdminHistory.Name = "buttonAdminHistory";
            this.buttonAdminHistory.Size = new System.Drawing.Size(220, 85);
            this.buttonAdminHistory.TabIndex = 4;
            this.buttonAdminHistory.Text = " История";
            this.buttonAdminHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdminHistory.UseVisualStyleBackColor = true;
            this.buttonAdminHistory.Click += new System.EventHandler(this.buttonAdminHistory_Click);
            this.buttonAdminHistory.Leave += new System.EventHandler(this.buttonAdminHistory_Leave);
            // 
            // buttonAdminOrder
            // 
            this.buttonAdminOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdminOrder.FlatAppearance.BorderSize = 0;
            this.buttonAdminOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminOrder.Image")));
            this.buttonAdminOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminOrder.Location = new System.Drawing.Point(0, 265);
            this.buttonAdminOrder.Name = "buttonAdminOrder";
            this.buttonAdminOrder.Size = new System.Drawing.Size(220, 85);
            this.buttonAdminOrder.TabIndex = 3;
            this.buttonAdminOrder.Text = " Заказ";
            this.buttonAdminOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdminOrder.UseVisualStyleBackColor = true;
            this.buttonAdminOrder.Click += new System.EventHandler(this.buttonAdminOrder_Click);
            this.buttonAdminOrder.Leave += new System.EventHandler(this.buttonAdminOrder_Leave);
            // 
            // buttonAdminClients
            // 
            this.buttonAdminClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdminClients.FlatAppearance.BorderSize = 0;
            this.buttonAdminClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminClients.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminClients.Image")));
            this.buttonAdminClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminClients.Location = new System.Drawing.Point(0, 180);
            this.buttonAdminClients.Name = "buttonAdminClients";
            this.buttonAdminClients.Size = new System.Drawing.Size(220, 85);
            this.buttonAdminClients.TabIndex = 2;
            this.buttonAdminClients.Text = " Клиенты";
            this.buttonAdminClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdminClients.UseVisualStyleBackColor = true;
            this.buttonAdminClients.Click += new System.EventHandler(this.buttonAdminClients_Click);
            this.buttonAdminClients.Leave += new System.EventHandler(this.buttonAdminClients_Leave);
            // 
            // buttonAdminInfo
            // 
            this.buttonAdminInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdminInfo.FlatAppearance.BorderSize = 0;
            this.buttonAdminInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminInfo.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdminInfo.Image")));
            this.buttonAdminInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminInfo.Location = new System.Drawing.Point(0, 95);
            this.buttonAdminInfo.Name = "buttonAdminInfo";
            this.buttonAdminInfo.Size = new System.Drawing.Size(220, 85);
            this.buttonAdminInfo.TabIndex = 1;
            this.buttonAdminInfo.Text = " Иформация";
            this.buttonAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdminInfo.UseVisualStyleBackColor = true;
            this.buttonAdminInfo.Click += new System.EventHandler(this.buttonAdminInfo_Click);
            this.buttonAdminInfo.Leave += new System.EventHandler(this.buttonAdminInfo_Leave);
            // 
            // panelAdminLogo
            // 
            this.panelAdminLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelAdminLogo.Controls.Add(this.labelAdminCompName);
            this.panelAdminLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminLogo.Location = new System.Drawing.Point(0, 0);
            this.panelAdminLogo.Name = "panelAdminLogo";
            this.panelAdminLogo.Size = new System.Drawing.Size(220, 95);
            this.panelAdminLogo.TabIndex = 0;
            // 
            // labelAdminCompName
            // 
            this.labelAdminCompName.AutoSize = true;
            this.labelAdminCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminCompName.ForeColor = System.Drawing.Color.Transparent;
            this.labelAdminCompName.Location = new System.Drawing.Point(47, 31);
            this.labelAdminCompName.Name = "labelAdminCompName";
            this.labelAdminCompName.Size = new System.Drawing.Size(120, 37);
            this.labelAdminCompName.TabIndex = 0;
            this.labelAdminCompName.Text = "MexOil";
            // 
            // panelAdminTitle
            // 
            this.panelAdminTitle.BackColor = System.Drawing.Color.Firebrick;
            this.panelAdminTitle.Controls.Add(this.labelAdminTitle);
            this.panelAdminTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminTitle.Location = new System.Drawing.Point(220, 0);
            this.panelAdminTitle.Name = "panelAdminTitle";
            this.panelAdminTitle.Size = new System.Drawing.Size(858, 95);
            this.panelAdminTitle.TabIndex = 2;
            // 
            // labelAdminTitle
            // 
            this.labelAdminTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdminTitle.AutoSize = true;
            this.labelAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdminTitle.ForeColor = System.Drawing.Color.White;
            this.labelAdminTitle.Location = new System.Drawing.Point(304, 31);
            this.labelAdminTitle.Name = "labelAdminTitle";
            this.labelAdminTitle.Size = new System.Drawing.Size(183, 29);
            this.labelAdminTitle.TabIndex = 0;
            this.labelAdminTitle.Text = "Админ-панель";
            // 
            // panelAdminDesktop
            // 
            this.panelAdminDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdminDesktop.Location = new System.Drawing.Point(220, 95);
            this.panelAdminDesktop.Name = "panelAdminDesktop";
            this.panelAdminDesktop.Size = new System.Drawing.Size(858, 449);
            this.panelAdminDesktop.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.panelAdminDesktop);
            this.Controls.Add(this.panelAdminTitle);
            this.Controls.Add(this.panelAdminMenu);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panelAdminMenu.ResumeLayout(false);
            this.panelAdminLogo.ResumeLayout(false);
            this.panelAdminLogo.PerformLayout();
            this.panelAdminTitle.ResumeLayout(false);
            this.panelAdminTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminMenu;
        private System.Windows.Forms.Panel panelAdminLogo;
        private System.Windows.Forms.Button buttonAdminInfo;
        private System.Windows.Forms.Button buttonAdminHistory;
        private System.Windows.Forms.Button buttonAdminOrder;
        private System.Windows.Forms.Button buttonAdminClients;
        private System.Windows.Forms.Label labelAdminCompName;
        private System.Windows.Forms.Panel panelAdminTitle;
        private System.Windows.Forms.Label labelAdminTitle;
        private System.Windows.Forms.Panel panelAdminDesktop;
    }
}