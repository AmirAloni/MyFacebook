namespace C18_Ex03_UI
{
    partial class FormTopCategories
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxthird = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(79, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Three Popular Category Pages Among Your Freinds";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Location = new System.Drawing.Point(92, 130);
            this.labelFirst.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(39, 32);
            this.labelFirst.TabIndex = 2;
            this.labelFirst.Text = "1.";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(92, 195);
            this.labelSecond.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(39, 32);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "2.";
            // 
            // labelThird
            // 
            this.labelThird.AutoSize = true;
            this.labelThird.Location = new System.Drawing.Point(92, 254);
            this.labelThird.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(39, 32);
            this.labelThird.TabIndex = 4;
            this.labelThird.Text = "3.";
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.BackColor = System.Drawing.Color.OldLace;
            this.textBoxFirst.Location = new System.Drawing.Point(151, 124);
            this.textBoxFirst.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(636, 38);
            this.textBoxFirst.TabIndex = 5;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.BackColor = System.Drawing.Color.OldLace;
            this.textBoxSecond.Location = new System.Drawing.Point(151, 185);
            this.textBoxSecond.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(636, 38);
            this.textBoxSecond.TabIndex = 6;
            // 
            // textBoxthird
            // 
            this.textBoxthird.BackColor = System.Drawing.Color.OldLace;
            this.textBoxthird.Location = new System.Drawing.Point(151, 247);
            this.textBoxthird.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxthird.Name = "textBoxthird";
            this.textBoxthird.Size = new System.Drawing.Size(636, 38);
            this.textBoxthird.TabIndex = 7;
            // 
            // FormTopCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(944, 368);
            this.Controls.Add(this.textBoxthird);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.labelThird);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormTopCategories";
            this.Text = "FormpopularPagesByFriends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelThird;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxthird;
    }
}