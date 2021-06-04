
namespace OnlineBookStore
{
    partial class UserControlMy_OrderList
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
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblOrderNoH = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalPriceH = new System.Windows.Forms.Label();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderNo.Location = new System.Drawing.Point(6, 50);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(106, 24);
            this.lblOrderNo.TabIndex = 34;
            this.lblOrderNo.Text = "2523226237";
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderNoH
            // 
            this.lblOrderNoH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderNoH.Location = new System.Drawing.Point(4, 26);
            this.lblOrderNoH.Name = "lblOrderNoH";
            this.lblOrderNoH.Size = new System.Drawing.Size(108, 24);
            this.lblOrderNoH.TabIndex = 33;
            this.lblOrderNoH.Text = "Order Number:";
            this.lblOrderNoH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(213, 50);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(74, 24);
            this.lblTotalPrice.TabIndex = 30;
            this.lblTotalPrice.Text = "500";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceH
            // 
            this.lblTotalPriceH.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceH.Location = new System.Drawing.Point(211, 26);
            this.lblTotalPriceH.Name = "lblTotalPriceH";
            this.lblTotalPriceH.Size = new System.Drawing.Size(76, 24);
            this.lblTotalPriceH.TabIndex = 29;
            this.lblTotalPriceH.Text = "Total Price:";
            this.lblTotalPriceH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewDetails.Location = new System.Drawing.Point(301, 32);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(89, 43);
            this.btnViewDetails.TabIndex = 35;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Order Time: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(118, 50);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 24);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "500";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(212, 72);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCancelOrder.TabIndex = 38;
            this.btnCancelOrder.Text = "Cancel";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // UserControlMy_OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.lblOrderNoH);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTotalPriceH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlMy_OrderList";
            this.Size = new System.Drawing.Size(404, 98);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblOrderNoH;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalPriceH;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnCancelOrder;
    }
}
