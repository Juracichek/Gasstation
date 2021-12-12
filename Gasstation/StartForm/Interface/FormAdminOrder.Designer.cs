namespace Gasstation.StartForm.Interface
{
    partial class FormAdminOrder
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
            this.labelNumStation = new System.Windows.Forms.Label();
            this.comboBoxAdminStations = new System.Windows.Forms.ComboBox();
            this.labelTypeFuel = new System.Windows.Forms.Label();
            this.comboBoxAdminFuel = new System.Windows.Forms.ComboBox();
            this.textBoxAdminLiter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdminOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumStation
            // 
            this.labelNumStation.AutoSize = true;
            this.labelNumStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumStation.Location = new System.Drawing.Point(12, 19);
            this.labelNumStation.Name = "labelNumStation";
            this.labelNumStation.Size = new System.Drawing.Size(163, 25);
            this.labelNumStation.TabIndex = 12;
            this.labelNumStation.Text = "Номер станции:";
            // 
            // comboBoxAdminStations
            // 
            this.comboBoxAdminStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAdminStations.FormattingEnabled = true;
            this.comboBoxAdminStations.Location = new System.Drawing.Point(11, 47);
            this.comboBoxAdminStations.Name = "comboBoxAdminStations";
            this.comboBoxAdminStations.Size = new System.Drawing.Size(215, 28);
            this.comboBoxAdminStations.TabIndex = 11;
            this.comboBoxAdminStations.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdminStations_SelectedIndexChanged);
            // 
            // labelTypeFuel
            // 
            this.labelTypeFuel.AutoSize = true;
            this.labelTypeFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeFuel.Location = new System.Drawing.Point(12, 109);
            this.labelTypeFuel.Name = "labelTypeFuel";
            this.labelTypeFuel.Size = new System.Drawing.Size(135, 25);
            this.labelTypeFuel.TabIndex = 14;
            this.labelTypeFuel.Text = "Вид топлива:";
            // 
            // comboBoxAdminFuel
            // 
            this.comboBoxAdminFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAdminFuel.FormattingEnabled = true;
            this.comboBoxAdminFuel.Location = new System.Drawing.Point(11, 137);
            this.comboBoxAdminFuel.Name = "comboBoxAdminFuel";
            this.comboBoxAdminFuel.Size = new System.Drawing.Size(215, 28);
            this.comboBoxAdminFuel.TabIndex = 13;
            // 
            // textBoxAdminLiter
            // 
            this.textBoxAdminLiter.Location = new System.Drawing.Point(11, 229);
            this.textBoxAdminLiter.Name = "textBoxAdminLiter";
            this.textBoxAdminLiter.Size = new System.Drawing.Size(215, 26);
            this.textBoxAdminLiter.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Сколько литров закзать:";
            // 
            // buttonAdminOrder
            // 
            this.buttonAdminOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdminOrder.Location = new System.Drawing.Point(17, 293);
            this.buttonAdminOrder.Name = "buttonAdminOrder";
            this.buttonAdminOrder.Size = new System.Drawing.Size(202, 54);
            this.buttonAdminOrder.TabIndex = 17;
            this.buttonAdminOrder.Text = "Заказать";
            this.buttonAdminOrder.UseVisualStyleBackColor = true;
            this.buttonAdminOrder.Click += new System.EventHandler(this.buttonAdminOrder_Click);
            // 
            // FormAdminOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdminOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdminLiter);
            this.Controls.Add(this.labelTypeFuel);
            this.Controls.Add(this.comboBoxAdminFuel);
            this.Controls.Add(this.labelNumStation);
            this.Controls.Add(this.comboBoxAdminStations);
            this.Name = "FormAdminOrder";
            this.Text = "Заказ топлива";
            this.Load += new System.EventHandler(this.FormAdminOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumStation;
        private System.Windows.Forms.ComboBox comboBoxAdminStations;
        private System.Windows.Forms.Label labelTypeFuel;
        private System.Windows.Forms.ComboBox comboBoxAdminFuel;
        private System.Windows.Forms.TextBox textBoxAdminLiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdminOrder;
    }
}