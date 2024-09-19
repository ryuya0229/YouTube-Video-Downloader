namespace Youtube
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Youtube = new System.Windows.Forms.TabPage();
            this.webyoutube = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Link = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DownLoad = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.folderpath = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ファイル選択ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.連続再生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filechange1 = new System.Windows.Forms.Label();
            this.filechange = new System.Windows.Forms.Label();
            this.filetxthide = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.filetxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Youtube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webyoutube)).BeginInit();
            this.panel1.SuspendLayout();
            this.DownLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Player.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Youtube);
            this.tabControl1.Controls.Add(this.DownLoad);
            this.tabControl1.Controls.Add(this.Player);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 718);
            this.tabControl1.TabIndex = 0;
            // 
            // Youtube
            // 
            this.Youtube.Controls.Add(this.webyoutube);
            this.Youtube.Controls.Add(this.panel1);
            this.Youtube.Location = new System.Drawing.Point(4, 22);
            this.Youtube.Name = "Youtube";
            this.Youtube.Padding = new System.Windows.Forms.Padding(3);
            this.Youtube.Size = new System.Drawing.Size(1078, 692);
            this.Youtube.TabIndex = 0;
            this.Youtube.Text = "Youtube";
            // 
            // webyoutube
            // 
            this.webyoutube.AllowExternalDrop = true;
            this.webyoutube.CreationProperties = null;
            this.webyoutube.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webyoutube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webyoutube.Location = new System.Drawing.Point(3, 32);
            this.webyoutube.Name = "webyoutube";
            this.webyoutube.Size = new System.Drawing.Size(1072, 657);
            this.webyoutube.Source = new System.Uri("https://youtube.com", System.UriKind.Absolute);
            this.webyoutube.TabIndex = 1;
            this.webyoutube.ZoomFactor = 1D;
            this.webyoutube.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.WebView21_SourceChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Link);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 29);
            this.panel1.TabIndex = 0;
            // 
            // Link
            // 
            this.Link.Dock = System.Windows.Forms.DockStyle.Left;
            this.Link.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Link.Location = new System.Drawing.Point(96, 0);
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            this.Link.Size = new System.Drawing.Size(976, 28);
            this.Link.TabIndex = 4;
            this.Link.TextChanged += new System.EventHandler(this.Link_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(64, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 29);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(32, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DownLoad
            // 
            this.DownLoad.Controls.Add(this.button4);
            this.DownLoad.Controls.Add(this.convert);
            this.DownLoad.Controls.Add(this.folderpath);
            this.DownLoad.Controls.Add(this.progressBar1);
            this.DownLoad.Controls.Add(this.label4);
            this.DownLoad.Controls.Add(this.label3);
            this.DownLoad.Controls.Add(this.pictureBox1);
            this.DownLoad.Controls.Add(this.title);
            this.DownLoad.Location = new System.Drawing.Point(4, 22);
            this.DownLoad.Name = "DownLoad";
            this.DownLoad.Padding = new System.Windows.Forms.Padding(3);
            this.DownLoad.Size = new System.Drawing.Size(1078, 692);
            this.DownLoad.TabIndex = 1;
            this.DownLoad.Text = "DownLoader";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(610, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 22);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // convert
            // 
            this.convert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("convert.BackgroundImage")));
            this.convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convert.Location = new System.Drawing.Point(610, 34);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(38, 22);
            this.convert.TabIndex = 12;
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.Button6_Click);
            // 
            // folderpath
            // 
            this.folderpath.AutoSize = true;
            this.folderpath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.folderpath.Location = new System.Drawing.Point(662, 7);
            this.folderpath.Name = "folderpath";
            this.folderpath.Size = new System.Drawing.Size(21, 16);
            this.folderpath.TabIndex = 11;
            this.folderpath.Text = "C:";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 666);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1072, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(524, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ダウンロード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(524, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "フォルダパス";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(0, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(518, 53);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // Player
            // 
            this.Player.Controls.Add(this.listBox1);
            this.Player.Controls.Add(this.mediaplayer);
            this.Player.Location = new System.Drawing.Point(4, 22);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(1078, 692);
            this.Player.TabIndex = 2;
            this.Player.Text = "Player";
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(814, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 692);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイル選択ToolStripMenuItem,
            this.連続再生ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // ファイル選択ToolStripMenuItem
            // 
            this.ファイル選択ToolStripMenuItem.Name = "ファイル選択ToolStripMenuItem";
            this.ファイル選択ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ファイル選択ToolStripMenuItem.Text = "ファイル選択";
            this.ファイル選択ToolStripMenuItem.Click += new System.EventHandler(this.ファイル選択ToolStripMenuItem_Click);
            // 
            // 連続再生ToolStripMenuItem
            // 
            this.連続再生ToolStripMenuItem.Name = "連続再生ToolStripMenuItem";
            this.連続再生ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.連続再生ToolStripMenuItem.Text = "繰り返し再生";
            this.連続再生ToolStripMenuItem.Click += new System.EventHandler(this.連続再生ToolStripMenuItem_Click);
            // 
            // mediaplayer
            // 
            this.mediaplayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(0, 0);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(814, 692);
            this.mediaplayer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filechange1);
            this.tabPage1.Controls.Add(this.filechange);
            this.tabPage1.Controls.Add(this.filetxthide);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.filetxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1078, 692);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Convertor";
            // 
            // filechange1
            // 
            this.filechange1.AutoSize = true;
            this.filechange1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.filechange1.Location = new System.Drawing.Point(82, 98);
            this.filechange1.Name = "filechange1";
            this.filechange1.Size = new System.Drawing.Size(68, 16);
            this.filechange1.TabIndex = 23;
            this.filechange1.Text = "FileName";
            // 
            // filechange
            // 
            this.filechange.AutoSize = true;
            this.filechange.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.filechange.Location = new System.Drawing.Point(137, 52);
            this.filechange.Name = "filechange";
            this.filechange.Size = new System.Drawing.Size(68, 16);
            this.filechange.TabIndex = 22;
            this.filechange.Text = "FileName";
            // 
            // filetxthide
            // 
            this.filetxthide.AutoSize = true;
            this.filetxthide.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.filetxthide.Location = new System.Drawing.Point(8, 98);
            this.filetxthide.Name = "filetxthide";
            this.filetxthide.Size = new System.Drawing.Size(68, 16);
            this.filetxthide.TabIndex = 21;
            this.filetxthide.Text = "FileName";
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(93, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 23);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 23);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(93, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 22);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // filetxt
            // 
            this.filetxt.AutoSize = true;
            this.filetxt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.filetxt.Location = new System.Drawing.Point(137, 11);
            this.filetxt.Name = "filetxt";
            this.filetxt.Size = new System.Drawing.Size(68, 16);
            this.filetxt.TabIndex = 15;
            this.filetxt.Text = "FileName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ファイルパス";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 718);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Youtube Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Youtube.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webyoutube)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DownLoad.ResumeLayout(false);
            this.DownLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Player.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Youtube;
        private System.Windows.Forms.TabPage DownLoad;
        private System.Windows.Forms.TabPage Player;
        private Microsoft.Web.WebView2.WinForms.WebView2 webyoutube;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label folderpath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイル選択ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 連続再生ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label filetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label filetxthide;
        private System.Windows.Forms.Label filechange;
        private System.Windows.Forms.Label filechange1;
    }
}

