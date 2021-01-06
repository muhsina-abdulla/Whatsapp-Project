using System;

namespace Whatsapp_Project
{
    public class UserProfile : I_SetProfile,I_Profile
    {
        private User user{get;set;}

        //Change Name
        public bool ChangeName()
        {
            //implement 
            return true;
        }
       
        //Change User Profile Picture
        public bool ChangeProfilePic()
        {
            //implement
            return true;
        }

        //Edit User About Info
        public bool EditAbout()
        {
            //implement
            return true;
        }

        //View User Profile About Info
        public void ViewAbout()
        {
            //implement
        }
        
        //View Users Name
        public void ViewName()
        {
            //implement
        }

        //View user Profile Picture
        public void ViewProfilePicture()
        {
            //implement
        }
    }
}