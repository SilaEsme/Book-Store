﻿
namespace OnlineBookStore
{
    partial class UserControlBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnReadMore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(0, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(230, 38);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(0, 194);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(230, 33);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReadMore
            // 
            this.btnReadMore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Location = new System.Drawing.Point(33, 230);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(164, 46);
            this.btnReadMore.TabIndex = 17;
            this.btnReadMore.Text = "Read More";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 121);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Name = "UserControlBook";
            this.Size = new System.Drawing.Size(230, 292);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnReadMore;
    }
}
