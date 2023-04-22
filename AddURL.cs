namespace EVE_Online_Fleet_Pings
{
    public partial class AddURL : Form
    {
        public AddURL()
        {
            InitializeComponent();
        }
        private void RemoveTextFromWebhookNameBox(object sender, EventArgs e)
        {
            AddRemove.RemoveText(WebhookNameBox, "Enter Webhook Name Here", Color.Black);
        }
        private void AddTextToWebhookNameBox(object sender, EventArgs e)
        {
            AddRemove.AddText(WebhookNameBox, "Enter Webhook Name Here");
        }
        private void RemoveTextFromWebhookURLBox(object sender, EventArgs e)
        {
            AddRemove.RemoveText(WebhookURLBox, "Enter Webhook URL Here", Color.Black);
        }
        private void AddTextToWebhookURLBox(object sender, EventArgs e)
        {
            AddRemove.AddText(WebhookURLBox, "Enter Webhook URL Here");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (WebhookNameBox.Text != "Enter Webhook Name Here" && !string.IsNullOrWhiteSpace(WebhookNameBox.Text)
                && WebhookURLBox.Text != "Enter Webhook URL Here" && !string.IsNullOrWhiteSpace(WebhookURLBox.Text))
                if (AddRemove.CheckURL(WebhookURLBox.Text))
                {
                    string list = File.ReadAllText("Cache/Webhooks List.csv");
                    FileStream file = new("Cache/Webhooks List.csv", FileMode.Append);
                    StreamWriter writer = new(file);
                    if (list != "")
                        writer.WriteLine();
                    writer.Write($"{WebhookNameBox.Text},{WebhookURLBox.Text}");
                    writer.Close();
                    file.Close();
                    MainWindow.MW.URL.Items.Add(WebhookNameBox.Text);
                    MainWindow.URLs.Add(WebhookNameBox.Text, WebhookURLBox.Text);
                    Close();
                }
                else
                    MessageBox.Show("Wrong URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            else
                MessageBox.Show("Enter Webhook Name and URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}