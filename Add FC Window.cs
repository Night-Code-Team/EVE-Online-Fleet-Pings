namespace EVE_Online_Fleet_Pings;
public partial class AddFCWindow : Form
{
    public AddFCWindow()
    {
        InitializeComponent();
    }
    private void RemoveTextFromFCNameBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(FCNameBox, "Enter FC Name Here", Color.Black);
    }
    private void AddTextToFCNameBox(object sender, EventArgs e)
    {
        AddRemove.AddText(FCNameBox, "Enter FC Name Here");
    }
    private void RemoveTextFromFCIDBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(FCIDBox, "Enter FC ID Here", Color.Black);
    }
    private void AddTextToFCIDBox(object sender, EventArgs e)
    {
        AddRemove.AddText(FCIDBox, "Enter FC ID Here");
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    async private void Submit_ClickAsync(object sender, EventArgs e)
    {
        if (FCNameBox.Text != "Enter FC Name Here" && !string.IsNullOrWhiteSpace(FCNameBox.Text)
            && FCIDBox.Text != "Enter FC ID Here" && !string.IsNullOrWhiteSpace(FCIDBox.Text))
            if (AddRemove.CheckURL($"https://kb.evetools.org/character/{FCIDBox.Text}/"))
            {
                try
                {
                    string url = $"https://images.evetech.net/characters/{FCIDBox.Text}/portrait?size=32";
                    await AddRemove.DownloadImageAsync(url, AddRemove.SavePath.FC, FCNameBox.Text, FCIDBox.Text);
                    MainWindow.MW.FCName.Items.Add(FCNameBox.Text);
                    MainWindow.FCS.Add(FCNameBox.Text, FCIDBox.Text);
                    Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("Character already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
                MessageBox.Show("Character does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        else
            MessageBox.Show("Enter FC Name and ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }
}