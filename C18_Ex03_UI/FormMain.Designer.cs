namespace C18_Ex03_UI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.listBoxFriendsList = new C18_Ex03_UI.MyListBox();
            this.labelPrivateNameText = new System.Windows.Forms.Label();
            this.labelFamilyNameText = new System.Windows.Forms.Label();
            this.labelBirthdayText = new System.Windows.Forms.Label();
            this.labelGenderText = new System.Windows.Forms.Label();
            this.listBoxEvents = new C18_Ex03_UI.MyListBox();
            this.listBoxLikedPages = new C18_Ex03_UI.MyListBox();
            this.buttonLogOut = new C18_Ex03_UI.MyButton();
            this.listBoxTaggedPosts = new C18_Ex03_UI.MyListBox();
            this.buttonSearchFriends = new System.Windows.Forms.Button();
            this.listBoxStatuses = new C18_Ex03_UI.MyListBox();
            this.buttonMostPopularPagesF = new C18_Ex03_UI.MyButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFamilyName = new System.Windows.Forms.Label();
            this.labelPrivateName = new System.Windows.Forms.Label();
            this.buttonLogIn = new C18_Ex03_UI.MyButton();
            this.textBoxPostStatus = new C18_Ex03_UI.MyTextBox();
            this.buttonPostStatus = new C18_Ex03_UI.MyButton();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEmailText = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxMyPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxEventPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new C18_Ex03_UI.MyButton();
            this.buttonNext = new C18_Ex03_UI.MyButton();
            this.buttonLikestPhotoInAlbum = new C18_Ex03_UI.MyButton();
            this.labelEvents = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelTaggedPosts = new System.Windows.Forms.Label();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.listBoxBinding = new C18_Ex03_UI.MyListBox();
            this.editAbleFriendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBinding = new System.Windows.Forms.Panel();
            this.myButtonDone = new C18_Ex03_UI.MyButton();
            this.labelPanel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new C18_Ex03_UI.MyTextBox();
            this.lastNameTextBox = new C18_Ex03_UI.MyTextBox();
            this.buttonEditFriendsNames = new System.Windows.Forms.Button();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.labelShowPhotos = new System.Windows.Forms.Label();
            this.myButtonSlideShow = new C18_Ex03_UI.MyButton();
            this.myButtonEndSlideShow = new C18_Ex03_UI.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editAbleFriendBindingSource)).BeginInit();
            this.panelBinding.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(11, 99);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 147);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxFriendsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxFriendsList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 36;
            this.listBoxFriendsList.Location = new System.Drawing.Point(54, 976);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(396, 508);
            this.listBoxFriendsList.TabIndex = 2;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // labelPrivateNameText
            // 
            this.labelPrivateNameText.AutoSize = true;
            this.labelPrivateNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrivateNameText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPrivateNameText.Location = new System.Drawing.Point(463, 188);
            this.labelPrivateNameText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrivateNameText.Name = "labelPrivateNameText";
            this.labelPrivateNameText.Size = new System.Drawing.Size(262, 44);
            this.labelPrivateNameText.TabIndex = 4;
            this.labelPrivateNameText.Text = "Private Name:";
            // 
            // labelFamilyNameText
            // 
            this.labelFamilyNameText.AutoSize = true;
            this.labelFamilyNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamilyNameText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFamilyNameText.Location = new System.Drawing.Point(463, 232);
            this.labelFamilyNameText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFamilyNameText.Name = "labelFamilyNameText";
            this.labelFamilyNameText.Size = new System.Drawing.Size(257, 44);
            this.labelFamilyNameText.TabIndex = 5;
            this.labelFamilyNameText.Text = "Family Name:";
            // 
            // labelBirthdayText
            // 
            this.labelBirthdayText.AutoSize = true;
            this.labelBirthdayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelBirthdayText.Location = new System.Drawing.Point(463, 320);
            this.labelBirthdayText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBirthdayText.Name = "labelBirthdayText";
            this.labelBirthdayText.Size = new System.Drawing.Size(171, 44);
            this.labelBirthdayText.TabIndex = 7;
            this.labelBirthdayText.Text = "Birthday:";
            // 
            // labelGenderText
            // 
            this.labelGenderText.AutoSize = true;
            this.labelGenderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenderText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelGenderText.Location = new System.Drawing.Point(463, 369);
            this.labelGenderText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelGenderText.Name = "labelGenderText";
            this.labelGenderText.Size = new System.Drawing.Size(158, 44);
            this.labelGenderText.TabIndex = 8;
            this.labelGenderText.Text = "Gender:";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxEvents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 36;
            this.listBoxEvents.Location = new System.Drawing.Point(1372, 236);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(296, 400);
            this.listBoxEvents.TabIndex = 10;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxLikedPages.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 36;
            this.listBoxLikedPages.Location = new System.Drawing.Point(2009, 236);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(1);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(296, 400);
            this.listBoxLikedPages.TabIndex = 12;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLogOut.Enabled = false;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLogOut.Location = new System.Drawing.Point(815, 57);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(349, 84);
            this.buttonLogOut.TabIndex = 14;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // listBoxTaggedPosts
            // 
            this.listBoxTaggedPosts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxTaggedPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxTaggedPosts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxTaggedPosts.FormattingEnabled = true;
            this.listBoxTaggedPosts.ItemHeight = 36;
            this.listBoxTaggedPosts.Location = new System.Drawing.Point(1692, 236);
            this.listBoxTaggedPosts.Name = "listBoxTaggedPosts";
            this.listBoxTaggedPosts.Size = new System.Drawing.Size(296, 400);
            this.listBoxTaggedPosts.TabIndex = 15;
            // 
            // buttonSearchFriends
            // 
            this.buttonSearchFriends.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSearchFriends.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSearchFriends.Enabled = false;
            this.buttonSearchFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchFriends.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonSearchFriends.Location = new System.Drawing.Point(471, 976);
            this.buttonSearchFriends.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchFriends.Name = "buttonSearchFriends";
            this.buttonSearchFriends.Size = new System.Drawing.Size(257, 115);
            this.buttonSearchFriends.TabIndex = 19;
            this.buttonSearchFriends.Text = "Search Friends";
            this.buttonSearchFriends.UseVisualStyleBackColor = false;
            this.buttonSearchFriends.Click += new System.EventHandler(this.buttonSearchFriends_Click);
            // 
            // listBoxStatuses
            // 
            this.listBoxStatuses.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxStatuses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxStatuses.FormattingEnabled = true;
            this.listBoxStatuses.ItemHeight = 36;
            this.listBoxStatuses.Location = new System.Drawing.Point(57, 659);
            this.listBoxStatuses.Name = "listBoxStatuses";
            this.listBoxStatuses.Size = new System.Drawing.Size(922, 220);
            this.listBoxStatuses.TabIndex = 21;
            // 
            // buttonMostPopularPagesF
            // 
            this.buttonMostPopularPagesF.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonMostPopularPagesF.Enabled = false;
            this.buttonMostPopularPagesF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostPopularPagesF.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonMostPopularPagesF.Location = new System.Drawing.Point(1838, 675);
            this.buttonMostPopularPagesF.Name = "buttonMostPopularPagesF";
            this.buttonMostPopularPagesF.Size = new System.Drawing.Size(467, 149);
            this.buttonMostPopularPagesF.TabIndex = 26;
            this.buttonMostPopularPagesF.Text = "Discovered top three most popular page categories among your friend list";
            this.buttonMostPopularPagesF.UseVisualStyleBackColor = false;
            this.buttonMostPopularPagesF.Click += new System.EventHandler(this.buttonMostPopularPagesF_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGender.Location = new System.Drawing.Point(623, 369);
            this.labelGender.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(33, 44);
            this.labelGender.TabIndex = 30;
            this.labelGender.Text = "-";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelBirthday.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBirthday.Location = new System.Drawing.Point(636, 320);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(33, 44);
            this.labelBirthday.TabIndex = 29;
            this.labelBirthday.Text = "-";
            // 
            // labelFamilyName
            // 
            this.labelFamilyName.AutoSize = true;
            this.labelFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelFamilyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFamilyName.Location = new System.Drawing.Point(722, 232);
            this.labelFamilyName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFamilyName.Name = "labelFamilyName";
            this.labelFamilyName.Size = new System.Drawing.Size(33, 44);
            this.labelFamilyName.TabIndex = 28;
            this.labelFamilyName.Text = "-";
            // 
            // labelPrivateName
            // 
            this.labelPrivateName.AutoSize = true;
            this.labelPrivateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPrivateName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrivateName.Location = new System.Drawing.Point(722, 188);
            this.labelPrivateName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrivateName.Name = "labelPrivateName";
            this.labelPrivateName.Size = new System.Drawing.Size(33, 44);
            this.labelPrivateName.TabIndex = 27;
            this.labelPrivateName.Text = "-";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLogIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLogIn.Location = new System.Drawing.Point(471, 57);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(349, 84);
            this.buttonLogIn.TabIndex = 31;
            this.buttonLogIn.Text = "LogIn";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Enabled = false;
            this.textBoxPostStatus.Location = new System.Drawing.Point(57, 551);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(922, 38);
            this.textBoxPostStatus.TabIndex = 33;
            this.textBoxPostStatus.Text = "What is in your mind?";
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPostStatus.Enabled = false;
            this.buttonPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonPostStatus.Location = new System.Drawing.Point(57, 485);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(257, 62);
            this.buttonPostStatus.TabIndex = 34;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = false;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmail.Location = new System.Drawing.Point(593, 276);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(33, 44);
            this.labelEmail.TabIndex = 36;
            this.labelEmail.Text = "-";
            // 
            // labelEmailText
            // 
            this.labelEmailText.AutoSize = true;
            this.labelEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEmailText.Location = new System.Drawing.Point(463, 276);
            this.labelEmailText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmailText.Name = "labelEmailText";
            this.labelEmailText.Size = new System.Drawing.Size(128, 44);
            this.labelEmailText.TabIndex = 35;
            this.labelEmailText.Text = "Email:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Font = new System.Drawing.Font("Guttman-CourMir", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTitle.Location = new System.Drawing.Point(30, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(340, 88);
            this.labelTitle.TabIndex = 41;
            this.labelTitle.Text = "Facebook";
            // 
            // pictureBoxMyPicture
            // 
            this.pictureBoxMyPicture.BackColor = System.Drawing.Color.OldLace;
            this.pictureBoxMyPicture.Location = new System.Drawing.Point(1372, 984);
            this.pictureBoxMyPicture.Name = "pictureBoxMyPicture";
            this.pictureBoxMyPicture.Size = new System.Drawing.Size(933, 500);
            this.pictureBoxMyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyPicture.TabIndex = 37;
            this.pictureBoxMyPicture.TabStop = false;
            // 
            // pictureBoxFriendPicture
            // 
            this.pictureBoxFriendPicture.BackColor = System.Drawing.Color.OldLace;
            this.pictureBoxFriendPicture.Location = new System.Drawing.Point(471, 1113);
            this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
            this.pictureBoxFriendPicture.Size = new System.Drawing.Size(257, 200);
            this.pictureBoxFriendPicture.TabIndex = 18;
            this.pictureBoxFriendPicture.TabStop = false;
            // 
            // pictureBoxEventPicture
            // 
            this.pictureBoxEventPicture.BackColor = System.Drawing.Color.OldLace;
            this.pictureBoxEventPicture.Location = new System.Drawing.Point(1517, 531);
            this.pictureBoxEventPicture.Name = "pictureBoxEventPicture";
            this.pictureBoxEventPicture.Size = new System.Drawing.Size(169, 128);
            this.pictureBoxEventPicture.TabIndex = 17;
            this.pictureBoxEventPicture.TabStop = false;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(57, 185);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(393, 294);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 1;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.LightGray;
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(1310, 1368);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(126, 118);
            this.buttonPrev.TabIndex = 50;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightGray;
            this.buttonNext.Enabled = false;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(2241, 1368);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(126, 118);
            this.buttonNext.TabIndex = 51;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLikestPhotoInAlbum
            // 
            this.buttonLikestPhotoInAlbum.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLikestPhotoInAlbum.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLikestPhotoInAlbum.Enabled = false;
            this.buttonLikestPhotoInAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLikestPhotoInAlbum.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLikestPhotoInAlbum.Location = new System.Drawing.Point(1372, 675);
            this.buttonLikestPhotoInAlbum.Name = "buttonLikestPhotoInAlbum";
            this.buttonLikestPhotoInAlbum.Size = new System.Drawing.Size(469, 149);
            this.buttonLikestPhotoInAlbum.TabIndex = 52;
            this.buttonLikestPhotoInAlbum.Text = "Press To See The Likest Photos In Your Albums";
            this.buttonLikestPhotoInAlbum.UseVisualStyleBackColor = false;
            this.buttonLikestPhotoInAlbum.Click += new System.EventHandler(this.buttonLikestPhotoInAlbum_Click);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelEvents.Location = new System.Drawing.Point(1364, 189);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(136, 44);
            this.labelEvents.TabIndex = 53;
            this.labelEvents.Text = "Events";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFriends.Location = new System.Drawing.Point(49, 931);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(147, 44);
            this.labelFriends.TabIndex = 54;
            this.labelFriends.Text = "Friends";
            // 
            // labelTaggedPosts
            // 
            this.labelTaggedPosts.AutoSize = true;
            this.labelTaggedPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaggedPosts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTaggedPosts.Location = new System.Drawing.Point(1684, 191);
            this.labelTaggedPosts.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTaggedPosts.Name = "labelTaggedPosts";
            this.labelTaggedPosts.Size = new System.Drawing.Size(253, 44);
            this.labelTaggedPosts.TabIndex = 55;
            this.labelTaggedPosts.Text = "Tagged Posts";
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikedPages.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLikedPages.Location = new System.Drawing.Point(2001, 191);
            this.labelLikedPages.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(228, 44);
            this.labelLikedPages.TabIndex = 56;
            this.labelLikedPages.Text = "Liked Pages";
            // 
            // listBoxBinding
            // 
            this.listBoxBinding.DataSource = this.editAbleFriendBindingSource;
            this.listBoxBinding.DisplayMember = "FullName";
            this.listBoxBinding.FormattingEnabled = true;
            this.listBoxBinding.ItemHeight = 31;
            this.listBoxBinding.Location = new System.Drawing.Point(11, 202);
            this.listBoxBinding.Name = "listBoxBinding";
            this.listBoxBinding.Size = new System.Drawing.Size(434, 283);
            this.listBoxBinding.TabIndex = 57;
            // 
            // editAbleFriendBindingSource
            // 
            this.editAbleFriendBindingSource.DataSource = typeof(C18_Ex03_Logic.EditAbleFriend);
            // 
            // panelBinding
            // 
            this.panelBinding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBinding.Controls.Add(this.myButtonDone);
            this.panelBinding.Controls.Add(this.labelPanel);
            this.panelBinding.Controls.Add(this.firstNameLabel);
            this.panelBinding.Controls.Add(this.firstNameTextBox);
            this.panelBinding.Controls.Add(this.lastNameLabel);
            this.panelBinding.Controls.Add(this.lastNameTextBox);
            this.panelBinding.Controls.Add(this.listBoxBinding);
            this.panelBinding.Enabled = false;
            this.panelBinding.Location = new System.Drawing.Point(754, 915);
            this.panelBinding.Name = "panelBinding";
            this.panelBinding.Size = new System.Drawing.Size(462, 569);
            this.panelBinding.TabIndex = 58;
            // 
            // myButtonDone
            // 
            this.myButtonDone.BackColor = System.Drawing.Color.SteelBlue;
            this.myButtonDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonDone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.myButtonDone.Location = new System.Drawing.Point(176, 491);
            this.myButtonDone.Name = "myButtonDone";
            this.myButtonDone.Size = new System.Drawing.Size(269, 62);
            this.myButtonDone.TabIndex = 65;
            this.myButtonDone.Text = "Done";
            this.myButtonDone.UseVisualStyleBackColor = false;
            this.myButtonDone.Click += new System.EventHandler(this.myButtonDone_Click);
            // 
            // labelPanel
            // 
            this.labelPanel.AutoSize = true;
            this.labelPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanel.Location = new System.Drawing.Point(9, 17);
            this.labelPanel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(330, 44);
            this.labelPanel.TabIndex = 65;
            this.labelPanel.Text = "Choose Nickname";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editAbleFriendBindingSource, "FirstName", true));
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(176, 96);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(269, 38);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editAbleFriendBindingSource, "LastName", true));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(176, 141);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(269, 38);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // buttonEditFriendsNames
            // 
            this.buttonEditFriendsNames.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEditFriendsNames.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEditFriendsNames.Enabled = false;
            this.buttonEditFriendsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditFriendsNames.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonEditFriendsNames.Location = new System.Drawing.Point(468, 1327);
            this.buttonEditFriendsNames.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEditFriendsNames.Name = "buttonEditFriendsNames";
            this.buttonEditFriendsNames.Size = new System.Drawing.Size(257, 157);
            this.buttonEditFriendsNames.TabIndex = 62;
            this.buttonEditFriendsNames.Text = "Give Your Friends some Nicknames!";
            this.buttonEditFriendsNames.UseVisualStyleBackColor = false;
            this.buttonEditFriendsNames.Click += new System.EventHandler(this.buttonEditFriendsNames_Click);
            // 
            // labelStatusText
            // 
            this.labelStatusText.AutoSize = true;
            this.labelStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelStatusText.Location = new System.Drawing.Point(49, 612);
            this.labelStatusText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(168, 44);
            this.labelStatusText.TabIndex = 63;
            this.labelStatusText.Text = "Statuses";
            // 
            // labelShowPhotos
            // 
            this.labelShowPhotos.AutoSize = true;
            this.labelShowPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowPhotos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelShowPhotos.Location = new System.Drawing.Point(1364, 937);
            this.labelShowPhotos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelShowPhotos.Name = "labelShowPhotos";
            this.labelShowPhotos.Size = new System.Drawing.Size(393, 44);
            this.labelShowPhotos.TabIndex = 64;
            this.labelShowPhotos.Text = "Photos You Tagged In";
            // 
            // myButtonSlideShow
            // 
            this.myButtonSlideShow.BackColor = System.Drawing.Color.SteelBlue;
            this.myButtonSlideShow.Enabled = false;
            this.myButtonSlideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonSlideShow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.myButtonSlideShow.Location = new System.Drawing.Point(1793, 931);
            this.myButtonSlideShow.Name = "myButtonSlideShow";
            this.myButtonSlideShow.Size = new System.Drawing.Size(257, 55);
            this.myButtonSlideShow.TabIndex = 65;
            this.myButtonSlideShow.Text = "Slide Show";
            this.myButtonSlideShow.UseVisualStyleBackColor = false;
            this.myButtonSlideShow.Click += new System.EventHandler(this.myButtonSlideShow_Click);
            // 
            // myButtonEndSlideShow
            // 
            this.myButtonEndSlideShow.BackColor = System.Drawing.Color.SteelBlue;
            this.myButtonEndSlideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButtonEndSlideShow.ForeColor = System.Drawing.SystemColors.Desktop;
            this.myButtonEndSlideShow.Location = new System.Drawing.Point(2048, 931);
            this.myButtonEndSlideShow.Name = "myButtonEndSlideShow";
            this.myButtonEndSlideShow.Size = new System.Drawing.Size(257, 55);
            this.myButtonEndSlideShow.TabIndex = 66;
            this.myButtonEndSlideShow.Text = "End Slide Show";
            this.myButtonEndSlideShow.UseVisualStyleBackColor = false;
            this.myButtonEndSlideShow.Click += new System.EventHandler(this.myButtonEndSlideShow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2482, 1520);
            this.Controls.Add(this.myButtonEndSlideShow);
            this.Controls.Add(this.myButtonSlideShow);
            this.Controls.Add(this.labelShowPhotos);
            this.Controls.Add(this.labelStatusText);
            this.Controls.Add(this.buttonEditFriendsNames);
            this.Controls.Add(this.panelBinding);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.labelTaggedPosts);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.buttonLikestPhotoInAlbum);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxMyPicture);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEmailText);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelFamilyName);
            this.Controls.Add(this.labelPrivateName);
            this.Controls.Add(this.buttonMostPopularPagesF);
            this.Controls.Add(this.listBoxStatuses);
            this.Controls.Add(this.buttonSearchFriends);
            this.Controls.Add(this.pictureBoxFriendPicture);
            this.Controls.Add(this.pictureBoxEventPicture);
            this.Controls.Add(this.listBoxTaggedPosts);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.labelGenderText);
            this.Controls.Add(this.labelBirthdayText);
            this.Controls.Add(this.labelFamilyNameText);
            this.Controls.Add(this.labelPrivateNameText);
            this.Controls.Add(this.listBoxFriendsList);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editAbleFriendBindingSource)).EndInit();
            this.panelBinding.ResumeLayout(false);
            this.panelBinding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private MyListBox listBoxFriendsList;
        private System.Windows.Forms.Label labelPrivateNameText;
        private System.Windows.Forms.Label labelFamilyNameText;
        private System.Windows.Forms.Label labelBirthdayText;
        private System.Windows.Forms.Label labelGenderText;
        private MyListBox listBoxEvents;
        private MyListBox listBoxLikedPages;
        private C18_Ex03_UI.MyButton buttonLogOut;
        private MyListBox listBoxTaggedPosts;
        private System.Windows.Forms.PictureBox pictureBoxEventPicture;
        private System.Windows.Forms.PictureBox pictureBoxFriendPicture;
        private System.Windows.Forms.Button buttonSearchFriends;
        private MyListBox listBoxStatuses;
        private C18_Ex03_UI.MyButton buttonMostPopularPagesF;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelFamilyName;
        private System.Windows.Forms.Label labelPrivateName;
        private C18_Ex03_UI.MyButton buttonLogIn;
        private MyTextBox textBoxPostStatus;
        private C18_Ex03_UI.MyButton buttonPostStatus;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEmailText;
        private System.Windows.Forms.PictureBox pictureBoxMyPicture;
        private System.Windows.Forms.Label labelTitle;
        private C18_Ex03_UI.MyButton buttonPrev;
        private C18_Ex03_UI.MyButton buttonNext;
        private C18_Ex03_UI.MyButton buttonLikestPhotoInAlbum;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelTaggedPosts;
        private System.Windows.Forms.Label labelLikedPages;
        private MyListBox listBoxBinding;
        private System.Windows.Forms.Panel panelBinding;
        private System.Windows.Forms.Button buttonEditFriendsNames;
        private System.Windows.Forms.BindingSource editAbleFriendBindingSource;
        private MyTextBox firstNameTextBox;
        private MyTextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Label labelShowPhotos;
        private System.Windows.Forms.Label labelPanel;
        private MyButton myButtonDone;
        private MyButton myButtonSlideShow;
        private MyButton myButtonEndSlideShow;
    }
}

