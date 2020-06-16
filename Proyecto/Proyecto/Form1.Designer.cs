namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SpotflixLabel = new System.Windows.Forms.Label();
            this.NewOrRetLabel = new System.Windows.Forms.Label();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.RetUserButton = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpotflixLabel
            // 
            this.SpotflixLabel.AutoSize = true;
            this.SpotflixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpotflixLabel.Location = new System.Drawing.Point(348, 47);
            this.SpotflixLabel.Name = "SpotflixLabel";
            this.SpotflixLabel.Size = new System.Drawing.Size(459, 55);
            this.SpotflixLabel.TabIndex = 0;
            this.SpotflixLabel.Text = "Welcome to Spotflix!";
            // 
            // NewOrRetLabel
            // 
            this.NewOrRetLabel.AutoSize = true;
            this.NewOrRetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrRetLabel.Location = new System.Drawing.Point(313, 188);
            this.NewOrRetLabel.Name = "NewOrRetLabel";
            this.NewOrRetLabel.Size = new System.Drawing.Size(561, 42);
            this.NewOrRetLabel.TabIndex = 1;
            this.NewOrRetLabel.Text = "Are you a new or returning user?";
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(187, 318);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(199, 69);
            this.NewUserButton.TabIndex = 2;
            this.NewUserButton.Text = "New";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click_1);
            // 
            // RetUserButton
            // 
            this.RetUserButton.Location = new System.Drawing.Point(785, 313);
            this.RetUserButton.Name = "RetUserButton";
            this.RetUserButton.Size = new System.Drawing.Size(199, 74);
            this.RetUserButton.TabIndex = 3;
            this.RetUserButton.Text = "Returning";
            this.RetUserButton.UseVisualStyleBackColor = true;
            this.RetUserButton.Click += new System.EventHandler(this.RetUserButton_Click);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.SpotflixLabel);
            this.Panel1.Controls.Add(this.RetUserButton);
            this.Panel1.Controls.Add(this.NewOrRetLabel);
            this.Panel1.Controls.Add(this.NewUserButton);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1169, 684);
            this.Panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 696);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SpotflixLabel;
        private System.Windows.Forms.Label NewOrRetLabel;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button RetUserButton;
        private System.Windows.Forms.Panel Panel1;
    }
}