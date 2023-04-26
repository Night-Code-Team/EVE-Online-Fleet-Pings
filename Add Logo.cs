namespace EVE_Online_Fleet_Pings;
public partial class AddLogo : Form
{
    public AddLogo()
    {
        InitializeComponent();
    }
    private void RemoveTextFromLogoURLBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(LogoURLBox, "Enter Logo URL Here", Color.Black);
    }
    private void AddTextToLogoURLBox(object sender, EventArgs e)
    {
        AddRemove.AddText(LogoURLBox, "Enter Logo URL Here");
    }
    private void RemoveTextFromLogoNameBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(LogoNameBox, "Enter Logo Name Here", Color.Black);
    }
    private void AddTextToLogoNameBox(object sender, EventArgs e)
    {
        AddRemove.AddText(LogoNameBox, "Enter Logo Name Here");
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    async private void Submit_ClickAsync(object sender, EventArgs e)
    {
        if (LogoNameBox.Text != "Enter Logo Name Here" && !string.IsNullOrWhiteSpace(LogoNameBox.Text)
                    && LogoURLBox.Text != "Enter Logo URL Here" && !string.IsNullOrWhiteSpace(LogoURLBox.Text))
            if (AddRemove.CheckURL(LogoURLBox.Text))
            {
                try
                {
                    await AddRemove.DownloadImageAsync(LogoURLBox.Text, AddRemove.SavePath.Logos, LogoNameBox.Text, LogoURLBox.Text);
                    LogoSelection.LS.Logos.Images.Add(LogoNameBox.Text, Image.FromFile($"Cache/Logos Photos/{LogoNameBox.Text}.png"));
                    LogoSelection.LS.Logos.Images.SetKeyName(LogoSelection.LS.Logos.Images.Count - 1, $"{LogoNameBox.Text}.png");
                    LogoSelection.LS.LogosList.LargeImageList = LogoSelection.LS.Logos;
                    ListViewItem lvi = new();
                    lvi.Text = LogoNameBox.Text;
                    lvi.ImageKey = LogoNameBox.Text + ".png";
                    LogoSelection.LS.LogosList.Items.Add(lvi);
                    MainWindow.Logos.Add(LogoNameBox.Text, LogoURLBox.Text);
                }
                catch (IOException)
                {
                    MessageBox.Show("Logo already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                Close();
            }
            else
                MessageBox.Show("URL does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        else
            MessageBox.Show("Enter Logo Name and URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

    }
}