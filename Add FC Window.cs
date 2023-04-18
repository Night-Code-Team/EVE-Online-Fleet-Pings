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

    async private void Submit_Click(object sender, EventArgs e)
    {
        if (FCNameBox.Text != "Enter FC Name Here" && !string.IsNullOrWhiteSpace(FCNameBox.Text)
            && FCIDBox.Text != "Enter FC ID Here" && !string.IsNullOrWhiteSpace(FCIDBox.Text))
            if (CheckURL(FCIDBox.Text))
            {
                try
                {
                    using var stream = await MainWindow.Client.GetStreamAsync($"https://images.evetech.net/characters/{FCIDBox.Text}/portrait?size=32");
                    using FileStream fileStream = new($@"Cache\FC Photos\{FCNameBox.Text}.png", FileMode.CreateNew);
                    await stream.CopyToAsync(fileStream);
                }
                catch (IOException)
                {
                    MessageBox.Show("Character already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
                string list = File.ReadAllText("Cache/FC List.csv");
                FileStream file = new("Cache/FC List.csv", FileMode.Append);
                StreamWriter writer = new(file);
                if (list != "")
                    writer.WriteLine();
                writer.Write($"{FCNameBox.Text}, {FCIDBox.Text}");
                writer.Close();
                file.Close();
                MainWindow.MW.FCName.Items.Add(FCNameBox.Text);
                MainWindow.FCS.Add(FCNameBox.Text, FCIDBox.Text);
                Close();
            }
            else
                MessageBox.Show("Character does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        else
            MessageBox.Show("Enter FC Name and ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

    }
    private static bool CheckURL(string ID)
    {
        using HttpResponseMessage response = MainWindow.Client.GetAsync($"https://kb.evetools.org/character/{ID}/").Result;
        if (response.IsSuccessStatusCode)
            return true;
        else
        {
            return false;
        }
    }
}