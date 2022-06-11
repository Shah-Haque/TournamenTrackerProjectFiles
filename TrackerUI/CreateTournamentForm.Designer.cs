
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreateNewTeamLabel = new System.Windows.Forms.LinkLabel();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersLabel = new System.Windows.Forms.Label();
            this.TournamentTeamslistbox = new System.Windows.Forms.ListBox();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.RemoveSelectedTeamButton = new System.Windows.Forms.Button();
            this.RemoveSelectedPrizesButton = new System.Windows.Forms.Button();
            this.Create_TournamentButton = new System.Windows.Forms.Button();
            this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.Label_SelectTeam = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Bold);
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentLabel.Location = new System.Drawing.Point(8, 14);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(420, 62);
            this.CreateTournamentLabel.TabIndex = 1;
            this.CreateTournamentLabel.Text = "Create Tournament";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentNameLabel.Location = new System.Drawing.Point(12, 88);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.TournamentNameLabel.TabIndex = 10;
            this.TournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(143, 235);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(128, 43);
            this.EntryFeeValue.TabIndex = 13;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.EntryFeeLabel.Location = new System.Drawing.Point(12, 235);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.EntryFeeLabel.TabIndex = 12;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(126, 442);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(155, 49);
            this.AddTeamButton.TabIndex = 17;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // CreateNewTeamLabel
            // 
            this.CreateNewTeamLabel.AutoSize = true;
            this.CreateNewTeamLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CreateNewTeamLabel.Location = new System.Drawing.Point(316, 342);
            this.CreateNewTeamLabel.Name = "CreateNewTeamLabel";
            this.CreateNewTeamLabel.Size = new System.Drawing.Size(112, 28);
            this.CreateNewTeamLabel.TabIndex = 18;
            this.CreateNewTeamLabel.TabStop = true;
            this.CreateNewTeamLabel.Text = "Create New";
            this.CreateNewTeamLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateNewTeamLabel_LinkClicked);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(91, 506);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(240, 53);
            this.CreatePrizeButton.TabIndex = 19;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // TournamentPlayersLabel
            // 
            this.TournamentPlayersLabel.AutoSize = true;
            this.TournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentPlayersLabel.Location = new System.Drawing.Point(459, 39);
            this.TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            this.TournamentPlayersLabel.Size = new System.Drawing.Size(165, 32);
            this.TournamentPlayersLabel.TabIndex = 20;
            this.TournamentPlayersLabel.Text = "Teams/Players";
            // 
            // TournamentTeamslistbox
            // 
            this.TournamentTeamslistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentTeamslistbox.FormattingEnabled = true;
            this.TournamentTeamslistbox.ItemHeight = 37;
            this.TournamentTeamslistbox.Location = new System.Drawing.Point(465, 88);
            this.TournamentTeamslistbox.Name = "TournamentTeamslistbox";
            this.TournamentTeamslistbox.Size = new System.Drawing.Size(402, 187);
            this.TournamentTeamslistbox.TabIndex = 21;
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 37;
            this.PrizesListBox.Location = new System.Drawing.Point(465, 350);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(402, 187);
            this.PrizesListBox.TabIndex = 23;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.PrizesLabel.Location = new System.Drawing.Point(459, 315);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(76, 32);
            this.PrizesLabel.TabIndex = 22;
            this.PrizesLabel.Text = "Prizes";
            // 
            // RemoveSelectedTeamButton
            // 
            this.RemoveSelectedTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RemoveSelectedTeamButton.Location = new System.Drawing.Point(891, 129);
            this.RemoveSelectedTeamButton.Name = "RemoveSelectedTeamButton";
            this.RemoveSelectedTeamButton.Size = new System.Drawing.Size(171, 80);
            this.RemoveSelectedTeamButton.TabIndex = 24;
            this.RemoveSelectedTeamButton.Text = "Remove Selected";
            this.RemoveSelectedTeamButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedTeamButton.Click += new System.EventHandler(this.RemoveSelectedTeamButton_Click);
            // 
            // RemoveSelectedPrizesButton
            // 
            this.RemoveSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedPrizesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RemoveSelectedPrizesButton.Location = new System.Drawing.Point(888, 401);
            this.RemoveSelectedPrizesButton.Name = "RemoveSelectedPrizesButton";
            this.RemoveSelectedPrizesButton.Size = new System.Drawing.Size(171, 80);
            this.RemoveSelectedPrizesButton.TabIndex = 25;
            this.RemoveSelectedPrizesButton.Text = "Remove Selected";
            this.RemoveSelectedPrizesButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedPrizesButton.Click += new System.EventHandler(this.RemoveSelectedPrizesButton_Click);
            // 
            // Create_TournamentButton
            // 
            this.Create_TournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Create_TournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Create_TournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Create_TournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_TournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_TournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Create_TournamentButton.Location = new System.Drawing.Point(441, 591);
            this.Create_TournamentButton.Name = "Create_TournamentButton";
            this.Create_TournamentButton.Size = new System.Drawing.Size(240, 53);
            this.Create_TournamentButton.TabIndex = 27;
            this.Create_TournamentButton.Text = "Create Tournament";
            this.Create_TournamentButton.UseVisualStyleBackColor = true;
            this.Create_TournamentButton.Click += new System.EventHandler(this.Create_TournamentButton_Click);
            // 
            // SelectTeamDropdown
            // 
            this.SelectTeamDropdown.ForeColor = System.Drawing.Color.Black;
            this.SelectTeamDropdown.FormattingEnabled = true;
            this.SelectTeamDropdown.Location = new System.Drawing.Point(6, 379);
            this.SelectTeamDropdown.Name = "SelectTeamDropdown";
            this.SelectTeamDropdown.Size = new System.Drawing.Size(422, 45);
            this.SelectTeamDropdown.TabIndex = 28;
            // 
            // Label_SelectTeam
            // 
            this.Label_SelectTeam.AutoSize = true;
            this.Label_SelectTeam.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Label_SelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Label_SelectTeam.Location = new System.Drawing.Point(5, 335);
            this.Label_SelectTeam.Name = "Label_SelectTeam";
            this.Label_SelectTeam.Size = new System.Drawing.Size(156, 37);
            this.Label_SelectTeam.TabIndex = 29;
            this.Label_SelectTeam.Text = "Select Team";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(12, 129);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(376, 43);
            this.TournamentNameValue.TabIndex = 30;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 690);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.Label_SelectTeam);
            this.Controls.Add(this.SelectTeamDropdown);
            this.Controls.Add(this.Create_TournamentButton);
            this.Controls.Add(this.RemoveSelectedPrizesButton);
            this.Controls.Add(this.RemoveSelectedTeamButton);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.TournamentTeamslistbox);
            this.Controls.Add(this.TournamentPlayersLabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.CreateNewTeamLabel);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournamentLabel;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.LinkLabel CreateNewTeamLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.Label TournamentPlayersLabel;
        private System.Windows.Forms.ListBox TournamentTeamslistbox;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.Button RemoveSelectedTeamButton;
        private System.Windows.Forms.Button RemoveSelectedPrizesButton;
        private System.Windows.Forms.Button Create_TournamentButton;
        private System.Windows.Forms.ComboBox SelectTeamDropdown;
        private System.Windows.Forms.Label Label_SelectTeam;
        private System.Windows.Forms.TextBox TournamentNameValue;
    }
}