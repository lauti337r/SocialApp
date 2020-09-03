using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace SocialApp.Models
{
    /// <summary>
    /// Represents the News shown on the Home Page
    /// </summary>
    public class News: BindableBase
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _description;

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _url;

        public string Url
        {
            get => _url;
            set => SetProperty(ref _url, value);
        }
    }
}
