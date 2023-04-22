namespace EVE_Online_Fleet_Pings
{
    partial class AddURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddURL));
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.WebhookURLBox = new System.Windows.Forms.TextBox();
            this.WebhookNameBox = new System.Windows.Forms.TextBox();
            this.WebhookURL = new System.Windows.Forms.Label();
            this.WebhookName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(13, 98);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 26);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(271, 98);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(139, 26);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // WebhookURLBox
            // 
            this.WebhookURLBox.ForeColor = System.Drawing.Color.Silver;
            this.WebhookURLBox.Location = new System.Drawing.Point(142, 59);
            this.WebhookURLBox.Name = "WebhookURLBox";
            this.WebhookURLBox.Size = new System.Drawing.Size(268, 27);
            this.WebhookURLBox.TabIndex = 1;
            this.WebhookURLBox.Text = "Enter Webhook URL Here";
            this.WebhookURLBox.GotFocus += new System.EventHandler(this.RemoveTextFromWebhookURLBox);
            this.WebhookURLBox.LostFocus += new System.EventHandler(this.AddTextToWebhookURLBox);
            // 
            // WebhookNameBox
            // 
            this.WebhookNameBox.ForeColor = System.Drawing.Color.Silver;
            this.WebhookNameBox.Location = new System.Drawing.Point(142, 12);
            this.WebhookNameBox.Name = "WebhookNameBox";
            this.WebhookNameBox.Size = new System.Drawing.Size(268, 27);
            this.WebhookNameBox.TabIndex = 0;
            this.WebhookNameBox.Text = "Enter Webhook Name Here";
            this.WebhookNameBox.GotFocus += new System.EventHandler(this.RemoveTextFromWebhookNameBox);
            this.WebhookNameBox.LostFocus += new System.EventHandler(this.AddTextToWebhookNameBox);
            // 
            // WebhookURL
            // 
            this.WebhookURL.AutoSize = true;
            this.WebhookURL.Location = new System.Drawing.Point(23, 62);
            this.WebhookURL.Name = "WebhookURL";
            this.WebhookURL.Size = new System.Drawing.Size(105, 20);
            this.WebhookURL.TabIndex = 9;
            this.WebhookURL.Text = "Webhook URL:";
            // 
            // WebhookName
            // 
            this.WebhookName.AutoSize = true;
            this.WebhookName.Location = new System.Drawing.Point(17, 15);
            this.WebhookName.Name = "WebhookName";
            this.WebhookName.Size = new System.Drawing.Size(119, 20);
            this.WebhookName.TabIndex = 10;
            this.WebhookName.Text = "Webhook Name:";
            // 
            // AddURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 137);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.WebhookURLBox);
            this.Controls.Add(this.WebhookNameBox);
            this.Controls.Add(this.WebhookURL);
            this.Controls.Add(this.WebhookName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddURL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel;
        private Button Submit;
        private TextBox WebhookURLBox;
        private TextBox WebhookNameBox;
        private Label WebhookURL;
        private Label WebhookName;
    }
}