namespace EVE_Online_Fleet_Pings;
public partial class ThumbnailSelection : Form
{
    public ThumbnailSelection()
    {
        InitializeComponent();
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            MainWindow.MW.Thumbnail.Image = Image.FromFile($"Cache/Ships Photos/{MainWindow.Ships[ThumbnailsList.SelectedItems[0].Text]}.png");
            MainWindow.ShipID = MainWindow.Ships[ThumbnailsList.SelectedItems[0].Text];
        }
        catch { }
        Close();
    }

    private void ThumbnailSelection_Load(object sender, EventArgs e)
    {
        string[] list = File.ReadAllLines("Cache/Ships List.csv");
        ThumbnailsList.LargeImageList = Thumbnails;
        foreach (string ship in list)
        {
            ListViewItem lvi = new();
            lvi.Text = ship.Remove(0, ship.IndexOf(",") + 1);
            lvi.ImageKey = ship.Remove(ship.IndexOf(",")) + ".png";
            ThumbnailsList.Items.Add(lvi);
        }
    }
}