using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Classes
{
    public class SongNameEventArgs : EventArgs
    {

        String _message;

        Boolean _fromChooseButton= true;

        public String message { get { return _message; } }

        public Boolean fromChooseButton { get { return _fromChooseButton; } }

        public SongNameEventArgs(String msg, Boolean fromChooseButton)
        {
            this._fromChooseButton = fromChooseButton;
            this._message = msg;
        }
    }
}
