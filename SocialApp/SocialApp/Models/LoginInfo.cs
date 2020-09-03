using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace SocialApp.Models
{
    /// <summary>
    /// Represents the user input on the Login Page
    /// </summary>
    public class LoginInfo: BindableBase
    {
        private string _username;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }
        private string _password;

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }
    }
}
