namespace EVE_Online_Fleet_Pings;
public partial class LogoSelection : Form
{
    public LogoSelection()
    {
        InitializeComponent();
        LS = this;
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void AddNewLogo_Click(object sender, EventArgs e)
    {
        new AddLogo().ShowDialog();
    }

    private void Submit_Click(object sender, EventArgs e)
    {
        try
        {
            using (Image img = Logos.Images[$"{LogosList.SelectedItems[0].Text}.png"])
            {
                MainWindow.MW.Logo.Image = new Bitmap(img);
                img.Dispose();
            }
            MainWindow.LogoURL = MainWindow.Logos[LogosList.SelectedItems[0].Text];
        }
        catch { }
        Close();
    }
    private void LogoSelection_Load(object sender, EventArgs e)
    {
        string[] list = File.ReadAllLines("Cache/Logo List.csv");
        for (int i = 0; i < list.Length; i++)
        {
            string logo = list[i];
            Logos.Images.Add(Image.FromFile($"Cache/Logo Photos/{logo.Remove(logo.IndexOf(","))}.png"));
            Logos.Images.SetKeyName(i, $"{logo.Remove(logo.IndexOf(","))}.png");
        }
        LogosList.LargeImageList = Logos;
        foreach (string logo in list)
        {
            ListViewItem lvi = new();
            lvi.Text = logo.Remove(logo.IndexOf(","));
            lvi.ImageKey = logo.Remove(logo.IndexOf(",")) + ".png";
            LogosList.Items.Add(lvi);
        }
    }
}