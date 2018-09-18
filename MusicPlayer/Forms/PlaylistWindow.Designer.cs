namespace MusicPlayer.Forms
{
    partial class PlaylistWindow
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
            this.songListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // songListBox
            // 
            this.songListBox.FormattingEnabled = true;
            this.songListBox.Location = new System.Drawing.Point(9, 10);
            this.songListBox.Margin = new System.Windows.Forms.Padding(2);
            this.songListBox.Name = "songListBox";
            this.songListBox.Size = new System.Drawing.Size(578, 290);
            this.songListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(388, 315);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(199, 31);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add track to playlist";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(9, 314);
            this.ChooseButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(172, 32);
            this.ChooseButton.TabIndex = 2;
            this.ChooseButton.Text = "Choose track to play";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // PlaylistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 357);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.songListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlaylistWindow";
            this.Text = "PlaylistWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox songListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChooseButton;
    }
}