using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Classes
{
     public class Song
    {
        //constructor
        public Song(String filepath)
        {
            this.path = filepath;
            Dispose();
            mp3FileReader = new AudioFileReader(filepath);
     //       stream = new BlockAlignReductionStream(mp3FileReader);

            output = new WaveOutEvent();
            output.Init(mp3FileReader);
        }

        //fields 
        String path = null; 

        private WaveOutEvent output;
       
        AudioFileReader mp3FileReader = null;

        public TimeSpan currentTime
        {
            get{ return  mp3FileReader.CurrentTime; }                
            set { mp3FileReader.CurrentTime = value; }
        }

        //methods
        private void Dispose()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (mp3FileReader != null)
            {
                mp3FileReader.Dispose();
                mp3FileReader = null;
            }
        }      

        public void Play()
        {
            if(output.PlaybackState != PlaybackState.Playing)
            {
                if (output != null) output.Play();
            }
        }

        public bool IsPlaying()
        {
            if (output.PlaybackState == PlaybackState.Playing) return true;
            else return false;
        }

        public void Stop()
        {
            
            output.Stop();
        }

        public void Pause()
        {
            output.Pause();
            
        }
        
    }
}
