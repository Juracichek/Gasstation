namespace Gasstation.StartForm.Interface
{
    partial class FormCard
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
            this.labelViewCard = new System.Windows.Forms.Label();
            this.labelViewCard1 = new System.Windows.Forms.Label();
            this.labelCountBon = new System.Windows.Forms.Label();
            this.labelCountSale = new System.Windows.Forms.Label();
            this.buttonCheckoutCard = new System.Windows.Forms.Button();
            this.comboBoxSelectCard = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelViewCard
            // 
            this.labelViewCard.AutoSize = true;
            this.labelViewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewCard.Location = new System.Drawing.Point(206, 65);
            this.labelViewCard.Name = "labelViewCard";
            this.labelViewCard.Size = new System.Drawing.Size(92, 32);
            this.labelViewCard.TabIndex = 0;
            this.labelViewCard.Text = "label1";
            // 
            // labelViewCard1
            // 
            this.labelViewCard1.AutoSize = true;
            this.labelViewCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewCard1.Location = new System.Drawing.Point(206, 124);
            this.labelViewCard1.Name = "labelViewCard1";
            this.labelViewCard1.Size = new System.Drawing.Size(92, 32);
            this.labelViewCard1.TabIndex = 1;
            this.labelViewCard1.Text = "label1";
            // 
            // labelCountBon
            // 
            this.labelCountBon.AutoSize = true;
            this.labelCountBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountBon.Location = new System.Drawing.Point(440, 65);
            this.labelCountBon.Name = "labelCountBon";
            this.labelCountBon.Size = new System.Drawing.Size(92, 32);
            this.labelCountBon.TabIndex = 2;
            this.labelCountBon.Text = "label1";
            // 
            // labelCountSale
            // 
            this.labelCountSale.AutoSize = true;
            this.labelCountSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountSale.Location = new System.Drawing.Point(440, 124);
            this.labelCountSale.Name = "labelCountSale";
            this.labelCountSale.Size = new System.Drawing.Size(92, 32);
            this.labelCountSale.TabIndex = 3;
            this.labelCountSale.Text = "label1";
            // 
            // buttonCheckoutCard
            // 
            this.buttonCheckoutCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckoutCard.Location = new System.Drawing.Point(553, 349);
            this.buttonCheckoutCard.Name = "buttonCheckoutCard";
            this.buttonCheckoutCard.Size = new System.Drawing.Size(197, 71);
            this.buttonCheckoutCard.TabIndex = 4;
            this.buttonCheckoutCard.Text = "Оформить карту";
            this.buttonCheckoutCard.UseVisualStyleBackColor = true;
            this.buttonCheckoutCard.Visible = false;
            this.buttonCheckoutCard.Click += new System.EventHandler(this.buttonCheckoutCard_Click);
            // 
            // comboBoxSelectCard
            // 
            this.comboBoxSelectCard.FormattingEnabled = true;
            this.comboBoxSelectCard.Location = new System.Drawing.Point(303, 373);
            this.comboBoxSelectCard.Name = "comboBoxSelectCard";
            this.comboBoxSelectCard.Size = new System.Drawing.Size(215, 28);
            this.comboBoxSelectCard.TabIndex = 5;
            this.comboBoxSelectCard.Visible = false;
            // 
            // FormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSelectCard);
            this.Controls.Add(this.buttonCheckoutCard);
            this.Controls.Add(this.labelCountSale);
            this.Controls.Add(this.labelCountBon);
            this.Controls.Add(this.labelViewCard1);
            this.Controls.Add(this.labelViewCard);
            this.Name = "FormCard";
            this.Text = "Бонусная программа";
            this.Load += new System.EventHandler(this.FormCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelViewCard;
        private System.Windows.Forms.Label labelViewCard1;
        private System.Windows.Forms.Label labelCountBon;
        private System.Windows.Forms.Label labelCountSale;
        private System.Windows.Forms.Button buttonCheckoutCard;
        private System.Windows.Forms.ComboBox comboBoxSelectCard;
    }
}