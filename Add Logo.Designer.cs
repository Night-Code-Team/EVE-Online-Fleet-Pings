namespace EVE_Online_Fleet_Pings;
partial class AddLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLogo));
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.LogoURLBox = new System.Windows.Forms.TextBox();
            this.LogoNameBox = new System.Windows.Forms.TextBox();
            this.LogoURL = new System.Windows.Forms.Label();
            this.LogoName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(13, 99);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 26);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(271, 99);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(139, 26);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_ClickAsync);
            // 
            // LogoURLBox
            // 
            this.LogoURLBox.ForeColor = System.Drawing.Color.Silver;
            this.LogoURLBox.Location = new System.Drawing.Point(113, 60);
            this.LogoURLBox.Name = "LogoURLBox";
            this.LogoURLBox.Size = new System.Drawing.Size(297, 27);
            this.LogoURLBox.TabIndex = 1;
            this.LogoURLBox.Text = "Enter Logo URL Here";
            this.LogoURLBox.GotFocus += new System.EventHandler(this.RemoveTextFromLogoURLBox);
            this.LogoURLBox.LostFocus += new System.EventHandler(this.AddTextToLogoURLBox);
            // 
            // LogoNameBox
            // 
            this.LogoNameBox.ForeColor = System.Drawing.Color.Silver;
            this.LogoNameBox.Location = new System.Drawing.Point(113, 13);
            this.LogoNameBox.Name = "LogoNameBox";
            this.LogoNameBox.Size = new System.Drawing.Size(297, 27);
            this.LogoNameBox.TabIndex = 0;
            this.LogoNameBox.Text = "Enter Logo Name Here";
            this.LogoNameBox.GotFocus += new System.EventHandler(this.RemoveTextFromLogoNameBox);
            this.LogoNameBox.LostFocus += new System.EventHandler(this.AddTextToLogoNameBox);
            // 
            // LogoURL
            // 
            this.LogoURL.AutoSize = true;
            this.LogoURL.Location = new System.Drawing.Point(17, 63);
            this.LogoURL.Name = "LogoURL";
            this.LogoURL.Size = new System.Drawing.Size(76, 20);
            this.LogoURL.TabIndex = 3;
            this.LogoURL.Text = "Logo URL:";
            // 
            // LogoName
            // 
            this.LogoName.AutoSize = true;
            this.LogoName.Location = new System.Drawing.Point(17, 16);
            this.LogoName.Name = "LogoName";
            this.LogoName.Size = new System.Drawing.Size(90, 20);
            this.LogoName.TabIndex = 4;
            this.LogoName.Text = "Logo Name:";
            // 
            // AddLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 137);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.LogoURLBox);
            this.Controls.Add(this.LogoNameBox);
            this.Controls.Add(this.LogoURL);
            this.Controls.Add(this.LogoName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Logo";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button Cancel;
    private Button Submit;
    private TextBox LogoURLBox;
    private TextBox LogoNameBox;
    private Label LogoURL;
    private Label LogoName;
}