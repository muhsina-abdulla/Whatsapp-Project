using System;

namespace Whatsapp_Project{
    public class Contact : I_ViewProfile{
         
        //Properties
        
        private String Name{get; set;}
        private int PhoneNum{get; set;}
        private String About{get ; set;}
     // private var ProfilePic{get ; set ;}

        //Send invites to non Whatsapp users
        public void SendInvites(){

        }


        //View Contact About Info
         public void ViewAbout()
        {
            throw new NotImplementedException();
        }

        //View Contact Profile Picture
        public void ViewProfilePicture()
        {
            throw new NotImplementedException();
        }
        

        









    }
}
