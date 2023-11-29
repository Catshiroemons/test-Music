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

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            player.uiMode = "none";
            track_volume.Value = 90;
            lbl_titlesong.Visible = false;
            lbl_author.Visible = false;
            lbl_album.Visible = false;
            btn_loadf.Visible = false;
            btn_savef.Visible = false;
            favorite_list.Visible = false;
            btn_delete.Visible = false;
            btn_save.Visible = true;
            track_list.Visible = true;
            txt_search.Visible = true;
        }

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
        string[] paths, files;

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt.Text = track_list.Text;
            btn_save.Enabled = true;
            player.URL = @track_list.Text;
            player.Ctlcontrols.play();
            /*  player.URL = paths[track_list.SelectedIndex];
              player.Ctlcontrols.play();
              try
              {
                  var file = TagLib.File.Create(paths[track_list.SelectedIndex]);
                  var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                  pic_art.Image = Image.FromStream(new MemoryStream(bin));
                  lbl_titlesong.Visible = true;
                  lbl_titlesong.Text = (file.Tag.Title);
                  lbl_author.Visible = true;
                  lbl_author.Text = (file.Tag.FirstPerformer);
                  lbl_album.Visible = true;
                  lbl_album.Text = (file.Tag.Album);

              }
              catch { } */
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            p_bar.Value = 0;
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.URL = @track_list.Text;
            player.URL = @favorite_list.Text;
            player.Ctlcontrols.play();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(track_list.Visible == true)
            { 
            if(track_list.SelectedIndex<track_list.Items.Count-1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
            else
            {
                string message = "This is the last song!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
            }

            if (favorite_list.Visible == true)
            {
                if (favorite_list.SelectedIndex < favorite_list.Items.Count - 1)
                {
                    favorite_list.SelectedIndex = favorite_list.SelectedIndex + 1;
                }
                else
                {
                    string message = "This is the last song!";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons);
                }
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (track_list.Visible == true)
            { 
            if(track_list.SelectedIndex>0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
            else
            {
                string message = "This is the first song!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons);
            }
            }
            if (favorite_list.Visible == true)
            {
                if (favorite_list.SelectedIndex > 0)
                {
                    favorite_list.SelectedIndex = favorite_list.SelectedIndex - 1;
                }
                else
                {
                    string message = "This is the first song!";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
                try
                {
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
            player.URL = @track_list.Text;
            player.URL = @favorite_list.Text;
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        List<string> listResult = new List<string>();
        private void txt_search_MouseClick(object sender, MouseEventArgs e)
        {
            txt_search.Text = "";
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
       
              int result = track_list.FindString(txt_search.Text);
              if (0<=result)
              {
                  track_list.SetSelected(result,true);
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
            favorite_list.Visible = false;
            btn_savef.Visible = false;
            btn_loadf.Visible = false;
            btn_delete.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            favorite_list.Items.Add(txt.Text);
        }

        private void btn_savef_Click(object sender, EventArgs e)
        {
            StreamWriter Save = new StreamWriter("../../Storage/Favotire.txt");

            foreach(var item in favorite_list.Items)
            {
                Save.WriteLine(item.ToString());
                this.Refresh();
            }
            MessageBox.Show("Save Successfully!");
            Save.Close();
            favorite_list.Items.Clear();
            btn_savef.Enabled = false;
            btn_favorite.Enabled = true;
        }

        private void btn_loadf_Click(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader("../../Storage/Favotire.txt"))
            {
             
                string line;
                while((line=read.ReadLine())!=null)
                {
                    favorite_list.Items.Add(line);
                }
            };
        }

        private void favorite_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt.Text = favorite_list.Text;
            player.URL = @favorite_list.Text;
            player.Ctlcontrols.play();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(favorite_list.SelectedItems.Count>0)
            {
                favorite_list.Items.Remove(favorite_list.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("There is nothing to delete!");
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            /*if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                //paths = ofd.FileNames;
                paths = (paths ?? Enumerable.Empty<string>()).Concat(ofd.FileNames).ToArray();
                for (int x = 0; x < files.Length; x++)
                {
                    // track_list.Items.Add(files[x]);
                   TagLib.File file = TagLib.File.Create(files[x]);
                    if (file.Tag.Title == null)
                    {
                        info_list.Items.Add(Path.GetFileName(files[x]));
                        listResult.Add(Path.GetFileName(files[x]));
                    }
                    else
                    {
                        info_list.Items.Add(file.Tag.Title);
                        listResult.Add(file.Tag.Title);
                    }
                }
                
            } */
            if (ofd.ShowDialog() == DialogResult.Cancel) { return; }
            foreach (string s in ofd.FileNames)
            {
                track_list.Items.Add(Path.GetFullPath(s));
                str.Add(s);
            }


        }
    }
}
