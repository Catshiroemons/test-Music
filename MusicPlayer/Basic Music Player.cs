using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;
using static MusicPlayer.Form1.MusicLinkedList;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "Simple Music Player";
            InitializeComponent();
            player.uiMode = "none";
            track_volume.Value = 90;
            lbl_titlesong.Visible = false;
            lbl_author.Visible = false;
            lbl_album.Visible = false;
            btn_loadf.Visible = false;
            btn_savef.Visible = false;
            favorite_list.Visible = false;
            btn_delete.Visible = true;
            btn_save.Visible = true;
            track_list.Visible = true;
            txt_search.Visible = true;
            c_box.Items.Add("Main Playlist");
        }
        public class Music
        {
            public string FilePath { get; set; }
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Album { get; set; }
            public System.Drawing.Image Pic_art { get; set; }
            public int lcount {  get; set; }



            public Music(string filePath, string title, string artist, string album, System.Drawing.Image pic, int lco)
            {
                FilePath = filePath;
                Title = title;
                Artist = artist;
                Album = album;
                Pic_art = pic;
                lcount = lco;
            }

            public override string ToString()
            {
                return $"{Title} - {Artist}";
            }
        }

        public class MusicLinkedList
        {
            public class Node
            {
                public Music Data { get; }
                public Node Next { get; set; }
                public Node Previous { get; set; }

                public Node(Music data)
                {
                    Data = data;
                }
            }

            private Node head;
            private Node tail;

            public void Add(Music music)
            {
                Node newNode = new Node(music);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
            }

            public IEnumerable<Music> GetAllItems()
            {
                Node current = head;

                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

            public IEnumerable<Music> GetItems(int lcount)
            {
                Node current = head;

                while (current != null)
                {
                    if (current.Data.lcount == lcount)
                    { yield return current.Data; }
                    current = current.Next;
                }
            }

            public Node GetPreviousNode(Node targetNode)
            {
                if (targetNode == null)
                {
                    return null;
                }

                return targetNode.Previous;
            }
            public void Remove(Node nodeToRemove)
            {
                if (nodeToRemove == null)
                {
                    return;
                }

                if (nodeToRemove.Previous != null)
                {
                    nodeToRemove.Previous.Next = nodeToRemove.Next;
                }
                else
                {
                    head = nodeToRemove.Next;
                }

                if (nodeToRemove.Next != null)
                {
                    nodeToRemove.Next.Previous = nodeToRemove.Previous;
                }
                else
                {
                    tail = nodeToRemove.Previous;
                }
            }

            public Node GetNodeAt(int index)
            {
                int currentIndex = 0;
                Node current = head;

                while (current != null && currentIndex < index)
                {
                    current = current.Next;
                    currentIndex++;
                }

                return current;
            }
            public void RemoveAt(int index)
            {
                Node nodeToRemove = GetNodeAt(index);
                Remove(nodeToRemove);
            }

            public void Insert(int index, Music music)
            {
                Node newNode = new Node(music);

                if (index <= 0)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    Node nodeAtIndex = GetNodeAt(index - 1);
                    newNode.Next = nodeAtIndex.Next;
                    newNode.Previous = nodeAtIndex;
                    nodeAtIndex.Next = newNode;

                    if (newNode.Next != null)
                    {
                        newNode.Next.Previous = newNode;
                    }
                    else
                    {
                        tail = newNode;
                    }
                }
            }

            private int count;

            public int Count
            {
                get { return count; }
            }

            public Node GetNextNode(Node currentNode)
            {
                if (currentNode != null)
                {
                    return currentNode.Next;
                }

                return null;
            }
            public int IndexOf(Node targetNode)
            {
                int index = 0;
                Node current = head;

                while (current != null)
                {
                    if (current == targetNode)
                    {
                        return index;
                    }

                    current = current.Next;
                    index++;
                }

                return -1; 
            }
        }

        private MusicLinkedList musicList = new MusicLinkedList();
        private MusicLinkedList.Node currentMusicNode;

        public class FavoriteLinkedList
        {
            public class Node
            {
                public Music Data { get; }
                public Node Next { get; set; }
                public Node Previous { get; set; }

                public Node(Music data)
                {
                    Data = data;
                }
            }

            private Node head;
            private Node tail;
            public Node GetNextNode(Node currentNode)
            {
                if (currentNode != null)
                {
                    return currentNode.Next;
                }

                return null; 
            }
            public Node GetPreviousNode(Node targetNode)
            {
                if (targetNode == null)
                {
                    return null;
                }

                return targetNode.Previous;
            }
            public void Add(Music music)
            {
                Node newNode = new Node(music);

                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Previous = tail;
                    tail = newNode;
                }
            }

            public void Clear()
            {
                head = null;
                tail = null;
            }
            public IEnumerable<Music> GetAllItems()
            {
                Node current = head;

                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

            public Node GetNodeAt(int index)
            {
                int currentIndex = 0;
                Node current = head;

                while (current != null && currentIndex < index)
                {
                    current = current.Next;
                    currentIndex++;
                }

                return current;
            }

            public void Remove(Node nodeToRemove)
            {
                if (nodeToRemove == null)
                {
                    return; 
                }

                if (nodeToRemove.Previous != null)
                {
                    nodeToRemove.Previous.Next = nodeToRemove.Next;
                }
                else
                {
                    head = nodeToRemove.Next;
                }

                if (nodeToRemove.Next != null)
                {
                    nodeToRemove.Next.Previous = nodeToRemove.Previous;
                }
                else
                {
                    tail = nodeToRemove.Previous;
                }
            }

            public void RemoveAt(int index)
            {
                Node nodeToRemove = GetNodeAt(index);
                Remove(nodeToRemove);
            }

            public void Insert(int index, Music music)
            {
                Node newNode = new Node(music);

                if (index <= 0)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    Node nodeAtIndex = GetNodeAt(index - 1);
                    newNode.Next = nodeAtIndex.Next;
                    newNode.Previous = nodeAtIndex;
                    nodeAtIndex.Next = newNode;

                    if (newNode.Next != null)
                    {
                        newNode.Next.Previous = newNode;
                    }
                    else
                    {
                        tail = newNode;
                    }
                }
            }
            public int IndexOf(Node targetNode)
            {
                int index = 0;
                Node current = head;

                while (current != null)
                {
                    if (current == targetNode)
                    {
                        return index;
                    }

                    current = current.Next;
                    index++;
                }

                return -1;
            }
        }


        private FavoriteLinkedList favoriteList = new FavoriteLinkedList();
        private FavoriteLinkedList.Node currentFavoriteNode;


        OpenFileDialog ofd = new OpenFileDialog();
        List<string> str = new List<string>();

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(31, 77, 87);
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            lbl_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex != -1)
            {
                currentMusicNode = musicList.GetNodeAt(track_list.SelectedIndex);
                PlaySelectedMusic(currentMusicNode);
                songInfo(currentMusicNode.Data);
            }

            try
              {
                  var file = TagLib.File.Create(currentMusicNode.Data.FilePath);
                  var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                  pic_art.Image = Image.FromStream(new MemoryStream(bin));
                  lbl_titlesong.Visible = true;
                  lbl_titlesong.Text = (file.Tag.Title);
                  lbl_author.Visible = true;
                  lbl_author.Text = (file.Tag.FirstPerformer);
                  lbl_album.Visible = true;
                  lbl_album.Text = (file.Tag.Album);

              }
              catch { }
            btn_save.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void ChangeSongOrder(int oldIndex, int newIndex)
        {
            if (oldIndex != newIndex)
            {
                Music movedMusic = musicList.GetNodeAt(oldIndex).Data;

                int selectedIndex = track_list.SelectedIndex;

                musicList.RemoveAt(oldIndex);
                musicList.Insert(newIndex, movedMusic);

                List<Music> musicListAsList = musicList.GetAllItems().ToList();

                track_list.DataSource = null;
                track_list.DataSource = musicListAsList;

                track_list.SelectedIndex = selectedIndex;

                PlaySelectedMusic(musicList.GetNodeAt(newIndex));
                songInfo(musicList.GetNodeAt(newIndex).Data);
            }
        }

        private void songInfo(Music selectedMusic)
        {
            lbl_titlesong.Visible = true;
            lbl_titlesong.Text = selectedMusic.Title;
            lbl_author.Visible = true;
            lbl_author.Text = selectedMusic.Artist;
            lbl_album.Visible = true;
            lbl_album.Text = selectedMusic.Album;


        }
        private void PlaySelectedMusic(MusicLinkedList.Node selectedNode)
        {
            if (selectedNode != null)
            {
                if(btn_repeat.Text == "Off")
                { 
                    next_time.Start();
                    random_time.Stop();
                    RepeatTimer.Stop();
                    player.URL = selectedNode.Data.FilePath;
                    player.Ctlcontrols.play();
                }
                else if(btn_repeat.Text == "Repeat")
                {
                    next_time.Stop();
                    random_time.Stop();
                    RepeatTimer.Start();
                    player.URL = selectedNode.Data.FilePath;
                    player.Ctlcontrols.play();
                }
                else if (btn_repeat.Text == "Random")
                {
                    next_time.Stop();
                    RepeatTimer.Stop();
                    random_time.Start();
                    player.URL = selectedNode.Data.FilePath;
                    player.Ctlcontrols.play();
                }
            }
        }
        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) 
            {
                player.Ctlcontrols.currentPosition = 0;
                player.Ctlcontrols.play();
            }
        }

        private void PlaySelectedMusic(FavoriteLinkedList.Node selectedNode)
        {
            if (selectedNode != null)
            {
                if (btn_repeat.Text == "Off")
                {
                    next_time.Start();
                    random_time.Stop();
                    RepeatTimer.Start();
                    player.URL = selectedNode.Data.FilePath;
                    player.Ctlcontrols.play();
                }
                else if (btn_repeat.Text == "Repeat")
                {
                    next_time.Stop();
                    random_time.Stop();
                    RepeatTimer.Start();
                    player.URL = selectedNode.Data.FilePath;
                    player.Ctlcontrols.play();
                }
                else if (btn_repeat.Text == "Random")
                {
                    next_time.Stop();
                    RepeatTimer.Stop();
                    random_time.Start();
                    player.URL = selectedNode.Data.FilePath;
                    player.Ctlcontrols.play();
                }

            }
        }


        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            p_bar.Value = 0;
        }
        private double pauseposition;
        private void btn_pause_Click(object sender, EventArgs e)
        {
                player.Ctlcontrols.pause();
            player.Ctlcontrols.currentPosition = pauseposition;

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (track_list.Visible == true)
            { 
            if (track_list.SelectedIndex != -1)
            {
                Music selectedMusic = track_list.SelectedItem as Music;
                if (selectedMusic != null)
                {
                    player.URL = selectedMusic.FilePath;
                    player.Ctlcontrols.play();
                }
            }
            }
            else
            {
                if (favorite_list.SelectedIndex != -1)
                {
                    Music selectedMusic = favorite_list.SelectedItem as Music;
                    if (selectedMusic != null)
                    {
                        player.URL = selectedMusic.FilePath;
                        player.Ctlcontrols.play();
                    }
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(track_list.Visible == true)
            { 
            if (currentMusicNode == null)
            {
                track_list.SelectedIndex = 0;
                currentMusicNode = musicList.GetNodeAt(track_list.SelectedIndex);
            }
            else if (currentMusicNode != null && currentMusicNode.Next != null)
            {
                currentMusicNode = currentMusicNode.Next;
                int newIndex = musicList.IndexOf(currentMusicNode);
                if (newIndex != -1)
                {
                    
                        try
                        {
                            track_list.SelectedIndex = newIndex;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            string errorMessage = "This is the last song;";
                            string errorTitle = "Error";
                            MessageBoxButtons button = MessageBoxButtons.OK;
                            MessageBox.Show(errorMessage, errorTitle, button);
                        }
                    }
            }
            else
            {
                string errorMessage = "This is the last song;";
                string errorTitle = "Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(errorMessage, errorTitle, button);
            }
            }
            else
            {
                if(currentFavoriteNode == null)
    {
                    favorite_list.SelectedIndex = 0;
                    currentFavoriteNode = favoriteList.GetNodeAt(favorite_list.SelectedIndex);
                }
                     else if (currentFavoriteNode != null && currentFavoriteNode.Next != null)
                {
                    currentFavoriteNode = currentFavoriteNode.Next;
                    PlaySelectedMusic(currentFavoriteNode);
                    int newIndex = favoriteList.IndexOf(currentFavoriteNode);
                    if (newIndex != -1)
                    {
                        favorite_list.SelectedIndex = newIndex;
                    }
                }
                else
                {
                    string errorMessage = "This is the last song in favorite list!";
                    string errorTitle = "Error";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(errorMessage, errorTitle, button);
                }
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.Visible == true)
            { 
            if (currentMusicNode == null)
            {
                track_list.SelectedIndex = 0;
                currentMusicNode = musicList.GetNodeAt(track_list.SelectedIndex);
            }
            else if (currentMusicNode != null && currentMusicNode.Previous != null)
            {
                currentMusicNode = currentMusicNode.Previous;
                int newIndex = musicList.IndexOf(currentMusicNode);
                if (newIndex != -1)
                {
                    track_list.SelectedIndex = newIndex;
                }
            }
            else
            {
                string errorMessage = "This is the first song;";
                string errorTitle = "Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(errorMessage, errorTitle, button);
            }
            }
            else
            {
                if (currentFavoriteNode == null)
                {
                    favorite_list.SelectedIndex = 0;
                    currentFavoriteNode = favoriteList.GetNodeAt(favorite_list.SelectedIndex);
                }
                else if (currentFavoriteNode != null && currentFavoriteNode.Previous != null)
                {
                    currentFavoriteNode = currentFavoriteNode.Previous;
                    int newIndex = favoriteList.IndexOf(currentFavoriteNode);
                    if (newIndex != -1)
                    {
                        favorite_list.SelectedIndex = newIndex;
                    }
                }
                else
                {
                    string errorMessage = "This is the first song;";
                    string errorTitle = "Error";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(errorMessage, errorTitle, button);
                }
            }
        }

        private Music GetSelectedMusicFromListBox(ListBox listBox)
        {
            if (listBox.SelectedIndex != -1)
            {
                if (listBox == track_list)
                {
                    return musicList.GetNodeAt(listBox.SelectedIndex).Data;
                }
                else if (listBox == favorite_list)
                {
                    FavoriteLinkedList.Node favoriteNode = favoriteList.GetNodeAt(listBox.SelectedIndex);
                    return favoriteNode != null ? favoriteNode.Data : null;
                }
            }

            return null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                try
                {
                    int newMaximum = (int)player.Ctlcontrols.currentItem.duration;

                    if (newMaximum >= p_bar.Minimum && newMaximum <= int.MaxValue)
                    {
                        p_bar.Maximum = newMaximum;
                    }

                    int newPosition = (int)player.Ctlcontrols.currentPosition;
                    if (newPosition >= p_bar.Minimum && newPosition <= p_bar.Maximum)
                    {
                        p_bar.Value = newPosition;
                    }

                    lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                    lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {
                }
            }


        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        List<string> listResult = new List<string>();
        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }
        private void ReloadOriginalList()
        {
            track_list.DataSource = null;
            track_list.DataSource = musicList.GetAllItems().ToList();
            track_list.DisplayMember = "Title" + " " + "Artist"; // Adj
        }
        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {

            string keyword = txt_search.Text.ToLower();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                ReloadOriginalList();
            }
            else
            {
                List<Music> filteredMusic = new List<Music>();

                foreach (var music in musicList.GetAllItems())
                {
                    string title = music.Title;
                    int icol;

                    int index = title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase);

                    if (index >= 0)
                    {
                        string coloredTitle = $"{title.Substring(0, index)}[---->]{title.Substring(index, keyword.Length)}[<----]{title.Substring(index + keyword.Length)}";

                        Music coloredMusic = new Music(music.FilePath, coloredTitle, music.Artist, music.Album, music.Pic_art, music.lcount);

                        filteredMusic.Add(coloredMusic);
                    }
                    else
                    {
                        filteredMusic.Add(music);
                    }
                }
                track_list.DataSource = null;
                track_list.DataSource = filteredMusic;
                track_list.DisplayMember = "Title" + "Artist"; 

            }
            

        }

        private void btn_favorite_Click(object sender, EventArgs e)
        {
            track_list.Visible = false;
            btn_save.Visible = false;
            txt_search.Visible = false;
            favorite_list.Visible = true;
            btn_savef.Visible = true;
            btn_loadf.Visible = true;
            btn_delete.Visible = true;

            btn_savef.Enabled = true;
        }

        private void btn_playlist_Click(object sender, EventArgs e)
        {
            track_list.Visible = true;
            btn_save.Visible = true;
            txt_search.Visible = true;
            favorite_list.Visible = false;
            btn_savef.Visible = false;
            btn_loadf.Visible = false;
            btn_delete.Visible = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (currentMusicNode != null)
            {
                favoriteList.Add(currentMusicNode.Data);
                UpdateFavoriteList();
            }
            btn_save.Enabled = false; 
        }


        private void UpdateFavoriteList()
        {

            favorite_list.DataSource = favoriteList.GetAllItems().ToList();
            favorite_list.DisplayMember = "PropertyName"; 
        }

        private void btn_savef_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter Save = new StreamWriter("../../Storage/favorite.txt"))

                foreach (var music in favoriteList.GetAllItems())
                {
                    Save.WriteLine(music.FilePath);
                }
                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving favorite songs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            favorite_list.DataSource = null;
            favorite_list.Items.Clear();
            btn_savef.Enabled=false;
        }

        private void btn_loadf_Click(object sender, EventArgs e)
        {
            try
            {
                favoriteList.Clear();
                favorite_list.DataSource = null;
                favorite_list.Items.Clear();
                string filePath = "../../Storage/favorite.txt";
                List<string> fileLines = new List<string>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string filePathInFile = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(filePathInFile))
                        {
                            fileLines.Add(filePathInFile);
                        }
                    }
                }

                foreach (var filePathInFile in fileLines)
                {
                    TagLib.File file = TagLib.File.Create(filePathInFile);
                    string title = file.Tag.Title ?? Path.GetFileNameWithoutExtension(filePathInFile);
                    string artist = file.Tag.FirstPerformer ?? "Unknown";
                    string album = file.Tag.Album ?? "Unknown";
                    int ico = dem;
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    System.Drawing.Image pic;
                    if (bin != null)
                    {
                        pic = Image.FromStream(new MemoryStream(bin));
                    }
                    else
                    {
                        string specificImagePath = "../../Resources/Disc.png";
                        pic = Image.FromFile(specificImagePath);
                    }

                    Music newMusic = new Music(filePathInFile, title, artist, album, pic, ico);
                    favoriteList.Add(newMusic);
                }

                UpdateFavoriteList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading favorite songs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btn_savef.Enabled = true;
        }

 
        private void favorite_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (favorite_list.SelectedIndex != -1)
            {
                currentFavoriteNode = favoriteList.GetNodeAt(favorite_list.SelectedIndex);
                PlaySelectedMusic(currentFavoriteNode);
                try
                {
                    var file = TagLib.File.Create(currentFavoriteNode.Data.FilePath);
                    var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                    pic_art.Image = Image.FromStream(new MemoryStream(bin));
                    lbl_titlesong.Visible = true;
                    lbl_titlesong.Text = (file.Tag.Title);
                    lbl_author.Visible = true;
                    lbl_author.Text = (file.Tag.FirstPerformer);
                    lbl_album.Visible = true;
                    lbl_album.Text = (file.Tag.Album);

                }
                catch { }
            }

            btn_delete.Enabled = true;
            btn_save.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (track_list.Visible == false)
            {
                if (favorite_list.SelectedItems.Count > 0)
                {
                    int selectedIndex = favorite_list.SelectedIndex;
                    FavoriteLinkedList.Node selectedNode = favoriteList.GetNodeAt(selectedIndex);

                    if (selectedNode != null)
                    {
                        FavoriteLinkedList.Node nextNode = favoriteList.GetNextNode(selectedNode);
                        FavoriteLinkedList.Node previousNode = favoriteList.GetPreviousNode(selectedNode);

                        favoriteList.Remove(selectedNode);
                        UpdateFavoriteList(); 

                        if (nextNode != null)
                        {
                            PlaySelectedMusic(nextNode);
                            favorite_list.SelectedIndex = selectedIndex;
                        }
                        else if (previousNode == null && nextNode == null)
                        {
                            player.Ctlcontrols.stop();
                            p_bar.Value = 0;
                        };


                    }
                }
                else
                {
                    MessageBox.Show("There is nothing to delete!");
                }
            }
            else
            {
                if (track_list.SelectedItems.Count > 0)
                {
                    int selectedIndex = track_list.SelectedIndex;
                    MusicLinkedList.Node selectedNode = musicList.GetNodeAt(selectedIndex);

                    if (selectedNode != null)
                    {
                        MusicLinkedList.Node nextNode = musicList.GetNextNode(selectedNode);
                        MusicLinkedList.Node previousNode = musicList.GetPreviousNode(selectedNode);

                        musicList.Remove(selectedNode);
                        UpdateTrackList(dem); 

                        if (nextNode != null)
                        {
                            PlaySelectedMusic(nextNode);
                            track_list.SelectedIndex = selectedIndex;
                        }
                        else if (previousNode == null && nextNode == null)
                        {
                            player.Ctlcontrols.stop();
                            p_bar.Value = 0;
                        };

                       
                    }
                }
                else
                {
                    MessageBox.Show("There is nothing to delete!");
                }
            }
        }
        public int dem = 0;
        private void btn_open_Click(object sender, EventArgs e)
        {

                var openFileDialog = new OpenFileDialog
                {
                    Title = "Select Music Files",
                    Multiselect = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var filePath in openFileDialog.FileNames)
                    {
                        TagLib.File file = TagLib.File.Create(filePath);
                        string title;
                        string artist;
                        string album;
                        int c;
                        if (file.Tag.Title != null)
                        {
                            title = file.Tag.Title;
                        }
                        else
                        {
                            title = Path.GetFileNameWithoutExtension(filePath);
                        }
                        if (file.Tag.FirstPerformer != null)
                        {
                            artist = file.Tag.FirstPerformer;
                        }
                            else
                        {
                            artist = "Unknow";
                        }
                        if (file.Tag.Album != null)
                        {
                            album = file.Tag.FirstPerformer;
                        }
                            else
                        {
                            album = "Unknow";
                        }
                        c = dem;
                        
                    Image pic;
                    if (file.Tag.Pictures != null && file.Tag.Pictures.Length > 0)
                    {
                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                        pic = Image.FromStream(new MemoryStream(bin));
                    }
                    else
                    {
                        string specificImagePath = "../../Resources/Disc.png";
                        pic = Image.FromFile(specificImagePath);
                    }



                    Music newMusic = new Music(filePath, title, artist, album, pic, c);
                        musicList.Add(newMusic);
                    }

                    UpdateTrackList(dem);
                }
            track_list.Visible = true;
            favorite_list.Visible = false;
            txt_search.Visible = true;
            btn_save.Visible = true;
            btn_savef.Visible = false;
            btn_loadf.Visible = false;
        }


        private void UpdateTrackList(int dem)
        {
            track_list.DataSource = musicList.GetItems(dem).ToList();
            track_list.DisplayMember = "PropertyName";
        }
        private int dragIndex = -1;
        private Point dragStartPoint;
        private bool isDragging = false;

        private void track_list_MouseDown(object sender, MouseEventArgs e)
        {
            int index = track_list.IndexFromPoint(e.X, e.Y);

            if (index != ListBox.NoMatches)
            {
                if (e.Button == MouseButtons.Left)
                {
                    dragIndex = index;
                    dragStartPoint = e.Location;
                }
            }
        }

        

        private void track_list_DoubleClick(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex != -1)
            {
                currentMusicNode = musicList.GetNodeAt(track_list.SelectedIndex);

                if (currentMusicNode != null && currentMusicNode.Data != null)
                {
                    PlaySelectedMusic(currentMusicNode);
                    songInfo(currentMusicNode.Data);
                }
            }

            btn_save.Enabled = true;
        }

        private void track_list_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragIndex != -1)
            {
                if (Math.Abs(e.X - dragStartPoint.X) >= SystemInformation.DragSize.Width ||
                    Math.Abs(e.Y - dragStartPoint.Y) >= SystemInformation.DragSize.Height)
                {
                    track_list.DoDragDrop(dragIndex, DragDropEffects.Move);
                }
            }
        }

        private void track_list_MouseUp(object sender, MouseEventArgs e)
        {
            dragIndex = -1;
        }

        private void track_list_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void track_list_DragDrop(object sender, DragEventArgs e)
        {
            int newIndex = track_list.IndexFromPoint(track_list.PointToClient(new Point(e.X, e.Y)));

            if (newIndex != ListBox.NoMatches && newIndex != dragIndex)
            {
                Music movedMusic = musicList.GetNodeAt(dragIndex).Data;
                musicList.RemoveAt(dragIndex);
                musicList.Insert(newIndex, movedMusic);

                List<Music> musicListAsList = musicList.GetAllItems().ToList();
                track_list.DataSource = null;
                track_list.DataSource = musicListAsList;
                track_list.SelectedIndex = newIndex;
            }

            dragIndex = -1;
        }

        private void favorite_list_MouseUp(object sender, MouseEventArgs e)
        {
            dragIndex = -1;
        }

        private void favorite_list_MouseDown(object sender, MouseEventArgs e)
        {
            int index = favorite_list.IndexFromPoint(e.X, e.Y);

            if (index != ListBox.NoMatches)
            {
                if (e.Button == MouseButtons.Left)
                {
                    dragIndex = index;
                    dragStartPoint = e.Location;
                }
                else if (e.Button == MouseButtons.Right)
                {
                }
            }
        }

        private void favorite_list_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dragIndex != -1)
            {
                if (Math.Abs(e.X - dragStartPoint.X) >= SystemInformation.DragSize.Width ||
                    Math.Abs(e.Y - dragStartPoint.Y) >= SystemInformation.DragSize.Height)
                {
                    track_list.DoDragDrop(dragIndex, DragDropEffects.Move);
                }
            }
        }

        private void favorite_list_DragDrop(object sender, DragEventArgs e)
        {
            int newIndex = favorite_list.IndexFromPoint(favorite_list.PointToClient(new Point(e.X, e.Y)));

            if (newIndex != ListBox.NoMatches && newIndex != dragIndex)
            {
                Music movedMusic = favoriteList.GetNodeAt(dragIndex).Data;
                favoriteList.RemoveAt(dragIndex);
                favoriteList.Insert(newIndex, movedMusic);

                List<Music> musicListAsList = favoriteList.GetAllItems().ToList();
                favorite_list.DataSource = null;
                favorite_list.DataSource = musicListAsList;
                favorite_list.SelectedIndex = newIndex;
            }

            dragIndex = -1;
        }

        private void favorite_list_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void track_list_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Music music = (Music)track_list.Items[e.Index];
                string title = music.Title.ToLower();
                string keyword = txt_search.Text.ToLower();

                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                bool containsKeyword = title.Contains(keyword);

                e.DrawBackground();
                e.Graphics.FillRectangle(containsKeyword ? Brushes.Yellow : Brushes.White, e.Bounds);

                Brush textColor = containsKeyword ? Brushes.Black : SystemBrushes.ControlText;

                e.Graphics.DrawString(music.Title, track_list.Font, textColor, e.Bounds, stringFormat);

                e.DrawFocusRectangle();
            }
        }

        private void RepeatTimer_Tick(object sender, EventArgs e)
        {
            double totalDuration = player.currentMedia.duration;
            double currentPosition = player.Ctlcontrols.currentPosition;
            double tolerance = 1.0; 

            if (btn_repeat.Text == "Repeat" && totalDuration - currentPosition <= tolerance)
            {
                player.Ctlcontrols.currentPosition = 0;
                player.Ctlcontrols.play();
            }
        }

        private void next_time_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double currentPosition = player.Ctlcontrols.currentPosition;
                double duration = player.Ctlcontrols.currentItem.duration;

                if (Math.Abs(currentPosition - duration) < 1)
                {
                    next_time.Stop();

                    btn_next.PerformClick();
                }
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            PlayRandomSong();
        }
        private void PlayRandomSong()
        {
            Random random = new Random();
            if(track_list.Visible == true)
            { 
            int randomIndex = random.Next(0, track_list.Items.Count);

            track_list.SelectedIndex = randomIndex;
            PlaySelectedMusic(musicList.GetNodeAt(randomIndex));
            songInfo(musicList.GetNodeAt(randomIndex).Data);
            }
            else
            {
                int randomIndex = random.Next(0, favorite_list.Items.Count);

                favorite_list.SelectedIndex = randomIndex;
                PlaySelectedMusic(favoriteList.GetNodeAt(randomIndex));
                songInfo(favoriteList.GetNodeAt(randomIndex).Data);
            }
        }

        private void random_time_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying &&
        Math.Abs(player.Ctlcontrols.currentPosition - player.Ctlcontrols.currentItem.duration) < 1)
            {
                random_time.Stop();

                PlayRandomSong();
            }
        }
        
        private void btn_repeat_Click_1(object sender, EventArgs e)
        {
          
            string Off = "../../Resources/Off.png";
            string Repeat = "../../Resources/Repeat.png";
            string Random = "../../Resources/Random.png";
            if (btn_repeat.Text == "Off")
            {
                btn_repeat.Text = "Repeat";
                Image newImage = Image.FromFile(Repeat);
                btn_repeat.BackgroundImage = newImage;
                RepeatTimer.Start();
                random_time.Stop();
                next_time.Stop();
            }
            else if (btn_repeat.Text == "Repeat")
            {
                Image newImage = Image.FromFile(Random);
                btn_repeat.BackgroundImage = newImage;
                RepeatTimer.Stop();
                next_time.Stop();
                btn_repeat.Text = "Random";
                random_time.Start();
            }
            else if (btn_repeat.Text == "Random")
            {
                Image newImage = Image.FromFile(Off);
                btn_repeat.BackgroundImage = newImage;
                RepeatTimer.Stop();
                next_time.Start();
                btn_repeat.Text = "Off";
                random_time.Stop();
            }
        }
        int max = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
            dem++;
            c_box.Items.Add(dem);
            UpdateTrackList(dem);
        }

        private void c_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            dem = c_box.SelectedIndex;
            UpdateTrackList(c_box.SelectedIndex);
            object lastItem = c_box.Items[c_box.Items.Count - 1];
            if (lastItem is int lastInt)
            {
                dem = (int)lastInt;
            }
            currentMusicNode = musicList.GetNodeAt(track_list.SelectedIndex);
            PlaySelectedMusic(currentMusicNode);
            songInfo(currentMusicNode.Data);
        }

    }

}
