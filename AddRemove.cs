namespace EVE_Online_Fleet_Pings;
public static class AddRemove
{
    public enum SavePath
    {
        Logos,
        FC,
        Ships
    }
    public static void AddText(TextBox box, string text)
    {
        if (string.IsNullOrWhiteSpace(box.Text))
        {
            box.ForeColor = Color.Silver;
            box.Text = text;
        }
    }
    public static void AddText(RichTextBox box, string text)
    {
        if (string.IsNullOrWhiteSpace(box.Text))
        {
            box.ForeColor = Color.Silver;
            box.Text = text;
        }
    }
    public static void RemoveText(TextBox box, string text, Color color)
    {
        if (box.Text == text)
        {
            box.ForeColor = color;
            box.Text = "";
        }
    }
    public static void RemoveText(RichTextBox box, string text, Color color)
    {
        if (box.Text == text)
        {
            box.ForeColor = color;
            box.Text = "";
        }
    }
    public static bool CheckURL(string ID)
    {
        try
        {
            using HttpResponseMessage response = MainWindow.Client.GetAsync(ID).Result;
            if (response.IsSuccessStatusCode)
                return true;
            else
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
    }
    async public static Task DownloadImageAsync(string url, SavePath path, string name, string id)
    {
        using Stream stream = await MainWindow.Client.GetStreamAsync(url);
        using FileStream fileStream = new($@"Cache\{path.ToString()} Photos\{name}.png", FileMode.CreateNew);
        await stream.CopyToAsync(fileStream);
        fileStream.Close();
        stream.Close();
        string list = File.ReadAllText($"Cache/{path.ToString()} List.csv");
        FileStream file = new($"Cache/{path.ToString()} List.csv", FileMode.Append);
        StreamWriter writer = new(file);
        if (list != "")
            writer.WriteLine();
        writer.Write($"{name},{id}");
        writer.Close();
        file.Close();
    }
}