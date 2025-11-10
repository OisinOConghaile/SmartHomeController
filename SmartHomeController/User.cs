using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        //private fileds
        private int userId;
        private string userName;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;

        //public properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }   

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        // paramatarised constructor
        public User(int userId, string userName, 
                    string password, string contactInfo)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            ContactInfo = contactInfo;
            IsLoggedIn = false; // default to not logged in
        }

        //class methods
        public bool Login(string userName, string password)
        {
            if (UserName == userName && Password == password)
            {
                // username and password are authenticated
                //advise user that their login is successful
                IsLoggedIn = true;
                Console.WriteLine("Login successful.");
            }
            else
            {
                // username and or / or password are incorrect
                // advise user that their login details are incorrect
                IsLoggedIn = false;
                Console.WriteLine("Login failed. Invalid username or password.");
            }
            return IsLoggedIn;
        }

            public bool Logout()
            {
                if (IsLoggedIn) 
                {
                    IsLoggedIn = false;
                    Console.WriteLine("User logged out successfully.");
                }
                else
                {
                    Console.WriteLine("User is not logged in.");
                }
                return IsLoggedIn;


            }
        
            public void ControlDevice(int deviceId, string deviceName, 
                                      string deviceAction)
            {
                if (IsLoggedIn)
                {
                    Console.WriteLine($"Perfoming action {deviceAction} on {deviceName}");
                    // add logic to control the smart device
                }
                else
                {
                    Console.WriteLine("Please log in to control device.");
                }

            }
            

    }

}

