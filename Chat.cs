using System;
using System.Collections.Generic;

namespace Whatsapp_Project{
    public class Chat : I_Message,I_Attachments{
        private List<Contact> ContactList{set;get;}

        //View chat of desired Contact
        public void OpenChat(Contact contact){

        } 

        //Delete Chat of Desired Contact
        public void DeleteChat(Contact contact){

        }

        //Delete Message
        public void DeleteMessage(){

        }

        //Select contacts for broadcasting
        public void SelectContacts(){
            //Add Contacts to Contact List
        }
        
        //Send Broadcast Message
        public void Broadcast(List<Contact> contactList){
            //broadcast message
        }

        //send Message
        public void SendMessage()
        {
            //implement
        }

        //send Audio
        public void SendAudio()
        {
            //implement
        }


        //send Video
        public void SentVideo()
        {
            //implement
        }


        //send Location
        public void SendLocation()
        {
            //implement
        }

        //send Images
        public void SendImage()
        {
            //implement
        }

        //send Links
        public void SendLink()
        {
            //implement
        }

        //send Message
        public void SendContact()
        {
            //implement
        }

        //send Documents
        public void SendDocument()
        {
            //implement
        }

        //send Emojis
        public void SendImoji()
        {
            //implement
        }

        //send Sticers
        public void SendSticer()
        {
            //implement
        }

        //send GIF
        public void SendGIF()
        {
            //implement
        }

        //Play Audio From Chat
        public void PlayAudio()
        {
            //implement
        }

        //Play Video From Chat
        public void PlayVideo()
        {
            //implement
        }

        //Open Documents From Chat
        public void OpenDocs()
        {
            //implement
        }

        //Open Locations From Chat
        public void OpenLocation()
        {
            //implement
        }

        //Open Links From Chat
        public void OpenLinks()
        {
            //implement
        }

        //View Image From Chat
        public void ViewImage()
        {
            //implement
        }

    }
}