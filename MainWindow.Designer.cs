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
            this.Footer = new System.Windows.Forms.Label();
            this.FC = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Header = new System.Windows.Forms.TextBox();
            this.DoctrineBox = new System.Windows.Forms.TextBox();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.FleetNameBox = new System.Windows.Forms.TextBox();
            this.AuthorHeader = new System.Windows.Forms.TextBox();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Border = new System.Windows.Forms.PictureBox();
            this.WebhookURL = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.ColorPicker = new System.Windows.Forms.PictureBox();
            this.Send = new System.Windows.Forms.Button();
            this.BorderColor = new System.Windows.Forms.ColorDialog();
            this.AddFC = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker)).BeginInit();
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
            this.Panel.Controls.Add(this.Footer);
            this.Panel.Controls.Add(this.FC);
            this.Panel.Controls.Add(this.Description);
            this.Panel.Controls.Add(this.Header);
            this.Panel.Controls.Add(this.DoctrineBox);
            this.Panel.Controls.Add(this.LocationBox);
            this.Panel.Controls.Add(this.FleetNameBox);
            this.Panel.Controls.Add(this.AuthorHeader);
            this.Panel.Controls.Add(this.Thumbnail);
            this.Panel.Controls.Add(this.Logo);
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
            this.FCName.TabIndex = 54;
            this.FCName.SelectedIndexChanged += new System.EventHandler(this.FCName_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time.Location = new System.Drawing.Point(398, 257);
            this.Time.Name = "Time";
            this.Time.ShowUpDown = true;
            this.Time.Size = new System.Drawing.Size(216, 27);
            this.Time.TabIndex = 8;
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(173, 257);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(216, 27);
            this.Date.TabIndex = 7;
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
            this.FormupTime.Size = new System.Drawing.Size(147, 23);
            this.FormupTime.TabIndex = 10;
            this.FormupTime.Text = "Formup Time:";
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
            // Footer
            // 
            this.Footer.AutoSize = true;
            this.Footer.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Footer.ForeColor = System.Drawing.Color.White;
            this.Footer.Location = new System.Drawing.Point(55, 320);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(66, 17);
            this.Footer.TabIndex = 4;
            this.Footer.Text = "Fleet by";
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
            this.Description.TabIndex = 3;
            this.Description.Text = "Enter Description Here";
            this.Description.GotFocus += new System.EventHandler(this.RemoveTextFromDescription);
            this.Description.LostFocus += new System.EventHandler(this.AddTextToDescription);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.Header.Font = new System.Drawing.Font("Rockwell", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.ForeColor = System.Drawing.Color.Silver;
            this.Header.Location = new System.Drawing.Point(20, 59);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(513, 37);
            this.Header.TabIndex = 2;
            this.Header.Text = "Enter Header Here";
            this.Header.GotFocus += new System.EventHandler(this.RemoveTextFromHeader);
            this.Header.LostFocus += new System.EventHandler(this.AddTextToHeader);
            // 
            // DoctrineBox
            // 
            this.DoctrineBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.DoctrineBox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctrineBox.ForeColor = System.Drawing.Color.Silver;
            this.DoctrineBox.Location = new System.Drawing.Point(127, 284);
            this.DoctrineBox.Name = "DoctrineBox";
            this.DoctrineBox.Size = new System.Drawing.Size(487, 25);
            this.DoctrineBox.TabIndex = 9;
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
            this.LocationBox.TabIndex = 6;
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
            this.FleetNameBox.TabIndex = 5;
            this.FleetNameBox.Text = "Enter Fleet Name Here";
            this.FleetNameBox.GotFocus += new System.EventHandler(this.RemoveTextFromFleetNameBox);
            this.FleetNameBox.LostFocus += new System.EventHandler(this.AddTextToFleetNameBox);
            // 
            // AuthorHeader
            // 
            this.AuthorHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AuthorHeader.Font = new System.Drawing.Font("Rockwell", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorHeader.ForeColor = System.Drawing.Color.Silver;
            this.AuthorHeader.Location = new System.Drawing.Point(60, 17);
            this.AuthorHeader.Name = "AuthorHeader";
            this.AuthorHeader.Size = new System.Drawing.Size(473, 33);
            this.AuthorHeader.TabIndex = 1;
            this.AuthorHeader.Text = "Enter Header Here";
            this.AuthorHeader.GotFocus += new System.EventHandler(this.RemoveTextFromAuthorHeader);
            this.AuthorHeader.LostFocus += new System.EventHandler(this.AddTextToAuthorHeader);
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
            // Logo
            // 
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo.Location = new System.Drawing.Point(20, 20);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(30, 30);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
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
            this.WebhookURL.Location = new System.Drawing.Point(66, 44);
            this.WebhookURL.Name = "WebhookURL";
            this.WebhookURL.Size = new System.Drawing.Size(105, 20);
            this.WebhookURL.TabIndex = 1;
            this.WebhookURL.Text = "Webhook URL:";
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(174, 41);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(542, 27);
            this.URL.TabIndex = 0;
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
            this.Send.Location = new System.Drawing.Point(405, 474);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(311, 56);
            this.Send.TabIndex = 11;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // AddFC
            // 
            this.AddFC.Location = new System.Drawing.Point(66, 474);
            this.AddFC.Name = "AddFC";
            this.AddFC.Size = new System.Drawing.Size(311, 56);
            this.AddFC.TabIndex = 10;
            this.AddFC.Text = "Add FC profile";
            this.AddFC.UseVisualStyleBackColor = true;
            this.AddFC.Click += new System.EventHandler(this.AddFC_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.AddFC);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.ColorPicker);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.WebhookURL);
            this.Controls.Add(this.Panel);
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
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Panel Panel;
    private PictureBox Border;
    private Label WebhookURL;
    private TextBox AuthorHeader;
    public PictureBox Logo;
    private TextBox Header;
    public PictureBox Thumbnail;
    private RichTextBox Description;
    public ComboBox FCName;
    private PictureBox FCIcon;
    private Label Doctrine;
    private Label FormupTime;
    private Label FormupLocation;
    private Label FleetName;
    private Label Footer;
    private Label FC;
    private TextBox FleetNameBox;
    private DateTimePicker Date;
    public TextBox DoctrineBox;
    private TextBox LocationBox;
    private TextBox URL;
    private PictureBox ColorPicker;
    private Button Send;
    private DateTimePicker Time;
    private ColorDialog BorderColor;
    private Button AddFC;
}