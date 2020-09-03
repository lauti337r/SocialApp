using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace SocialApp.Models
{
    /// <summary>
    /// Represents the Status card shown on the list on the Home Page
    /// </summary>
    public class Status: BindableBase
    {
        private string _statusTitle;

        public string StatusTitle
        {
            get => _statusTitle;
            set => SetProperty(ref _statusTitle, value);
        }

        private string _userId;

        public string UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private string _comment;

        public string Comment
        {
            get => _comment;
            set => SetProperty(ref _comment, value);
        }

        private string _profilePictureUrl;

        public string ProfilePictureUrl
        {
            get => _profilePictureUrl;
            set => SetProperty(ref _profilePictureUrl, value);
        }

        private int _comments;

        public int Comments
        {
            get => _comments;
            set => SetProperty(ref _comments, value);
        }

        private int _likes;

        public int Likes
        {
            get => _likes;
            set => SetProperty(ref _likes, value);
        }
    }
}
