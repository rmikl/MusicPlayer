using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlayer.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        PlayerWindow playerWindow;
        PlaylistWindow playlistWindow;
        public Form1()
        {
            this.Visible = false;            
            InitializeComponent();
            playlistWindow = new PlaylistWindow();
            playerWindow = new PlayerWindow();
            playlistWindow.Visible = false;
            playerWindow.Visible = true;
            playerWindow._playlistWindow = playlistWindow;
            playlistWindow._playerWindow = playerWindow;
            playerWindow.SetSubscription();
            playlistWindow.SetSubscription();
            playlistWindow.ControlBox = false;
            playlistWindow.FormBorderStyle = FormBorderStyle.FixedSingle;
            playerWindow.FormBorderStyle = FormBorderStyle.FixedSingle;




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
