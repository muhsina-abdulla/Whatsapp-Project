using System;

namespace Whatsapp_Project
{
    public interface I_Message{
        void SendMessage();
        void SendAudio();
        void SentVideo();
        void SendLocation();
        void SendImage();
        void SendLink();
        void SendContact();
        void SendDocument();
        void SendImoji();
        void SendSticer();
        void SendGIF();
    }
}