using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using MusicPlayer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer.Forms
{
    public partial class PlayerWindow : Form
    {

        //constructor 
        public PlayerWindow()
        {
            InitializeComponent();
            PauseButton.Visible = false;
            songTimer.Interval = 1000;
            songTrackBar.Maximum = 0;

        }

        //fields
        public PlaylistWindow _playlistWindow;

        Song song;

        String _songName;

        private int _tikerIterator = 0;

        private TimeSpan _currentTimeAfterPause = TimeSpan.Zero;        

        //form behavior 
        private void OpenButton_Click(object sender, EventArgs e)
        {

            if (_playlistWindow != null)
            {
                if (_playlistWindow.Visible == false)
                {
                    _playlistWindow.Visible = true;
                }
            }
            else
            {
                _playlistWindow = new PlaylistWindow();
                _playlistWindow._playerWindow = this;
                _playlistWindow.Visible = true;

            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlaySong(_songName);
        }

        private void SongTrackBar_Click(object sender, EventArgs e)
        {
            songTimer.Stop();            
            ChangeSongTrackbarProgress(TimeSpan.FromSeconds(songTrackBar.Value));
            _tikerIterator = songTrackBar.Value;
            if (PlayButton.Visible == false) songTimer.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _currentTimeAfterPause = song.currentTime;
            song.Pause();
            PauseButton.Visible = false;
            PlayButton.Visible = true;
            songTimer.Stop();
        }

        private void Shuffle_StateChange(object sender, EventArgs e)
        {
            if(isShuffleCheckBox.Checked == true)
                OnShuffleChecked();
            else OnShuffleUnchecked();
        }

        private void NextSongButton_Click(object sender, EventArgs e)
        {
            if(song != null)
            {
                StopSong();
                OnSongEnded();
            }

        }

        private void PreviousSongButton_CLick(object sender, EventArgs e)
        {
            if(song != null) OnPreviousSongButton();
        }

        private void StopSongButton_Click (object sender, EventArgs e)
        {
            StopSong();
        }

        //methods
        public void SetSubscription()
        {
            _playlistWindow.SendSongName += SendSongNameHandler;
        }

        public void StopSong()
        {
            songTimer.Stop();
            song.Stop();
            _tikerIterator = 0;
        }

        private void PlaySong(String nextSong)
        {
            if (song == null) return;
            if (_currentTimeAfterPause != TimeSpan.Zero)
            {
                song.currentTime = _currentTimeAfterPause;
            }
            PlayButton.Visible = false;
            PauseButton.Visible = true;
            song.Play();
            songTimer.Start();
        }

        private void PlayPauseButtonActive()
        {
            if (!PlayButton.Visible)
            {
                PlayButton.Visible = true;
                PauseButton.Visible = false;
            }

        }

        private void songTimer_Tick(object sender, EventArgs e)
        {
            _tikerIterator++;
            tickerStateTextBox.Text = TimeSpan.FromSeconds( _tikerIterator).ToString();
            int videoDuration = CountSeconds(GetVideoDuration(_songName));
            if (videoDuration < _tikerIterator)
            {
                songTimer.Stop();
                _tikerIterator = 0;
                OnSongEnded();
            }
            songTrackBar.Value = _tikerIterator;
        }

        private static TimeSpan GetVideoDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }        

        private void RefreshState()
        {
            if (song.IsPlaying())
            {
                song.Stop();
            }

        }

        private int CountSeconds(TimeSpan inputTime)// class that were made because TimeSpan.TotalSecond property return wierd value
        {
            return (inputTime.Minutes * 60) + inputTime.Seconds;
        }

        private void ChangeSongTrackbarProgress(TimeSpan currentTime)
        {
            song.currentTime =currentTime;
        }

        //event handlers subscriber
        public void SendSongNameHandler(object sender, SongNameEventArgs e)
        {
            if (song !=null) StopSong();
            _songName = e.message;
            song = new Song(_songName);
            textBox1.Text = Path.GetFileName ( e.message);
            _tikerIterator = 0;
            songTrackBar.Value = 0;
            durationTextBox.Text = TimeSpan.FromSeconds( CountSeconds(GetVideoDuration(e.message))).ToString();
            songTrackBar.Maximum = CountSeconds(GetVideoDuration(e.message));


            if (e.fromChooseButton)//sended from ChooseButton
            {
                song.Stop();
                songTimer.Stop();
                PlayPauseButtonActive();                
            }
            else //sended by playing automatically
            {
                PlaySong(_songName);
            }
        }

        //event handlers sender
        public delegate void SongEndedEventHandler(object o, EventArgs e);

        public event SongEndedEventHandler SongEnded;

        public void OnSongEnded()
        {
            if(SongEnded != null)
            {
                SongEnded(this, EventArgs.Empty);
            }
        }

        public delegate void ShuffleCheckedEventHandler(object o, EventArgs e);

        public event ShuffleCheckedEventHandler ShuffleChecked;

        public void OnShuffleChecked()
        {
            if(ShuffleChecked != null)
            {
                ShuffleChecked(this, EventArgs.Empty);
            }
        }

        public delegate void ShuffleUnCheckedEventHandler(object o, EventArgs e);

        public event ShuffleUnCheckedEventHandler ShuffleUnchecked;

        public void OnShuffleUnchecked()
        {
            if(ShuffleUnchecked != null)
            {
                ShuffleUnchecked(this, EventArgs.Empty);
            }
        }

        public delegate void PreviousSongButtonEventHandler(object o, EventArgs e);

        public event PreviousSongButtonEventHandler PreviousSongButton;

        public void OnPreviousSongButton()
        {
            if(PreviousSongButton != null)
            {
                PreviousSongButton(this, EventArgs.Empty);
            }
        }

    }//end of class

}//end of namspace
