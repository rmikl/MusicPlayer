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


namespace MusicPlayer.Forms
{
    public partial class PlaylistWindow : Form
    {

        //construktor
        public PlaylistWindow()
        {
            InitializeComponent();            
        }

        //fields

        public PlayerWindow _playerWindow;              

        public BindingList<String> songListUrl = new BindingList<String>();

        String songName = null;

        Boolean isShuffle = false;

        private int _currentActiveSongIndex;

        Boolean _previousSongButton=false;

        //click events 

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 (*.mp3)|*.mp3;";
            if (open.ShowDialog() != DialogResult.OK) return;
            songListUrl.Add(open.FileName);
            songName = open.FileName;
            RefreshListbox();
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if(songListUrl.Count > 0) SendName(songName, true);
        }



        //methods

        public void SetSubscription()
        {
            _playerWindow.SongEnded += SongEndedEventHandler;
            _playerWindow.ShuffleChecked += ShuffleCheckedEventHandler;
            _playerWindow.ShuffleUnchecked += ShuffleUncheckedEventHandler;
            _playerWindow.PreviousSongButton += PreviousSungButtonEventHandler;

        }

        public void RefreshListbox()
        {
            songListBox.DataSource = songListUrl;
            songListBox.Refresh();
        }

        public int NextSongIndex(int currentSongIndex)
        {
            Random random = new Random();
            int index=0;

            if (isShuffle)
            {
                index = random.Next(0, songListUrl.Count );
            }
            else
            {
                if (_previousSongButton)
                {
                    if (currentSongIndex == 0)
                    {
                        return currentSongIndex;
                    }
                    else return currentSongIndex - 1;
                }
                if (songListUrl.Count == currentSongIndex + 1)
                {
                    return currentSongIndex;
                }
                else
                {
                    index = currentSongIndex + 1;
                    return index;
                }
            }
            return index;
        }
        
        //event handling sender

        public delegate void SendSongNameEventHandler(object o, SongNameEventArgs e);

        public event SendSongNameEventHandler SendSongName;

        public void SendName(String songName, Boolean fromChooseButton) //for choose button
        {
            songName = songListUrl[songListBox.SelectedIndex];             
            var messageToSend = new SongNameEventArgs(songName, fromChooseButton);
            OnSendSongName(messageToSend);
            _currentActiveSongIndex = songListBox.SelectedIndex;   
        }

        public void SendName(String songName) //for automatically playing playlist
        {
            var messageToSend = new SongNameEventArgs(songName, false);
            OnSendSongName(messageToSend);
            _currentActiveSongIndex = songListBox.SelectedIndex = NextSongIndex(_currentActiveSongIndex);
        }

        public void OnSendSongName(SongNameEventArgs e)
        {
            if(SendSongName != null)
            {
                SendSongName(this, e);
            }

        }

        //event handlers subscirber

        public void SongEndedEventHandler(object sender, EventArgs e)
        {
            int nextIndex = NextSongIndex(_currentActiveSongIndex);
            String name = songListUrl[nextIndex];
            SendName(name);
        }

        public void ShuffleCheckedEventHandler(object sender, EventArgs e)
        {
            isShuffle = true;

        }

        public void ShuffleUncheckedEventHandler(object sender, EventArgs e)
        {
            isShuffle = false;
        }

        public void PreviousSungButtonEventHandler(object sender, EventArgs e)
        {
            _previousSongButton = true;
            int nextIndex = NextSongIndex(_currentActiveSongIndex);
            String name = songListUrl[nextIndex];
            SendName(name);
            _previousSongButton = false;

        }

    }
}
