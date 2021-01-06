using System;
using System.Collections.Generic;

namespace Whatsapp_Project
{
    public class GroupAdmin:I_Profile,I_SetProfile{
        private List<Contact> Members{get;set;}
        private Group Group1{get; set;}

        //Create New Group

        public void CreateGroup(){
            Group1 = new Group();
            //create Group
        }

        //Add new Members to the Group
        public void AddMembers(){

        }

        //Remove Members to the Group
        public void RemoveMembers(){

        }

        //Make new Admins
        public void MakeAdmin(){

        }

        //Delete Group
        public void DeleteGroup(){

        }


        //Change Group DP
        public bool ChangeProfilePic()
        {
            //implement
            return true;
        }


        //Change Group About Info
        public bool EditAbout()
        {
            //implement
            return true;
        }

        //Change Group Name
        public bool ChangeName()
        {
            //implement
            return true;
        }


        //View Group DP
        public void ViewProfilePicture()
        {
            //implement
        }

        //View Group About Info
        public void ViewAbout()
        {
            //implement
        }

        //View GroupName
        public void ViewName()
        {
            //implement
        }
    }
}