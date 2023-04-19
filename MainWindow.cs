using System.Reflection.Emit;
namespace EVE_Online_Fleet_Pings;
public partial class MainWindow : Form
{
    public static HttpClient Client { get; set; } = new HttpClient();
    public static Dictionary<string, string> FCS { get; set; } = new();
    public static Dictionary<string, string> Ships { get; set; } = new();
    public static Dictionary<string, string> Logos { get; set; } = new();
    public static string FCID { get; set; } = "";
    public static string ShipID { get; set; } = "";
    public static string LogoURL { get; set; } = "";
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
        string[] list = File.ReadAllLines("Cache/Ships List.csv");
        foreach (string ship in list)
        {
            MainWindow.Ships.Add(ship.Remove(0, ship.IndexOf(",") + 1), ship.Remove(ship.IndexOf(",")));
        }
        list = File.ReadAllLines("Cache/Logo List.csv");
        foreach (string logo in list)
        {
            MainWindow.Logos.Add(logo.Remove(logo.IndexOf(",")), logo.Remove(0, logo.IndexOf(",")) + 1);
        }
    }

    private void FCName_SelectedIndexChanged(object sender, EventArgs e)
    {
        FCIcon.Image = new Bitmap($"Cache/FC Photos/{FCName.SelectedItem}.png");
        Footer.Text = "Fleet by " + FCName.SelectedItem.ToString();
        FCID = FCS[$"{FCName.SelectedItem.ToString()}"];
    }
}