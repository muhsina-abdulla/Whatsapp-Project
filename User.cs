using System;

namespace Whatsapp_Project
{
    public class User:Account
    {
        
        private String Name{ get ; set ;}
        private int PhoneNum{get ; set ;}
        private int CountryCode{get ; set ;}


        public User(String name,int countryCode, int phoneNum)
        {
            //Validate country code and phone number
            CountryCode = countryCode;
            //verify phone number 
            Verify_Phone_Num();
            PhoneNum = phoneNum;
            Name = name;
            //create new account if the user doesnt have a whatsapp account;
            Create_New_User();
         }




        //A private function for verification of user phone number
        private Boolean Verify_Phone_Num(){

            //verify phone number
            return true;//else false
        }

        
         //Function to create a new whatsapp user
        private void Create_New_User(){
            
        
        }


        //Function for logging into whatsapp
        public void login(int country_code,int phone_num){
            //verify
            //code for logging out  from previously logged in device
            Logout_From_Other_Devices();
            //login to new device
        }


        //A private logout method
        private void Logout_From_Other_Devices(){
            //Code to logout from other devices
        }


    
       
    }
}
