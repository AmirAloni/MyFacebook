namespace C18_Ex03_UI
{
    partial class FormLikestPhotoInAlbum
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxTopLikePhoto = new System.Windows.Forms.PictureBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelYourAlbums = new System.Windows.Forms.Label();
            this.labelLikestPhoto = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLikePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.listBoxAlbums.ForeColor = System.Drawing.Color.Black;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 36;
            this.listBoxAlbums.Location = new System.Drawing.Point(40, 191);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(428, 508);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // pictureBoxTopLikePhoto
            // 
            this.pictureBoxTopLikePhoto.BackColor = System.Drawing.Color.OldLace;
            this.pictureBoxTopLikePhoto.Location = new System.Drawing.Point(574, 191);
            this.pictureBoxTopLikePhoto.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBoxTopLikePhoto.Name = "pictureBoxTopLikePhoto";
            this.pictureBoxTopLikePhoto.Size = new System.Drawing.Size(611, 506);
            this.pictureBoxTopLikePhoto.TabIndex = 1;
            this.pictureBoxTopLikePhoto.TabStop = false;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelInstructions.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelInstructions.Location = new System.Drawing.Point(33, 63);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(1152, 38);
            this.labelInstructions.TabIndex = 3;
            this.labelInstructions.Text = "Choose an Album and the top liked photo in this album will appear";
            // 
            // labelYourAlbums
            // 
            this.labelYourAlbums.AutoSize = true;
            this.labelYourAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYourAlbums.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelYourAlbums.Location = new System.Drawing.Point(32, 140);
            this.labelYourAlbums.Name = "labelYourAlbums";
            this.labelYourAlbums.Size = new System.Drawing.Size(237, 44);
            this.labelYourAlbums.TabIndex = 5;
            this.labelYourAlbums.Text = "Your Albums";
            // 
            // labelLikestPhoto
            // 
            this.labelLikestPhoto.AutoSize = true;
            this.labelLikestPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikestPhoto.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelLikestPhoto.Location = new System.Drawing.Point(566, 140);
            this.labelLikestPhoto.Name = "labelLikestPhoto";
            this.labelLikestPhoto.Size = new System.Drawing.Size(229, 44);
            this.labelLikestPhoto.TabIndex = 6;
            this.labelLikestPhoto.Text = "Likest Photo";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonExit.Enabled = false;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonExit.Location = new System.Drawing.Point(40, 747);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(428, 86);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // FormLikestPhotoInAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 909);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelLikestPhoto);
            this.Controls.Add(this.labelYourAlbums);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.pictureBoxTopLikePhoto);
            this.Controls.Add(this.listBoxAlbums);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormLikestPhotoInAlbum";
            this.Text = "FormTopPhotoInAlbum";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLikePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxTopLikePhoto;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelYourAlbums;
        private System.Windows.Forms.Label labelLikestPhoto;
        private System.Windows.Forms.Button buttonExit;
    }
}