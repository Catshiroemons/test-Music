namespace MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lbl_album = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_titlesong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.info_list = new System.Windows.Forms.ListBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_loadf = new System.Windows.Forms.Button();
            this.btn_savef = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.favorite_list = new System.Windows.Forms.ListBox();
            this.btn_favorite = new System.Windows.Forms.Button();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.track_list = new System.Windows.Forms.ListBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.MinExtra = 0;
            this.splitter1.MinSize = 0;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(946, 2);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 2);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 545);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Coral;
            this.splitContainer1.Panel2.Controls.Add(this.txt);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_volume);
            this.splitContainer1.Panel2.Controls.Add(this.player);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_track_end);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_track_start);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.track_volume);
            this.splitContainer1.Panel2.Controls.Add(this.p_bar);
            this.splitContainer1.Panel2.Controls.Add(this.btn_open);
            this.splitContainer1.Panel2.Controls.Add(this.btn_next);
            this.splitContainer1.Panel2.Controls.Add(this.btn_pause);
            this.splitContainer1.Panel2.Controls.Add(this.btn_play);
            this.splitContainer1.Panel2.Controls.Add(this.btn_stop);
            this.splitContainer1.Panel2.Controls.Add(this.btn_preview);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(944, 545);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 12;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Panel1.Controls.Add(this.lbl_album);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_author);
            this.splitContainer2.Panel1.Controls.Add(this.lbl_titlesong);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.pic_art);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            this.splitContainer2.Panel1MinSize = 0;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.CausesValidation = false;
            this.splitContainer2.Panel2.Controls.Add(this.checkedListBox1);
            this.splitContainer2.Panel2.Controls.Add(this.info_list);
            this.splitContainer2.Panel2.Controls.Add(this.btn_delete);
            this.splitContainer2.Panel2.Controls.Add(this.btn_loadf);
            this.splitContainer2.Panel2.Controls.Add(this.btn_savef);
            this.splitContainer2.Panel2.Controls.Add(this.btn_save);
            this.splitContainer2.Panel2.Controls.Add(this.favorite_list);
            this.splitContainer2.Panel2.Controls.Add(this.btn_favorite);
            this.splitContainer2.Panel2.Controls.Add(this.btn_playlist);
            this.splitContainer2.Panel2.Controls.Add(this.txt_search);
            this.splitContainer2.Panel2.Controls.Add(this.track_list);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Panel2MinSize = 0;
            this.splitContainer2.Size = new System.Drawing.Size(944, 410);
            this.splitContainer2.SplitterDistance = 313;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // lbl_album
            // 
            this.lbl_album.BackColor = System.Drawing.Color.Transparent;
            this.lbl_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_album.ForeColor = System.Drawing.Color.Black;
            this.lbl_album.Location = new System.Drawing.Point(8, 373);
            this.lbl_album.Name = "lbl_album";
            this.lbl_album.Size = new System.Drawing.Size(296, 16);
            this.lbl_album.TabIndex = 4;
            this.lbl_album.Text = "Album";
            this.lbl_album.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_author
            // 
            this.lbl_author.BackColor = System.Drawing.Color.Transparent;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.Color.Black;
            this.lbl_author.Location = new System.Drawing.Point(8, 349);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(296, 16);
            this.lbl_author.TabIndex = 3;
            this.lbl_author.Text = "Author";
            this.lbl_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titlesong
            // 
            this.lbl_titlesong.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titlesong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlesong.ForeColor = System.Drawing.Color.Black;
            this.lbl_titlesong.Location = new System.Drawing.Point(8, 325);
            this.lbl_titlesong.Name = "lbl_titlesong";
            this.lbl_titlesong.Size = new System.Drawing.Size(296, 16);
            this.lbl_titlesong.TabIndex = 2;
            this.lbl_titlesong.Text = "Name of Song";
            this.lbl_titlesong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pic_art
            // 
            this.pic_art.BackColor = System.Drawing.Color.White;
            this.pic_art.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_art.Image = global::MusicPlayer.Properties.Resources.Disc;
            this.pic_art.Location = new System.Drawing.Point(0, 0);
            this.pic_art.Margin = new System.Windows.Forms.Padding(0);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(314, 314);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 0;
            this.pic_art.TabStop = false;
            // 
            // info_list
            // 
            this.info_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info_list.BackColor = System.Drawing.Color.White;
            this.info_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_list.HorizontalScrollbar = true;
            this.info_list.ItemHeight = 20;
            this.info_list.Location = new System.Drawing.Point(558, 339);
            this.info_list.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.info_list.Name = "info_list";
            this.info_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.info_list.Size = new System.Drawing.Size(73, 44);
            this.info_list.TabIndex = 10;
            this.info_list.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(169, 389);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_loadf
            // 
            this.btn_loadf.BackColor = System.Drawing.Color.White;
            this.btn_loadf.FlatAppearance.BorderSize = 0;
            this.btn_loadf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadf.Location = new System.Drawing.Point(353, 389);
            this.btn_loadf.Name = "btn_loadf";
            this.btn_loadf.Size = new System.Drawing.Size(86, 23);
            this.btn_loadf.TabIndex = 8;
            this.btn_loadf.Text = "Load";
            this.btn_loadf.UseVisualStyleBackColor = false;
            this.btn_loadf.Click += new System.EventHandler(this.btn_loadf_Click);
            // 
            // btn_savef
            // 
            this.btn_savef.BackColor = System.Drawing.Color.White;
            this.btn_savef.FlatAppearance.BorderSize = 0;
            this.btn_savef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savef.Location = new System.Drawing.Point(261, 389);
            this.btn_savef.Name = "btn_savef";
            this.btn_savef.Size = new System.Drawing.Size(86, 23);
            this.btn_savef.TabIndex = 7;
            this.btn_savef.Text = "Save";
            this.btn_savef.UseVisualStyleBackColor = false;
            this.btn_savef.Click += new System.EventHandler(this.btn_savef_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(323, 389);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save to Favorite";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // favorite_list
            // 
            this.favorite_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favorite_list.BackColor = System.Drawing.Color.White;
            this.favorite_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_list.HorizontalScrollbar = true;
            this.favorite_list.ItemHeight = 20;
            this.favorite_list.Location = new System.Drawing.Point(2, -1);
            this.favorite_list.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.favorite_list.Name = "favorite_list";
            this.favorite_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.favorite_list.Size = new System.Drawing.Size(634, 384);
            this.favorite_list.TabIndex = 4;
            this.favorite_list.SelectedIndexChanged += new System.EventHandler(this.favorite_list_SelectedIndexChanged);
            // 
            // btn_favorite
            // 
            this.btn_favorite.BackColor = System.Drawing.Color.White;
            this.btn_favorite.FlatAppearance.BorderSize = 0;
            this.btn_favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favorite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_favorite.Location = new System.Drawing.Point(537, 389);
            this.btn_favorite.Name = "btn_favorite";
            this.btn_favorite.Size = new System.Drawing.Size(86, 23);
            this.btn_favorite.TabIndex = 3;
            this.btn_favorite.Text = "Favorite";
            this.btn_favorite.UseVisualStyleBackColor = false;
            this.btn_favorite.Click += new System.EventHandler(this.btn_favorite_Click);
            // 
            // btn_playlist
            // 
            this.btn_playlist.BackColor = System.Drawing.Color.White;
            this.btn_playlist.FlatAppearance.BorderSize = 0;
            this.btn_playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlist.Location = new System.Drawing.Point(445, 389);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(86, 23);
            this.btn_playlist.TabIndex = 2;
            this.btn_playlist.Text = "Playlist";
            this.btn_playlist.UseVisualStyleBackColor = false;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(0, 390);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(318, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.Text = "Search";
            this.txt_search.Visible = false;
            this.txt_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_search_MouseClick);
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // track_list
            // 
            this.track_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.track_list.BackColor = System.Drawing.Color.White;
            this.track_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_list.HorizontalScrollbar = true;
            this.track_list.ItemHeight = 20;
            this.track_list.Location = new System.Drawing.Point(0, 0);
            this.track_list.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.track_list.Name = "track_list";
            this.track_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.track_list.Size = new System.Drawing.Size(645, 384);
            this.track_list.TabIndex = 0;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(376, 8);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(496, 20);
            this.txt.TabIndex = 15;
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(280, 0);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(27, 13);
            this.lbl_volume.TabIndex = 14;
            this.lbl_volume.Text = "90%";
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(316, 32);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(618, 56);
            this.player.TabIndex = 13;
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_end.ForeColor = System.Drawing.Color.White;
            this.lbl_track_end.Location = new System.Drawing.Point(908, 11);
            this.lbl_track_end.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(30, 15);
            this.lbl_track_end.TabIndex = 12;
            this.lbl_track_end.Text = "00:00";
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_track_start.ForeColor = System.Drawing.Color.White;
            this.lbl_track_start.Location = new System.Drawing.Point(312, 11);
            this.lbl_track_start.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(30, 15);
            this.lbl_track_start.TabIndex = 11;
            this.lbl_track_start.Text = "00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.Speaker;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(38, 13);
            this.track_volume.Margin = new System.Windows.Forms.Padding(2);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(266, 45);
            this.track_volume.TabIndex = 9;
            this.track_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.track_volume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(315, 96);
            this.p_bar.Margin = new System.Windows.Forms.Padding(2);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(619, 7);
            this.p_bar.TabIndex = 7;
            this.p_bar.Click += new System.EventHandler(this.progressBar2_Click);
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.BackgroundImage = global::MusicPlayer.Properties.Resources.Open;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Location = new System.Drawing.Point(258, 72);
            this.btn_open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(29, 32);
            this.btn_open.TabIndex = 5;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.BackgroundImage = global::MusicPlayer.Properties.Resources.Next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(210, 74);
            this.btn_next.Margin = new System.Windows.Forms.Padding(2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(24, 26);
            this.btn_next.TabIndex = 4;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Transparent;
            this.btn_pause.BackgroundImage = global::MusicPlayer.Properties.Resources.Pause;
            this.btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pause.FlatAppearance.BorderSize = 0;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Location = new System.Drawing.Point(161, 74);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(24, 26);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.BackgroundImage = global::MusicPlayer.Properties.Resources.Play;
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_play.FlatAppearance.BorderSize = 0;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Location = new System.Drawing.Point(98, 65);
            this.btn_play.Margin = new System.Windows.Forms.Padding(2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 44);
            this.btn_play.TabIndex = 2;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BackgroundImage = global::MusicPlayer.Properties.Resources.Stop_Playback;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Location = new System.Drawing.Point(54, 74);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(24, 26);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.BackgroundImage = global::MusicPlayer.Properties.Resources.Previous;
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_preview.FlatAppearance.BorderSize = 0;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.ForeColor = System.Drawing.Color.Transparent;
            this.btn_preview.Location = new System.Drawing.Point(10, 74);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(2);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(24, 26);
            this.btn_preview.TabIndex = 0;
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(579, 403);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pic_art;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Label lbl_track_end;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Label lbl_titlesong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_album;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_favorite;
        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.ListBox favorite_list;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_savef;
        private System.Windows.Forms.Button btn_loadf;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListBox info_list;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

