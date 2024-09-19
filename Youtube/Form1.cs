using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.Data.Odbc;
using MediaToolkit;
using MediaToolkit.Model;

namespace Youtube
{
    public partial class Form1 : Form
    {
        string[] 拡張子 = new string[] {"aac","ogg","wav","mp3","flac" };
        private void fileselect()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "MP4|*.mp4|MP3|*.mp3|WAV|*.wav|OGG|*.ogg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFiles> files = new List<MediaFiles>();
                    foreach (string filename in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(filename);
                        files.Add(new MediaFiles() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listBox1.DataSource = files;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            for(int i =0; i<拡張子.Length; i++)
            {
                comboBox1.Items.Add(拡張子[i]);
            }
            filetxthide.Hide();
            filechange1.Hide();
        }

        private void WebView21_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            Link.Text = webyoutube.Source.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            webyoutube.GoBack();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            webyoutube.GoForward();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            webyoutube.Refresh();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            webyoutube.CoreWebView2.Navigate("https://youtube.com");
        }
        private void GetPath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            {
                fbd.Description = "フォルダを指定してください";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    folderpath.Text = fbd.SelectedPath;
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GetPath();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFiles file = listBox1.SelectedItem as MediaFiles;
            if (file != null)
            {
                mediaplayer.URL = file.Path;
                mediaplayer.Ctlcontrols.play();
                mediaplayer.stretchToFit = true;
            }
        }
        public void informationAsync()
        {
            DialogResult res = MessageBox.Show("Youtubeの動画を保存しますか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {

                try
                {
                    MessageBox.Show("Youtube動画をMP4に変換します...", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    convert.Enabled = false;
                    progressBar1.Value = 0;
                    backgroundWorker1.RunWorkerAsync();
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    progressBar1.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("キャンセルします。", "エラー", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            informationAsync();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
          
        }

        private void Link_TextChanged(object sender, EventArgs e)
        {
            try
            {
                title.Text = "Title";
                pictureBox1.ImageLocation = "";
                string url = "https://www.youtube.com/watch?v=";
                string str = Link.Text;
                int index = str.IndexOf(url)+32;
                string videoid = str.Substring(index);

                if (Link.Text == url + videoid)
                {
                    URLGet();
                    convert.Enabled = true;
                }
                else
                {
                    convert.Enabled = false;
                }
            }
            catch
            {

            }



        }
        public void Title()
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(webyoutube.Source);
                WebResponse response;
                response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string str = sr.ReadToEnd();
                int index = str.IndexOf("<title>") + 7;
                int dex = str.Substring(index).IndexOf("</title>") - 10;
                string result = str.Substring(index, dex);
                title.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Samnail()
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(webyoutube.Source);
                WebResponse response;
                response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                string str = sr.ReadToEnd();
                int index = str.IndexOf("thumbnailUrl") + 20;
                int dex = str.Substring(index).IndexOf(">") - 1;
                string result = str.Substring(index, dex);
                pictureBox1.ImageLocation = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void URLGet()
        {
            Title();
            Samnail();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            convert.Enabled = false;
            listBox1.ValueMember = "Path";
            listBox1.DisplayMember = "FileName";
            mediaplayer.settings.volume = 50;
            convert.Enabled = false;
        }

        private void ファイル選択ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileselect();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);

                int progress = i;
                this.backgroundWorker1.ReportProgress(progress);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           progressBar1.Value = e.ProgressPercentage;
        }

        private async void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                var youtube = YouTube.Default;
                var video = await youtube.GetVideoAsync(Link.Text);
                System.IO.File.WriteAllBytes(folderpath.Text + @"\" + video.FullName, await video.GetBytesAsync());
                MessageBox.Show("変換終わりました！", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void 連続再生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            if(item.Checked)
                mediaplayer.settings.setMode("loop", true);
            else
                mediaplayer.settings.setMode("loop", false);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            GetPath();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "MP4ファイル(*.mp4)|*.mp4|MP3ファイル(*.mp3)|*.mp3";
            ofd.Title = "開くファイルを選択してください";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                int index = ofd.FileName.LastIndexOf("\\")+1;
                string str = ofd.FileName.Substring(index);
                filetxt.Text = str;
                filetxthide.Text = ofd.FileName;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
           
            var inputFile = new MediaFile { Filename = filetxthide.Text };
            var outputFile = new MediaFile { Filename = filechange.Text };

            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
                MessageBox.Show("変換終了");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = filetxt.Text.LastIndexOf(".");
                string str1 = filetxt.Text;
                string str2 = str1.Remove(index);
                int index1 = filetxthide.Text.LastIndexOf(".");
                string str3 = filetxthide.Text;
                string str4 = str3.Remove(index1);
                if (comboBox1.SelectedItem.Equals(拡張子[0]))
                {
                    filechange.Text = str2 + "." + 拡張子[0];
                    filechange1.Text = str4 + "." + 拡張子[0];
                }
                if (comboBox1.SelectedItem.Equals(拡張子[1]))
                {
                    filechange.Text = str2 + "." + 拡張子[1];
                    filechange1.Text = str4 + "." + 拡張子[1];
                }
                if (comboBox1.SelectedItem.Equals(拡張子[2]))
                {
                    filechange.Text = str2 + "." + 拡張子[2];
                    filechange1.Text = str4 + "." + 拡張子[2];
                }
                if (comboBox1.SelectedItem.Equals(拡張子[3]))
                {
                    filechange.Text = str2 + "." + 拡張子[3];
                    filechange1.Text = str4 + "." + 拡張子[3];
                }
                if (comboBox1.SelectedItem.Equals(拡張子[4]))
                {
                    filechange.Text = str2 + "." + 拡張子[4];
                    filechange1.Text = str4 + "." + 拡張子[4];
                }
               
            }
            catch
            {
                MessageBox.Show("ファイルを選択してください");
            }
        }
    }
}
