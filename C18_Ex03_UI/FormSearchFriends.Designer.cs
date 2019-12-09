namespace C18_Ex03_UI
{
    partial class FormSearchFriends
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxFriendsListConditon = new System.Windows.Forms.ListBox();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelFirstName.Location = new System.Drawing.Point(33, 77);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(152, 32);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelLastName.Location = new System.Drawing.Point(33, 144);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(151, 32);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelGender.Location = new System.Drawing.Point(33, 225);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(110, 32);
            this.labelGender.TabIndex = 2;
            this.labelGender.Text = "Gender";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(190, 77);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(293, 38);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(190, 144);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(293, 38);
            this.textBoxLastName.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSearch.Location = new System.Drawing.Point(39, 580);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(334, 117);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxFriendsListConditon
            // 
            this.listBoxFriendsListConditon.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxFriendsListConditon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxFriendsListConditon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxFriendsListConditon.FormattingEnabled = true;
            this.listBoxFriendsListConditon.ItemHeight = 36;
            this.listBoxFriendsListConditon.Location = new System.Drawing.Point(768, 77);
            this.listBoxFriendsListConditon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxFriendsListConditon.Name = "listBoxFriendsListConditon";
            this.listBoxFriendsListConditon.Size = new System.Drawing.Size(414, 616);
            this.listBoxFriendsListConditon.TabIndex = 7;
            this.listBoxFriendsListConditon.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsListConditon_SelectedIndexChanged);
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFriendsList.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelFriendsList.Location = new System.Drawing.Point(761, 28);
            this.labelFriendsList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(153, 42);
            this.labelFriendsList.TabIndex = 8;
            this.labelFriendsList.Text = "Friends:";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(190, 225);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(114, 36);
            this.radioButtonMale.TabIndex = 14;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(190, 280);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(147, 36);
            this.radioButtonFemale.TabIndex = 15;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriendPicture
            // 
            this.pictureBoxFriendPicture.BackColor = System.Drawing.Color.OldLace;
            this.pictureBoxFriendPicture.Location = new System.Drawing.Point(407, 358);
            this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
            this.pictureBoxFriendPicture.Size = new System.Drawing.Size(353, 339);
            this.pictureBoxFriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendPicture.TabIndex = 18;
            this.pictureBoxFriendPicture.TabStop = false;
            // 
            // FormSearchFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 738);
            this.Controls.Add(this.pictureBoxFriendPicture);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.labelFriendsList);
            this.Controls.Add(this.listBoxFriendsListConditon);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSearchFriends";
            this.Text = "FormSearchFriends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxFriendsListConditon;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.PictureBox pictureBoxFriendPicture;
    }
}