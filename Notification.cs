using System;

namespace Whatsapp_Project{
    
    public class Notifications{
       

        private Contact Cont {get;set;}
        private Boolean vibrate{get;set;}

        private string NotificationTone{get;set;}

        //private enum time ={}
        
        //Constructor
        public Notifications(Contact cont, bool vibrate=true, string notificationTone="Default Tone")
        {
            Cont = cont;
            
        }

        //set Custom notification tone for selected contact
        public void SetCustomtone(){

        }

        //Set Vibration to on
        public void SetVibrate(){
            vibrate = true;
        }

        //Set vibration to off
        public void UnsetVibrate(){
            vibrate = false;
        }

        //Mute Notification for a specified time for the contact
        public void MuteNotification(String time){

        }

        

    }
}