
namespace OnlineBookStore
{
    partial class FormMainPage
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
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.btnMagazines = new System.Windows.Forms.Button();
            this.btnMusicCDs = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMyPage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelProductDisplay = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.BackColor = System.Drawing.Color.PowderBlue;
            this.btnShoppingCart.FlatAppearance.BorderSize = 0;
            this.btnShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoppingCart.Location = new System.Drawing.Point(9, 356);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(155, 79);
            this.btnShoppingCart.TabIndex = 6;
            this.btnShoppingCart.Text = "Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = false;
            // 
            // btnMagazines
            // 
            this.btnMagazines.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMagazines.FlatAppearance.BorderSize = 0;
            this.btnMagazines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagazines.Location = new System.Drawing.Point(9, 272);
            this.btnMagazines.Name = "btnMagazines";
            this.btnMagazines.Size = new System.Drawing.Size(155, 79);
            this.btnMagazines.TabIndex = 5;
            this.btnMagazines.Text = "Magazines";
            this.btnMagazines.UseVisualStyleBackColor = false;
            this.btnMagazines.Click += new System.EventHandler(this.btnMagazines_Click);
            // 
            // btnMusicCDs
            // 
            this.btnMusicCDs.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMusicCDs.FlatAppearance.BorderSize = 0;
            this.btnMusicCDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicCDs.Location = new System.Drawing.Point(9, 188);
            this.btnMusicCDs.Name = "btnMusicCDs";
            this.btnMusicCDs.Size = new System.Drawing.Size(155, 79);
            this.btnMusicCDs.TabIndex = 4;
            this.btnMusicCDs.Text = "Music CDs";
            this.btnMusicCDs.UseVisualStyleBackColor = false;
            this.btnMusicCDs.Click += new System.EventHandler(this.btnMusicCDs_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Location = new System.Drawing.Point(9, 104);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(155, 79);
            this.btnBooks.TabIndex = 3;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnMyPage
            // 
            this.btnMyPage.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMyPage.FlatAppearance.BorderSize = 0;
            this.btnMyPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPage.Location = new System.Drawing.Point(9, 440);
            this.btnMyPage.Name = "btnMyPage";
            this.btnMyPage.Size = new System.Drawing.Size(155, 79);
            this.btnMyPage.TabIndex = 7;
            this.btnMyPage.Text = "My Page";
            this.btnMyPage.UseVisualStyleBackColor = false;
            this.btnMyPage.Click += new System.EventHandler(this.btnMyPage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnMyPage);
            this.panel3.Controls.Add(this.btnBooks);
            this.panel3.Controls.Add(this.btnShoppingCart);
            this.panel3.Controls.Add(this.btnMusicCDs);
            this.panel3.Controls.Add(this.btnMagazines);
            this.panel3.Location = new System.Drawing.Point(2, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 562);
            this.panel3.TabIndex = 3;
            // 
            // panelProductDisplay
            // 
            this.panelProductDisplay.Location = new System.Drawing.Point(186, 94);
            this.panelProductDisplay.Name = "panelProductDisplay";
            this.panelProductDisplay.Size = new System.Drawing.Size(930, 568);
            this.panelProductDisplay.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 79);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::OnlineBookStore.Properties.Resources.icons8_close_window_64;
            this.pictureBoxExit.Location = new System.Drawing.Point(1016, 12);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(100, 45);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 83);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 674);
            this.Controls.Add(this.panelProductDisplay);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MainPage";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.Button btnMagazines;
        private System.Windows.Forms.Button btnMusicCDs;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Button btnMyPage;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panelProductDisplay;
        private System.Windows.Forms.Button button1;
    }
}