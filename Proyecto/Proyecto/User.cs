using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Diagnostics;

namespace Proyecto
{
    [Serializable()]
    public class User : ISerializable
    {
        private List<object> UserData;
        private string UserName { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private bool PrivateAccount { get; set; }
        private List<User> Followers;
        private List<Object> Following;
        private Queue<Media> Queue;
        private Dictionary<object, List<object>> Favorites;
        private List<object> Likes;
        private bool Premium { get; set; }
        private List<Playlist> Playlists;

        public User(string name, string email, string password, bool privateAccount, bool premium)
        {
            UserName = name;
            Email = email;
            Password = password;
            PrivateAccount = privateAccount;
            Dictionary<object, List<object>> favorites = new Dictionary<object, List<object>>();
            List<object> likes = new List<object>();
            Queue<Media> queue = new Queue<Media>();
            List<Playlist> playlists = new List<Playlist>();
            Favorites = favorites;
            Likes = likes;
            Queue = queue;
            Playlists = playlists;
            Premium = premium;
            List<User> Followers;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", UserName);
            info.AddValue("Email", Email);
            info.AddValue("Password", Password);
            info.AddValue("Private", PrivateAccount);
            info.AddValue("Premium", Premium);
        }

        public User(SerializationInfo info, StreamingContext context)
        {
            string Name = (string)info.GetValue("Name", typeof(string));
            string Email = (string)info.GetValue("Email", typeof(string));
            string Password = (string)info.GetValue("Password", typeof(string));
            bool Private = (bool)info.GetValue("Private", typeof(bool));
            bool Premium = (bool)info.GetValue("Premium", typeof(bool));
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetUsername()
        {
            return UserName;
        }

        public string GetEmail()
        {
            return Email;
        }

        public List<Playlist> GetPlaylist()
        {
            return Playlists;
        }

        public List<User> GetFollowers()
        {
            return Followers;
        }

        public List<object> GetFollowing()
        {
            return Following;
        }

        public void AddToQueue(Media nextMedia)
        {
            Queue.Enqueue(nextMedia);
        }

        public void AddToPlaylist(Media media, Playlist plName)
        {
            if (Playlists.Count == 0)
            {
                Console.WriteLine("You have no playlists, to create one go to new playlist.");  //placeholder
            }

            else
            {
                Playlist a = Playlists.Find(x => x.GetName() == plName.GetName());

                if (a.GetList().Contains(media))
                {
                    Console.WriteLine($"Playlist already contains {0}" , media);    //placeholder
                }

                else
                {

                    a.AddMedia(media);
                }
            }
        }

        public void LikeMedia(Media media)
        {
            if (Likes.Contains(media))
            {
                media.AddLike(false);
            }
            else
            {
                media.AddLike(true);
            }
            
        }

        public void NewPlaylist()
        {
            Console.Write("Playlist name: ");
            string name = Console.ReadLine();
            bool privateList = false;
            if (PrivateAccount == true)
            {
                privateList = true;
            }
            else
            {
                Console.WriteLine("Do you want your playlist to be private? y/n");
                int read = Console.Read();
                if (read == 'y')
                {
                    privateList = true;
                }
            }

            Playlist a = new Playlist(name, privateList, Spotflix.GetUserDB[UserName]);
            Playlists.Add(a);
        }

        public void Follow(User following, User follower)
        {
            User toFollow = Spotflix.GetUserDB[following.GetUsername()];
            List<User> followersList = toFollow.GetFollowers();
            followersList.Add(follower);
        }

    }
}


//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();