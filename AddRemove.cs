namespace EVE_Online_Fleet_Pings;
public static class AddRemove
{
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
}