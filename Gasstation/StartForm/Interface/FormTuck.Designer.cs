namespace Gasstation.StartForm.Interface
{
    partial class FormTuck
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
            this.comboBoxStations = new System.Windows.Forms.ComboBox();
            this.comboBoxColumns = new System.Windows.Forms.ComboBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.textBoxLiter = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxCard = new System.Windows.Forms.ComboBox();
            this.labelBonus = new System.Windows.Forms.Label();
            this.labelPriceSale = new System.Windows.Forms.Label();
            this.checkBoxWriteOffBonus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxStations
            // 
            this.comboBoxStations.FormattingEnabled = true;
            this.comboBoxStations.Location = new System.Drawing.Point(24, 24);
            this.comboBoxStations.Name = "comboBoxStations";
            this.comboBoxStations.Size = new System.Drawing.Size(215, 28);
            this.comboBoxStations.TabIndex = 0;
            this.comboBoxStations.SelectedIndexChanged += new System.EventHandler(this.comboBoxStations_SelectedIndexChanged);
            // 
            // comboBoxColumns
            // 
            this.comboBoxColumns.FormattingEnabled = true;
            this.comboBoxColumns.Location = new System.Drawing.Point(24, 68);
            this.comboBoxColumns.Name = "comboBoxColumns";
            this.comboBoxColumns.Size = new System.Drawing.Size(215, 28);
            this.comboBoxColumns.TabIndex = 1;
            this.comboBoxColumns.Visible = false;
            this.comboBoxColumns.SelectedIndexChanged += new System.EventHandler(this.comboBoxColumns_SelectedIndexChanged);
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(24, 111);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(215, 28);
            this.comboBoxFuel.TabIndex = 2;
            this.comboBoxFuel.Visible = false;
            this.comboBoxFuel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuel_SelectedIndexChanged);
            // 
            // textBoxLiter
            // 
            this.textBoxLiter.Location = new System.Drawing.Point(24, 157);
            this.textBoxLiter.Name = "textBoxLiter";
            this.textBoxLiter.Size = new System.Drawing.Size(215, 26);
            this.textBoxLiter.TabIndex = 3;
            this.textBoxLiter.Visible = false;
            this.textBoxLiter.TextChanged += new System.EventHandler(this.textBoxLiter_TextChanged);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(51, 378);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(108, 48);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Купить";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(332, 59);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 29);
            this.labelPrice.TabIndex = 5;
            // 
            // comboBoxCard
            // 
            this.comboBoxCard.FormattingEnabled = true;
            this.comboBoxCard.Location = new System.Drawing.Point(24, 204);
            this.comboBoxCard.Name = "comboBoxCard";
            this.comboBoxCard.Size = new System.Drawing.Size(215, 28);
            this.comboBoxCard.TabIndex = 6;
            this.comboBoxCard.Visible = false;
            this.comboBoxCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxCard_SelectedIndexChanged);
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBonus.Location = new System.Drawing.Point(545, 205);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(0, 29);
            this.labelBonus.TabIndex = 7;
            // 
            // labelPriceSale
            // 
            this.labelPriceSale.AutoSize = true;
            this.labelPriceSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceSale.Location = new System.Drawing.Point(332, 104);
            this.labelPriceSale.Name = "labelPriceSale";
            this.labelPriceSale.Size = new System.Drawing.Size(0, 29);
            this.labelPriceSale.TabIndex = 8;
            // 
            // checkBoxWriteOffBonus
            // 
            this.checkBoxWriteOffBonus.AutoSize = true;
            this.checkBoxWriteOffBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxWriteOffBonus.Location = new System.Drawing.Point(266, 204);
            this.checkBoxWriteOffBonus.Name = "checkBoxWriteOffBonus";
            this.checkBoxWriteOffBonus.Size = new System.Drawing.Size(225, 33);
            this.checkBoxWriteOffBonus.TabIndex = 9;
            this.checkBoxWriteOffBonus.Text = "Списать бонусы";
            this.checkBoxWriteOffBonus.UseVisualStyleBackColor = true;
            this.checkBoxWriteOffBonus.Visible = false;
            this.checkBoxWriteOffBonus.CheckedChanged += new System.EventHandler(this.checkBoxWriteOffBonus_CheckedChanged);
            // 
            // FormTuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxWriteOffBonus);
            this.Controls.Add(this.labelPriceSale);
            this.Controls.Add(this.labelBonus);
            this.Controls.Add(this.comboBoxCard);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.textBoxLiter);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.comboBoxColumns);
            this.Controls.Add(this.comboBoxStations);
            this.Name = "FormTuck";
            this.Text = "Заправка";
            this.Load += new System.EventHandler(this.FormTuck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStations;
        private System.Windows.Forms.ComboBox comboBoxColumns;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.TextBox textBoxLiter;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxCard;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.Label labelPriceSale;
        private System.Windows.Forms.CheckBox checkBoxWriteOffBonus;
    }
}