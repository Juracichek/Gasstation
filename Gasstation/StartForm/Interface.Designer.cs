namespace Gasstation
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonCard = new System.Windows.Forms.Button();
            this.buttonTuck = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonHistory);
            this.panelMenu.Controls.Add(this.buttonCard);
            this.panelMenu.Controls.Add(this.buttonTuck);
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 544);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            this.buttonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonHistory.Image")));
            this.buttonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.Location = new System.Drawing.Point(0, 350);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonHistory.Size = new System.Drawing.Size(220, 85);
            this.buttonHistory.TabIndex = 6;
            this.buttonHistory.Text = " История";
            this.buttonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            this.buttonHistory.Leave += new System.EventHandler(this.buttonHistory_Leave);
            // 
            // buttonCard
            // 
            this.buttonCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCard.FlatAppearance.BorderSize = 0;
            this.buttonCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCard.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCard.Image = ((System.Drawing.Image)(resources.GetObject("buttonCard.Image")));
            this.buttonCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCard.Location = new System.Drawing.Point(0, 265);
            this.buttonCard.Name = "buttonCard";
            this.buttonCard.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonCard.Size = new System.Drawing.Size(220, 85);
            this.buttonCard.TabIndex = 5;
            this.buttonCard.Text = " Карта";
            this.buttonCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCard.UseVisualStyleBackColor = true;
            this.buttonCard.Click += new System.EventHandler(this.buttonCard_Click);
            this.buttonCard.Leave += new System.EventHandler(this.buttonCard_Leave);
            // 
            // buttonTuck
            // 
            this.buttonTuck.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTuck.FlatAppearance.BorderSize = 0;
            this.buttonTuck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTuck.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTuck.Image = ((System.Drawing.Image)(resources.GetObject("buttonTuck.Image")));
            this.buttonTuck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTuck.Location = new System.Drawing.Point(0, 180);
            this.buttonTuck.Name = "buttonTuck";
            this.buttonTuck.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonTuck.Size = new System.Drawing.Size(220, 85);
            this.buttonTuck.TabIndex = 2;
            this.buttonTuck.Text = " Заправка";
            this.buttonTuck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTuck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTuck.UseVisualStyleBackColor = true;
            this.buttonTuck.Click += new System.EventHandler(this.buttonTuck_Click);
            this.buttonTuck.Leave += new System.EventHandler(this.buttonTuck_Leave);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(0, 95);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonProfile.Size = new System.Drawing.Size(220, 85);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = " Профиль";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            this.buttonProfile.Leave += new System.EventHandler(this.buttonProfile_Leave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.labelCompanyName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 95);
            this.panelLogo.TabIndex = 0;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompanyName.ForeColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.Location = new System.Drawing.Point(47, 31);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(120, 37);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "MexOil";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Firebrick;
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(858, 95);
            this.panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(304, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(252, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Домашняя страница";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 95);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(858, 449);
            this.panelDesktop.TabIndex = 2;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonTuck;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonCard;
        private System.Windows.Forms.Button buttonHistory;
    }
}