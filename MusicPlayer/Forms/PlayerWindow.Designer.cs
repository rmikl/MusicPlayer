namespace MusicPlayer.Forms
{
    partial class PlayerWindow
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
            this.AddSongButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.songTrackBar = new System.Windows.Forms.TrackBar();
            this.songTimer = new System.Windows.Forms.Timer(this.components);
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.tickerStateTextBox = new System.Windows.Forms.TextBox();
            this.NextSong = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.isShuffleCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.songTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSongButton
            // 
            this.AddSongButton.Location = new System.Drawing.Point(68, 35);
            this.AddSongButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(107, 42);
            this.AddSongButton.TabIndex = 0;
            this.AddSongButton.Text = "Add Song";
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 1;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(102, 136);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(47, 46);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(102, 137);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(46, 46);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // songTrackBar
            // 
            this.songTrackBar.Location = new System.Drawing.Point(10, 86);
            this.songTrackBar.Name = "songTrackBar";
            this.songTrackBar.Size = new System.Drawing.Size(228, 45);
            this.songTrackBar.TabIndex = 4;
            this.songTrackBar.Scroll += new System.EventHandler(this.SongTrackBar_Click);
            // 
            // songTimer
            // 
            this.songTimer.Tick += new System.EventHandler(this.songTimer_Tick);
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(10, 35);
            this.durationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(54, 20);
            this.durationTextBox.TabIndex = 5;
            // 
            // tickerStateTextBox
            // 
            this.tickerStateTextBox.Location = new System.Drawing.Point(179, 35);
            this.tickerStateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tickerStateTextBox.Name = "tickerStateTextBox";
            this.tickerStateTextBox.Size = new System.Drawing.Size(59, 20);
            this.tickerStateTextBox.TabIndex = 6;
            // 
            // NextSong
            // 
            this.NextSong.Location = new System.Drawing.Point(172, 137);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(66, 45);
            this.NextSong.TabIndex = 7;
            this.NextSong.Text = "Next";
            this.NextSong.UseVisualStyleBackColor = true;
            this.NextSong.Click += new System.EventHandler(this.NextSongButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(12, 137);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(61, 45);
            this.PreviousButton.TabIndex = 8;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousSongButton_CLick);
            // 
            // isShuffleCheckBox
            // 
            this.isShuffleCheckBox.AutoSize = true;
            this.isShuffleCheckBox.Location = new System.Drawing.Point(179, 60);
            this.isShuffleCheckBox.Name = "isShuffleCheckBox";
            this.isShuffleCheckBox.Size = new System.Drawing.Size(59, 17);
            this.isShuffleCheckBox.TabIndex = 9;
            this.isShuffleCheckBox.Text = "Shuffle";
            this.isShuffleCheckBox.UseVisualStyleBackColor = true;
            this.isShuffleCheckBox.CheckedChanged += new System.EventHandler(this.Shuffle_StateChange);
            // 
            // PlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 200);
            this.Controls.Add(this.isShuffleCheckBox);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextSong);
            this.Controls.Add(this.tickerStateTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.songTrackBar);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddSongButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayerWindow";
            this.Text = "PlayerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.songTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TrackBar songTrackBar;
        private System.Windows.Forms.Timer songTimer;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox tickerStateTextBox;
        private System.Windows.Forms.Button NextSong;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.CheckBox isShuffleCheckBox;
    }
}