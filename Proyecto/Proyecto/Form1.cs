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

        private void NewUserButton_Click_1(object sender, EventArgs e)
        {
            this.Controls.Remove(SpotflixLabel);
            this.Controls.Remove(NewOrRetLabel);
            this.Controls.Remove(RetUserButton);
            this.Controls.Remove(NewUserButton);

            Label UserNameLabel = new Label();
            UserNameLabel.Location = new Point(90, 50);
            UserNameLabel.Text = "Username";
            this.Controls.Add(UserNameLabel);
            TextBox UserNameTB = new TextBox();
            UserNameTB.Location = new Point(200, 50);
            UserNameTB.ReadOnly = false;
            this.Controls.Add(UserNameTB);
            string username = UserNameTB.Text;

            Label UserPassLabel = new Label();
            UserPassLabel.Location = new Point(90, 100);
            UserPassLabel.Text = "Password";
            this.Controls.Add(UserPassLabel);
            TextBox UserPassTB = new TextBox();
            UserPassTB.Location = new Point(200, 100);
            UserPassTB.Size = new Size(90, 24);
            UserPassTB.ReadOnly = false;
            this.Controls.Add(UserPassTB);
            string password = UserPassTB.Text;

            Label UserEmailLabel = new Label();
            UserEmailLabel.Location = new Point(90, 150);
            UserEmailLabel.Text = "Email";
            this.Controls.Add(UserEmailLabel);
            TextBox UserEmailTB = new TextBox();
            UserEmailTB.Location = new Point(200, 150);
            this.Controls.Add(UserEmailTB);
            string email = UserEmailTB.Text;

            Label PrivateButtonLabel = new Label();
            PrivateButtonLabel.Text = "Do you wish to get a private account?";
            PrivateButtonLabel.AutoSize = true;
            PrivateButtonLabel.Location = new Point(90, 200);
            this.Controls.Add(PrivateButtonLabel);
            Label YesLabel = new Label();
            YesLabel.Text = "Yes";
            YesLabel.Location = new Point(90, 220);
            this.Controls.Add(YesLabel);
            RadioButton PrivateUserYes = new RadioButton();
            PrivateUserYes.Location = new Point(200, 220);
            this.Controls.Add(PrivateUserYes);
            bool privateUser;
            if (PrivateUserYes.Checked == true)
            {
                privateUser = true;
            }
            Label NoLabel = new Label();
            NoLabel.Text = "No";
            NoLabel.Location = new Point(90, 240);
            this.Controls.Add(NoLabel);
            RadioButton PrivateUserNo = new RadioButton();
            PrivateUserNo.Location = new Point(200, 240);
            this.Controls.Add(PrivateUserNo);
            if (PrivateUserNo.Checked == true)
            {
                privateUser = false;
            }

            Label PremiumButtonLabel = new Label();
            PremiumButtonLabel.Text = "Do you wish to have a premium account?";
            PremiumButtonLabel.AutoSize = true;
            PremiumButtonLabel.Location = new Point(200, 270);
            this.Controls.Add(PremiumButtonLabel);
            Label YesLabel2 = new Label();
            YesLabel2.Text = "Yes";
            YesLabel2.Location = new Point(200, 300);
            this.Controls.Add(YesLabel2);
            RadioButton PremiumUserYes = new RadioButton();
            PremiumUserYes.Location = new Point(200, 330);
            this.Controls.Add(PremiumUserYes);
            bool premium;
            if (PremiumUserYes.Checked == true)
            {
                premium = true;
            }
            Label NoLabel2 = new Label();
            NoLabel2.Text = "No";
            NoLabel2.Location = new Point(200, 360);
            this.Controls.Add(NoLabel2);
            RadioButton PremiumUserNo = new RadioButton();
            PremiumUserNo.Location = new Point(240, 390);
            if (PremiumUserNo.Checked == true)
            {
                premium = false;
            }
            this.Controls.Add(PremiumUserNo);

            Button DoneButton = new Button();
            DoneButton.Location = new Point(300, 200);
            DoneButton.Text = "Enter";
            this.Controls.Add(DoneButton);

            void DoneButton_Click(object sender2, EventArgs e2)
            {
                User NewUser = new User(username, email, password, privateUser, premium);
                Spotflix.GetUserDB.Add(username, NewUser);
            }
        }

        //Falta poner los lugares donde van quedar
       private void RetUserButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(SpotflixLabel);
            this.Controls.Remove(NewOrRetLabel);
            this.Controls.Remove(RetUserButton);
            this.Controls.Remove(NewUserButton);

            Label RetUserDataLabel = new Label();
            RetUserDataLabel.Location = new Point(140, 50);
            RetUserDataLabel.Text = "Please enter your account data";
            RetUserDataLabel.Size = new Size(200, 40);
            this.Controls.Add(RetUserDataLabel);

            //Returning user username
            Label RetUserUsernameLabel = new Label();
            RetUserUsernameLabel.Location = new Point(200, 100);
            RetUserUsernameLabel.Text = "Username";
            this.Controls.Add(RetUserUsernameLabel);
            TextBox RetUserUsernameTB = new TextBox();
            RetUserUsernameTB.Location = new Point(300, 100);
            this.Controls.Add(RetUserUsernameTB);
            string username = RetUserUsernameTB.Text;

            //Returning user password
            Label RetUserPassLabel = new Label();
            RetUserPassLabel.Location = new Point(200, 140);
            RetUserPassLabel.Text = "Password";
            this.Controls.Add(RetUserPassLabel);
            TextBox RetUserPassTB = new TextBox();
            RetUserPassTB.Location = new Point(300, 140);
            this.Controls.Add(RetUserPassTB);
            string password = RetUserPassTB.Text;

            Button RetDoneButton = new Button();
            RetDoneButton.Text = "Enter";
            RetDoneButton.Location = new Point(240, 200);
            this.Controls.Add(RetDoneButton);

            void DoneButton_Click(object sender2, EventArgs e2)
            {
                //Removing all previous Windows Forms elements
                this.Controls.Remove(RetUserDataLabel);
                this.Controls.Remove(RetUserUsernameLabel);
                this.Controls.Remove(RetUserUsernameTB);
                this.Controls.Remove(RetUserPassLabel);
                this.Controls.Remove(RetUserPassTB);
                this.Controls.Remove(RetDoneButton);

                Label WelcomeBackLabel = new Label();
                WelcomeBackLabel.Text = "Welcome Back!";
                this.Controls.Add(WelcomeBackLabel);

                Label OptionsLabel = new Label();
                OptionsLabel.Text = "What do you want to do?";
                this.Controls.Add(OptionsLabel);

                
                Button MusicOrVidsButton = new Button();
                MusicOrVidsButton.Text = "Search for music or videos";
                this.Controls.Add(MusicOrVidsButton);

                Button PlaylistsButton = new Button();
                PlaylistsButton.Text = "Access your playlists";
                this.Controls.Add(PlaylistsButton);

                Button OtherAccountsButton = new Button();
                OtherAccountsButton.Text = "Look for other accounts";
                this.Controls.Add(OtherAccountsButton);

                Button ImportMusicButton = new Button();
                ImportMusicButton.Text = "Import a music file";
                this.Controls.Add(ImportMusicButton);

                void MusicOrVidsButton_Click(object sender3, EventArgs e3)
                {
                    this.Controls.Remove(WelcomeBackLabel);
                    this.Controls.Remove(OptionsLabel);
                    this.Controls.Remove(MusicOrVidsButton);
                    this.Controls.Remove(PlaylistsButton);
                    this.Controls.Remove(OtherAccountsButton);

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
                        this.Controls.Add(optionsLabel);

                        //Song filter options
                        Label songFiltersLabel = new Label();
                        songFiltersLabel.Text = "For songs: ";
                        this.Controls.Add(songFiltersLabel);

                        CheckBox songName = new CheckBox();
                        songName.Text = "Name";
                        this.Controls.Add(songName);
                        if (songName.Checked == true)
                        {
                            filtersUsed.Add(1);
                        }

                        CheckBox songArtist = new CheckBox();
                        songArtist.Text = "Artist";
                        this.Controls.Add(songArtist);
                        if (songArtist.Checked == true)
                        {
                            filtersUsed.Add(2);
                        }

                        CheckBox songAlbum = new CheckBox();
                        songAlbum.Text = "Album";
                        this.Controls.Add(songAlbum);
                        if (songAlbum.Checked == true)
                        {
                            filtersUsed.Add(3);
                        }

                        CheckBox songGenre = new CheckBox();
                        songGenre.Text = "Genre";
                        this.Controls.Add(songGenre);
                        if (songGenre.Checked == true)
                        {
                            filtersUsed.Add(4);
                        }

                        //Video filter options
                        Label videoFiltersLabel = new Label();
                        videoFiltersLabel.Text = "For videos: ";
                        this.Controls.Add(videoFiltersLabel);

                        CheckBox videoName = new CheckBox();
                        videoName.Text = "Name";
                        this.Controls.Add(videoName);
                        if (videoName.Checked == true)
                        {
                            filtersUsed.Add(5);
                        }

                        CheckBox videoCreator = new CheckBox();
                        videoCreator.Text = "Creator";
                        this.Controls.Add(videoCreator);
                        if (videoCreator.Checked == true)
                        {
                            filtersUsed.Add(6);
                        }

                        CheckBox videoGenre = new CheckBox();
                        videoGenre.Text = "Genre";
                        this.Controls.Add(videoGenre);
                        if (videoGenre.Checked == true)
                        {
                            filtersUsed.Add(7);
                        }

                        CheckBox videoCat = new CheckBox();
                        videoCat.Text = "Category";
                        this.Controls.Add(videoCat);
                        if (videoCat.Checked == true)
                        {
                            filtersUsed.Add(8);
                        }

                        CheckBox videoDirector = new CheckBox();
                        videoDirector.Text = "Director";
                        this.Controls.Add(videoDirector);
                        if (videoDirector.Checked == true)
                        {
                            filtersUsed.Add(9);
                        }

                        CheckBox videoStudio = new CheckBox();
                        videoStudio.Text = "Studio";
                        this.Controls.Add(videoStudio);
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

                        this.Controls.Add(searchResSongLB);
                        this.Controls.Add(searchResVidLB);
                        object choice = searchResSongLB.SelectedItem;

                    }

                    else
                    {
                        Filter f = new Filter();
                        List<object> searchResults = f.Search(search);
                    }

                }

                void PlaylistsButton_Click(object sender3, EventArgs e3)
                {
                    this.Controls.Remove(WelcomeBackLabel);
                    this.Controls.Remove(OptionsLabel);
                    this.Controls.Remove(MusicOrVidsButton);
                    this.Controls.Remove(PlaylistsButton);
                    this.Controls.Remove(OtherAccountsButton);

                    ListBox playlistsList = new ListBox();
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
                            playlistsList.Items.Add(pName);
                        }

                        this.Controls.Add(playlistsList);
                        string chosenPlaylist = (string)playlistsList.SelectedItem;
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
                        this.Controls.Add(mediaListBox);

                    }
                }

                void OtherAccountsButton_Click(object sender3, EventArgs e3)
                {
                    this.Controls.Remove(WelcomeBackLabel);
                    this.Controls.Remove(OptionsLabel);
                    this.Controls.Remove(MusicOrVidsButton);
                    this.Controls.Remove(PlaylistsButton);
                    this.Controls.Remove(OtherAccountsButton);

                    Label searchBarLabel = new Label();
                    searchBarLabel.Text = "Search for other accounts by their username";
                    this.Controls.Add(searchBarLabel);

                    TextBox searchBar = new TextBox();
                    this.Controls.Add(searchBar);
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
                        this.Controls.Add(userAttributes);

                        string selectedOption = (string)userAttributes.SelectedItem;

                        if (selectedOption == "See playlists")
                        {
                            ListBox playlistLB = new ListBox();
                            List<Playlist> p = account.GetPlaylist();
                            foreach(Playlist p2 in p)
                            {
                                string pName = p2.GetName();
                                playlistLB.Items.Add(pName);
                            }
                            this.Controls.Add(playlistLB);
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
                            this.Controls.Add(songLB);

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
                    this.Controls.Add(searchedUserLabel);
                }

                void ImportOtherMusicButton_Click(object sender3, EventArgs e3)
                {
                    int size = -1;
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    DialogResult result = openFileDialog1.ShowDialog();

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
    }
}
