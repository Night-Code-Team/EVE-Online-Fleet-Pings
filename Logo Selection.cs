namespace EVE_Online_Fleet_Pings;
    public partial class LogoSelection : Form
    {
        public LogoSelection()
        {
            InitializeComponent();
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

        }
    }