using System.Data;
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
    private string Content { get; set; } = "@everyone";
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
        AddRemove.RemoveText(Title, "Enter Header Here", Color.White);
    }
    private void AddTextToHeader(object sender, EventArgs e)
    {
        AddRemove.AddText(Title, "Enter Header Here");
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
        AddRemove.RemoveText(Author, "Enter Header Here", Color.White);
    }
    private void AddTextToAuthorHeader(object sender, EventArgs e)
    {
        AddRemove.AddText(Author, "Enter Header Here");
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
            URLs.Add(Webhook.Remove(Webhook.IndexOf(",")), Webhook.Remove(0, Webhook.IndexOf(",") + 1));
            URL.Items.Add(Webhook.Remove(Webhook.IndexOf(",")));
        }
        string[] list = File.ReadAllLines("Cache/Ships List.csv");
        foreach (string ship in list)
        {
            MainWindow.Ships.Add(ship.Remove(0, ship.IndexOf(",") + 1), ship.Remove(ship.IndexOf(",")));
        }
        list = File.ReadAllLines("Cache/Logos List.csv");
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
        FooterText.Text = "Fleet by " + FCName.SelectedItem.ToString();
        FCID = FCS[$"{FCName.SelectedItem}"];
    }
    private void Send_Click(object sender, EventArgs e)
    {
        if (CheckJSON())
        {
            try
            {
                string json = FormJSON();
                SendMessage(URLstr, json);
                File.WriteAllText("Cache/Last Ping.json", json);
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
    private string FormJSON()
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
        string ET;
        string formupTime;
        if ((ft - DateTime.Now).TotalMinutes < 5)
        {
            ET = "NOW";
            formupTime = "NOW";
        }
        else
        {
            DateTime formupTimeET = ft.AddHours(-3);
            ET = $"{formupTimeET.Hour}:{formupTimeET.Minute}ET";
            formupTime = $"<t:{((DateTimeOffset)ft).ToUnixTimeSeconds()}:F>";
        }
        string color = ((Border.BackColor.R * 65536) + (Border.BackColor.G * 256) + Border.BackColor.B).ToString();
        string json = JsonConvert.SerializeObject(new
        {
            content = Content,
            embeds = new[]
                {
                    new
                    {
                        title = $"{Title.Text}",
                        description = $"{Description.Text}\n\n**FC**: {FCName.SelectedItem}\n**Fleet Name**: {FleetNameBox.Text}\n**Formup Location**: {LocationBox.Text}\n**Formup Time ET**: {ET}\n**Formup Time Local**: {formupTime}\n**Doctrine**: {DoctrineBox.Text}",
                        color = $"{color}",
                        author = new
                        {
                            name = $"{Author.Text}",
                            icon_url = $"{LogoURL}"
                        },
                        footer = new
                        {
                            text = $"{FooterText.Text}",
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
        if (WebhookURL.Text != "Enter Webhook URL Here" && AuthorIcon.Image != null && Author.Text != "Enter Header Here"
                && Thumbnail.Image != null && Title.Text != "Enter Header Here" && Description.Text != "Enter Description Here"
                && FleetNameBox.Text != "Enter Fleet Name Here" && LocationBox.Text != "Enter Location Here" && DoctrineBox.Text != "Enter Doctrine Here")
        {
            DateTime ft = new(Date.Value.Year, Date.Value.Month, Date.Value.Day, Time.Value.Hour, Time.Value.Minute, Time.Value.Second);
            if ((ft - DateTime.Now).TotalMinutes > 0)
                return true;
            else
            {
                MessageBox.Show("Formup time must be greater than the current time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }
        }
        else
        {
            MessageBox.Show("Fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
        AuthorIcon.Image = null;
        Thumbnail.Image = null;
        FCIcon.Image = Image.FromFile("Cache/FC Photos/TBD.png");
        FCName.SelectedItem = "TBD";
        Border.BackColor = Color.Green;
        for (int i = 1; i <= 3; ++i)
        {
            try
            {
                ClearFiles("Cache/FC Photos", "Cache/Logos Photos");
                break;
            }
            catch
            {
                Thread.Sleep(500);
            }
        }
        ClearCSVs("Cache/FC List.csv", "Cache/Logos List.csv", "Cache/Webhooks List.csv", "Cache/Last Ping.json");
        Description.Text = "Enter Description Here";
        Title.Text = "Enter Header Here";
        DoctrineBox.Text = "Enter Doctrine Here";
        LocationBox.Text = "Enter Location Here";
        FleetNameBox.Text = "Enter Fleet Name Here";
        Author.Text = "Enter Header Here";
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
        if (CheckJSON())
        {
            SaveJsonToFile.ShowDialog();
        }
    }

    private void LoadPing_Click(object sender, EventArgs e)
    {
        LoadJsonFromFile.ShowDialog();
    }

    private void LoadLastPing_Click(object sender, EventArgs e)
    {
        if (File.Exists("Cache/Last Ping.json"))
            LoadJson("Cache/Last Ping.json");
        else
            MessageBox.Show("Cannot Find \"Cache/Last Ping.json\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

    }
    private void CopyJSON_Click(object sender, EventArgs e)
    {
        if (CheckJSON())
            Clipboard.SetData(DataFormats.Text, FormJSON());
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
        new Info().ShowDialog();
    }

    private void URL_SelectedIndexChanged(object sender, EventArgs e)
    {
        URLstr = URLs[$"{URL.SelectedItem}"];
    }

    private void SaveJsonToFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
        File.WriteAllText(SaveJsonToFile.FileName, FormJSON());
    }

    private void LoadJsonFromFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
        LoadJson(LoadJsonFromFile.FileName);
    }
    async private void LoadJson(string path)
    {
        JsonProperties? json = JsonConvert.DeserializeObject<JsonProperties>(File.ReadAllText(path));
        if (json != null)
        {
            if (!Logos.ContainsValue(json.Embeds[0].Author.IconURL))
            {
                await AddRemove.DownloadImageAsync(json.Embeds[0].Author.IconURL, AddRemove.SavePath.Logos, "Loaded " + json.Embeds[0].Author.Name, json.Embeds[0].Author.IconURL);
                LogoSelection.LS.Logos.Images.Add("Loaded " + json.Embeds[0].Author.Name, Image.FromFile($"Cache/Logos Photos/{"Loaded " + json.Embeds[0].Author.Name}.png"));
                LogoSelection.LS.Logos.Images.SetKeyName(LogoSelection.LS.Logos.Images.Count - 1, $"{"Loaded " + json.Embeds[0].Author.Name}.png");
                LogoSelection.LS.LogosList.LargeImageList = LogoSelection.LS.Logos;
                ListViewItem lvi = new();
                lvi.Text = "Loaded " + json.Embeds[0].Author.Name;
                lvi.ImageKey = "Loaded " + json.Embeds[0].Author.Name + ".png";
                LogoSelection.LS.LogosList.Items.Add(lvi);
                MainWindow.Logos.Add("Loaded " + json.Embeds[0].Author.Name, json.Embeds[0].Author.IconURL);
            }
            LogoURL = json.Embeds[0].Author.IconURL;
            using (Image img = Image.FromFile($"Cache/Logos Photos/{Logos.Where(pair => pair.Value == json.Embeds[0].Author.IconURL).Select(pair => pair.Key).FirstOrDefault()}.png"))
            {
                AuthorIcon.Image = new Bitmap(img);
                img.Dispose();
            }
            FleetInfo fi = FormDescription(json.Embeds[0].Description);
            FCID = json.Embeds[0].Footer.IconURL.Split("/", StringSplitOptions.RemoveEmptyEntries)[3];
            if (!FCS.ContainsKey(fi.FC))
            {
                await AddRemove.DownloadImageAsync(json.Embeds[0].Footer.IconURL, AddRemove.SavePath.FC, fi.FC, FCID);
                MW.FCName.Items.Add(fi.FC);
                FCS.Add(fi.FC, FCID);
            }
            FCName.SelectedItem = fi.FC.ToString();
            Content = json.Content;
            Title.Text = json.Embeds[0].Title;
            Border.BackColor = Color.FromArgb(json.Embeds[0].Color);
            ColorPicker.BackColor = Color.FromArgb(json.Embeds[0].Color);
            Author.Text = json.Embeds[0].Author.Name;
            if (fi != null)
            {
                Description.Text = fi.Description;
                FleetNameBox.Text = fi.FleetName;
                LocationBox.Text = fi.FormupLocation;
                Date.Value = fi.FormupTime;
                Time.Value = fi.FormupTime;
                DoctrineBox.Text = fi.Doctrine;
            }
            FooterText.Text = json.Embeds[0].Footer.Text;
            ShipID = json.Embeds[0].Thumbnail.URL.Replace("https://images.evetech.net/types/", "").Replace("/render?size=128", "");
            Thumbnail.Image = Image.FromFile($"Cache/Ships Photos/{ShipID}.png");
        }
    }
    private FleetInfo FormDescription(string description)
    {
        FleetInfo fi = new();
        List<string> properties = new(description.Split(new string[] { "\n", ": " }, StringSplitOptions.RemoveEmptyEntries));
        for (int i = properties.Count - 1; i >= 0; i--)
            if (i % 2 != 0)
                properties.RemoveAt(i);
        fi.Description = properties[0];
        fi.FC = properties[1];
        fi.FleetName = properties[2];
        fi.FormupLocation = properties[3];
        fi.FormupTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Convert.ToInt64(properties[4].Split(":")[1]));
        fi.Doctrine = properties[5];
        return fi;
    }
}