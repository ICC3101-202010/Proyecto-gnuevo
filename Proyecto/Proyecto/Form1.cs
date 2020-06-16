using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }

        User newUser = new User("a", "b", "c", true, true);
        string username = "a";
        Panel Panel2 = new Panel();

        private void NewUserButton_Click_1(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Panel Panel2 = new Panel();
            Panel2.Size = Panel1.Size;

            Label IntroLabel = new Label();
            IntroLabel.Location = new Point(220, 20);
            IntroLabel.Text = "Please enter your data";
            IntroLabel.AutoSize = true;
            Panel2.Controls.Add(IntroLabel);

            //Username textboxt and label
            Label UserNameLabel = new Label();
            UserNameLabel.Location = new Point(50, 50);
            UserNameLabel.Text = "Username";
            UserNameLabel.AutoSize = true;
            Panel2.Controls.Add(UserNameLabel);
            TextBox UserNameTB = new TextBox();
            UserNameTB.Location = new Point(110, 50);
            UserNameTB.ReadOnly = false;
            Panel2.Controls.Add(UserNameTB);
            string username = UserNameTB.Text;

            //Password textbox and label
            Label UserPassLabel = new Label();
            UserPassLabel.Location = new Point(50, 80);
            UserPassLabel.Text = "Password";
            UserPassLabel.AutoSize = true;
            Panel2.Controls.Add(UserPassLabel);
            TextBox UserPassTB = new TextBox();
            UserPassTB.Location = new Point(110, 80);
            UserPassTB.Size = new Size(90, 24);
            UserPassTB.PasswordChar = '*';
            UserPassTB.ReadOnly = false;
            Panel2.Controls.Add(UserPassTB);
            string password = UserPassTB.Text;

            //Email textbox and label
            Label UserEmailLabel = new Label();
            UserEmailLabel.Location = new Point(50, 110);
            UserEmailLabel.Text = "Email";
            UserEmailLabel.AutoSize = true;
            Panel2.Controls.Add(UserEmailLabel);
            TextBox UserEmailTB = new TextBox();
            UserEmailTB.Location = new Point(110, 110);
            UserEmailTB.Size = new Size(90, 24);
            Panel2.Controls.Add(UserEmailTB);
            string email = UserEmailTB.Text;

            
            //Private account label
            Label PrivateButtonLabel = new Label();
            PrivateButtonLabel.Text = "Do you wish to get a private account?";
            PrivateButtonLabel.AutoSize = true;
            PrivateButtonLabel.Location = new Point(50, 160);
            Panel2.Controls.Add(PrivateButtonLabel);

            //Yes Label and RadioButton (private account)
            Label YesLabel = new Label();
            YesLabel.Text = "Yes";
            YesLabel.Location = new Point(50, 210);
            YesLabel.AutoSize = true;
            Panel2.Controls.Add(YesLabel);
            RadioButton PrivateUserYes = new RadioButton();
            PrivateUserYes.Location = new Point(90, 205);
            Panel2.Controls.Add(PrivateUserYes);
            bool privateUser = true;
            if (PrivateUserYes.Checked == true)
            {
                privateUser = true;
            }

            //No Label and RadioButton (private account)
            Label NoLabel = new Label();
            NoLabel.Text = "No";
            NoLabel.Location = new Point(50, 240);
            NoLabel.AutoSize = true;
            Panel2.Controls.Add(NoLabel);
            RadioButton PrivateUserNo = new RadioButton();
            PrivateUserNo.Location = new Point(90, 235);
            Panel2.Controls.Add(PrivateUserNo);
            if (PrivateUserNo.Checked == true)
            {
                privateUser = false;
            }


            //Premium account label
            Label PremiumButtonLabel = new Label();
            PremiumButtonLabel.Text = "Do you wish to have a premium account?";
            PremiumButtonLabel.AutoSize = true;
            PremiumButtonLabel.Location = new Point(270, 160);
            Panel2.Controls.Add(PremiumButtonLabel);

            //Yes Label and RadioButton (premium account)
            Panel PremiumPanel = new Panel();
            PremiumPanel.Location = new Point(260, 200);
            PremiumPanel.Size = new Size(60, 50);
            PremiumPanel.Visible = true;

            Label YesLabel2 = new Label();
            YesLabel2.Text = "Yes";
            YesLabel2.AutoSize = true;
            YesLabel2.Visible = true;
            YesLabel2.Location = new Point(10, 15);
            PremiumPanel.Controls.Add(YesLabel2);

            RadioButton PremiumUserYes = new RadioButton();
            PremiumUserYes.Location = new Point(40, 10);
            PremiumPanel.Controls.Add(PremiumUserYes);
            bool premium = true;
            if (PremiumUserYes.Checked == true)
            {
                premium = true;
            }
            
            //No Label and RadioButton (premium account)
            Label NoLabel2 = new Label();
            NoLabel2.Text = "No";
            NoLabel2.AutoSize = true;
            NoLabel2.Location = new Point(10, 35);
            PremiumPanel.Controls.Add(NoLabel2);
            RadioButton PremiumUserNo = new RadioButton();
            PremiumUserNo.Location = new Point(40, 30);
            if (PremiumUserNo.Checked == true)
            {
                premium = false;
            }
            PremiumPanel.Controls.Add(PremiumUserNo);

            Button DoneButton = new Button();
            DoneButton.Location = new Point(160, 270);
            DoneButton.Text = "Enter";
            Panel2.Controls.Add(DoneButton);

            Panel2.Controls.Add(PremiumPanel);

            DoneButton.Click += DoneButton_Click;

            Panel1.Controls.Add(Panel2);

            newUser = new User(username, password, email, privateUser, premium);
        }


        void DoneButton_Click(object sender, EventArgs e)
        {
            Spotflix.GetUserDB.Add(username, newUser);
            Panel1.Controls.Remove(Panel2);
        }



        //Falta poner los lugares donde van quedar
        private void RetUserButton_Click(object sender, EventArgs e)
        {
            Panel Panel2 = new Panel();
            Panel2.Size = Panel1.Size;
            Panel1.Controls.Add(Panel2);

            Label RetUserDataLabel = new Label();
            RetUserDataLabel.Location = new Point(140, 50);
            RetUserDataLabel.Text = "Please enter your account data";
            RetUserDataLabel.Size = new Size(200, 40);
            Panel2.Controls.Add(RetUserDataLabel);

            //Returning user username
            Label RetUserUsernameLabel = new Label();
            RetUserUsernameLabel.Location = new Point(200, 100);
            RetUserUsernameLabel.Text = "Username";
            Panel2.Controls.Add(RetUserUsernameLabel);
            TextBox RetUserUsernameTB = new TextBox();
            RetUserUsernameTB.Location = new Point(300, 100);
            Panel2.Controls.Add(RetUserUsernameTB);
            string username = RetUserUsernameTB.Text;

            //Returning user password
            Label RetUserPassLabel = new Label();
            RetUserPassLabel.Location = new Point(200, 140);
            RetUserPassLabel.Text = "Password";
            Panel2.Controls.Add(RetUserPassLabel);
            TextBox RetUserPassTB = new TextBox();
            RetUserPassTB.Location = new Point(300, 140);
            RetUserPassTB.PasswordChar = '*';
            Panel2.Controls.Add(RetUserPassTB);
            string password = RetUserPassTB.Text;

            Button RetDoneButton = new Button();
            RetDoneButton.Text = "Enter";
            RetDoneButton.Location = new Point(240, 200);
            Panel2.Controls.Add(RetDoneButton);

            RetDoneButton.Click += RetDoneButton_Click;
        }


        public void RetDoneButton_Click(object sender, EventArgs e)
        {
            //Removing all previous Windows Forms elements
            Panel2.Controls.Clear();

            Label WelcomeBackLabel = new Label();
            WelcomeBackLabel.Text = "Welcome Back!";
            Panel2.Controls.Add(WelcomeBackLabel);

            Label OptionsLabel = new Label();
            OptionsLabel.Text = "What do you want to do?";
            Panel2.Controls.Add(OptionsLabel);

            Button MusicOrVidsButton = new Button();
            MusicOrVidsButton.Text = "Search for music or videos";
            MusicOrVidsButton.Click += MusicOrVidsButton_Click;
            Panel2.Controls.Add(MusicOrVidsButton);

            Button PlaylistsButton = new Button();
            PlaylistsButton.Text = "Access your playlists";
            PlaylistsButton.Click += PlaylistsButton_Click;
            Panel2.Controls.Add(PlaylistsButton);
            
            Button OtherAccountsButton = new Button();
            OtherAccountsButton.Text = "Look for other accounts";
            OtherAccountsButton.Click += OtherAccountsButton_Click;
            Panel2.Controls.Add(OtherAccountsButton);

            Button ImportMusicButton = new Button();
            ImportMusicButton.Text = "Import a music file";
            ImportMusicButton.Click += ImportMusicButton_Click;
            Panel2.Controls.Add(ImportMusicButton); 
        }

        void MusicOrVidsButton_Click(object sender3, EventArgs e3)
        {
            Panel2.Controls.Clear();

            Label SearchLabel = new Label();
            SearchLabel.Text = "Search";
            this.Controls.Add(SearchLabel);

            TextBox SearchBar = new TextBox();
            this.Controls.Add(SearchBar);
            string search = SearchBar.Text;

            Label filterOptionsLabel = new Label();
            filterOptionsLabel.Text = "Do you want to use any filters?";
            this.Controls.Add(filterOptionsLabel);

            Label filterYesLabel = new Label();
            filterYesLabel.Text = "Yes";
            this.Controls.Add(filterYesLabel);
            RadioButton filterYes = new RadioButton();
            this.Controls.Add(filterYes);

            Label filterNoLabel = new Label();
            filterNoLabel.Text = "No";
            this.Controls.Add(filterNoLabel);
            RadioButton filterNo = new RadioButton();
            this.Controls.Add(filterNo);

            if (filterYes.Checked == true)
            {
                List<int> filtersUsed = new List<int>();

                Label optionsLabel = new Label();
                optionsLabel.Text = "What filters do you want to use?";
                Panel2.Controls.Add(optionsLabel);

                //Song filter options
                Label songFiltersLabel = new Label();
                songFiltersLabel.Text = "For songs: ";
                Panel2.Controls.Add(songFiltersLabel);

                CheckBox songName = new CheckBox();
                songName.Text = "Name";
                Panel2.Controls.Add(songName);
                if (songName.Checked == true)
                {
                    filtersUsed.Add(1);
                }

                CheckBox songArtist = new CheckBox();
                songArtist.Text = "Artist";
                Panel2.Controls.Add(songArtist);
                if (songArtist.Checked == true)
                {
                    filtersUsed.Add(2);
                }

                CheckBox songAlbum = new CheckBox();
                songAlbum.Text = "Album";
                Panel2.Controls.Add(songAlbum);
                if (songAlbum.Checked == true)
                {
                    filtersUsed.Add(3);
                }

                CheckBox songGenre = new CheckBox();
                songGenre.Text = "Genre";
                Panel2.Controls.Add(songGenre);
                if (songGenre.Checked == true)
                {
                    filtersUsed.Add(4);
                }

                //Video filter options
                Label videoFiltersLabel = new Label();
                videoFiltersLabel.Text = "For videos: ";
                Panel2.Controls.Add(videoFiltersLabel);

                CheckBox videoName = new CheckBox();
                videoName.Text = "Name";
                Panel2.Controls.Add(videoName);
                if (videoName.Checked == true)
                {
                    filtersUsed.Add(5);
                }

                CheckBox videoCreator = new CheckBox();
                videoCreator.Text = "Creator";
                Panel2.Controls.Add(videoCreator);
                if (videoCreator.Checked == true)
                {
                    filtersUsed.Add(6);
                }

                CheckBox videoGenre = new CheckBox();
                videoGenre.Text = "Genre";
                Panel2.Controls.Add(videoGenre);
                if (videoGenre.Checked == true)
                {
                    filtersUsed.Add(7);
                }

                CheckBox videoCat = new CheckBox();
                videoCat.Text = "Category";
                Panel2.Controls.Add(videoCat);
                if (videoCat.Checked == true)
                {
                    filtersUsed.Add(8);
                }

                CheckBox videoDirector = new CheckBox();
                videoDirector.Text = "Director";
                Panel2.Controls.Add(videoDirector);
                if (videoDirector.Checked == true)
                {
                    filtersUsed.Add(9);
                }

                CheckBox videoStudio = new CheckBox();
                videoStudio.Text = "Studio";
                Panel2.Controls.Add(videoStudio);
                if (videoStudio.Checked == true)
                {
                    filtersUsed.Add(10);
                }

                Filter f = new Filter();
                List<object> filteredSearchResults =
                    f.FilteredSearch(filtersUsed, search);

                if (filteredSearchResults.Count == 2)
                {
                    object songList = filteredSearchResults[0];
                    object vidList = filteredSearchResults[1];
                }

                ListBox searchResSongLB = new ListBox();
                ListBox searchResVidLB = new ListBox();

                ListBox searchResLB = new ListBox();

                foreach(object o in filteredSearchResults)
                {
                    searchResLB.Items.Add(o);
                }

                object choice = searchResLB.SelectedItem;

                Panel2.Controls.Add(searchResLB);

            }

            else
            {
                Filter f = new Filter();
                List<object> searchResults = f.Search(search);
                ListBox LB = new ListBox();
                
                foreach(object o in searchResults)
                {
                    LB.Items.Add(o);
                }

                object choice = LB.SelectedItem;

                Panel2.Controls.Add(LB);
            }

        }

        void PlaylistsButton_Click(object sender3, EventArgs e3)
        {
            Panel2.Controls.Clear();

            ListBox playlistsLB = new ListBox();
            User u = Spotflix.GetUserDB[username];
            List<Playlist> p = u.GetPlaylist();
            if (p.Count == 0)
            {
                Label warningLabel = new Label();
                warningLabel.Text = "You have no playlists!";
            }

            else
            {
                foreach (Playlist i in p)
                {
                    string pName = i.GetName();
                    playlistsLB.Items.Add(pName);
                }

                Panel2.Controls.Add(playlistsLB);
                string chosenPlaylist = (string)playlistsLB.SelectedItem;
                Playlist thePlaylist = new Playlist("a", true, u);

                foreach (Playlist i in p)
                {
                    if (i.GetName() == chosenPlaylist)
                    {
                        thePlaylist = i;
                    }
                }

                ListBox mediaListBox = new ListBox();
                foreach (Media m in thePlaylist.GetList())
                {
                    string mName = m.GetName();
                    mediaListBox.Items.Add(mName);
                }
                Panel2.Controls.Add(mediaListBox);

            }
        }

        void OtherAccountsButton_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();

            Label searchBarLabel = new Label();
            searchBarLabel.Text = "Search for other accounts by their username";
            Panel2.Controls.Add(searchBarLabel);

            TextBox searchBar = new TextBox();
            Panel2.Controls.Add(searchBar);
            string search = searchBar.Text;
            User account = Spotflix.GetUserDB[username];
            bool proof = false;

            if (Spotflix.GetUserDB.ContainsKey(search) == true)
            {
                account = Spotflix.GetUserDB[search];
                proof = true;
            }

            Label searchedUserLabel = new Label();
            if (proof == true)
            {
                searchedUserLabel.Text = account.GetUsername();
                List<string> optionsList = new List<string>
                    { "See playlists", "Follow", "See followers" };
                ListBox userAttributes = new ListBox();
                foreach (string s in optionsList)
                {
                    userAttributes.Items.Add(s);
                }
                Panel2.Controls.Add(userAttributes);

                string selectedOption = (string)userAttributes.SelectedItem;

                if (selectedOption == "See playlists")
                {
                    ListBox playlistLB = new ListBox();
                    List<Playlist> p = account.GetPlaylist();
                    foreach (Playlist p2 in p)
                    {
                        string pName = p2.GetName();
                        playlistLB.Items.Add(pName);
                    }
                    Panel2.Controls.Add(playlistLB);
                    string chosenPlaylist = (string)playlistLB.SelectedItem;
                    ListBox songLB = new ListBox();

                    foreach (Playlist pl in account.GetPlaylist())
                    {
                        if (pl.GetName() == chosenPlaylist)
                        {
                            foreach (Song s in pl.GetList())
                            {
                                songLB.Items.Add(s);
                            }
                        }
                    }
                    Panel2.Controls.Add(songLB);

                }

                else if (selectedOption == "Follow")
                {
                    account.Follow(account, Spotflix.GetUserDB[username]);
                }

                else if (selectedOption == "See followers")
                {
                    account.GetFollowers();
                }

            }
            else
            {
                searchedUserLabel.Text = "No user was found";
            }
            Panel2.Controls.Add(searchedUserLabel);
        }

        void ImportMusicButton_Click(object sender3, EventArgs e3)
        {
            Panel2.Controls.Clear();
            
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            Panel2.Controls.Add(openFileDialog1);

            if (result == DialogResult.OK)
            {

                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {

                }
            }


        }

    }



    
}

