using System.Diagnostics;
using Newtonsoft.Json;

namespace EVE_Online_Fleet_Pings;
public partial class MainWindow : Form
{
    public static HttpClient Client { get; set; } = new HttpClient();
    public static Dictionary<string, string> FCS { get; set; } = new();
    public static Dictionary<string, string> Ships { get; set; } = new();
    public static Dictionary<string, string> Logos { get; set; } = new();
    public static Dictionary<string, string> URLs { get; set; } = new();
    public static string FCID { get; set; } = "";
    public static string ShipID { get; set; } = "";
    public static string LogoURL { get; set; } = "";
    public static string URLstr { get; set; } = "";
    public MainWindow()
    {
        InitializeComponent();
        MW = this;
    }
    #region
    private void RemoveTextFromDoctrineBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(DoctrineBox, "Enter Doctrine Here", Color.White);
    }
    private void AddTextToDoctrineBox(object sender, EventArgs e)
    {
        AddRemove.AddText(DoctrineBox, "Enter Doctrine Here");
    }
    private void RemoveTextFromDescription(object sender, EventArgs e)
    {
        AddRemove.RemoveText(Description, "Enter Description Here", Color.White);
    }
    private void AddTextToDescription(object sender, EventArgs e)
    {
        AddRemove.AddText(Description, "Enter Description Here");
    }
    private void RemoveTextFromHeader(object sender, EventArgs e)
    {
        AddRemove.RemoveText(Header, "Enter Header Here", Color.White);
    }
    private void AddTextToHeader(object sender, EventArgs e)
    {
        AddRemove.AddText(Header, "Enter Header Here");
    }
    private void RemoveTextFromLocationBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(LocationBox, "Enter Location Here", Color.White);
    }
    private void AddTextToLocationBox(object sender, EventArgs e)
    {
        AddRemove.AddText(LocationBox, "Enter Location Here");
    }
    private void RemoveTextFromFleetNameBox(object sender, EventArgs e)
    {
        AddRemove.RemoveText(FleetNameBox, "Enter Fleet Name Here", Color.White);
    }
    private void AddTextToFleetNameBox(object sender, EventArgs e)
    {
        AddRemove.AddText(FleetNameBox, "Enter Fleet Name Here");
    }
    private void RemoveTextFromAuthorHeader(object sender, EventArgs e)
    {
        AddRemove.RemoveText(AuthorHeader, "Enter Header Here", Color.White);
    }
    private void AddTextToAuthorHeader(object sender, EventArgs e)
    {
        AddRemove.AddText(AuthorHeader, "Enter Header Here");
    }
    #endregion
    private void ColorPicker_Click(object sender, EventArgs e)
    {
        if (BorderColor.ShowDialog() == DialogResult.OK)
        {
            ColorPicker.BackColor = BorderColor.Color;
            Border.BackColor = BorderColor.Color;
        }
    }
    private void Thumbnail_Click(object sender, EventArgs e)
    {
        new ThumbnailSelection().ShowDialog();
    }
    private void Logo_Click(object sender, EventArgs e)
    {
        new LogoSelection().ShowDialog();
    }

    private void AddFC_Click(object sender, EventArgs e)
    {
        new AddFCWindow().ShowDialog();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        string[] FCList = File.ReadAllLines("Cache/FC List.csv");
        foreach (string FC in FCList)
        {
            FCS.Add(FC.Remove(FC.IndexOf(",")), FC.Remove(0, FC.IndexOf(",") + 1));
            FCName.Items.Add(FC.Remove(FC.IndexOf(",")));
        }
        string[] WebhookList = File.ReadAllLines("Cache/Webhooks List.csv");
        foreach (string Webhook in WebhookList)
        {
            FCS.Add(Webhook.Remove(Webhook.IndexOf(",")), Webhook.Remove(0, Webhook.IndexOf(",") + 1));
            FCName.Items.Add(Webhook.Remove(Webhook.IndexOf(",")));
        }
        string[] list = File.ReadAllLines("Cache/Ships List.csv");
        foreach (string ship in list)
        {
            MainWindow.Ships.Add(ship.Remove(0, ship.IndexOf(",") + 1), ship.Remove(ship.IndexOf(",")));
        }
        list = File.ReadAllLines("Cache/Logo List.csv");
        foreach (string logo in list)
        {
            MainWindow.Logos.Add(logo.Remove(logo.IndexOf(",")), logo.Remove(0, logo.IndexOf(",") + 1));
        }
        FCName.SelectedItem = "TBD";
    }
    private void FCName_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (Image img = Image.FromFile($"Cache/FC Photos/{FCName.SelectedItem}.png"))
        {
            FCIcon.Image = new Bitmap(img);
            img.Dispose();
        }
        Footer.Text = "Fleet by " + FCName.SelectedItem.ToString();
        FCID = FCS[$"{FCName.SelectedItem}"];
    }
    private void Send_Click(object sender, EventArgs e)
    {
        if (CheckJSON())
        {
            try
            {
                SendMessage(URLs[URLstr], FormString());
            }
            catch
            {
                MessageBox.Show("Wrong Webhhok URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
    private static void SendMessage(string uri, string message)
    {
        Connection.Post(uri, message);
    }
    private string FormString()
    {
        DateTime dt = DateTime.UtcNow;
        string month = dt.Month.ToString();
        if (month.Length < 2)
        {
            month = "0" + month;
        }
        string day = dt.Day.ToString();
        if (day.Length < 2)
        {
            day = "0" + day;
        }
        string time = $"{dt.Year}-{month}-{day}T{dt.TimeOfDay}Z";
        DateTime ft = new(Date.Value.Year, Date.Value.Month, Date.Value.Day, Time.Value.Hour, Time.Value.Minute, Time.Value.Second);
        long unix = ((DateTimeOffset)ft).ToUnixTimeSeconds();
        string color = ((Border.BackColor.R * 65536) + (Border.BackColor.G * 256) + Border.BackColor.B).ToString();
        string json = JsonConvert.SerializeObject(new
        {
            content = "@everyone",
            embeds = new[]
                {
                    new
                    {
                        title = $"{Header.Text}",
                        description = $"{Description.Text}\n\n**FC**: {FCName.SelectedItem}\n**Fleet Name**: {FleetNameBox.Text}\n**Formup Location**: {LocationBox.Text}\n**Formup Time**: <t:{unix}:F>\n**Doctrine**: {DoctrineBox.Text}",
                        color = $"{color}",
                        author = new
                        {
                            name = $"{AuthorHeader.Text}",
                            icon_url = $"{LogoURL}"
                        },
                        footer = new
                        {
                            text = $"{Footer.Text}",
                            icon_url = $"https://images.evetech.net/characters/{FCID}/portrait?size=128"
                        },
                        timestamp = $"{time}",
                        thumbnail = new
                        {
                            url = $"https://images.evetech.net/types/{ShipID}/render?size=128"
                        }
                    }
                }
        });
        return json;
    }
    private bool CheckJSON()
    {
        if (WebhookURL.Text != "Enter Webhook URL Here" && Logo.Image != null && AuthorHeader.Text != "Enter Header Here"
                && Thumbnail.Image != null && Header.Text != "Enter Header Here" && Description.Text != "Enter Description Here"
                && FleetNameBox.Text != "Enter Fleet Name Here" && LocationBox.Text != "Enter Location Here" && DoctrineBox.Text != "Enter Doctrine Here")
        {
            Clipboard.SetData(DataFormats.Text, FormString());
            return true;
        }
        else
        {
            MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return false;
        }
    }
    private void ClearAllCache_Click(object sender, EventArgs e)
    {
        Logos.Clear();
        URLs.Clear();
        URL.Items.Clear();
        foreach (KeyValuePair<string, string> FC in FCS)
        {
            if (FC.Key != "TBD")
                FCS.Remove(FC.Key);
        }
        FCID = "";
        ShipID = "";
        LogoURL = "";
        URLstr = "";
        Logo.Image = null;
        Thumbnail.Image = null;
        FCIcon.Image = Image.FromFile("Cache/FC Photos/TBD.png");
        FCName.SelectedItem = "TBD";
        Border.BackColor = Color.Green;
        for (int i = 1; i <= 3; ++i)
        {
            try
            {
                ClearFiles("Cache/FC Photos", "Cache/Logo Photos");
                break;
            }
            catch
            {
                Thread.Sleep(500);
            }
        }
        ClearCSVs("Cache/FC List.csv", "Cache/Logo List.csv", "Cache/Webhooks List.csv");
        Description.Text = "Enter Description Here";
        Header.Text = "Enter Header Here";
        DoctrineBox.Text = "Enter Doctrine Here";
        LocationBox.Text = "Enter Location Here";
        FleetNameBox.Text = "Enter Fleet Name Here";
        AuthorHeader.Text = "Enter Header Here";
        foreach (var item in FCName.Items)
        {
            if (item.ToString() != "TBD")
                FCName.Items.Remove(item);
        }
    }
    private static void ClearFiles(params string[] path)
    {
        foreach (string p in path)
            foreach (System.IO.FileInfo file in new DirectoryInfo(p).GetFiles())
                if (!file.FullName.Contains("TBD"))
                    file.Delete();
    }
    private static void ClearCSVs(params string[] path)
    {
        foreach (string file in path)
            if (!file.Contains("FC"))
                File.WriteAllText(file, string.Empty);
            else
                File.WriteAllText(file, "TBD,0");
    }

    private void AddURL_Click(object sender, EventArgs e)
    {
        new AddURL().ShowDialog();
    }

    private void SavePing_Click(object sender, EventArgs e)
    {
        if (CheckJSON() && URL.SelectedItem != null)
        {

        }
    }

    private void LoadPing_Click(object sender, EventArgs e)
    {

    }

    private void LoadLastPing_Click(object sender, EventArgs e)
    {

    }

    private void CopyJSON_Click(object sender, EventArgs e)
    {
        if (CheckJSON())
            Clipboard.SetData(DataFormats.Text, FormString());
    }
    private void Quit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void GitHub_Click(object sender, EventArgs e)
    {
        using Process? p = Process.Start(new ProcessStartInfo("cmd", "/c start https://github.com/Night-Code-Team/EVE-Online-Fleet-Pings-Beta/releases") { CreateNoWindow = true });
    }

    private void About_Click(object sender, EventArgs e)
    {
        Process.Start("README.md");
    }

    private void URL_SelectedIndexChanged(object sender, EventArgs e)
    {
        URLstr = URLs[$"{URL.SelectedItem}"];
    }
}