using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            RetUserDataLabel.Text = "Please enter your account data";
            this.Controls.Add(RetUserDataLabel);

            //Returning user username
            Label RetUserUsernameLabel = new Label();
            RetUserUsernameLabel.Text = "Username";
            this.Controls.Add(RetUserUsernameLabel);
            TextBox RetUserUsernameTB = new TextBox();
            this.Controls.Add(RetUserUsernameTB);
            string username = RetUserUsernameTB.Text;

            //Returning user password
            Label RetUserPassLabel = new Label();
            RetUserPassLabel.Text = "Password";
            this.Controls.Add(RetUserPassLabel);
            TextBox RetUserPassTB = new TextBox();
            this.Controls.Add(RetUserPassTB);
            string password = RetUserPassTB.Text;

            Button DoneButton = new Button();
            DoneButton.Text = "Enter";
            this.Controls.Add(DoneButton);

            void DoneButton_Click(object sender2, EventArgs e2)
            {
                //Removing all previous Windows Forms elements
                this.Controls.Remove(RetUserDataLabel);
                this.Controls.Remove(RetUserUsernameLabel);
                this.Controls.Remove(RetUserUsernameTB);
                this.Controls.Remove(RetUserPassLabel);
                this.Controls.Remove(RetUserPassTB);
                this.Controls.Remove(DoneButton);

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

            }

        }
    }
}
