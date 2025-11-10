

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        //private fields
        private int userId;
        private string userName;
        private string contactInfo;
        private string password;
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

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        //Constructor
        public User(int userId, string userName, string contactInfo, string password, bool IsLoggedIn)
        {
            UserId = userId;
            UserName = userName;
            ContactInfo = contactInfo;
            Password = password;
            IsLoggedIn = false;
        }

        //Methods
        public bool Login(string userName, string passsword)
        {
            if(UserName == userName && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Login successful.");
            } 
            else
            {
                IsLoggedIn = false;
                Console.WriteLine("Login failed. Incorrect username or password.");
            }
            return IsLoggedIn;
        }
        public bool Logout()
        {
            if(IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("Logout successful.");
            }
            else
            {
                Console.WriteLine("User is not logged in.");
            }
            return IsLoggedIn;
        }
    }
}
