
namespace OnlineBookStore
{
    partial class UserControlChangeInformations
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
            this.lblUsernameH = new System.Windows.Forms.Label();
            this.lblAddressH = new System.Windows.Forms.Label();
            this.lblEMailH = new System.Windows.Forms.Label();
            this.lblSurnameH = new System.Windows.Forms.Label();
            this.lblNameH = new System.Windows.Forms.Label();
            this.pictureBoxCustomer = new System.Windows.Forms.PictureBox();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblInfoUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsernameH
            // 
            this.lblUsernameH.AutoSize = true;
            this.lblUsernameH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsernameH.Location = new System.Drawing.Point(462, 345);
            this.lblUsernameH.Name = "lblUsernameH";
            this.lblUsernameH.Size = new System.Drawing.Size(100, 20);
            this.lblUsernameH.TabIndex = 18;
            this.lblUsernameH.Text = "Username:";
            // 
            // lblAddressH
            // 
            this.lblAddressH.AutoSize = true;
            this.lblAddressH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddressH.Location = new System.Drawing.Point(478, 291);
            this.lblAddressH.Name = "lblAddressH";
            this.lblAddressH.Size = new System.Drawing.Size(84, 20);
            this.lblAddressH.TabIndex = 17;
            this.lblAddressH.Text = "Address:";
            // 
            // lblEMailH
            // 
            this.lblEMailH.AutoSize = true;
            this.lblEMailH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMailH.Location = new System.Drawing.Point(493, 237);
            this.lblEMailH.Name = "lblEMailH";
            this.lblEMailH.Size = new System.Drawing.Size(69, 20);
            this.lblEMailH.TabIndex = 16;
            this.lblEMailH.Text = "E-Mail:";
            // 
            // lblSurnameH
            // 
            this.lblSurnameH.AutoSize = true;
            this.lblSurnameH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurnameH.Location = new System.Drawing.Point(473, 183);
            this.lblSurnameH.Name = "lblSurnameH";
            this.lblSurnameH.Size = new System.Drawing.Size(89, 20);
            this.lblSurnameH.TabIndex = 15;
            this.lblSurnameH.Text = "Surname:";
            // 
            // lblNameH
            // 
            this.lblNameH.AutoSize = true;
            this.lblNameH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameH.Location = new System.Drawing.Point(499, 129);
            this.lblNameH.Name = "lblNameH";
            this.lblNameH.Size = new System.Drawing.Size(63, 20);
            this.lblNameH.TabIndex = 14;
            this.lblNameH.Text = "Name:";
            // 
            // pictureBoxCustomer
            // 
            this.pictureBoxCustomer.Location = new System.Drawing.Point(69, 107);
            this.pictureBoxCustomer.Name = "pictureBoxCustomer";
            this.pictureBoxCustomer.Size = new System.Drawing.Size(267, 284);
            this.pictureBoxCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCustomer.TabIndex = 13;
            this.pictureBoxCustomer.TabStop = false;
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateImage.FlatAppearance.BorderSize = 0;
            this.btnUpdateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateImage.Location = new System.Drawing.Point(105, 425);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(194, 54);
            this.btnUpdateImage.TabIndex = 25;
            this.btnUpdateImage.Text = "Update Image";
            this.btnUpdateImage.UseVisualStyleBackColor = false;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.Location = new System.Drawing.Point(597, 425);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(233, 54);
            this.btnUpdateInfo.TabIndex = 19;
            this.btnUpdateInfo.Text = "Update My Informations";
            this.btnUpdateInfo.UseVisualStyleBackColor = false;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(597, 110);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(233, 39);
            this.txtname.TabIndex = 27;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(597, 165);
            this.txtsurname.Multiline = true;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(233, 39);
            this.txtsurname.TabIndex = 28;
            this.txtsurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(597, 220);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(233, 39);
            this.txtemail.TabIndex = 29;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(597, 275);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(233, 39);
            this.txtaddress.TabIndex = 30;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(597, 330);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(233, 39);
            this.txtusername.TabIndex = 31;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(105, 485);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 54);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblInfoUpdate
            // 
            this.lblInfoUpdate.AutoSize = true;
            this.lblInfoUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblInfoUpdate.Location = new System.Drawing.Point(713, 504);
            this.lblInfoUpdate.Name = "lblInfoUpdate";
            this.lblInfoUpdate.Size = new System.Drawing.Size(0, 17);
            this.lblInfoUpdate.TabIndex = 33;
            this.lblInfoUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlChangeInformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfoUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.lblUsernameH);
            this.Controls.Add(this.lblAddressH);
            this.Controls.Add(this.lblEMailH);
            this.Controls.Add(this.lblSurnameH);
            this.Controls.Add(this.lblNameH);
            this.Controls.Add(this.pictureBoxCustomer);
            this.Name = "UserControlChangeInformations";
            this.Size = new System.Drawing.Size(893, 580);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsernameH;
        private System.Windows.Forms.Label lblAddressH;
        private System.Windows.Forms.Label lblEMailH;
        private System.Windows.Forms.Label lblSurnameH;
        private System.Windows.Forms.Label lblNameH;
        private System.Windows.Forms.PictureBox pictureBoxCustomer;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblInfoUpdate;
    }
}
