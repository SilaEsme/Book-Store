
namespace OnlineBookStore
{
    partial class UserControlMusicCD
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
            this.btnReadMore = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBoxMusicCD = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicCD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadMore
            // 
            this.btnReadMore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadMore.FlatAppearance.BorderSize = 0;
            this.btnReadMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadMore.Location = new System.Drawing.Point(30, 231);
            this.btnReadMore.Name = "btnReadMore";
            this.btnReadMore.Size = new System.Drawing.Size(164, 46);
            this.btnReadMore.TabIndex = 21;
            this.btnReadMore.Text = "Read More";
            this.btnReadMore.UseVisualStyleBackColor = false;
            this.btnReadMore.Click += new System.EventHandler(this.btnReadMore_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(3, 195);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(225, 24);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMusicCD
            // 
            this.pictureBoxMusicCD.Location = new System.Drawing.Point(30, 17);
            this.pictureBoxMusicCD.Name = "pictureBoxMusicCD";
            this.pictureBoxMusicCD.Size = new System.Drawing.Size(164, 121);
            this.pictureBoxMusicCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMusicCD.TabIndex = 19;
            this.pictureBoxMusicCD.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(0, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(230, 24);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlMusicCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReadMore);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureBoxMusicCD);
            this.Controls.Add(this.lblName);
            this.Name = "UserControlMusicCD";
            this.Size = new System.Drawing.Size(230, 292);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMusicCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadMore;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBoxMusicCD;
        private System.Windows.Forms.Label lblName;
    }
}
