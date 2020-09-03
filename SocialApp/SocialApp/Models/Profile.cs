using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace SocialApp.Models
{
    /// <summary>
    /// Represents all the info shown on the Profile Page
    /// </summary>
    public class Profile : BindableBase
    {
        private string _userId;

        public string UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private string _profilePictureUrl;

        public string ProfilePictureUrl
        {
            get => _profilePictureUrl;
            set => SetProperty(ref _profilePictureUrl, value);
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _country;

        public string Country
        {
            get => _country;
            set => SetProperty(ref _country, value);
        }

        private string _email;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }
    }
}
