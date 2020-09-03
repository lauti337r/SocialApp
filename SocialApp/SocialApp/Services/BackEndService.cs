using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SocialApp.Models;

namespace SocialApp.Services
{
    public class BackEndService
    {
        /// <summary>
        /// Retrieves the Profile for the given user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Instance of Profile</returns>
        public async Task<Profile> GetProfile(string userId)
        {
            throw new Exception("Error!");
            //Here we would call the API
            try
            {
                Profile profile = new Profile()
                {
                    Country = "USA",
                    Email = "thisismyemail@gmail.com",
                    ProfilePictureUrl =
                        "https://ichef.bbci.co.uk/news/800/cpsprodpb/17EF9/production/_114214089_mediaitem114214088.jpg",
                    Name = "John Smith",
                    UserId = userId
                };
                return profile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks if login information is correct
        /// </summary>
        /// <param name="login"></param>
        /// <returns>Boolean</returns>
        public async Task<bool> CheckUserLogin(LoginInfo login)
        {
            //Here we would call the API
            try
            {
                if (login.Username == "admin" && login.Password == "password123")
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retrieves the list of news to show on the Home Page (Carousel)
        /// </summary>
        /// <returns>List of News</returns>
        public async Task<List<News>> GetNews()
        {
            List<News> news = new List<News>();
            //Here we would call the API
            try
            {
                news.Add(new News()
                {
                    Description = "Germany says Alexei Navalny was attacked with a type of nerve agent used against an ex-spy in the UK.",
                    Title = "Russian opposition leader 'poisoned with Novichok'",
                    Url = "https://ichef.bbci.co.uk/news/800/cpsprodpb/17EF9/production/_114214089_mediaitem114214088.jpg"
                });

                news.Add(new News()
                {
                    Description = "Sineenat Wongvajirapakdi was stripped of her title last year after being accused of \"disloyalty\".",
                    Title = "Thai king reinstates disgraced royal consort",
                    Url = "https://ichef.bbci.co.uk/news/660/cpsprodpb/69E8/production/_109321172_hi057461749.jpg"
                });

                news.Add(new News()
                {
                    Description = "The first one is just weeks away and we are finding out more about the format and the hosts.",
                    Title = "Who is moderating the presidential debates?",
                    Url = "https://ichef.bbci.co.uk/news/660/cpsprodpb/4A9D/production/_108910191_trump-biden_split_reuters-getty.jpg"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return news;
        }

        /// <summary>
        /// Retrieves the list of statuses to show on the Home Page
        /// </summary>
        /// <returns>List of statuses</returns>
        public async Task<List<Status>> GetStatuses()
        {
            List<Status> statuses = new List<Status>();
            //Here we would call the API
            try
            {
                statuses.Add(new Status()
                {
                    StatusTitle = "Happy!",
                    Comment = "Got a new job at ... company",
                    Comments = 5,
                    Likes = 3,
                    UserId = "person123",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                });
                statuses.Add(new Status()
                {
                    StatusTitle = "Sad...",
                    Comment = "Broke up with my boyfriend",
                    Comments = 5,
                    Likes = 1,
                    UserId = "thatotherperson1",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1544005313-94ddf0286df2?ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80"
                });
                statuses.Add(new Status()
                {
                    StatusTitle = "Sick",
                    Comment = "I don't know what I ate, but it's bad.",
                    Comments = 6,
                    Likes = 15,
                    UserId = "iatemushrooms",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1549068106-b024baf5062d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80"
                });
                statuses.Add(new Status()
                {
                    StatusTitle = "Sleepy...",
                    Comment = "I was up all night finishing homework",
                    Comments = 1,
                    Likes = 30,
                    UserId = "hatedeadlines",
                    ProfilePictureUrl = "https://images.unsplash.com/photo-1552058544-f2b08422138a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=644&q=80"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return statuses;
        }
    }
}
