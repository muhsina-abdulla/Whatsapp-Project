using System;
using System.Collections.Generic;

namespace Whatsapp_Project
{
    public class Group :I_Profile,I_Message{

        private String GroupName{get; set;}

        private String GroupAbout{get ;set ;}

        private List<Contact> Admins{get;set;}
        private List<Contact> Members{get;set;}

        //View Group DP
        public void ViewProfilePicture()
        {
            //implement
        }

        //View Group Info
        public void ViewAbout()
        {
            //implement
        }

        //Send Message in group
        public void SendMessage()
        {
            //implement
        }

        //Send Audio Message in group
        public void SendAudio()
        {
            //implement
        }

        //Send Video Message in group
        public void SentVideo()
        {
            //implement
        }

        //Send Location in group
        public void SendLocation()
        {
            //implement
        }

        //Send Images in group
        public void SendImage()
        {
            //implement
        }

        //Send Links in Group
        public void SendLink()
        {
            //implement
        }

        //Send Contacts in group
        public void SendContact()
        {
            //implement
        }

        //Send Documents in group
        public void SendDocument()
        {
            //implement
        }

        //Send emojis in group
        public void SendImoji()
        {
            //implement
        }

        //Send Sticers in group
        public void SendSticer()
        {
            //implement
        }

        //Send GIF in group
        public void SendGIF()
        {
            //implement
        }

        
        //View Group Name
        public void ViewName()
        {
            //implement 
        }

        //Leave Group
        public void LeaveGroup(){

        }
    }
}