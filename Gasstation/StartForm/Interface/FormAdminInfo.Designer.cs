namespace Gasstation.StartForm.Interface
{
    partial class FormAdminInfo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_FuelPrice = new System.Windows.Forms.DataGridView();
            this.labelCountClient = new System.Windows.Forms.Label();
            this.labelCountStation = new System.Windows.Forms.Label();
            this.labelCountShop = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.buttonView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FuelPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество клиентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество станций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество покупок";
            // 
            // dgv_FuelPrice
            // 
            this.dgv_FuelPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FuelPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FuelPrice.Location = new System.Drawing.Point(17, 174);
            this.dgv_FuelPrice.Name = "dgv_FuelPrice";
            this.dgv_FuelPrice.RowHeadersWidth = 62;
            this.dgv_FuelPrice.RowTemplate.Height = 28;
            this.dgv_FuelPrice.Size = new System.Drawing.Size(397, 214);
            this.dgv_FuelPrice.TabIndex = 3;
            // 
            // labelCountClient
            // 
            this.labelCountClient.AutoSize = true;
            this.labelCountClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountClient.Location = new System.Drawing.Point(286, 21);
            this.labelCountClient.Name = "labelCountClient";
            this.labelCountClient.Size = new System.Drawing.Size(85, 29);
            this.labelCountClient.TabIndex = 4;
            this.labelCountClient.Text = "label4";
            // 
            // labelCountStation
            // 
            this.labelCountStation.AutoSize = true;
            this.labelCountStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountStation.Location = new System.Drawing.Point(286, 75);
            this.labelCountStation.Name = "labelCountStation";
            this.labelCountStation.Size = new System.Drawing.Size(85, 29);
            this.labelCountStation.TabIndex = 5;
            this.labelCountStation.Text = "label4";
            // 
            // labelCountShop
            // 
            this.labelCountShop.AutoSize = true;
            this.labelCountShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountShop.Location = new System.Drawing.Point(286, 127);
            this.labelCountShop.Name = "labelCountShop";
            this.labelCountShop.Size = new System.Drawing.Size(85, 29);
            this.labelCountShop.TabIndex = 6;
            this.labelCountShop.Text = "label4";
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(485, 21);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(953, 498);
            this.zedGraph.TabIndex = 7;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(997, 549);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(198, 26);
            this.dtpEnd.TabIndex = 8;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(744, 549);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(198, 26);
            this.dtpStart.TabIndex = 9;
            // 
            // buttonView
            // 
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonView.Location = new System.Drawing.Point(854, 616);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(237, 47);
            this.buttonView.TabIndex = 10;
            this.buttonView.Text = "Отобразить";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // FormAdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.labelCountShop);
            this.Controls.Add(this.labelCountStation);
            this.Controls.Add(this.labelCountClient);
            this.Controls.Add(this.dgv_FuelPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminInfo";
            this.Text = "Общая информация";
            this.Load += new System.EventHandler(this.FormAdminInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FuelPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_FuelPrice;
        private System.Windows.Forms.Label labelCountClient;
        private System.Windows.Forms.Label labelCountStation;
        private System.Windows.Forms.Label labelCountShop;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button buttonView;
    }
}