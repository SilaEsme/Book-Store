
namespace OnlineBookStore
{
    partial class UserControlShoppingCartItem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnDecrase = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNameH = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPriceH = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceH = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 84);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.Location = new System.Drawing.Point(232, 9);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(34, 31);
            this.btnIncrease.TabIndex = 1;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            // 
            // btnDecrase
            // 
            this.btnDecrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrase.Location = new System.Drawing.Point(232, 77);
            this.btnDecrase.Name = "btnDecrase";
            this.btnDecrase.Size = new System.Drawing.Size(34, 31);
            this.btnDecrase.TabIndex = 2;
            this.btnDecrase.Text = "-";
            this.btnDecrase.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(641, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblNameH
            // 
            this.lblNameH.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameH.Location = new System.Drawing.Point(292, 13);
            this.lblNameH.Name = "lblNameH";
            this.lblNameH.Size = new System.Drawing.Size(93, 24);
            this.lblNameH.TabIndex = 4;
            this.lblNameH.Text = "Name";
            this.lblNameH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(391, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(244, 24);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Validenin Günlüğü";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceH
            // 
            this.lblPriceH.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceH.Location = new System.Drawing.Point(292, 45);
            this.lblPriceH.Name = "lblPriceH";
            this.lblPriceH.Size = new System.Drawing.Size(93, 24);
            this.lblPriceH.TabIndex = 6;
            this.lblPriceH.Text = "Price";
            this.lblPriceH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(391, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(244, 24);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "100";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPriceH
            // 
            this.lblTotalPriceH.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceH.Location = new System.Drawing.Point(292, 77);
            this.lblTotalPriceH.Name = "lblTotalPriceH";
            this.lblTotalPriceH.Size = new System.Drawing.Size(93, 24);
            this.lblTotalPriceH.TabIndex = 8;
            this.lblTotalPriceH.Text = "Total Price";
            this.lblTotalPriceH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(391, 76);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(244, 24);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "500";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(231, 43);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(35, 31);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "5";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlShoppingCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPriceH);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceH);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameH);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDecrase);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlShoppingCartItem";
            this.Size = new System.Drawing.Size(692, 118);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrase;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNameH;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPriceH;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPriceH;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalAmount;
    }
}
