namespace EVE_Online_Fleet_Pings;
partial class MainWindow
{
    public static MainWindow MW { get; set; }
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Panel = new System.Windows.Forms.Panel();
            this.FCName = new System.Windows.Forms.ComboBox();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.FCIcon = new System.Windows.Forms.PictureBox();
            this.Doctrine = new System.Windows.Forms.Label();
            this.FormupTime = new System.Windows.Forms.Label();
            this.FormupLocation = new System.Windows.Forms.Label();
            this.FleetName = new System.Windows.Forms.Label();
            this.FooterText = new System.Windows.Forms.Label();
            this.FC = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.DoctrineBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.FleetNameBox = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.TextBox();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.AuthorIcon = new System.Windows.Forms.PictureBox();
            this.Border = new System.Windows.Forms.PictureBox();
            this.WebhookURL = new System.Windows.Forms.Label();
            this.ColorPicker = new System.Windows.Forms.PictureBox();
            this.Send = new System.Windows.Forms.Button();
            this.BorderColor = new System.Windows.Forms.ColorDialog();
            this.AddFC = new System.Windows.Forms.Button();
            this.ClearAllCache = new System.Windows.Forms.Button();
            this.AddURL = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.ComboBox();
            this.TopPanel = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePing = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadLastPing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.GitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveJsonToFile = new System.Windows.Forms.SaveFileDialog();
            this.LoadJsonFromFile = new System.Windows.Forms.OpenFileDialog();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Panel.Controls.Add(this.FCName);
            this.Panel.Controls.Add(this.Time);
            this.Panel.Controls.Add(this.Date);
            this.Panel.Controls.Add(this.FCIcon);
            this.Panel.Controls.Add(this.Doctrine);
            this.Panel.Controls.Add(this.FormupTime);
            this.Panel.Controls.Add(this.FormupLocation);
            this.Panel.Controls.Add(this.FleetName);
            this.Panel.Controls.Add(this.FooterText);
            this.Panel.Controls.Add(this.FC);
            this.Panel.Controls.Add(this.Description);
            this.Panel.Controls.Add(this.Title);
            this.Panel.Controls.Add(this.DoctrineBox);
            this.Panel.Controls.Add(this.LocationBox);
            this.Panel.Controls.Add(this.FleetNameBox);
            this.Panel.Controls.Add(this.Author);
            this.Panel.Controls.Add(this.Thumbnail);
            this.Panel.Controls.Add(this.AuthorIcon);
            this.Panel.Controls.Add(this.Border);
            this.Panel.Location = new System.Drawing.Point(66, 99);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(650, 355);
            this.Panel.TabIndex = 6;
            // 
            // FCName
            // 
            this.FCName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FCName.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FCName.ForeColor = System.Drawing.Color.Black;
            this.FCName.Location = new System.Drawing.Point(70, 167);
            this.FCName.Name = "FCName";
            this.FCName.Size = new System.Drawing.Size(302, 28);
            this.FCName.TabIndex = 5;
            this.FCName.SelectedIndexChanged += new System.EventHandler(this.FCName_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(426, 254);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(188, 27);
            this.Time.TabIndex = 9;
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(244, 254);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(176, 27);
            this.Date.TabIndex = 8;
            // 
            // FCIcon
            // 
            this.FCIcon.Location = new System.Drawing.Point(20, 314);
            this.FCIcon.Name = "FCIcon";
            this.FCIcon.Size = new System.Drawing.Size(32, 32);
            this.FCIcon.TabIndex = 8;
            this.FCIcon.TabStop = false;
            // 
            // Doctrine
            // 
            this.Doctrine.AutoSize = true;
            this.Doctrine.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Doctrine.ForeColor = System.Drawing.Color.White;
            this.Doctrine.Location = new System.Drawing.Point(21, 284);
            this.Doctrine.Name = "Doctrine";
            this.Doctrine.Size = new System.Drawing.Size(100, 23);
            this.Doctrine.TabIndex = 9;
            this.Doctrine.Text = "Doctrine:";
            // 
            // FormupTime
            // 
            this.FormupTime.AutoSize = true;
            this.FormupTime.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormupTime.ForeColor = System.Drawing.Color.White;
            this.FormupTime.Location = new System.Drawing.Point(20, 258);
            this.FormupTime.Name = "FormupTime";
            this.FormupTime.Size = new System.Drawing.Size(218, 23);
            this.FormupTime.TabIndex = 10;
            this.FormupTime.Text = "Formup Time (Local):";
            // 
            // FormupLocation
            // 
            this.FormupLocation.AutoSize = true;
            this.FormupLocation.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormupLocation.ForeColor = System.Drawing.Color.White;
            this.FormupLocation.Location = new System.Drawing.Point(20, 226);
            this.FormupLocation.Name = "FormupLocation";
            this.FormupLocation.Size = new System.Drawing.Size(174, 23);
            this.FormupLocation.TabIndex = 6;
            this.FormupLocation.Text = "Formup location:";
            // 
            // FleetName
            // 
            this.FleetName.AutoSize = true;
            this.FleetName.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FleetName.ForeColor = System.Drawing.Color.White;
            this.FleetName.Location = new System.Drawing.Point(20, 198);
            this.FleetName.Name = "FleetName";
            this.FleetName.Size = new System.Drawing.Size(126, 23);
            this.FleetName.TabIndex = 11;
            this.FleetName.Text = "Fleet Name:";
            // 
            // FooterText
            // 
            this.FooterText.AutoSize = true;
            this.FooterText.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FooterText.ForeColor = System.Drawing.Color.White;
            this.FooterText.Location = new System.Drawing.Point(55, 320);
            this.FooterText.Name = "FooterText";
            this.FooterText.Size = new System.Drawing.Size(66, 17);
            this.FooterText.TabIndex = 4;
            this.FooterText.Text = "Fleet by";
            // 
            // FC
            // 
            this.FC.AutoSize = true;
            this.FC.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FC.ForeColor = System.Drawing.Color.White;
            this.FC.Location = new System.Drawing.Point(20, 170);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(44, 23);
            this.FC.TabIndex = 12;
            this.FC.Text = "FC:";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Description.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.ForeColor = System.Drawing.Color.Silver;
            this.Description.Location = new System.Drawing.Point(20, 102);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(513, 62);
            this.Description.TabIndex = 4;
            this.Description.Text = "Enter Description Here";
            this.Description.GotFocus += new System.EventHandler(this.RemoveTextFromDescription);
            this.Description.LostFocus += new System.EventHandler(this.AddTextToDescription);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Title.Font = new System.Drawing.Font("Rockwell", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Silver;
            this.Title.Location = new System.Drawing.Point(20, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(513, 37);
            this.Title.TabIndex = 3;
            this.Title.Text = "Enter Header Here";
            this.Title.GotFocus += new System.EventHandler(this.RemoveTextFromHeader);
            this.Title.LostFocus += new System.EventHandler(this.AddTextToHeader);
            // 
            // DoctrineBox
            // 
            this.DoctrineBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.DoctrineBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctrineBox.ForeColor = System.Drawing.Color.Silver;
            this.DoctrineBox.Location = new System.Drawing.Point(127, 284);
            this.DoctrineBox.Name = "DoctrineBox";
            this.DoctrineBox.Size = new System.Drawing.Size(487, 25);
            this.DoctrineBox.TabIndex = 10;
            this.DoctrineBox.Text = "Enter Doctrine Here";
            this.DoctrineBox.GotFocus += new System.EventHandler(this.RemoveTextFromDoctrineBox);
            this.DoctrineBox.LostFocus += new System.EventHandler(this.AddTextToDoctrineBox);
            // 
            // LocationBox
            // 
            this.LocationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.LocationBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationBox.ForeColor = System.Drawing.Color.Silver;
            this.LocationBox.Location = new System.Drawing.Point(195, 226);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(419, 25);
            this.LocationBox.TabIndex = 7;
            this.LocationBox.Text = "Enter Location Here";
            this.LocationBox.GotFocus += new System.EventHandler(this.RemoveTextFromLocationBox);
            this.LocationBox.LostFocus += new System.EventHandler(this.AddTextToLocationBox);
            // 
            // FleetNameBox
            // 
            this.FleetNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FleetNameBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FleetNameBox.ForeColor = System.Drawing.Color.Silver;
            this.FleetNameBox.Location = new System.Drawing.Point(146, 198);
            this.FleetNameBox.Name = "FleetNameBox";
            this.FleetNameBox.Size = new System.Drawing.Size(468, 25);
            this.FleetNameBox.TabIndex = 6;
            this.FleetNameBox.Text = "Enter Fleet Name Here";
            this.FleetNameBox.GotFocus += new System.EventHandler(this.RemoveTextFromFleetNameBox);
            this.FleetNameBox.LostFocus += new System.EventHandler(this.AddTextToFleetNameBox);
            // 
            // Author
            // 
            this.Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Author.Font = new System.Drawing.Font("Rockwell", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Author.ForeColor = System.Drawing.Color.Silver;
            this.Author.Location = new System.Drawing.Point(60, 17);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(473, 33);
            this.Author.TabIndex = 2;
            this.Author.Text = "Enter Header Here";
            this.Author.GotFocus += new System.EventHandler(this.RemoveTextFromAuthorHeader);
            this.Author.LostFocus += new System.EventHandler(this.AddTextToAuthorHeader);
            // 
            // Thumbnail
            // 
            this.Thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Thumbnail.Location = new System.Drawing.Point(550, 20);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(80, 80);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thumbnail.TabIndex = 13;
            this.Thumbnail.TabStop = false;
            this.Thumbnail.Click += new System.EventHandler(this.Thumbnail_Click);
            // 
            // AuthorIcon
            // 
            this.AuthorIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorIcon.Location = new System.Drawing.Point(20, 20);
            this.AuthorIcon.Name = "AuthorIcon";
            this.AuthorIcon.Size = new System.Drawing.Size(30, 30);
            this.AuthorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AuthorIcon.TabIndex = 1;
            this.AuthorIcon.TabStop = false;
            this.AuthorIcon.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.Lime;
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Margin = new System.Windows.Forms.Padding(0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(5, 355);
            this.Border.TabIndex = 0;
            this.Border.TabStop = false;
            // 
            // WebhookURL
            // 
            this.WebhookURL.AutoSize = true;
            this.WebhookURL.Location = new System.Drawing.Point(66, 68);
            this.WebhookURL.Name = "WebhookURL";
            this.WebhookURL.Size = new System.Drawing.Size(105, 20);
            this.WebhookURL.TabIndex = 1;
            this.WebhookURL.Text = "Webhook URL:";
            // 
            // ColorPicker
            // 
            this.ColorPicker.BackColor = System.Drawing.Color.Lime;
            this.ColorPicker.Location = new System.Drawing.Point(12, 256);
            this.ColorPicker.Name = "ColorPicker";
            this.ColorPicker.Size = new System.Drawing.Size(40, 40);
            this.ColorPicker.TabIndex = 5;
            this.ColorPicker.TabStop = false;
            this.ColorPicker.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(405, 460);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(311, 81);
            this.Send.TabIndex = 13;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // AddFC
            // 
            this.AddFC.Location = new System.Drawing.Point(66, 460);
            this.AddFC.Name = "AddFC";
            this.AddFC.Size = new System.Drawing.Size(311, 36);
            this.AddFC.TabIndex = 11;
            this.AddFC.Text = "Add FC profile";
            this.AddFC.UseVisualStyleBackColor = true;
            this.AddFC.Click += new System.EventHandler(this.AddFC_Click);
            // 
            // ClearAllCache
            // 
            this.ClearAllCache.Location = new System.Drawing.Point(66, 505);
            this.ClearAllCache.Name = "ClearAllCache";
            this.ClearAllCache.Size = new System.Drawing.Size(311, 36);
            this.ClearAllCache.TabIndex = 12;
            this.ClearAllCache.Text = "Clear all cache and fields";
            this.ClearAllCache.UseVisualStyleBackColor = true;
            this.ClearAllCache.Click += new System.EventHandler(this.ClearAllCache_Click);
            // 
            // AddURL
            // 
            this.AddURL.Location = new System.Drawing.Point(565, 64);
            this.AddURL.Name = "AddURL";
            this.AddURL.Size = new System.Drawing.Size(151, 28);
            this.AddURL.TabIndex = 1;
            this.AddURL.Text = "Add New URL";
            this.AddURL.UseVisualStyleBackColor = true;
            this.AddURL.Click += new System.EventHandler(this.AddURL_Click);
            // 
            // URL
            // 
            this.URL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.URL.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.URL.FormattingEnabled = true;
            this.URL.Location = new System.Drawing.Point(179, 65);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(380, 28);
            this.URL.Sorted = true;
            this.URL.TabIndex = 0;
            this.URL.SelectedIndexChanged += new System.EventHandler(this.URL_SelectedIndexChanged);
            // 
            // TopPanel
            // 
            this.TopPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.Help});
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(782, 28);
            this.TopPanel.TabIndex = 14;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePing,
            this.LoadPing,
            this.toolStripSeparator1,
            this.LoadLastPing,
            this.toolStripSeparator2,
            this.CopyJSON,
            this.toolStripSeparator3,
            this.Quit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "File";
            // 
            // SavePing
            // 
            this.SavePing.Name = "SavePing";
            this.SavePing.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SavePing.Size = new System.Drawing.Size(306, 26);
            this.SavePing.Text = "Save Ping";
            this.SavePing.Click += new System.EventHandler(this.SavePing_Click);
            // 
            // LoadPing
            // 
            this.LoadPing.Name = "LoadPing";
            this.LoadPing.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadPing.Size = new System.Drawing.Size(306, 26);
            this.LoadPing.Text = "Load Ping";
            this.LoadPing.Click += new System.EventHandler(this.LoadPing_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(303, 6);
            // 
            // LoadLastPing
            // 
            this.LoadLastPing.Name = "LoadLastPing";
            this.LoadLastPing.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.LoadLastPing.Size = new System.Drawing.Size(306, 26);
            this.LoadLastPing.Text = "Load Last Ping";
            this.LoadLastPing.Click += new System.EventHandler(this.LoadLastPing_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(303, 6);
            // 
            // CopyJSON
            // 
            this.CopyJSON.Name = "CopyJSON";
            this.CopyJSON.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyJSON.Size = new System.Drawing.Size(306, 26);
            this.CopyJSON.Text = "Copy JSON To Clipboard";
            this.CopyJSON.Click += new System.EventHandler(this.CopyJSON_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(303, 6);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(306, 26);
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GitHub,
            this.toolStripSeparator4,
            this.About});
            this.Help.Name = "Help";
            this.Help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.Help.Size = new System.Drawing.Size(55, 24);
            this.Help.Text = "Help";
            // 
            // GitHub
            // 
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(139, 26);
            this.GitHub.Text = "GitHub";
            this.GitHub.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(136, 6);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(139, 26);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // SaveJsonToFile
            // 
            this.SaveJsonToFile.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            this.SaveJsonToFile.InitialDirectory = "\\\\?\\C:\\Users\\Александр\\AppData\\Local\\Temp\\WinFormsCache\\2k4uoa3j.ta1\\Cache\\Saved " +
    "Pings";
            this.SaveJsonToFile.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveJsonToFile_FileOk);
            // 
            // LoadJsonFromFile
            // 
            this.LoadJsonFromFile.FileName = "Last Ping";
            this.LoadJsonFromFile.Filter = "json files (*.json)|*.json";
            this.LoadJsonFromFile.InitialDirectory = "\\\\?\\C:\\Users\\Александр\\AppData\\Local\\Temp\\WinFormsCache\\2k4uoa3j.ta1\\Cache\\Saved " +
    "Pings";
            this.LoadJsonFromFile.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadJsonFromFile_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.AddURL);
            this.Controls.Add(this.ClearAllCache);
            this.Controls.Add(this.AddFC);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.WebhookURL);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Pings";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Panel Panel;
    private PictureBox Border;
    private Label WebhookURL;
    private TextBox Author;
    public PictureBox AuthorIcon;
    private TextBox Title;
    public PictureBox Thumbnail;
    private RichTextBox Description;
    public ComboBox FCName;
    private PictureBox FCIcon;
    private Label Doctrine;
    private Label FormupTime;
    private Label FormupLocation;
    private Label FleetName;
    private Label FooterText;
    private Label FC;
    private TextBox FleetNameBox;
    private DateTimePicker Date;
    public TextBox DoctrineBox;
    private TextBox LocationBox;
    private PictureBox ColorPicker;
    private Button Send;
    private DateTimePicker Time;
    private ColorDialog BorderColor;
    private Button AddFC;
    private Button ClearAllCache;
    private Button AddURL;
    public ComboBox URL;
    private ToolStripMenuItem GitHub;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private MenuStrip TopPanel;
    private ToolStripMenuItem FileMenu;
    private ToolStripMenuItem SavePing;
    private ToolStripMenuItem LoadPing;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem LoadLastPing;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem CopyJSON;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem Quit;
    private ToolStripMenuItem Help;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem About;
    private SaveFileDialog SaveJsonToFile;
    private OpenFileDialog LoadJsonFromFile;
}