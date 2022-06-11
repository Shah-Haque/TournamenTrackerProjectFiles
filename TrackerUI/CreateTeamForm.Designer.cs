
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.TeamMemberslistbox = new System.Windows.Forms.ListBox();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.RemoveSelectedMemberButton = new System.Windows.Forms.Button();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.Telephone_Label = new System.Windows.Forms.Label();
            this.TelephoneValue = new System.Windows.Forms.TextBox();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lbl_TeamShortListName = new System.Windows.Forms.Label();
            this.AddNewMemberGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Bold);
            this.CreateTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamLabel.Location = new System.Drawing.Point(15, 9);
            this.CreateTeamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(283, 62);
            this.CreateTeamLabel.TabIndex = 2;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(12, 111);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(512, 43);
            this.TeamNameValue.TabIndex = 12;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(25, 71);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.TeamNameLabel.TabIndex = 13;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(19, 168);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamMemberLabel.TabIndex = 14;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // SelectTeamMemberDropdown
            // 
            this.SelectTeamMemberDropdown.FormattingEnabled = true;
            this.SelectTeamMemberDropdown.Location = new System.Drawing.Point(12, 208);
            this.SelectTeamMemberDropdown.Name = "SelectTeamMemberDropdown";
            this.SelectTeamMemberDropdown.Size = new System.Drawing.Size(512, 45);
            this.SelectTeamMemberDropdown.TabIndex = 17;
            // 
            // TeamMemberslistbox
            // 
            this.TeamMemberslistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMemberslistbox.FormattingEnabled = true;
            this.TeamMemberslistbox.ItemHeight = 37;
            this.TeamMemberslistbox.Location = new System.Drawing.Point(548, 108);
            this.TeamMemberslistbox.Name = "TeamMemberslistbox";
            this.TeamMemberslistbox.Size = new System.Drawing.Size(441, 520);
            this.TeamMemberslistbox.TabIndex = 26;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(664, 673);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(218, 49);
            this.CreateTeamButton.TabIndex = 27;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // RemoveSelectedMemberButton
            // 
            this.RemoveSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RemoveSelectedMemberButton.Location = new System.Drawing.Point(1004, 287);
            this.RemoveSelectedMemberButton.Name = "RemoveSelectedMemberButton";
            this.RemoveSelectedMemberButton.Size = new System.Drawing.Size(128, 80);
            this.RemoveSelectedMemberButton.TabIndex = 30;
            this.RemoveSelectedMemberButton.Text = "Remove Selected";
            this.RemoveSelectedMemberButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedMemberButton.Click += new System.EventHandler(this.RemoveSelectedMemberButton_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddMemberButton.Location = new System.Drawing.Point(108, 268);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(190, 47);
            this.AddMemberButton.TabIndex = 32;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // AddNewMemberGroupbox
            // 
            this.AddNewMemberGroupbox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupbox.Controls.Add(this.Telephone_Label);
            this.AddNewMemberGroupbox.Controls.Add(this.TelephoneValue);
            this.AddNewMemberGroupbox.Controls.Add(this.EmailValue);
            this.AddNewMemberGroupbox.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroupbox.Controls.Add(this.LastNameValue);
            this.AddNewMemberGroupbox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupbox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupbox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupbox.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.AddNewMemberGroupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddNewMemberGroupbox.Location = new System.Drawing.Point(12, 321);
            this.AddNewMemberGroupbox.Name = "AddNewMemberGroupbox";
            this.AddNewMemberGroupbox.Size = new System.Drawing.Size(512, 401);
            this.AddNewMemberGroupbox.TabIndex = 33;
            this.AddNewMemberGroupbox.TabStop = false;
            this.AddNewMemberGroupbox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateMemberButton.Location = new System.Drawing.Point(110, 331);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(231, 56);
            this.CreateMemberButton.TabIndex = 32;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // Telephone_Label
            // 
            this.Telephone_Label.AutoSize = true;
            this.Telephone_Label.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Telephone_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Telephone_Label.Location = new System.Drawing.Point(2, 283);
            this.Telephone_Label.Name = "Telephone_Label";
            this.Telephone_Label.Size = new System.Drawing.Size(146, 37);
            this.Telephone_Label.TabIndex = 31;
            this.Telephone_Label.Text = "Telephone ";
            // 
            // TelephoneValue
            // 
            this.TelephoneValue.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TelephoneValue.Location = new System.Drawing.Point(149, 273);
            this.TelephoneValue.Name = "TelephoneValue";
            this.TelephoneValue.Size = new System.Drawing.Size(340, 41);
            this.TelephoneValue.TabIndex = 15;
            // 
            // EmailValue
            // 
            this.EmailValue.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.EmailValue.Location = new System.Drawing.Point(149, 208);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(340, 41);
            this.EmailValue.TabIndex = 15;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EmailLabel.Location = new System.Drawing.Point(6, 211);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 37);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LastNameValue.Location = new System.Drawing.Point(149, 139);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(340, 41);
            this.LastNameValue.TabIndex = 15;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LastNameLabel.Location = new System.Drawing.Point(6, 139);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.LastNameLabel.TabIndex = 14;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.FirstNameValue.Location = new System.Drawing.Point(149, 72);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(340, 41);
            this.FirstNameValue.TabIndex = 13;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 72);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "First Name";
            // 
            // lbl_TeamShortListName
            // 
            this.lbl_TeamShortListName.AutoSize = true;
            this.lbl_TeamShortListName.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lbl_TeamShortListName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lbl_TeamShortListName.Location = new System.Drawing.Point(554, 59);
            this.lbl_TeamShortListName.Name = "lbl_TeamShortListName";
            this.lbl_TeamShortListName.Size = new System.Drawing.Size(196, 37);
            this.lbl_TeamShortListName.TabIndex = 34;
            this.lbl_TeamShortListName.Text = "Team Short List";
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 759);
            this.Controls.Add(this.lbl_TeamShortListName);
            this.Controls.Add(this.AddNewMemberGroupbox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.RemoveSelectedMemberButton);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.TeamMemberslistbox);
            this.Controls.Add(this.SelectTeamMemberDropdown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberGroupbox.ResumeLayout(false);
            this.AddNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropdown;
        private System.Windows.Forms.ListBox TeamMemberslistbox;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Button RemoveSelectedMemberButton;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.GroupBox AddNewMemberGroupbox;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.Label Telephone_Label;
        private System.Windows.Forms.TextBox TelephoneValue;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label lbl_TeamShortListName;
    }
}