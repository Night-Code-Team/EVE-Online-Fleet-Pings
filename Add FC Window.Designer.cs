
namespace EVE_Online_Fleet_Pings;
partial class AddFCWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFCWindow));
            this.FCName = new System.Windows.Forms.Label();
            this.FCID = new System.Windows.Forms.Label();
            this.FCNameBox = new System.Windows.Forms.TextBox();
            this.FCIDBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FCName
            // 
            this.FCName.AutoSize = true;
            this.FCName.Location = new System.Drawing.Point(16, 16);
            this.FCName.Name = "FCName";
            this.FCName.Size = new System.Drawing.Size(72, 20);
            this.FCName.TabIndex = 0;
            this.FCName.Text = "FC Name:";
            // 
            // FCID
            // 
            this.FCID.AutoSize = true;
            this.FCID.Location = new System.Drawing.Point(25, 63);
            this.FCID.Name = "FCID";
            this.FCID.Size = new System.Drawing.Size(47, 20);
            this.FCID.TabIndex = 0;
            this.FCID.Text = "FC ID:";
            // 
            // FCNameBox
            // 
            this.FCNameBox.ForeColor = System.Drawing.Color.Silver;
            this.FCNameBox.Location = new System.Drawing.Point(89, 13);
            this.FCNameBox.Name = "FCNameBox";
            this.FCNameBox.Size = new System.Drawing.Size(320, 27);
            this.FCNameBox.TabIndex = 0;
            this.FCNameBox.Text = "Enter FC Name Here";
            this.FCNameBox.GotFocus += new System.EventHandler(this.RemoveTextFromFCNameBox);
            this.FCNameBox.LostFocus += new System.EventHandler(this.AddTextToFCNameBox);
            // 
            // FCIDBox
            // 
            this.FCIDBox.ForeColor = System.Drawing.Color.Silver;
            this.FCIDBox.Location = new System.Drawing.Point(89, 60);
            this.FCIDBox.Name = "FCIDBox";
            this.FCIDBox.Size = new System.Drawing.Size(320, 27);
            this.FCIDBox.TabIndex = 1;
            this.FCIDBox.Text = "Enter FC ID Here";
            this.FCIDBox.GotFocus += new System.EventHandler(this.RemoveTextFromFCIDBox);
            this.FCIDBox.LostFocus += new System.EventHandler(this.AddTextToFCIDBox);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(270, 99);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(139, 26);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_ClickAsync);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 99);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 26);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddFCWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 137);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.FCIDBox);
            this.Controls.Add(this.FCNameBox);
            this.Controls.Add(this.FCID);
            this.Controls.Add(this.FCName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddFCWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add FC";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label FCName;
    private Label FCID;
    private TextBox FCNameBox;
    private TextBox FCIDBox;
    private Button Submit;
    private Button Cancel;
}