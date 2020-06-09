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
            Label NoLabel = new Label();
            NoLabel.Text = "No";
            NoLabel.Location = new Point(90, 240);
            this.Controls.Add(NoLabel);
            RadioButton PrivateUserNo = new RadioButton();
            PrivateUserNo.Location = new Point(200, 240);
            this.Controls.Add(PrivateUserNo);

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
            Label NoLabel2 = new Label();
            NoLabel2.Text = "No";
            NoLabel2.Location = new Point(200, 360);
            this.Controls.Add(NoLabel2);
            RadioButton PremiumUserNo = new RadioButton();
            PremiumUserNo.Location = new Point(240, 390);
            this.Controls.Add(PremiumUserNo);

            Button DoneButton = new Button();
            DoneButton.Location = new Point(300, 200);
            DoneButton.Text = "Enter";
            this.Controls.Add(DoneButton);

        }
    }
}
