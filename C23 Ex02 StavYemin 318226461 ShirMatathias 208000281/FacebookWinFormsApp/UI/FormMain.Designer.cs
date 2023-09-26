using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookUI
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.linkPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.panelAlbums = new System.Windows.Forms.Panel();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.linkAlbums = new System.Windows.Forms.LinkLabel();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelEvents = new System.Windows.Forms.LinkLabel();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.linkLabelFetchGroups = new System.Windows.Forms.LinkLabel();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.FavouritePlacesList = new System.Windows.Forms.ListView();
            this.header5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFirstStepsOnFacebook = new System.Windows.Forms.Button();
            this.panelFeatures = new System.Windows.Forms.Panel();
            this.buttonFavouritePlaces = new System.Windows.Forms.Button();
            this.panelLikedPages = new System.Windows.Forms.Panel();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.linkLabelLikedPages = new System.Windows.Forms.LinkLabel();
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            this.panelPosts.SuspendLayout();
            this.panelFeatures.SuspendLayout();
            this.panelLikedPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Location = new System.Drawing.Point(27, 20);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfile.Location = new System.Drawing.Point(60, 60);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(188, 172);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // linkPosts
            // 
            this.linkPosts.AutoSize = true;
            this.linkPosts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.linkPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.linkPosts.LinkColor = System.Drawing.Color.Blue;
            this.linkPosts.Location = new System.Drawing.Point(2, 13);
            this.linkPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkPosts.Name = "linkPosts";
            this.linkPosts.Size = new System.Drawing.Size(223, 28);
            this.linkPosts.TabIndex = 74;
            this.linkPosts.TabStop = true;
            this.linkPosts.Text = "Click to view your own Posts!";
            this.linkPosts.UseCompatibleTextRendering = true;
            this.linkPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.DisplayMember = "name";
            this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 29;
            this.listBoxPostComments.Location = new System.Drawing.Point(332, 114);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(310, 62);
            this.listBoxPostComments.TabIndex = 76;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 29;
            this.listBoxPosts.Location = new System.Drawing.Point(18, 56);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(581, 120);
            this.listBoxPosts.TabIndex = 75;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // panelAlbums
            // 
            this.panelAlbums.Controls.Add(this.imageAlbumPictureBox);
            this.panelAlbums.Controls.Add(this.listBoxAlbums);
            this.panelAlbums.Controls.Add(this.linkAlbums);
            this.panelAlbums.Location = new System.Drawing.Point(26, 427);
            this.panelAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(318, 256);
            this.panelAlbums.TabIndex = 78;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(199, 161);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(117, 95);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 1;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 29;
            this.listBoxAlbums.Location = new System.Drawing.Point(4, 52);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(310, 120);
            this.listBoxAlbums.TabIndex = 80;
            // 
            // linkAlbums
            // 
            this.linkAlbums.AutoSize = true;
            this.linkAlbums.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.linkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.linkAlbums.Location = new System.Drawing.Point(4, 8);
            this.linkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkAlbums.Name = "linkAlbums";
            this.linkAlbums.Size = new System.Drawing.Size(212, 28);
            this.linkAlbums.TabIndex = 82;
            this.linkAlbums.TabStop = true;
            this.linkAlbums.Text = "Click to view your Albums!\r\n";
            this.linkAlbums.UseCompatibleTextRendering = true;
            this.linkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // panelEvents
            // 
            this.panelEvents.Controls.Add(this.pictureBoxEvent);
            this.panelEvents.Controls.Add(this.listBoxEvents);
            this.panelEvents.Controls.Add(this.labelEvents);
            this.panelEvents.Location = new System.Drawing.Point(352, 427);
            this.panelEvents.Margin = new System.Windows.Forms.Padding(4);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(346, 256);
            this.panelEvents.TabIndex = 79;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxEvent.Location = new System.Drawing.Point(235, 162);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(111, 94);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEvent.TabIndex = 82;
            this.pictureBoxEvent.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 29;
            this.listBoxEvents.Location = new System.Drawing.Point(0, 52);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(344, 120);
            this.listBoxEvents.TabIndex = 81;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.labelEvents.Location = new System.Drawing.Point(4, 8);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(203, 28);
            this.labelEvents.TabIndex = 83;
            this.labelEvents.TabStop = true;
            this.labelEvents.Text = "Click to view your Events!\r\n";
            this.labelEvents.UseCompatibleTextRendering = true;
            this.labelEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // panelGroups
            // 
            this.panelGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroups.Controls.Add(this.pictureBoxGroup);
            this.panelGroups.Controls.Add(this.listBoxGroups);
            this.panelGroups.Controls.Add(this.linkLabelFetchGroups);
            this.panelGroups.Location = new System.Drawing.Point(721, 427);
            this.panelGroups.Margin = new System.Windows.Forms.Padding(4);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(327, 256);
            this.panelGroups.TabIndex = 80;
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxGroup.Location = new System.Drawing.Point(212, 158);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(111, 94);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGroup.TabIndex = 82;
            this.pictureBoxGroup.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 29;
            this.listBoxGroups.Location = new System.Drawing.Point(0, 52);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(323, 120);
            this.listBoxGroups.TabIndex = 81;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // linkLabelFetchGroups
            // 
            this.linkLabelFetchGroups.AutoSize = true;
            this.linkLabelFetchGroups.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.linkLabelFetchGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.linkLabelFetchGroups.Location = new System.Drawing.Point(8, 8);
            this.linkLabelFetchGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelFetchGroups.Name = "linkLabelFetchGroups";
            this.linkLabelFetchGroups.Size = new System.Drawing.Size(202, 28);
            this.linkLabelFetchGroups.TabIndex = 83;
            this.linkLabelFetchGroups.TabStop = true;
            this.linkLabelFetchGroups.Text = "Click to view your Groups!";
            this.linkLabelFetchGroups.UseCompatibleTextRendering = true;
            this.linkLabelFetchGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchGroups_LinkClicked);
            // 
            // panelPosts
            // 
            this.panelPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPosts.Controls.Add(this.listBoxPostComments);
            this.panelPosts.Controls.Add(this.listBoxPosts);
            this.panelPosts.Controls.Add(this.linkPosts);
            this.panelPosts.Location = new System.Drawing.Point(27, 238);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(4);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(653, 178);
            this.panelPosts.TabIndex = 81;
            // 
            // FavouritePlacesList
            // 
            this.FavouritePlacesList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.FavouritePlacesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header5});
            this.FavouritePlacesList.HideSelection = false;
            this.FavouritePlacesList.Location = new System.Drawing.Point(120, 120);
            this.FavouritePlacesList.Name = "FavouritePlacesList";
            this.FavouritePlacesList.Size = new System.Drawing.Size(319, 129);
            this.FavouritePlacesList.TabIndex = 75;
            this.FavouritePlacesList.UseCompatibleStateImageBehavior = false;
            this.FavouritePlacesList.View = System.Windows.Forms.View.Details;
            // 
            // header5
            // 
            this.header5.Text = "";
            this.header5.Width = 319;
            // 
            // buttonFirstStepsOnFacebook
            // 
            this.buttonFirstStepsOnFacebook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFirstStepsOnFacebook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFirstStepsOnFacebook.Location = new System.Drawing.Point(19, 9);
            this.buttonFirstStepsOnFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFirstStepsOnFacebook.Name = "buttonFirstStepsOnFacebook";
            this.buttonFirstStepsOnFacebook.Size = new System.Drawing.Size(268, 56);
            this.buttonFirstStepsOnFacebook.TabIndex = 85;
            this.buttonFirstStepsOnFacebook.Tag = "FirstSteps";
            this.buttonFirstStepsOnFacebook.Text = "First Steps On Facebook";
            this.buttonFirstStepsOnFacebook.UseVisualStyleBackColor = false;
            this.buttonFirstStepsOnFacebook.Click += new System.EventHandler(this.buttonFacebook_Click);
            // 
            // panelFeatures
            // 
            this.panelFeatures.Controls.Add(this.buttonFavouritePlaces);
            this.panelFeatures.Controls.Add(this.buttonFirstStepsOnFacebook);
            this.panelFeatures.Location = new System.Drawing.Point(729, 20);
            this.panelFeatures.Margin = new System.Windows.Forms.Padding(4);
            this.panelFeatures.Name = "panelFeatures";
            this.panelFeatures.Size = new System.Drawing.Size(310, 132);
            this.panelFeatures.TabIndex = 87;
            // 
            // buttonFavouritePlaces
            // 
            this.buttonFavouritePlaces.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFavouritePlaces.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFavouritePlaces.Location = new System.Drawing.Point(19, 72);
            this.buttonFavouritePlaces.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFavouritePlaces.Name = "buttonFavouritePlaces";
            this.buttonFavouritePlaces.Size = new System.Drawing.Size(268, 56);
            this.buttonFavouritePlaces.TabIndex = 86;
            this.buttonFavouritePlaces.Tag = "FavouritePlaces";
            this.buttonFavouritePlaces.Text = "Favourite Places";
            this.buttonFavouritePlaces.UseVisualStyleBackColor = false;
            this.buttonFavouritePlaces.Click += new System.EventHandler(this.buttonFacebook_Click);
            // 
            // panelLikedPages
            // 
            this.panelLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLikedPages.Controls.Add(this.pictureBoxLikedPages);
            this.panelLikedPages.Controls.Add(this.listBoxLikedPages);
            this.panelLikedPages.Controls.Add(this.linkLabelLikedPages);
            this.panelLikedPages.Location = new System.Drawing.Point(722, 160);
            this.panelLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.panelLikedPages.Name = "panelLikedPages";
            this.panelLikedPages.Size = new System.Drawing.Size(327, 256);
            this.panelLikedPages.TabIndex = 89;
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxLikedPages.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(212, 158);
            this.pictureBoxLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(111, 94);
            this.pictureBoxLikedPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLikedPages.TabIndex = 82;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLikedPages.DisplayMember = "name";
            this.listBoxLikedPages.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 29;
            this.listBoxLikedPages.Location = new System.Drawing.Point(0, 52);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(323, 120);
            this.listBoxLikedPages.TabIndex = 81;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // linkLabelLikedPages
            // 
            this.linkLabelLikedPages.AutoSize = true;
            this.linkLabelLikedPages.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.linkLabelLikedPages.LinkArea = new System.Windows.Forms.LinkArea(0, 35);
            this.linkLabelLikedPages.Location = new System.Drawing.Point(9, 8);
            this.linkLabelLikedPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelLikedPages.Name = "linkLabelLikedPages";
            this.linkLabelLikedPages.Size = new System.Drawing.Size(235, 28);
            this.linkLabelLikedPages.TabIndex = 83;
            this.linkLabelLikedPages.TabStop = true;
            this.linkLabelLikedPages.Text = "Click to view your Liked Pages!";
            this.linkLabelLikedPages.UseCompatibleTextRendering = true;
            this.linkLabelLikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLikedPages_LinkClicked);
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(337, 29);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(359, 184);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 90;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1092, 773);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Controls.Add(this.panelLikedPages);
            this.Controls.Add(this.panelFeatures);
            this.Controls.Add(this.panelPosts);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.panelAlbums);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelAlbums.ResumeLayout(false);
            this.panelAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            this.panelGroups.ResumeLayout(false);
            this.panelGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            this.panelPosts.ResumeLayout(false);
            this.panelPosts.PerformLayout();
            this.panelFeatures.ResumeLayout(false);
            this.panelLikedPages.ResumeLayout(false);
            this.panelLikedPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.LinkLabel linkPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Panel panelAlbums;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.LinkLabel linkAlbums;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.LinkLabel labelEvents;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.LinkLabel linkLabelFetchGroups;
        private System.Windows.Forms.Panel panelPosts;
        private System.Windows.Forms.ListView FavouritePlacesList;
        private ColumnHeader header5;
        private Button buttonFirstStepsOnFacebook;
        private Panel panelFeatures;
        private Button buttonFavouritePlaces;
        private Panel panelLikedPages;
        private PictureBox pictureBoxLikedPages;
        private ListBox listBoxLikedPages;
        private LinkLabel linkLabelLikedPages;
        private BindingSource albumBindingSource;
        private PictureBox imageAlbumPictureBox;
        private PictureBox pictureBoxCoverPhoto;
    }
}

