namespace Assignment2
{
    partial class Assignment_2
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.NumOfFollowLbl = new System.Windows.Forms.Label();
            this.UserSearchButton = new System.Windows.Forms.Button();
            this.userPhotoOutput = new System.Windows.Forms.PictureBox();
            this.photoLbl = new System.Windows.Forms.Label();
            this.nameOutput = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.countryOutput = new System.Windows.Forms.Label();
            this.locationOutput = new System.Windows.Forms.Label();
            this.numOfFollowOutput = new System.Windows.Forms.Label();
            this.Chess_API_User = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(59, 120);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(83, 20);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "Username";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(59, 172);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(59, 217);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(70, 20);
            this.LocationLbl.TabIndex = 2;
            this.LocationLbl.Text = "Location";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Location = new System.Drawing.Point(59, 267);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(64, 20);
            this.CountryLbl.TabIndex = 3;
            this.CountryLbl.Text = "Country";
            // 
            // NumOfFollowLbl
            // 
            this.NumOfFollowLbl.AutoSize = true;
            this.NumOfFollowLbl.Location = new System.Drawing.Point(59, 318);
            this.NumOfFollowLbl.Name = "NumOfFollowLbl";
            this.NumOfFollowLbl.Size = new System.Drawing.Size(154, 20);
            this.NumOfFollowLbl.TabIndex = 4;
            this.NumOfFollowLbl.Text = "Number of Followers";
            // 
            // UserSearchButton
            // 
            this.UserSearchButton.Location = new System.Drawing.Point(146, 620);
            this.UserSearchButton.Name = "UserSearchButton";
            this.UserSearchButton.Size = new System.Drawing.Size(223, 47);
            this.UserSearchButton.TabIndex = 5;
            this.UserSearchButton.Text = "Find User Info";
            this.UserSearchButton.UseVisualStyleBackColor = true;
            this.UserSearchButton.Click += new System.EventHandler(this.UserSearchButton_Click);
            // 
            // userPhotoOutput
            // 
            this.userPhotoOutput.Location = new System.Drawing.Point(291, 363);
            this.userPhotoOutput.Name = "userPhotoOutput";
            this.userPhotoOutput.Size = new System.Drawing.Size(191, 163);
            this.userPhotoOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userPhotoOutput.TabIndex = 11;
            this.userPhotoOutput.TabStop = false;
            // 
            // photoLbl
            // 
            this.photoLbl.AutoSize = true;
            this.photoLbl.Location = new System.Drawing.Point(59, 363);
            this.photoLbl.Name = "photoLbl";
            this.photoLbl.Size = new System.Drawing.Size(106, 40);
            this.photoLbl.TabIndex = 12;
            this.photoLbl.Text = "User Photo\r\n(If Applicable)";
            // 
            // nameOutput
            // 
            this.nameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameOutput.Location = new System.Drawing.Point(291, 172);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(191, 20);
            this.nameOutput.TabIndex = 13;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(290, 120);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(192, 26);
            this.userNameInput.TabIndex = 6;
            // 
            // countryOutput
            // 
            this.countryOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countryOutput.Location = new System.Drawing.Point(291, 267);
            this.countryOutput.Name = "countryOutput";
            this.countryOutput.Size = new System.Drawing.Size(191, 20);
            this.countryOutput.TabIndex = 16;
            // 
            // locationOutput
            // 
            this.locationOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationOutput.Location = new System.Drawing.Point(291, 217);
            this.locationOutput.Name = "locationOutput";
            this.locationOutput.Size = new System.Drawing.Size(191, 20);
            this.locationOutput.TabIndex = 17;
            // 
            // numOfFollowOutput
            // 
            this.numOfFollowOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfFollowOutput.Location = new System.Drawing.Point(290, 318);
            this.numOfFollowOutput.Name = "numOfFollowOutput";
            this.numOfFollowOutput.Size = new System.Drawing.Size(192, 21);
            this.numOfFollowOutput.TabIndex = 18;
            // 
            // Chess_API_User
            // 
            this.Chess_API_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chess_API_User.Location = new System.Drawing.Point(63, 19);
            this.Chess_API_User.Name = "Chess_API_User";
            this.Chess_API_User.Size = new System.Drawing.Size(419, 51);
            this.Chess_API_User.TabIndex = 19;
            this.Chess_API_User.Text = "Chess.com User";
            this.Chess_API_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Assignment_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 685);
            this.Controls.Add(this.Chess_API_User);
            this.Controls.Add(this.numOfFollowOutput);
            this.Controls.Add(this.locationOutput);
            this.Controls.Add(this.countryOutput);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.photoLbl);
            this.Controls.Add(this.userPhotoOutput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.UserSearchButton);
            this.Controls.Add(this.NumOfFollowLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.userNameLbl);
            this.Name = "Assignment_2";
            this.Text = "Chess API ";
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label NumOfFollowLbl;
        private System.Windows.Forms.Button UserSearchButton;
        private System.Windows.Forms.PictureBox userPhotoOutput;
        private System.Windows.Forms.Label photoLbl;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Label countryOutput;
        private System.Windows.Forms.Label locationOutput;
        private System.Windows.Forms.Label numOfFollowOutput;
        private System.Windows.Forms.Label Chess_API_User;
    }
}

