using System.ComponentModel;

namespace EVE_Online_Fleet_Pings;
partial class Info
{

    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
        this.CloseButton = new System.Windows.Forms.Button();
        this.InfoText = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();

        // Close

        this.CloseButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.CloseButton.Location = new System.Drawing.Point(0, 547);
        this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.CloseButton.Name = "close";
        this.CloseButton.Size = new System.Drawing.Size(686, 53);
        this.CloseButton.TabIndex = 0;
        this.CloseButton.Text = "Close";
        this.CloseButton.UseVisualStyleBackColor = true;
        this.CloseButton.Click += new System.EventHandler(this.Close_Click);
        // 
        // InfoText
        // 
        this.InfoText.Location = new System.Drawing.Point(0, 0);
        this.InfoText.Name = "InfoText";
        this.InfoText.ReadOnly = true;
        this.InfoText.Size = new System.Drawing.Size(686, 549);
        this.InfoText.TabIndex = 1;
        this.InfoText.Text = File.ReadAllText("README.md");
        // 
        // Info
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(686, 600);
        this.Controls.Add(this.InfoText);
        this.Controls.Add(this.CloseButton);
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.Name = "Info";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Info";
        this.ResumeLayout(false);
    }

    private Button CloseButton;
    private RichTextBox InfoText;
}