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
            throw new NotImplementedException();
        }


        //Change Group About Info
        public bool EditAbout()
        {
            throw new NotImplementedException();
        }

        //Change Group Name
        public bool ChangeName()
        {
            throw new NotImplementedException();
        }


        //View Group DP
        public void ViewProfilePicture()
        {
            throw new NotImplementedException();
        }

        //View Group About Info
        public void ViewAbout()
        {
            throw new NotImplementedException();
        }

        //View GroupName
        public void ViewName()
        {
            throw new NotImplementedException();
        }
    }
}